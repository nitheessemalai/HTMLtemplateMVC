using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using LibraryHTMLtemplate.EmplyoeeModel;

namespace LibraryHTMLtemplate.RepositoryEmployee
{
    public class Repositoryemployee
    {
        public readonly string connectionstring;

        public Repositoryemployee()
        {
            connectionstring = @"Data source=DESKTOP-531QTCP;Initial catalog=Manage;User Id=sa;Password=Anaiyaan@123";

        }

        public List<ModelEmployee> selectsp()
        {
            try
            {
                List<ModelEmployee> constrain = new List<ModelEmployee>();

                var connection = new SqlConnection(connectionstring);
                connection.Open();
                constrain = connection.Query<ModelEmployee>(" exec Getworker ").ToList();
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
        public ModelEmployee selectid (int id)
        {
            try
            {
                

                var connection = new SqlConnection(connectionstring);
                connection.Open();
                var result = connection.QueryFirst<ModelEmployee>($"exec listworkersp {id}");
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
        public void Insertsp(ModelEmployee emp)
        {
            try
            {

                SqlConnection con = new SqlConnection(connectionstring);

                con.Open();
                con.Execute($"exec insertworkersp'{emp.Name}','{emp.AadharNumber}','{emp.Email}','{emp.phonenumber}','{emp.location}'");
                con.Close();

            }
            catch (SqlException sqlEx)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void updatesp(ModelEmployee emp)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionstring);
                connection.Open();
                connection.Execute($"exec  updatesp  ' {emp.id}',' {emp.Name}','{emp.AadharNumber}','{emp.Email}','{emp.phonenumber}','{emp.location}'");
             


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
        public void deletesp(int id)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionstring);
                connection.Open();
                connection.Execute($"exec  deletesp  {id}");
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
   



