using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using JuiceShopEntities;
namespace JuiceShopDAL
{
    public class JuiceShopDal
    {
        public List<Juice> GetAlljuice()
        {
            List<Juice> lstjs = new List<Juice>();

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=IN-5CG0253GXL\SQLEXPRESS;Initial Catalog=JUICEDB;Integrated Security=True";

            SqlCommand cmd = new SqlCommand("select * from Juice order by Price,Juice_flavour", con);
            cmd.CommandType = CommandType.Text;

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                Juice jsp = new Juice
                {
                    Juice_id = (int)sdr[0],
                    Juice_flavour = sdr[1].ToString(),
                    Price = (int)sdr[2]
                };
                lstjs.Add(jsp);
            }
            sdr.Close();
            con.Close();
            return lstjs;
        }


    }
}
