namespace FriendLetter.Models
{
  public class LetterVariable
  {
    private string _recipient;
    private string _sender;
    private string _vacation;
    private string _dreamspot;
    public string GetRecipient()
    {
      return _recipient;
    }
    public void SetRecipient(string newRecipient)
    {
      _recipient = newRecipient;
    }
    public string GetSender()
    {
      return _sender;
    }

    public void SetSender(string newSender)
    {
      _sender = newSender;
    }
    public void SetVacation(string newVacation)
    {
      _vacation = newVacation;
    }
    public string GetVacation()
    {
      return _vacation;
    }
    public void SetDreamspot(string newDreamspot)
    {
      _dreamspot = newDreamspot;
    }
    public string GetDreamspot()
    {
      return _dreamspot;
    }
  }
}
