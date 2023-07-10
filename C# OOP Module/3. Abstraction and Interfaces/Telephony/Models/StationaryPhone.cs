using Telephony.Interfaces;

namespace Telephony.Models
{
    public class StationaryPhone : ICallable
    {
        public string Call(string phonenumber)
        {
            if (!ValidatePhoneNumber(phonenumber))
            {
                throw new ArgumentException("Invalid number!");
            }
            return $"Dialing... {phonenumber}";
        }

        private bool ValidatePhoneNumber(string phoneNumber) => phoneNumber.All(x => char.IsDigit(x));

    }
}
