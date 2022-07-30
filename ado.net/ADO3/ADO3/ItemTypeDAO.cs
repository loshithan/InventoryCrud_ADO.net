using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO3
{
    class ItemTypeDAO
    {
        public List<ItemType> GetAllItemType()
        {
            List<ItemType> list = new List<ItemType>();
            //Fill your code here
            SqlConnection sql = DBConnection.GetConnection();
            sql.Open();
            SqlCommand cmd = new SqlCommand("select * from item_type", sql);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int id = Convert.ToInt32(dr["ID"]);
                string name = Convert.ToString(dr["Name"]);
                double deposit = Convert.ToDouble(dr["deposit"]);
                double costPerDay = Convert.ToDouble(dr["costPerDay"]);

                ItemType item = new ItemType(id, name, deposit, costPerDay);
                list.Add(item);
            }
            sql.Close();
            return list;
        }

        public bool DeleteItemType(string name)
        {
            SqlConnection sql = DBConnection.GetConnection();
            sql.Open();
            SqlCommand cmd = new SqlCommand("delete from item_type where name = '" + name + "'", sql);
            int output = cmd.ExecuteNonQuery();
            sql.Close();
            if(output > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            //Fill your code here

        }

        public ItemType GetItemTypeByName(string name)
        {
            ItemType itemType = null;
            SqlConnection sql = DBConnection.GetConnection();
            sql.Open();
            SqlCommand cmd = new SqlCommand("select * from item_type where name = '"+name+"'", sql);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr["Name"] == name)
                {
                    int id = Convert.ToInt32(dr["ID"]);
                    string username = Convert.ToString(dr["Name"]);
                    double deposit = Convert.ToDouble(dr["deposit"]);
                    double costPerDay = Convert.ToDouble(dr["costPerDay"]);

                    
                }


            }
            itemType = new ItemType(id, username, deposit, costPerDay);
            sql.Close();

            //Fill your code here

            return itemType;
        }
    }

}
