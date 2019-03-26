using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsAdmin
{
    public static class TravelExpertsDB
    {
        
       public static  SqlConnection  GetConnection()

        {
            string dataBasePath = @"Data Source=localhost\sqlexpress;Initial Catalog=TravelExperts;Integrated Security=True";
            return new SqlConnection (dataBasePath);
        }
    }
}
