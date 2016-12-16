using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace SQLiteApp
{
    public class DatabaseActivity
    {
        public void CreateDB(string baseName)
        {
            SQLiteConnection.CreateFile(baseName);
        }

        public SQLiteConnection CreateDBConnection(string baseName)
        {
            return new SQLiteConnection(String.Format("Data Source={0}", baseName));
        }

        public void CreateTable(string baseName, string tableName)
        {
            var connection = CreateDBConnection(baseName);
            connection.Open();
            using (SQLiteCommand command = new SQLiteCommand(connection))
            {
                command.CommandText = (String.Format(@"CREATE TABLE [{0}] (
                    [id] integer PRIMARY KEY AUTOINCREMENT NOT NULL,
                    [name] char(100) NOT NULL,
                    [time] datetime NOT NULL,
                    [filename] char(100) NOT NULL
                    );", tableName));
                command.ExecuteNonQuery();
            }
            connection.Close();
        }

        public void AddDataToTable(string baseName, string tableName)
        {
            string sql = (String.Format("INSERT INTO [{0}] (name, time, filename) VALUES (@name, @time, @filename)", tableName));

            var connection = CreateDBConnection(baseName);
            connection.Open();
            using (SQLiteCommand command = new SQLiteCommand(connection))
            {
                DateTime dateTimeVariable = DateTime.Now;
                command.CommandText = sql;
                command.Parameters.AddWithValue("@name", "just some name");
                command.Parameters.AddWithValue("@time", dateTimeVariable);
                command.Parameters.AddWithValue("@filename", "just some filename");
                command.ExecuteNonQuery();
            }
            connection.Close();
        }

        public void DeleteDataFromTable(string baseName, string tableName, int rowId)
        {
            string sql = (String.Format("DELETE FROM [{0}] WHERE id = @row", tableName));
            var connection = CreateDBConnection(baseName);
            connection.Open();
            using (SQLiteCommand command = new SQLiteCommand(sql, connection))
            {
                try
                {
                    command.Parameters.AddWithValue("@row", rowId);
                    command.ExecuteNonQuery();
                }
                catch (SQLiteException ex)
                {
                    Exception error = new Exception("ERROR: ", ex);
                    throw error;
                }
            }
            connection.Close();
        }

        public void UpdateDataInTable(string baseName, string tableName, int rowId, string newname)
        {
            string sql = (String.Format("UPDATE [{0}] SET name = @name WHERE id = @row", tableName));
            var connection = CreateDBConnection(baseName);
            connection.Open();
            using (SQLiteCommand command = new SQLiteCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@name", newname);
                command.Parameters.AddWithValue("@row", rowId+1);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }

        public DataTable SelectAllFromTable(string baseName, string tableName)
        {
            var connection = CreateDBConnection(baseName);
            connection.Open();

            DataTable dt = new DataTable();
            string sql = (String.Format("SELECT * FROM [{0}]", tableName));
            using (SQLiteCommand command = new SQLiteCommand(sql, connection))
            {

                SQLiteDataReader dr = command.ExecuteReader();
                dt.Load(dr);
                dr.Close();
            }
            connection.Close();
            return dt;
        }

        public void DropTable(string baseName, string tableName)
        {
            var connection = CreateDBConnection(baseName);
            connection.Open();
            using (SQLiteCommand command = new SQLiteCommand(connection))
            {
                command.CommandText = (String.Format("DROP TABLE IF EXISTS [{0}]", tableName));
                command.ExecuteNonQuery();
            }
            connection.Close();
        }

        //        public List<string> GetColumnNames(string baseName, string tableName) //looks like works only in SQL
        //        {
        //            List<string> columns = new List<string>();
        //            var connection = CreateDBConnection(baseName);
        //            connection.Open();
        //            using (SQLiteCommand command = new SQLiteCommand(connection))
        //            {
        //                command.CommandText = (String.Format(@"SELECT COLUMN_NAME 
        //                                 FROM INFORMATION_SCHEMA.COLUMNS 
        //                                 WHERE TABLE_NAME = {0}", tableName));
        //                //command.Parameters.AddWithValue("@{0}", tableName);
        //                using (SQLiteDataReader reader = command.ExecuteReader())
        //                {
        //                    columns.Add(reader["COLUMN_NAME"].ToString());
        //                }
        //            }
        //            return columns;
        //        }
        public void GetColumnNames(string baseName, string tableName)
        {
            var connection = CreateDBConnection(baseName);
            connection.Open();
            string sql = (String.Format("select * from {0}", tableName));
            using (var cmd = new SQLiteCommand(sql, connection))
            {
                var dr = cmd.ExecuteReader();
                for (var i = 0; i < dr.FieldCount; i++)
                {
                    Console.WriteLine(dr.GetName(i));
                }
            }
            connection.Close();
        }

        public void KillAllConnections(string baseName, string tableName) //wasn't tested :)
        {
            var connection = CreateDBConnection(baseName);
            connection.Open();
            using (var comExecuteInsert = new SQLiteCommand(connection))
            {
                //comExecuteInsert.Connection = connection;
                ////comExecuteInsert.CommandType = CommandType.StoredProcedure;
                ////comExecuteInsert.CommandText = strProcedureName;
                //comExecuteInsert.ExecuteScalar();
                //comExecuteInsert.Parameters.Clear();
                connection.Close();
            }

            SQLiteConnection.ClearAllPools();
        }
    }
}
