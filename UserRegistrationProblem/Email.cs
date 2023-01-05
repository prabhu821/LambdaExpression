using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    internal class Email
    {
        public const string EMAILSAMPLECHECK = "^[a-zA-Z0-9+-.]+@[a-zA-Z0-9]+.+([com|net|com.com|com.au])$";
        public string ValidateSampleEmail(string sampleEmail) => Regex.IsMatch(sampleEmail, EMAILSAMPLECHECK) ? "Match" : "No Match";
    }
}
