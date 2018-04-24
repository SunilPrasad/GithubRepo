using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "10,12,\n15,14";
            Console.WriteLine(str);
        }
    }

    public class AccontController
    {
        
        public bool ValidateUser(string username, string password)
        {
            Repository repository = new Repository();

            if(!repository.CheckUser("alexa"))
            {
                return false;
            }

            return true;
        }
    }

    public class Repository
    {
        public bool CheckUser(string userName)
        {
            return true;
        }
    }

}
