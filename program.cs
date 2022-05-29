/*using System;

class program
{
    static program()
    {
         int a=45, b=54;
        Console.WriteLine( a / b);
    }

    static void Main(string[] args)
    {
        program();
    }
}*/
/*using System;
class Program
{ //  Syed Mustafa 084
    static void Main(string[] args){
        int Rollno = 84;
        int[] array = new int[]  { Rollno + 2, 3 * Rollno, Rollno, 35, 220, 50, 2 * Rollno + 4, 100 };
        int number = 0;
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            int temp_num = array[i];
            int temp_count = 0;
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] == temp_num)
                { temp_count++; }
                if (temp_count > count)
                {
                    number = temp_num;
                    count = temp_count;
                    Console.WriteLine($"The most frequent number {number} in this array is repeated {count} time");
                    Console.ReadKey();
                }
            }
        }
    }
} 
*/
/*
using System;

 // Syed Mustafa 084
    class fro
    {
        public void array()
        {
            int i, j, a, b;
            Console.WriteLine("Enter values of Arrays 1?");
            a = Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[a];
            Console.WriteLine($"Enter {a} values");
            for (i = 0; i < a; i++)
            {
                j = Convert.ToInt32(Console.ReadLine());
                arr1[i] = j;
            }
            Console.WriteLine("Enter values of Arrays 2?");
            b = Convert.ToInt32(Console.ReadLine());
            int[] arr2 = new int[b];
            Console.WriteLine($"Enter {b} values");
            for (i = 0; i < b; i++)
            {
                j = Convert.ToInt32(Console.ReadLine());
                arr2[i] = j;
            }
            int a1 = arr1.Length;
            int a2 = arr2.Length;
            if (a1 == a2)
            {
                Console.WriteLine("Han equal hain");
            }
            else
                Console.WriteLine("Not equal hain");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            fro i = new fro();
            i.array();
            Console.ReadKey();
        }
    }
*/
/*using System;
public class Const
{ // Mustafa Ahmed 084
    public Const()
    {
        Console.WriteLine("THIS IS MY DATA OF CLASS [TULIP]! ");
    }
    public Const(string name)
    {
        Console.WriteLine(name);
    }
    public Const(int num, int rollno)
    {
        Console.WriteLine((num + 2) + rollno);
    }
}
public class Program
{
    public static void Main()
    {
        Const c1 = new Const();
        Const c2 = new Const("Mustafa \nBCS-2021F-084");    
        Const c3 = new Const(55, 084);
        Console.ReadLine();
    }
}
*/

/*  static class program
{
  static double a = 45;
  static double b = 54;

  static program()
  {
     Console.WriteLine( a / b);
  }

  static void Main(string[] args)
  {

  }
}*/

//     namespace program
//    {
//    public class method
//    {
//public void pr1()
//        {
//            console.writeline("normal method chal gaya");

//        }

//    static void main()
//    {
//        method method = new method();
//        method.pr1();
//    }
//    }
//}

//namespace ConsoleApplication43
//{
//    class car
//    {
//        public int age;
//        public string name;
//       public car(int a,string b)
//        {
//            Console.WriteLine(" Constructor chal gaya... ");
//            age = a;
//            name = b;
//            Console.WriteLine($" Ye mera naam {name} meri age {age} hai");
//        }

//    }

//class testcar
//    {
//        static void Main(string[] args)
//        {
//            car obj = new car(19,"mustafa");        
//        }
//    }
//}

//                 static Variable 
/*namespace ConsoleApplication45
{
    class Vehicle
    {
        public static string name = "Civic";
    }
    class doosri
    {
        public string name="corolla";
    public void eesha()
        {
            Console.WriteLine(name);
        }
    }
    class TestVehicle
    {
        static void Main(string[] args)
        {
           Console.WriteLine(Vehicle.name);
            doosri obj = new doosri();  
            obj.eesha();
            Console.Read();

        }
    }
   
}*/

/*using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication45
{
    class Numbers
    {
        public int findminimum1(int num1, int num2)
        {
            int min = num2;
            if (num1 < num2) { min = num1; }
            return min;
        }
       
    }
    class testnumber
    {
        static void Main(string[] args)
        {
            int min;
            Numbers obj = new Numbers();
             min = obj.findminimum1(8, 9);
            Console.WriteLine(" Minimum Value is : " + min);
            Console.Read();
        }
    }
}
*/

