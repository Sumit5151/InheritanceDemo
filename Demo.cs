using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{

    internal class Parent
    {


        


        public Parent()  //consturctor
        {
            this.Id = 10;
        }

        //Data members
        public int Id { get; set; }

        //Member functions
        public void function1()
        {
            Console.WriteLine("Parent class function 1 ");
        }
        public void function2()
        {
            Console.WriteLine("Parent class function 2 ");
        }

    }

    internal class Child : Parent
    {

        //Constructor
        public Child()
        {
            this.Name = "Ajay";
        }

        //Data members
        public string Name { get; set; }


        //Member functions
        public void function3()
        {
            Console.WriteLine("Child class function 3 ");

            Console.WriteLine("Name= " + Name);
            Console.WriteLine("Id= " + Id);

            
        }
        public void function4()
        {
            Console.WriteLine("Child class function 4 ");
        }
    }

}
