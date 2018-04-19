using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {

    // [Route("/hello")]
    // public string Hello() { return "Hello friend!"; }
    // [Route("/goodbye")]
    // public string Goodbye() { return "Goodbye friend."; }
    [Route("/")]
    // public ActionResult Letter()
    // {
    //   return View();
    // }
    public ActionResult Hello()
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.SetRecipient("Eric");
      myLetterVariable.SetSender("John");
      return View(myLetterVariable);
    }
    [Route("/journal")]
    public ActionResult Journal()
    {
      return View();
    }
    [Route("/form")]
    public ActionResult Form()
    {
      return View();
    }
    [Produces("text/html")]
    [Route("/favorite_photos")]
    public ActionResult FavoritePhotos()
    {
      return View();
    }
    [Route("/greeting_card")]
    public ActionResult GreetingCard()
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.SetRecipient(Request.Query["recipient"]);
      myLetterVariable.SetSender(Request.Query["sender"]);
      myLetterVariable.SetVacation(Request.Query["vacation"]);
      myLetterVariable.SetDreamspot(Request.Query["dreamspot"]);
      return View("Hello", myLetterVariable);
    }
  }
}
