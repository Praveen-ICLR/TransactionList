using inteliclear;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;

namespace TL
{
    internal class Program
    {
     /*   public void PrintRows(DataSet dataSet)
     {
    // For each table in the DataSet, print the values of each row.
    foreach(DataTable thisTable in dataSet.Tables)
    {
        // For each row, print the values of each column.
        foreach(DataRow row in thisTable.Rows)
        {
            foreach(DataColumn column in thisTable.Columns)
            {
                Console.WriteLine(row[column]);
            }
        }
    }
} */

        static void Main(string[] args)
        {
            icGeneric.GetConfigData();

            DataTable dt = new DataTable();
            DbCommand ICcmd;
            CommandClass objCC = new CommandClass();
            DataAccess objDA = new DataAccess();
            ICcmd = objCC.GetTranslist();
            dt = objDA.GetData(ICcmd);

            if(dt.Rows.Count > 0)
            {   
                Console.WriteLine("Coming In");
               // Console.WriteLine(dt);
                icGeneric.WriteToCSV(dt,"r"," ");
                Console.WriteLine("SuccessFul");
            
              //  icGeneric.GetColumnNames(dt,",");
              //  icGeneric.WriteDataTableintoFile("r.txt",",",dt);
              
               // Console.WriteLine(dt.Rows);

            //    foreach(DataRow row in dt.Rows)
            //    {
           //         foreach(DataColumn column in dt.Columns)
           //         {
           //             Console.WriteLine("Sucess");
           //             Console.WriteLine(row[column]);
           //         }
             //   }

            }
            else
            {
                Console.WriteLine("Failed Process..");
            }

        }
    }
}
