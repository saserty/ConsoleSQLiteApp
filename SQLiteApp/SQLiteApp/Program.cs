using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseName = "DatabaseFile.sqlite";
            string tableName = "tblTestTable";
            int rowId = 2;
            string newname = "new name";
            DatabaseActivity da = new DatabaseActivity();
            InternalDataCheck idc = new InternalDataCheck();

            
            //da.CreateDB(baseName); //uncomment to create DB
            da.DropTable(baseName, tableName);
            da.CreateTable(baseName, tableName);
            da.GetColumnNames(baseName, tableName);
            da.AddDataToTable(baseName, tableName);
            da.AddDataToTable(baseName, tableName); //only in testing purposes
            da.DeleteDataFromTable(baseName, tableName, rowId);
            da.AddDataToTable(baseName, tableName); //only in testing purposes
            da.UpdateDataInTable(baseName, tableName, rowId, newname);
            idc.PrintTable(da.SelectAllFromTable(baseName, tableName));

            Console.ReadLine();
        }
    }
}