/*
using System;
using System.Collections.Generic;
using System.Text;
namespace ConsoleApplication45
{
    static class user
    {
         static int age;
         static string name;
        static public void hellog() //Static method
        {
            Console.WriteLine("Enter name and age");
            name = Console.ReadLine();
            Console.WriteLine($" my name is: {name} ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine($" my age is: {age} ");

        }
        static void Main(string[] args)
        {
            user.hellog();
            
            Console.Read();

        }
    
    }
    
}*/
/*
using System;
using System.Collections.Generic;
using System.Text;
namespace ConsoleApplication56
{
    class Employee
    {
        public int id;
        public string name;
        public int salary;
        public Employee(int id, string name, int salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        public void display()
        {
            Console.WriteLine(id + " " + name + " " + salary);
        }
    }

class Program
    {

        static void Main(string[] args)
        {

            Employee ali = new Employee(11, " Ali Ahmed ", 1000);
            ali.display();
            Employee Zia = new Employee(12, " Zia Khan ", 3000);
            Zia.display();
            Employee Asad = new Employee(13, " Asad Ahmed ", 4000);
            Asad.display();
            Console.Read();

        }
    }
}*/

/*using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication41
{
    class Employee
    {
        private int salary = 2000;
        public int salaryaccess //read & write property
        {
            get { return salary; }
            set { salary = value; }
        }
    }

class Program
    {
        static void Main(string[] args)
        {
            int bonus;
            Employee emp = new Employee();
            emp.salaryaccess = 1800;
            bonus = emp.salaryaccess / 100 * 30;
            Console.WriteLine(bonus);
            Console.ReadKey();

        }
    }
}*/
/*
using System;

namespace Mustafa
{
    class Program
    {
       static void Main()
        {
            Child child = new Child();
            child.F();
        }
    }
    class  Parent
{
        public virtual void F()
        {
            Console.WriteLine("Parent class hai");

        }
}
    class Child : Parent
        {
            public override void F()
            {
                Console.WriteLine("me bacha huu");
            }
        }      
      }
*/
/*
using System;
namespace Mustafa
{
    class A
    {
        public A()
        {
            Console.WriteLine("This is GrandParent");
        }
    }
    class B : A
    {
        public B()
        {
            Console.WriteLine("This is Parent");
        }
    }
    class C : B
    {
        public C()
        {
            Console.WriteLine("This is Child");
        }
    }
        class D : C
        {
            public D()
            {
                Console.WriteLine("This is  Grandchild");
            }
        }
    class Program
    {
        static public void Main()
        {
            D si = new D();
        }
    }
}*/
/*
namespace ConsoleApplication61
{
    class sum
    {   // compile-time polymorphism can be achieved by using method overloading
        public  void addnumbers(int a, int b)
        {
            Console.WriteLine("addnumbers(int a, int b)" + (a + b));
        }
        public void addnumbers(int a, int b, int c)//1 method overloading
        {
            Console.WriteLine("addnumbers(int a, int b, int c)" + (a + b + c));
        }
        public void addnumbers(double a, int b)// 2 method overloading
        {
            Console.WriteLine("addnumbers(double a, int b)" + (a + b));
        }
        public void addnumbers(double a, double b)//3 method overloading
        {
            Console.WriteLine("addnumbers(double a, double b)" + (a + b));
        }
        public void addnumbers(int a, double b, int c)// 4 method overloading
        {
            Console.WriteLine("addnumbers(int a, double b, int c)" + (a + b + c));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            sum s = new sum();
            s.addnumbers(6,51.5,5);
            Console.Read();
        }
    }
}*/
/*
namespace ConsoleApplication60
{
    class A
    {
        public string name;
        public void displayname()
        {
            Console.WriteLine(" Name : " + name);
        }
    }
    class B : A
    {
        
        public string location;
        public void displaylocation()
        {
            Console.WriteLine("Location : " + location);
        }
    }
    class C : B
    {
        public C()
        {
            Console.WriteLine("CONSTRUCTER HAI");
        }
        public int salary;
        public void displaysalary()
        {
            Console.WriteLine("Salary : " + salary);
        }
    }
    class D : C
    {
        public int age;
        public void displayage()
        {
            Console.WriteLine(" Age : " + age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            D d = new D();
            d.name = "Ikrama";
            d.location = "Islamabad";
            d.salary = 3533;
            d.age = 65;
            d.displayname();
            d.displaysalary();
            d.displayage();
            d.displaylocation();
            Console.Read();
        }
    }
}*/
/*
namespace ConsoleApplication60
{
    class User
    {
        public static string name;
        public string location;
        public void displayuserinfo()
        {
            Console.WriteLine(" Name : " + name);
            Console.WriteLine(" Location : " + location);
        }
        public User()
        {
            Console.WriteLine("Parent (Base) class constructor invoked...");
        }
    }
    class details : User
    {
        public int salary;
        public void displaysalary()
        {
            Console.WriteLine(" Salary : " + salary);
        }
        public details()
        {
            Console.WriteLine(" Child Class Constructor invoked...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            details d = new details();
            details.name = "Ali Ahmed";
            d.location = "Karachi";
            d.salary = 2324;
            d.displayuserinfo();
            d.displaysalary();
            Console.Read();
        }
    }
*/

