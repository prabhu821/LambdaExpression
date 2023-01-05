﻿using System;
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

        public string ValidateFirstName(string fName) => Regex.IsMatch(fName, FIRSTNAME) ? "Match" : "No Match";
        public string ValidateLastName(string lName) => Regex.IsMatch(lName, LASTNAME) ? "Match" : "No Match";

    }
}
