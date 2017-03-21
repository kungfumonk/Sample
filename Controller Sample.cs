#controller
using System.Net.Mail;

public ActionResult Index()
{
  Model model = new Model();
  model.StateList = service.GetStates();

  return View(model);
}

[HttpPost]
public ActionResult Index(Model model)
{
  model.StateList = Service.GetStates();
  if (ModelState.IsValid)
  {
      Request req = new Request(model.FirstName, model.LastName);

      Service API = new Service();
      Results results = API.methodCall(req);

      MailAddress From = new MailAddress("asdf@gmail.com", "donotreply");
      MailAddress To = new MailAddress("xxxxxxxx@gmail.com", "Records");
      MailMessage Message = new MailMessage(From, To);
      Message.Subject = "Contact Info";

      Message.Body =  String.Format("First Name: {0} \nLast Name: {1}\n", model.FirstName, model.LastName);

      SmtpClient client = new SmtpClient{
          Host = "smtp.gmail.com",
          Port = 587,
          EnableSsl = true,
          DeliveryMethod = SmtpDeliveryMethod.Network,
          UseDefaultCredentials = false,
          Credentials = new System.Net.NetworkCredential("asdf@gmail.com", "password")
      };

      try
      {
          client.Send(Message);
      }
      catch (Exception ex)
      {
          Console.WriteLine(ex.ToString());
      }

  }
  return View(model);
}


[HttpGet]
public JsonResult HelloWorld()
{
    var results = new API.API().GetHelloWorld();
    return Json(new { data = results }, JsonRequestBehavior.AllowGet);
}
