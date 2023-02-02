namespace DAL;
using BOL;
using System.Data;
using MySql.Data.MySqlClient;

public class DBManager
{
    public static string conString=@"server=localhost; port=3306; user=root; password=root; database=knowitdb";
    public static List<Country> GetAll()
    {
        List<Country> countries = new List<Country>();
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString=conString;
        try
        {
            DataSet ds = new DataSet();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            string query = "select * from contacts";
            cmd.CommandText = query;
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            DataRowCollection rows = dt.Rows;
            foreach(DataRow row in rows)
            {
                int id = int.Parse(row["cid"].ToString());
                string name = row["lname"].ToString();
                Country c = new Country{Id=id, Name=name};
                countries.Add(c);
            }
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
        return countries;
    }


    public static bool Delete(int id){
        bool status=false;
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;
        try
        {
            string query = "delete from contacts where cid=" + id;
            MySqlCommand command = new MySqlCommand(query, con);
            con.Open();
            command.ExecuteNonQuery();
            status=true;
        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            con.Close();
        }
      return status;
    }
}