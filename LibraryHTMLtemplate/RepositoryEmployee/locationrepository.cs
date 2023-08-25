using LibraryHTMLtemplate.EmplyoeeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
 using System.Data.SqlClient;


namespace LibraryHTMLtemplate.RepositoryEmployee
{
    public class locationrepository
    {
        public readonly string connectionstring;

        public locationrepository()
        {
            connectionstring = @"Data source=DESKTOP-531QTCP;Initial catalog=Manage;User Id=sa;Password=Anaiyaan@123";

        }
        public void insertlocationname(locationModel locationid)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionstring);
                con.Open();
                con.Execute("$exec Insertlocationins '{locationid .locationname}'");
                con.Close();
            }
            catch (SqlException ex)
            {
                throw;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public List<locationModel> locationin()
        {
            try
            {
                List<locationModel> constrain = new List<locationModel>();

                var connection = new SqlConnection(connectionstring);
                connection.Open();
                constrain = connection.Query<locationModel>("  exec locationins ").ToList();
                connection.Close();

                return constrain;


            }
            catch (SqlException ep)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public locationModel locationname(int locationid)
        {
            try
            {


                var connection = new SqlConnection(connectionstring);
                connection.Open();
                var result = connection.QueryFirst<locationModel>($"exec listworkersp {locationid}");
                connection.Close();

                return result;


            }
            catch (SqlException ep)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void updatelocationin(locationModel emp)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionstring);
                connection.Open();
                connection.Execute($"exec updatelocationin { emp.locationid},'{emp.locationname}'");



                connection.Close();

            }
            catch (SqlException e)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Deletelocationin(int locationid)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionstring);
                connection.Open();
                connection.Execute($" exec deletesp  {locationid}");
                connection.Close();

            }
            catch (SqlException e)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
