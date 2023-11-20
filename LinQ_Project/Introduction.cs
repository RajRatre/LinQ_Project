using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_Project
{
    internal class Introduction
    {


        public void GetLinqIntro()
        {

            Console.WriteLine("Print the introduction class");
            //  Data Souce 
            string[] empName = { "Raj", "Ramesh", "Sanjay", "Kumar", "Tinu", "Neha", "Hema" };

            // Sample  LinQ Query 

            var nameResult = from name in empName
                             where name.Contains("R")
                             select name;

            //  Display the result using loop

            foreach(var item in nameResult) {

                Console.WriteLine(item);
            
            }

            Console.WriteLine("============= END ===================");
        }

    }
}
