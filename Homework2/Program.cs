using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Homework2.Models;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new List<Models.User>();

            users.Add(new Models.User { Name = "Dave", Password = "hello" });
            users.Add(new Models.User { Name = "Steve", Password = "steve" });
            users.Add(new Models.User { Name = "Lisa", Password = "hello" });

            //Display to the console all the passwords that are "hello"

            var filterHello = users.Where(t => t.Password == "hello");
            foreach (User u in filterHello)
            {
                Console.WriteLine(u.Name);
            }

            //Delete any passwords that are the lower-cased version of their Name. 

            var lowerCasePassword = users.RemoveAll(t => t.Password == t.Name.ToLower());

            //Delete the first User that has the password "hello". 

            var firstHello = users.First(t => t.Password == "hello");
            users.Remove(firstHello);

            //Display to the console the remaining users with their Name and Password

            foreach (User u in users)
            {
                Console.WriteLine(u.Name, u.Password);
            }


        }
    }
}
