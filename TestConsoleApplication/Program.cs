using AbstractFactory.cs;
using AdapterDesignPattern;
using BuilderPattern;
using FactoryMethod;
using ProtoType;
using ShallowAndDeepCloning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Factory Method
            /////Factory Method
            //EmployeeFactory EmployeeFactory = new ConcreteEmployeeFactory();

            //IFactory permanentEmployee = EmployeeFactory.Factory("PermanentEmployee");
            //permanentEmployee.Details();

            //IFactory TemporaryEmployee = EmployeeFactory.Factory("TemporaryEmployee");
            //TemporaryEmployee.Details();
            #endregion

            #region Abstract Factory
            //IComputerFactory lenovoFactory = new LenovoFactory();
            //IComputerFactory dellFactory = new DellFactory();
            //Console.WriteLine("--------- Lenovo Products --------------------------");
            //ComputerClient lenovoClient = new ComputerClient(lenovoFactory, "gaming");
            //Console.WriteLine(lenovoClient.GetLaptopName());
            //Console.WriteLine(lenovoClient.GetDesktopName());
            //lenovoClient = new ComputerClient(lenovoFactory, "normal");
            //Console.WriteLine(lenovoClient.GetLaptopName());
            //Console.WriteLine(lenovoClient.GetDesktopName());


            //Console.WriteLine("--------- Dell Products --------------------------");
            //ComputerClient dellClient = new ComputerClient(lenovoFactory, "gaming");
            //Console.WriteLine(dellClient.GetLaptopName());
            //Console.WriteLine(dellClient.GetDesktopName());
            //dellClient = new ComputerClient(lenovoFactory, "normal");
            //Console.WriteLine(dellClient.GetLaptopName());
            //Console.WriteLine(dellClient.GetDesktopName());

            #endregion

            #region Prototype pattern

            //ParmenantEmployee permanentEmployee = new ParmenantEmployee();
            //permanentEmployee.Name = "Sam";
            //permanentEmployee.Age = 25;
            //permanentEmployee.EmployeeType = "Permanent";

            //// clone permanent employee object with Clone method
            //// If you will not set the new value for any field the it will take the default value from original object
            //ParmenantEmployee permanentEmployeeClone = (ParmenantEmployee)permanentEmployee.Clone();
            //permanentEmployeeClone.Name = "Tom";
            //permanentEmployeeClone.Age = 30;

            //Console.WriteLine("Permanent Employee Details");
            //Console.WriteLine("Name: {0}; Age: {1}; Employment Type: {2}", permanentEmployee.Name, permanentEmployee.Age, permanentEmployee.EmployeeType);

            //Console.WriteLine("Cloned Permanent Employee Details");
            //Console.WriteLine("Name: {0}; Age: {1}; Employment Type: {2}", permanentEmployeeClone.Name, permanentEmployeeClone.Age, permanentEmployeeClone.EmployeeType);
            #endregion

            #region Shallow and Deep cloning
            //// Create an instance of Person and assign values to its fields.
            //Person p1 = new Person();
            //p1.Age = 42;
            //p1.Name = "Sam";
            //p1.IdInfo = new IdInfo(6565);

            //// Perform a shallow copy of p1 and assign it to p2.
            //Person p2 = p1.ShallowCopy();

            //// Display values of p1, p2
            //Console.WriteLine("Original values of p1 and p2:");
            //Console.WriteLine("   p1 instance values: ");
            //DisplayValues(p1);
            //Console.WriteLine("   p2 instance values:");
            //DisplayValues(p2);

            //// Change the value of p1 properties and display the values of p1 and p2.
            //p1.Age = 32;
            //p1.Name = "Frank";
            //p1.IdInfo.IdNumber = 7878;
            //Console.WriteLine("\nValues of p1 and p2 after changes to p1:");
            //Console.WriteLine("   p1 instance values: ");
            //DisplayValues(p1);
            //Console.WriteLine("   p2 instance values:");
            //DisplayValues(p2);


            // void DisplayValues(Person p)
            //{
            //    Console.WriteLine("      Name: {0:s}, Age: {1:d}", p.Name, p.Age);
            //    Console.WriteLine("      Value: {0:d}", p.IdInfo.IdNumber);
            //}
            #endregion

            #region Builder design pattern
            //LaptopManufacturer laptopManufaturer = new LaptopManufacturer();
            //ILaptopBuilder laptopBuilder = new GamingLaptopBuilder();
            //laptopManufaturer.BuildLaptop(laptopBuilder);
            //Laptop GamingLaptop = laptopBuilder.GetLaptop();
            //// print details
            //Console.WriteLine("Gaming Laptop Object:");
            //GamingLaptop.PrintDetails();

            //// build normal laptop
            //ILaptopBuilder normalLaptopBuilder = new NormalLaptiopBuilder();
            //laptopManufaturer.BuildLaptop(normalLaptopBuilder);
            //Laptop NormalLaptop = normalLaptopBuilder.GetLaptop();
            //// print details
            //Console.WriteLine("\nNormal Laptop Object:");
            //NormalLaptop.PrintDetails();

            #endregion

            #region Adapter desing pattern

            Console.WriteLine("Employee List from ThridPartyEmployee class");
            // client will use ITarget interface to call functionality of Adaptee class i.e. ThirdPartyEmployee
            ITarget adapter = new EmployeeAdapter(); ;
            foreach (string employee in adapter.GetEmployee())
            {
                Console.WriteLine(employee);
            }
            Console.ReadLine();
            #endregion



            Console.ReadLine();
        }
    }
}
