using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using JuiceShopEntities;
using JuiceShopDAL;

namespace JuiceShopBusinessManager
{
    public class JuiceShopBusinessMangr
    {
        public void AddJuicePurchase(int Juice_id, int Quantity)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=IN-5CG0253GXL\SQLEXPRESS;Initial Catalog=JUICEDB;Integrated Security=True";

            SqlCommand cmd = new SqlCommand("insert into Juice_Parchased(Juice_id,Quantity) values(@jid,@qty)", con);
            cmd.CommandType = CommandType.Text;


            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@jid", Juice_id);
            cmd.Parameters.AddWithValue("@qty", Quantity);

            SqlCommand cmd1 = new SqlCommand("update Juice_Parchased set Juice_Parchased.Amount = j.Price *jp.Quantity from Juice_Parchased jp inner join Juice j on jp.Juice_id = j.Juice_id", con);
            cmd1.CommandType = CommandType.Text;
            cmd1.Parameters.Clear();

            con.Open();
            //SqlDataReader sdr = cmd1.ExecuteReader();
            //while(sdr.Read())
            //{
            //    JuiceParchased jp = new JuiceParchased
            //    {
            //        Purchase_no = (int)sdr[0],
            //        Juice_id = (int)sdr[1],
            //        Quantity = (int)sdr[2],
            //        Amount = (int)sdr[3]
            //    };
                
            //}
            cmd.ExecuteNonQuery();
            cmd1.ExecuteNonQuery();
            con.Close();
        }
        public List<JuiceParchased> GetAllJuicePurchased()
        {
            List<JuiceParchased> lstjs = new List<JuiceParchased>();

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=IN-5CG0253GXL\SQLEXPRESS;Initial Catalog=JUICEDB;Integrated Security=True";

            SqlCommand cmd = new SqlCommand("select * from  Juice_Parchased",con);
            cmd.CommandType = CommandType.Text;

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                JuiceParchased jsp = new JuiceParchased
                {
                    Purchase_no = (int)sdr[0],
                    Juice_id = (int)sdr[1],
                    Quantity = (int)sdr[2],
                    Amount = (int)sdr[3]
                };
                lstjs.Add(jsp);
            }
            sdr.Close();
            con.Close();
            return lstjs;
        }
    }
}

//SqlCommand cmd1 = new SqlCommand("update Juice_Parchased set Juice_Parchased.Amount = j.Price *jp.Quantity from Juice_Parchased jp inner join Juice j on jp.Juice_id = j.Juice_id", con);