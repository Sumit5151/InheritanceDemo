using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{


    public class Teacher
    {
        public void GetData()
        {  
        }
        public void PutData()
        {

        }
    }


   public class ParamanatTeacher: Teacher
    {
        void function1()
        {

        }
    }







    internal class Parent
    {
        //consturctor
        public Parent(int id)  
        {
            this.Id = id;
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
        public Child():base(20)
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
        public void function4(int num1, int num2, string operation)  //Formal paramters
        {

            if(operation =="Add")
            {
                int result= num1 + num2;
            }


            if (operation == "Sub")
            {
                int result = num1 - num2;
            }


            Console.WriteLine("Child class function 4 ");
        }
    }

}
