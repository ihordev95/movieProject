using MySql.Data.MySqlClient;
using System;
using System.Data;

public class DatabaseAccess
{

    private string conn = "server=memdixyp.mysql.db.hostpoint.ch;uid=memdixyp_user;pwd=rmpvzSp4BsNm;database=memdixyp_imdb;SslMode=None"; //read only
    private string conn2 = "server=memdixyp.mysql.db.hostpoint.ch;uid=memdixyp_user;pwd=rmpvzSp4BsNm;database=memdixyp_film;SslMode=None"; //writable



    public DataSet GetDataSet() //Example function to run a "GET" stored procedure
    {
        try
        {
            MySqlConnection connection = new MySqlConnection(conn); //Make a new connection using our connection string
            DataSet ds = new DataSet();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM title_basics limit 1000;", connection);
            //MySqlCommand cmd = new MySqlCommand("<stored procedure name>", connection);
            //cmd.CommandType = CommandType.StoredProcedure; //This tells it we are using a stored procedure instead of passing in a query of our own

            //This is an alternative that would accomplish the same thing as the lines above
            //cmd.CommandType = CommandType.StoredProcedure
            //cmd.Connection = connection
            //cmd.CommandText = "<stored procedure name>"
            //If the commandType is not specified as a stored procedure you can write a query in the CommandText field

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            try
            {
                connection.Open();
                da.Fill(ds); //Whatever the stored procedure queries is dumped into our dataset
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }

            finally
            {
                connection.Close(); //Make sure we always close the database connection when done with it
            }

            return ds;
        }
        catch (Exception ex)
        {
            throw new ArgumentException(ex.Message);
            //MessageBox.Show(ex.Message);
        }
    }

    public DataSet InsertDataRow(String s, int i)   //Example function that would insert a row into the table with values of s and i
    {
        try
        {
            MySqlConnection connection = new MySqlConnection(conn);     //Make a new connection using our connection string
            DataSet ds = new DataSet();

            MySqlCommand cmd = new MySqlCommand("<stored procedure name>", connection);
            cmd.CommandType = CommandType.StoredProcedure;  //This tells it we are using a stored procedure instead of passing in a query of our own

            cmd.Parameters.Add("@name", MySqlDbType.VarChar, 100);  //Tells it we are passing in a parameter to the @name variable in the stored procedure
            cmd.Parameters[cmd.Parameters.Count - 1].Direction = ParameterDirection.Input;  //Tells it that this is a value we are sending to the stored procedure
            cmd.Parameters[cmd.Parameters.Count - 1].Value = s;     //Tells it what value we are sending it

            cmd.Parameters.Add("@id", MySqlDbType.Int32);
            cmd.Parameters[cmd.Parameters.Count - 1].Direction = ParameterDirection.Input;
            cmd.Parameters[cmd.Parameters.Count - 1].Value = i;


            try
            {
                connection.Open();
                cmd.ExecuteNonQuery(); //Tells it we are not expecting the results of a query back
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }

            finally
            {
                connection.Close();
            }

            return ds;
        }
        catch (Exception ex)
        {
            throw new ArgumentException(ex.Message);
            //MessageBox.Show(ex.Message);
        }
    }
}