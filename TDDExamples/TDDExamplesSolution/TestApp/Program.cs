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
        private Repository repository;
        public AccontController(Repository repository)
        {

        }
        
        public bool ValidateUser(string username, string password)
        {
            

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
