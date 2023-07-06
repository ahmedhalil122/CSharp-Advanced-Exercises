using Telephony.Interfaces;

namespace Telephony.Models;

public class Smartphone : ICallable, IBrowsable
{
    public string Call(string phonenumber)
    {
        if (!ValidatePhoneNumber(phonenumber))
        {
            throw new ArgumentException("Invalid number!");
        }
        return $"Calling... {phonenumber}";
    }
    public string Browse(string url)
    {
        if (!ValidateURL(url))
        {
            throw new ArgumentException("Invalid URL!");

        }
        return $"Browsing: {url}!";
    }
private bool ValidatePhoneNumber(string phoneNumber) => phoneNumber.All(x => char.IsDigit(x)); 
private bool ValidateURL(string Url) => Url.All(x => !char.IsDigit(x)); 

}
