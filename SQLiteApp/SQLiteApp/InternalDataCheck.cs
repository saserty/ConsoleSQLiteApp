using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace SQLiteApp
{
    public class InternalDataCheck
    {
        public void PrintTable(DataTable Table)
        {
            foreach (DataRow dataRow in Table.Rows)
            {
                foreach (var item in dataRow.ItemArray)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
