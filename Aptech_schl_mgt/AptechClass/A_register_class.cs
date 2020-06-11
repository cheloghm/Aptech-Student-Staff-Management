using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aptech_schl_mgt.AptechClass
{
    class A_register_class
    {

        #region getterNsetter_properties

        #region Register

        public int ContactId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Course { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Laptop { get; set; }
        public string Gender { get; set; }

        static string myconnstring = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

        #endregion

        #region sign_in

        public int RegNum { get; set; }
        public string Class2 { get; set; }
        public string Faculty { get; set; }
        public DateTime Time { get; set; }

        static string myconnstring2 = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

        #endregion

        #region Sign_out

        public int RegNum2 { get; set; }
        public DateTime Time2 { get; set; }

        static string myconnstring3 = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

        #endregion

        #endregion

        #region selectingDataFromDataBase

        #region Help

        public DataTable select()
        {
            // DataBaseConnection

            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                // sql query
                string sql = "SELECT * FROM student_db";

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adpter = new SqlDataAdapter(cmd);

                conn.Open();
                adpter.Fill(dt);

            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                Console.WriteLine(msg);
            }
            finally
            {
                conn.Close();
            }
            return dt;

        }

        #endregion

        #region After(Registering)

        public DataTable select2()
        {
            // DataBaseConnection

            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                // sql query
                string sql = "SELECT MAX(ID) AS [REG-NUMBER] FROM Register";

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adpter = new SqlDataAdapter(cmd);

                conn.Open();
                adpter.Fill(dt);

            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                Console.WriteLine(msg);
            }
            finally
            {
                conn.Close();
            }
            return dt;

        }

        #endregion

        #region After(Signing In)
        public DataTable select3()
        {
            // DataBaseConnection

            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                // sql query
                string sql = "SELECT MAX(ID_Today) AS [Your Roll No for Today] FROM Sign_In";

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adpter = new SqlDataAdapter(cmd);

                conn.Open();
                adpter.Fill(dt);

            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                Console.WriteLine(msg);
            }
            finally
            {
                conn.Close();
            }
            return dt;

        }
        #endregion

        #endregion

        #region InsertingIntoDataBase

        #region Register

        #region students

        public bool Insert(A_register_class c)
        {
            //Default return type
            bool isSuccess = false;

            //connect DataBase
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //sql Query
                string sql = "INSERT INTO student_db (First_Name, Last_Name, Email, Course, Phone_Number, Address, Gender) VALUES (@FirstName, @LastName, @Email, @Course, @Phone, @Address, @Gender)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@Email", c.Email);
                cmd.Parameters.AddWithValue("@Course", c.Course);
                cmd.Parameters.AddWithValue("@Phone", c.Phone);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
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
                string msg = ex.Message;
                Console.WriteLine(msg);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        #endregion

        #region staffs

        public bool Insert2(A_register_class c)
        {
            //Default return type
            bool isSuccess = false;

            //connect DataBase
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //sql Query
                string sql = "INSERT INTO staff_db (First_Name, Last_Name, Email, Course, Phone_Number, Address, Gender) VALUES (@FirstName, @LastName, @Email, @Course, @Phone, @Address, @Gender)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@Email", c.Email);
                cmd.Parameters.AddWithValue("@Course", c.Course);
                cmd.Parameters.AddWithValue("@Phone", c.Phone);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
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
                string msg = ex.Message;
                Console.WriteLine(msg);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        #endregion

        #endregion

        #region Sign_in

        public bool Insert3(A_register_class c)
        {
            //Default return type
            bool isSuccess = false;

            //connect DataBase
            SqlConnection conn = new SqlConnection(myconnstring2);
            try
            {
                //sql Query
                string sql = "INSERT INTO attendance_db (Reg_No, Class, Faculty) VALUES (@RegNum, @Class2, @Faculty)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@RegNum", c.RegNum);
                cmd.Parameters.AddWithValue("@Class2", c.Class2);
                cmd.Parameters.AddWithValue("@Faculty", c.Faculty);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
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
                string msg = ex.Message;
                Console.WriteLine(msg);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        #endregion

        #region Sign_out

        public bool Insert4(A_register_class c)
        {
            //Default return type
            bool isSuccess = false;

            //connect DataBase
            SqlConnection conn = new SqlConnection(myconnstring3);
            try
            {
                //sql Query
                string sql = "INSERT INTO Sign_Out (ID) VALUES (@RegNum2)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@RegNum2", c.RegNum2);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
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
                string msg = ex.Message;
                Console.WriteLine(msg);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        #endregion

        #endregion

        #region upDateDataBase

        public bool update(A_register_class c)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "UPDATE Register SET First_Name = @FirstName, Last_Name = @LastName, Email = @Email, Course = @Course, Phone_Number = @Phone, Address = @Address, Gender = @Gender WHERE ID = @ContactId";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@Email", c.Email);
                cmd.Parameters.AddWithValue("@Course", c.Course);
                cmd.Parameters.AddWithValue("@Phone", c.Phone);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);
                cmd.Parameters.AddWithValue("@ContactId", c.ContactId);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

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
                string msg = ex.Message;
                Console.WriteLine(msg);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        #endregion

        #region DeletingFromDataBase

        public bool delete(A_register_class c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string sql = "DELETE FROM Register WHERE ID = @ContactId";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ContactId", c.ContactId);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

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
                string msg = ex.Message;
                Console.WriteLine(msg);
            }
            finally
            {

            }
            return isSuccess;
        }

        #endregion

    }
}
