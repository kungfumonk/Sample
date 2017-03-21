#API

public void Load()
{
    try
    {
        string connection = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        using (var con = new SqlConnection(connection))
        {
            con.Open();
            using (var command = new SqlCommand("SELECT TOP(1) Name FROM HelloWorld WHERE Name = @Name", con))
            {
                command.Parameters.Add(new SqlParameter("@Name", "Hello World!"));
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Word = reader[0].ToString();
                }
            }
            con.Close();
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex);
        throw new Exception("error", ex);
    }
}
