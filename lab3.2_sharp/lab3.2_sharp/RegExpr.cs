using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace lab3._2_sharp
{
    class RegExpr
    {
 
        static public Regex Name = new Regex (@"^[A-Z]+[a-z]{1,20}$") ;
        static public Regex Surname = new Regex (@"^[A-Z]+[a-z]{1,20}$") ;
        static public Regex Country = new Regex(@"^[A-Z]+[a-z]{1,20}$");
        static public Regex Gradebook = new Regex(@"^[A-Z]+[a-z]{1,20}$");
        static public Regex Academic_results = new Regex(@"^[A-F]{1,20}$");
        static public Regex Identical_card = new Regex(@"^\d{1,10}$");
        static public Regex Year = new Regex(@"^[1-5]{1}$");

        static public bool StringCheck(string StringExpression, Regex RegExpression)
        {
            if (RegExpression.IsMatch(StringExpression))

                return true;
            else
                return false;
        }
        
    }
}
