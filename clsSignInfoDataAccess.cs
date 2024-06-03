using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpokenGlovesDataAccess1
{
    public static class clsSignInfoDataAccess
    {
        public static DataTable GetAllSigns()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SpokenGloves_DB"].ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("SP_GetAllSigns", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            dt.Load(reader);
                        }

                        reader.Close();


                    }

                    catch (Exception ex)
                    {
                        clsConfigrationSettings._LogErorr(ex);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

            return dt;
        }
        public static bool IsSignExist(string SignText)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SpokenGloves_DB"].ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("SP_CheckSignExist", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@SignText", SignText);
                    SqlParameter returnParameter = new SqlParameter("@ReturnVal", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.ReturnValue
                    };
                    command.Parameters.Add(returnParameter);
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        isFound = (int)returnParameter.Value == 1;
                    }
                    catch (Exception ex)
                    {
                        clsConfigrationSettings._LogErorr(ex);
                        isFound = false;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            return isFound;
        }
        public static bool DeleteSignInfo(int SignInfoID)
        {

            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SpokenGloves_DB"].ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("SP_DeleteSignInfoByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@SignInfoID", SignInfoID);

                    try
                    {
                        connection.Open();

                        rowsAffected = command.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        clsConfigrationSettings._LogErorr(ex);
                    }
                    finally
                    {

                        connection.Close();

                    }
                }
            }
            return (rowsAffected > 0);

        }
        public static int AddNewSignInfo(string Text, string ImagePath)
        {
            int SignID = -1;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SpokenGloves_DB"].ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("SP_AddNewSignInfo", connection))
                {

                    command.CommandType = CommandType.StoredProcedure;
          
                    command.Parameters.AddWithValue("@Text", Text);
                    command.Parameters.AddWithValue("@ImagePath", ImagePath);
                    SqlParameter outputIdParam = new SqlParameter("@NewSignInfoID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(outputIdParam);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();

                        SignID = (int)command.Parameters["@NewSignInfoID"].Value;
                    }

                    catch (Exception ex)
                    {
                        clsConfigrationSettings._LogErorr(ex);

                    }

                    finally
                    {
                        connection.Close();
                    }
                }
            }

            return SignID;

        }
        public static bool UpdateSignInfo(int SignID, string Text, string ImagePath)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SpokenGloves_DB"].ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("SP_UpdateSignInfo", connection))
                {

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@SignID", SignID);
                    command.Parameters.AddWithValue("@Text", Text);
                    command.Parameters.AddWithValue("@ImagePath", ImagePath);


                    try
                    {
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        clsConfigrationSettings._LogErorr(ex);
                        return false;
                    }

                    finally
                    {
                        connection.Close();
                    }
                }
            }
            return (rowsAffected > 0);
        }
        public static bool FindSignInfoByID(int SignInfoID, ref string Text, ref string ImagePath)
        {

            bool IsFound = false;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SpokenGloves_DB"].ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_FindSignInfoByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@SignInfoID", SignInfoID);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            IsFound = true;
                            Text = (string)reader["Text"];       
                            ImagePath = (string)reader["ImagePath"];

                        }
                        else
                        {
                            IsFound = false;
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        clsConfigrationSettings._LogErorr(ex);
                        IsFound = false;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            return IsFound;


        }
    }
}
