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
                Console.WriteLine(dt);
            }
            else
            {
                Console.WriteLine("Failed Process..");
            }

        }
    }
}