/*
namespace ConsoleApplication41
{
    class Employee 
    {
        private int salary = 2000;//original value will remain same
        public int salaraccess //read property
        {
            get { return salary; }//read only
            
        }
    
    }
    class Program
    {
        static void Main(string[] args)
        {
            int bonus;
            Employee emp = new Employee();
            bonus = emp.salaraccess ;
            Console.WriteLine(bonus);
            Console.ReadKey();
        
        }
    }
}*/
/*
namespace faiqa_siddiqui
{
    class emp
    { //* <<FAIQA SIDDIQUI>> <<319>> *
        private string emp_name;
        private double emp_sal;
        private double emp_hour;
        public emp()
        {
            name = emp_name;
            sal = emp_sal;
            hr = emp_hour;
        }
        public string name
        {
            get { return emp_name; }
            set { emp_name = value; }
        }
        public double sal
        {
            get { return emp_sal; }
            set { emp_sal = value; }
        }
        public double hr
        {
            get { return emp_hour; }
            set { emp_hour = value; }
        }
        public double calemp()
        {
            if (hr <= 20)
                return hr * sal;
            else
                return (20 * sal) + ((hr - 20) * (sal * 1.5));
        }
        public void display()
        {
            Console.WriteLine("Employee Name : " + name);
            Console.WriteLine("Employee Salary : " + sal);
            Console.WriteLine("Employee Hours Worked: " + hr);
            Console.WriteLine("Employee Total Pay : " + calemp());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            emp k = new emp();
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Enter Employee Name :");
                k.name = Console.ReadLine();
                Console.WriteLine("Enter Employee Salary :");
                k.sal = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Employee Hours :");
                k.hr = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("------------------------------------\n");
                Console.WriteLine("Employee :" + i, "\n");
                k.display();
                Console.WriteLine("\n------------------------------------\n");
            }
            Console.ReadKey();
        }
    }
}*/
/*
using System;
class Palindrome
{
    static void Main()
    {
        string input;
        int number;
        
        while (true)
        {
            Console.Write("Enter a 3 digit number :");
            input = Console.ReadLine();
            bool isValid = int.TryParse(input, out number);
            if (!isValid || input.Length != 3 || input[0] == '0')
            {
                Console.WriteLine("Not a 3 digit number, ERROR ALERT! Enter new value!!");
                Console.WriteLine("---------------------------------------------------");
             }
            else
            {
                break;
            }
        }
        char[] chars = input.ToCharArray();
        Array.Reverse(chars);
        string reverseInput = new string(chars);
        int reverseNumber = int.Parse(reverseInput);
        if (number == reverseNumber)
        {
            Console.WriteLine("{0} is a palindrome", number);
        }
        else
        {
            Console.WriteLine("{0} is not a palindrome", number);
        }
        Console.ReadKey();
    }
}*/
