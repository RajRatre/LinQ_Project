using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_Project
{
    internal class Filtering
    {

        public Filtering()
        {
            
        }


        //Where ---Returns values from the collection based on a predicate function.

        public void GetFilterData()
        {
            IEnumerable<Employee> employees = new List<Employee>()
        { new Employee() { EmpId=1001,Name="Raj Prakash Ratre",Age=34 },
          new Employee() {EmpId=1002,Name="Suresh",Age=36 },
          new Employee() {EmpId=1003,Name="Mark", Age=39 },
          new Employee() {EmpId=1004,Name="David",Age=40},
          new Employee() {EmpId=1005,Name="Sobha",Age=31}
        };

            //  using Query 

            var result = from emp in employees
                         where emp.Age>32 && emp.Age<35
                         select emp;

            // Using Extention Method 

            var result2 = employees.Where(x => x.Age>32 && x.Age<35);
           

            foreach ( var emp in result2)
            {

                Console.WriteLine( emp.Name );
            }

        }


        //OfType -- Returns values from the collection based on a specified type.However, it will depend on their ability to cast to a specified type.
    }
}
