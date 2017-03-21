# Sample

MVC sample

//  <connectionStrings>
 //   <add name="DefaultConnection" connectionString="Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DatabaseName.mdf;Integrated Security=True" providerName="System.Data.SqlClient" />
 // </connectionStrings>

///////////////////// PUT THESE TWO LINES IN INIT METHOD ///////////////////////////
String DataDirectory = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\App_Data"));
AppDomain.CurrentDomain.SetData("DataDirectory", DataDirectory);
///////////////////////////////////////////////////////////////////////////////////
