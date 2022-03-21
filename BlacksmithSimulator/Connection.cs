using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace BlacksmithSimulator
{
    public class Connection
    {
       
        public SQLiteConnection conn = new SQLiteConnection("Data Source=blacksmith.db");
        public void Connect()
        {
            conn.Open();
        }
        public void Disconnect()
        {
            conn.Close();
        }
    }
}
