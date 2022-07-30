using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ADO3
{
    class DBConnection
    {
        public static SqlConnection GetConnection()
        {
            String xmlString = System.IO.File.ReadAllText("mssql.xml");

            string username;
            string password;
            string schema;
            string host;

            using (XmlReader reader = XmlReader.Create(new StringReader(xmlString)))
            {
                reader.ReadToFollowing("username");
                username = reader.ReadElementContentAsString();
                reader.ReadToFollowing("password");
                password = reader.ReadElementContentAsString();
                reader.ReadToFollowing("host");
                host = reader.ReadElementContentAsString();
                reader.ReadToFollowing("schema");
                schema = reader.ReadElementContentAsString();
            }

            //Fill your code here
            SqlConnection conn = new SqlConnection(@"Data Source=" + host + ";database=" + schema + ";Password = " + password + ";User ID=" + username + "");
            return conn;
        }
    }
}
