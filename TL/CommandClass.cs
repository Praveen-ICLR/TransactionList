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
            DbCommand ICcmd = ICprovider.CreateCommand();
            ICcmd.CommandText = "translist";
            ICcmd.CommandType = CommandType.StoredProcedure;
            ICcmd.CommandTimeout = AcctLoadCommandTimeout;

            return ICcmd;
        }
        
        
       

    }
}
