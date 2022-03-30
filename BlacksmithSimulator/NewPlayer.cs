using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace BlacksmithSimulator
{
    public class NewPlayer
    {
        public static string Create(string name)
        {
            Connection c = new Connection();
            c.Connect();
            DataTable temp = new DataTable();
            string select = $"SELECT NAME FROM Player WHERE NAME='{name}';";
            SQLiteDataAdapter data0 = new SQLiteDataAdapter(select, c.conn);
            data0.Fill(temp);
            
            if (temp.Rows.Count > 0)
                return "name";

            string command = $"INSERT INTO Player (NAME) VALUES ('{name}')";
            SQLiteCommand cmd = new SQLiteCommand(command, c.conn);
            cmd.ExecuteNonQuery();
            command = "SELECT last_insert_rowid()";
            cmd.CommandText = command;
            int ID = Convert.ToInt32(cmd.ExecuteScalar());

            string query = "select ID,NAME from Items;";
            temp.Clear();
            SQLiteDataAdapter data = new SQLiteDataAdapter(query, c.conn);
            data.Fill(temp);

            query = "INSERT INTO Inventory (PLAYER_ID,ITEM_ID,ITEM) VALUES ";
            foreach (DataRow row in temp.Rows)
            {
                query += $"({ID}, {row[0]}, '{row[1]}'),";
            }
            query = query.Substring(0, query.Length - 1);
            query += ';';
            
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            temp.Clear();
            query = "select ID from Quest;";
            data.SelectCommand.CommandText = query;
            data.Fill(temp);

            query = "INSERT INTO QuestLog (PLAYER_ID,QUEST_ID) VALUES ";
            foreach (DataRow row in temp.Rows)
                query += $"{ID}, {row[0]}";
            query = query.Substring(0, query.Length - 1);
            query += ';';
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            c.Disconnect();
            return "success";
        }
    }
}