using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Poject_QUANLYCUAHANGDONGHO
{
    internal class ConnectDB
    {
        string str;
        public void Dataconect()
         {
            str = @"Data Source = KE-INIZUKO\\SQLEXPRESS; Initial Catalog = QL_CUAHANGDONGHO; Integrated Security = True";
        }
    public SqlConnection getconnect()
    {
        return new SqlConnection(str);
    }
}
}
