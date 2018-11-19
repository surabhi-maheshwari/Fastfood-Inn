using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodDemo.classes
{
    class FastFoodClass
    {
        public int ID { get; set; }
        public string PhoneNo { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

       public DataTable Select()
        {
            //Step 1 Database Connection 
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                //Step 2 writing SQL query
                String sql = "SELECT * FROM fastFood";
                //Creating cmd using sql and conn 
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creating SQL DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                cmd.Connection = conn;

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        //Inserting data into database
        public bool Insert(FastFoodClass f)
        {
            //Creating default return type and setting its value to false
            bool isSuccess = false;

            //Step 1 Connect database 
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Step 2 Creating SQL query to insert data
                string sql = "INSERT INTO fastFood(Name, Address, PhoneNo) VALUES (@Name, @Address, @PhoneNo)";

                //Creating sql command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create parameter to add data
                cmd.Parameters.AddWithValue("@Name", f.Name);
                cmd.Parameters.AddWithValue("@PhoneNo", f.PhoneNo);
                cmd.Parameters.AddWithValue("@Address", f.Address);
                cmd.Connection = conn;

                //Connection open
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //If the query runs then the value of rows will be > 0 else it will be 0
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {

                conn.Close();
            }
            return isSuccess;
        }

    }
}
