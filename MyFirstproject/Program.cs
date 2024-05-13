// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//string name = "Amit";// 4byte

//short s1 = 100;
//int no = 10;
//long l1 = 455443l;

//float fl = 20.33F;

//double d1 = 45.55;

//decimal d2 = 89.77M;

//Print the output
// Console.WriteLine("integer number");


// accept thevalue from user

//Console.WriteLine("Enter Your name");
//string name2 = Console.ReadLine();

//Console.WriteLine("Enter your age");
//int age = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter your salary");
//double salary = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine($"Hello {name2},your age is{age} and salary is{salary}");


using MyFirstproject;
using System;
using System.Collections;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography;

//Employee emp = new Employee();
//emp.Assign();
//emp.CalculateSalary();
//string result = emp.Display();
//Console.WriteLine(result);

/*Student s1 = new Student();
Student s2 = new Student(2,"Dhiraj");

Console.WriteLine(s1.Display());
Console.WriteLine(s2.Display());*/

/*Date date = new Date();
Console.WriteLine(date.Display());

Date date2 = new Date(23, 04, 2024);

Console.WriteLine(date2.Display());*/

/*Product p1 = new Product();
p1.Code = 100;
p1.Name = "Mobile";
p1.Price = 500;

Console.WriteLine($"{p1.Code}, {p1.Name} ,{p1.Price}");*/

/*Product p2 = new Product{code= 202,"name =Keyboard", price =10000};
Console.WriteLine($"{p2.code}, {p2.name} ,{p2.price}");*/

/*Book b1 = new Book();

b1.Bid = 100;
b1.Bname = "java";
b1.Price = 400;

Console.WriteLine($"{b1.Bid}, {b1.Bname} ,{b1.Price}");

Book b2 = new Book { Bid = 200, Bname = "C#", Price = 300 };
Console.WriteLine($"{b2.Bid}, {b2.Bname} ,{b2.Price}");

*/

/*Student1 s1 = new Student1();

s1.AcceptDetails(101, "Aarti", 60, 50, 79);
s1.CalculatePercentage();
string result = s1.DisplayDetails();

Console.WriteLine(result);*/

/*Employee emp = new Employee(102,"Suja",20000,1000,3000);
emp.CalculateSalary();
Console.WriteLine(emp.Display());


Manager m = new Manager(103 ,"Sumit",30000, 2000,1000,400);
m.CalculateSalary();
Console.WriteLine(m.Display());

Employee e1 = new Manager(104, "Sima", 50000, 2000, 5000, 3000);
e1.CalculateSalary();
Console.WriteLine(e1.Display());*/

/*
Rectangle r = new Rectangle(3,4);
r.CalculateArea();
Console.WriteLine(r.Print());*/

/*Circle c1 = new Circle(5);
c1.CalculateArea();
Console.WriteLine(c1.Print());*/
/*
Shopping s1 = new Shopping();
s1.AddProduct(1, "Shirt", 25, 2);
s1.CalculateTotalBill();
Console.WriteLine(s1.ShowDetail());


Shopping s2 = new Shopping();
s2.AddProduct(2, "Pant", 50, 0);
s2.CalculateTotalBill();
Console.WriteLine(s2.ShowDetail());*/

/*
Console.WriteLine("Manufacturer: " + Car.manufacturer);
Car.CarInfo();


Car myCar = new Car("Camry", 2022);


Console.WriteLine("Model: " + myCar.model);
Console.WriteLine("Year: " + myCar.year);


myCar.Drive();*/


/*ChildClass obj = new ChildClass(10, 20);
int sum = obj.AddNumbers();
Console.WriteLine($"Sum of numbers: {sum}");*/

/*Hashtable ht = new Hashtable();
ht.Add(91, "India");
ht.Add(92, "Pak");
ht.Add(65, "Aus");
ht.Add(1, "Usa");


Console.WriteLine("Hashtable contents:");
foreach (DictionaryEntry entry in ht)
{
    Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
}
*/
/*
SortedList list = new SortedList();

list.Add(106, "Hr");
list.Add(103, "Finance");
list.Add(105, "It");
list.Add(104, "Testing");

foreach (DictionaryEntry item in list) { 
    Console.WriteLine($"{item.Key} -> {item.Value}");
}
*/

/*Person p1 = new Person();
try
{
    p1.AcceptName("");
}
catch (NameException ex)
{
    Console.WriteLine(ex.Message);
}
*/





/*MyCalculater c1 = new MyCalculater();

MyDelegate md = new MyDelegate(c1.Add);
md += new MyDelegate(c1.Mul);
md += new MyDelegate(c1.Sub);

// remove

md -= new MyDelegate(c1.Sub);
 
Delegate[] list = md.GetInvocationList();

foreach (Delegate item in list)
{
    Console.WriteLine(item.Method);
    Console.WriteLine(item.DynamicInvoke(45, 34));
}*/

// this is in case of single cast delete
//int result=mydelegate.Invoke(20, 40);
//Console.WriteLine(result);

