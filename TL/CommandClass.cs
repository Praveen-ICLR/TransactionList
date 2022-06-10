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
    public class CommandClass
    {
        private int AcctLoadCommandTimeout = 12000;
        public DbCommand GetTranslist()
        {
            //icGeneric.GetConfigData();
            DbProviderFactory ICprovider = icGeneric.GetProvider();
           // Console.WriteLine(ICprovider);
          //  var ICconnection = ICprovider.CreateConnection();
            
           // ICconnection.ConnectionString = icGeneric.GetConnString();
          //  Console.WriteLine(ICconnection.ConnectionString);
            DbCommand ICcmd = ICprovider.CreateCommand();
            ICcmd.CommandText = "translist";
            ICcmd.CommandType = CommandType.StoredProcedure;
            ICcmd.CommandTimeout = AcctLoadCommandTimeout;
          //  ICconnection.Open();
            //ICcmd.ExecuteNonQuery();
            //ICconnection.Close();

          //  Console.WriteLine(ICcmd);

            return ICcmd;
        }
        
        
       

    }
}
