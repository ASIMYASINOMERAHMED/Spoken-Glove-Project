using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using static System.Net.Mime.MediaTypeNames;

namespace SpokenGlovesDataAccess1
{
    public static class clsSignDataAccsess
    {
      
        public static bool DeleteSign(int SignID)
        {

            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SpokenGloves_DB"].ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("SP_DeleteSignByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@SignID", SignID);

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
        public static bool DeleteAllSignData(int SignInfoID)
        {

            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SpokenGloves_DB"].ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("SP_DeleteAllSignDataBySignInfoID", connection))
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

        public static int AddNewSign(string Flex1Read, string Flex2Read,
      string Flex3Read, string Flex4Read, string Flex5Read,int Angle,int SignInfoID)
        {
            int SignID = -1;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SpokenGloves_DB"].ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("SP_AddNewSign", connection))
                {

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Flex1Read", Flex1Read);
                    command.Parameters.AddWithValue("@Flex2Read", Flex2Read);
                    command.Parameters.AddWithValue("@Flex3Read", Flex3Read);
                    command.Parameters.AddWithValue("@Flex4Read", Flex4Read);
                    command.Parameters.AddWithValue("@Flex5Read", Flex5Read);
                    command.Parameters.AddWithValue("@Angle", Angle);
                    command.Parameters.AddWithValue("@SignInfoID", SignInfoID);
                    SqlParameter outputIdParam = new SqlParameter("@NewSignID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(outputIdParam);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();

                        SignID = (int)command.Parameters["@NewSignID"].Value;
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
        public static bool UpdateSign(int SignID,string Flex1Read, string Flex2Read,
      string Flex3Read, string Flex4Read, string Flex5Read, int Angle,int SignInfoID)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SpokenGloves_DB"].ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("SP_UpdateSign", connection))
                {

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@SignID", SignID);
                    command.Parameters.AddWithValue("@Flex1Read", Flex1Read);
                    command.Parameters.AddWithValue("@Flex2Read", Flex2Read);
                    command.Parameters.AddWithValue("@Flex3Read", Flex3Read);
                    command.Parameters.AddWithValue("@Flex4Read", Flex4Read);
                    command.Parameters.AddWithValue("@Flex5Read", Flex5Read);
                    command.Parameters.AddWithValue("@Angle", Angle);
                    command.Parameters.AddWithValue("@SignInfoID", SignInfoID);


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
        public static bool FindSignByID(int SignID,ref string Flex1Read,ref string Flex2Read,
      ref string Flex3Read,ref string Flex4Read,ref string Flex5Read,ref int Angle,ref int SignInfoID)
        {

            bool IsFound = false;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SpokenGloves_DB"].ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_FindSignByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@SignID", SignID);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            IsFound = true;

                            Flex1Read = (string)reader["Flex1Read"];
                            Flex2Read = (string)reader["Flex2Read"];
                            Flex3Read = (string)reader["Flex3Read"];
                            Flex4Read = (string)reader["Flex4Read"];
                            Flex5Read = (string)reader["Flex5Read"];
                            Angle = (int)reader["Angle"];
                            SignInfoID = (int)reader["SignInfoID"];


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
        public static DataTable GetAllSignsData()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SpokenGloves_DB"].ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("SP_GetAllSignsData", connection))
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
    }
}
