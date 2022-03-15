using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;

namespace personnalisation_chequiers
{
    class D
    {
        public static DbProviderFactory pf = DbProviderFactories.GetFactory(Properties.Settings.Default.MF);
        public static DbConnection cn;
    }
}
