using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examadoNew2
{
    class DoctorDAO
    {
        public bool InsertDoctor(Doctor doctor)
        {
            //Fill your code here
            SqlConnection sql = DBConnection.GetConnection();
            sql.Open();
            SqlCommand cmd = new SqlCommand("insert into doctor(name,qualification,experience,fees) values('"+doctor.Name+ "','" + doctor.Qualification + "','" + doctor.Experience + "','" + doctor.Fees + "') ", sql);
            int result = cmd.ExecuteNonQuery();
            sql.Close();
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateDoctor(int doctorId, double fees)
        {
            SqlConnection sql = DBConnection.GetConnection();
            sql.Open();
            SqlCommand cmd = new SqlCommand("update doctor set fees='"+fees+"' where id='"+doctorId+"'", sql);
            int result = cmd.ExecuteNonQuery();
            sql.Close();
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteDoctor(int doctorId)
        {
            SqlConnection sql = DBConnection.GetConnection();
            sql.Open();
            SqlCommand cmd = new SqlCommand("delete from doctor where id='"+doctorId+"' ", sql);
            int result = cmd.ExecuteNonQuery();
            sql.Close();
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Doctor> GetAllDoctor()
        {
            List<Doctor> list = new List<Doctor>();
            //Fill your code here
            SqlConnection sql = DBConnection.GetConnection();
            sql.Open();
            SqlCommand cmd = new SqlCommand("select * from doctor", sql);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int id = Convert.ToInt32(dr["id"]);
                string name = dr["Name"].ToString();
                string qualification = dr["qualification"].ToString();
                int experience = Convert.ToInt32(dr["experience"]);
                double fees = Convert.ToDouble(dr["fees"]);

                list.Add(new Doctor(id,name, qualification, experience, fees));
            }


            return list;
        }
    }

}
