using InheritanceDemo;

class Program
{
    public static void Main()
    {


        Teacher teacher = new Teacher();
        teacher.GetData();
        teacher.PutData();
       
        Child C = new Child();

        string Operation = "Add";

        C.function4(10,20,Operation); //Actual paramters

        Parent P = new Parent(10);


        Child c1;
        Parent p1;

        

        //c1 = P;  //invalid 
         p1 = C;  //valid
        //p1 is the varible of parent class but its the refernce of child class

        //p1.function3();




        //Child C;   //This is Variable

        //C = new Child();//Instance of the class


        //Child C2 = new Child();  //instace of the class

        //Child C3;   //variable of the class
        //C3 = C2;   //Reference of the class

    }
}
