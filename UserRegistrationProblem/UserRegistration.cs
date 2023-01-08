using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    internal class UserRegistration
    {
        public const string FIRSTNAME = "^[A-Z]{1}[A-Za-z]{3,}$";
        public const string LASTNAME = "^[A-Z]{1}[A-Za-z]{2,}$";
        public const string EMAIL = "^abc+.+[a-zA-Z0-9]+@+bl.co+.+[in|com]$";
        public const string MOBILENUMBER = "^[1-9]{2}[: :][0-9]{10}$";
        public const string PASSWORD = "^.*(?=.{8,})(?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+=]).*$";

        public string ValidateFirstName(string fName) => Regex.IsMatch(fName, FIRSTNAME) ? "Match" : "No Match";
        public string ValidateLastName(string lName) => Regex.IsMatch(lName, LASTNAME) ? "Match" : "No Match";
        public string ValidateEmail(string email) => Regex.IsMatch(email, EMAIL) ? "Match" : "No Match";
        public string ValidateMobileNUmber(string mobileNumber) => Regex.IsMatch(mobileNumber, MOBILENUMBER) ? "Match" : "No Match";
        public string ValidatePassword(string password) => Regex.IsMatch(password, PASSWORD) ? "Match" : "No Match";
    }

    public class UserRegistrationValidateTest
    {
        public const string FIRSTNAME = "^[A-Z]{1}[A-Za-z]{3,}$";
        public const string LASTNAME = "^[A-Z]{1}[A-Za-z]{2,}$";
        public const string EMAIL = "^abc+.+[a-zA-Z0-9]+@+bl.co+.+[in|com]$";
        public const string MOBILENUMBER = "^[1-9]{2}[: :][0-9]{10}$";
        public const string PASSWORD = "^.*(?=.{8,})(?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+=]).*$";
        public string ValidateFirstName(string firstname) => Regex.IsMatch(firstname, FIRSTNAME) ? "Prabhu" : "First Name is not match";
        public string ValidateLastName(string lastname) => Regex.IsMatch(lastname, LASTNAME) ? "Goyal" : "Last Name is not match";
        public string ValidateEmail(string email) => Regex.IsMatch(email, EMAIL) ? "abc.xyz@bl.co.in" : "Email is not match";
        public string ValidatePhoneNumber(string phonenumber) => Regex.IsMatch(phonenumber, MOBILENUMBER) ? "91 9149218712" : "Phonenumber is not match";
        public string ValidatePassword1(string password) => Regex.IsMatch(password, PASSWORD) ? "Prabhu@821" : "Password is not match";
    }

    public class ValidateMultipleEmailAddress
    {
        public const string EMAIL = "^abc+.+[a-zA-Z0-9]+@+bl.co+.+[in|com]$";
        public string MultipleEmailAddress(string email) => Regex.IsMatch(email, EMAIL) ? "prabhugoyal821@gmail.com" : "Email is not match";
    }
}
