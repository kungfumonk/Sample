[TestClass]
public class TestCases
{

  Int32 GlobalNumber {get;set;}
  Object Request {get;set;}
  
  [TestInitialize]
  public void TestInitialize()
  {
      String DataDirectory = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\App_Data"));
      AppDomain.CurrentDomain.SetData("DataDirectory", DataDirectory);

      Request = new Request("Test", "Test", "Tester", "111 Test Dr.", "Test", "HI", "99999", "Test@Test.com", "", "");

  }

  [TestMethod]
  public void Test1()
  {
      Service API = new Service();
      Response results = API.call(Request);
      Assert.IsTrue(results.Succeeded);

  }

  [TestMethod]
  public void Test2()
  {
      Response results = Service.call2(Request);
      Assert.IsFalse(results.Succeeded);
  }


  /// <summary>
  /// Gets the states.
  /// </summary>
  [TestMethod]
  public void GetStates()
  {
      List<String> StateList = Service.GetStates();
      Assert.AreEqual(50, StateList.Count);
  }
}
