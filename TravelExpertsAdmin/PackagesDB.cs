using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsAdmin
{
    public static class PackagesDB
    {
        public static List<Packages> GetPackages()

         {
            List<Packages> _packages = new List<Packages>();
            Packages pkg;

           
                SqlConnection conn = TravelExpertsDB.GetConnection();
                conn.Open();
                string statement = "SELECT * FROM packages ";
                SqlCommand comm = new SqlCommand(statement, conn);
            try
            {
                SqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())// read next row of data
                {
                    pkg = new Packages();
                    pkg.PkgName = dr["PkgName"].ToString();
                    pkg.PkgDescription = dr["PkgDesc"].ToString();
                    _packages.Add(pkg);
                }
                dr.Close();
                // concurrency error catch
            }
            catch(Exception ex)
                {
                throw ex;
            }
            conn.Close();

            return _packages;

            


        }
        
    }
}
