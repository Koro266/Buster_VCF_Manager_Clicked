//___________________________________________________________________________________________________________________________________________________
using System;
using System.IO;
using Microsoft.Data.Sqlite;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.GLOBAL.TOOLS
{
	//___________________________________________________________________________________________________________________________________________________
	public class ExtractTextMessages
	{
		private string target_Recipient		= "%+64272359777%";
		private string recipient_Parm		= "@recipient";
		private string connection_String	= @"Data Source=C:\Users\Brusster\ContactsManager\Database\chat.db";
		private string message_Date			= @"MessageDate";
		private string unknown_Date			= @"Unknown Date";
		private string sender				= @"Sender";
		private string unknown				= @"Unknown";
		private string group_ChatName		= @"ChatGroupName";
		private string direct_Message		= @"Direct Message";
		private string message_Text			= @"MessageText";
		private string is_Text				= @"txt?";
		private string service_Type			= @"ServiceType";
		private string sms_Message			= @"SMS/iMessage";
		private string new_Line				= @"\n";

		//___________________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Extracts txt messages from 'MAC' ... .chat.db.
		/// </summary>
		public ExtractTextMessages()
		{
		}
		//___________________________________________________________________________________________________________________________________________________
		public string  ExtractMessages()
		{
			string query = GetExtractionSql;

			using ( var connection = new SqliteConnection( GetConnectionString ) )
			{
				connection.Open();

				using ( var command = new SqliteCommand( query, connection ) )
				{
					command.Parameters.AddWithValue( GetRecipientParm, GetTargetRecipient );

					using ( var reader = command.ExecuteReader() )
					{
						int messageCount = 0;

						string s = "";

						while ( reader.Read() )
						{
							messageCount++;

							string date			= reader[message_Date]?.	ToString() ?? unknown_Date;
							string dispatcher	= reader[sender]?.			ToString() ?? unknown;
							string chatName		= reader[group_ChatName]?.	ToString() ?? direct_Message;
							string text			= reader[message_Text]?.	ToString() ?? is_Text;
							string service		= reader[service_Type]?.	ToString() ?? sms_Message;

							s += $"{date} | {text}" + new_Line;
 						}

						return s;
					}
				}
			}
		}
		//___________________________________________________________________________________________________________________________________________________
		private string GetConnectionString
		{
			get { return connection_String; }
		}
		//___________________________________________________________________________________________________________________________________________________
		private string GetTargetRecipient
		{
			get { return target_Recipient; }
		}
		//___________________________________________________________________________________________________________________________________________________
		private string GetRecipientParm
		{
			get { return recipient_Parm; }
		}
		//___________________________________________________________________________________________________________________________________________________
		private string GetExtractionSql
		{
			get
			{
				string query =
				@"SELECT
					datetime((m.date / 1000000000) + 978307200, 'unixepoch', 'localtime') AS MessageDate,
					CASE 
						WHEN m.is_from_me = 1 THEN 'Me'
						WHEN h.id IS NOT NULL THEN h.id
						ELSE 'Unknown Sender'
					END AS Sender,
					CASE 
						WHEN c.display_name IS NOT NULL AND c.display_name != '' THEN c.display_name
						WHEN c.chat_identifier LIKE 'chat%' THEN 'Group Chat (' || c.chat_identifier || ')'
						ELSE 'Direct Message'
					END AS ChatGroupName,
					m.text AS MessageText,
					m.service AS ServiceType
				FROM message m
				LEFT JOIN handle h ON m.handle_id = h.ROWID
				LEFT JOIN chat_message_join cmj ON m.ROWID = cmj.message_id
				LEFT JOIN chat c ON cmj.chat_id = c.ROWID
				WHERE m.text
					IS NOT NULL
					AND (
							c.chat_identifier LIKE @recipient
								OR
									c.ROWID IN (
										SELECT chj.chat_id
										FROM chat_handle_join chj
										JOIN handle h2 ON chj.handle_id = h2.ROWID
										WHERE h2.id LIKE @recipient
								)
					)
				ORDER BY m.date DESC;";

				return query;
			}
		}
	}
}
