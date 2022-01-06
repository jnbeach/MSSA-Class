// See https://aka.ms/new-console-template for more information

#region Module1
//Module 1 Challenge
// Console.WriteLine("Hello, World!");

// double firstNum, secondNum, sum;

// Console.Write("Introduce first number: ");
// firstNum = getEvenNum();

// Console.Write("Introduce second number: ");
// secondNum = getEvenNum();

// sum = firstNum + secondNum;

// Console.WriteLine("The sum of {0} and {1} is {2}", firstNum, secondNum, sum);
// static double getEvenNum()
// {
//     double num = Convert.ToDouble(Console.ReadLine());
//     if (num % 2 == 0)
//     {
//         return num;
//     }
//     else
//     {
//         Console.WriteLine("Please input an even number.");
//         return getEvenNum();
//     }
// }
#endregion
#region Module2
//Module 2 Exercise 1
// int[] array = new int[5] { 1, 4, 2, 3, 5 };
// Console.WriteLine("---Default Array Elements---");
// foreach (int num in array)
// {
//     Console.WriteLine(num);
// }

// Array.Sort(array);
// Console.WriteLine("---Elements After Sort---");
// foreach (int num in array)
// {
//     Console.WriteLine(num);
// }

// Array.Reverse(array);
// Console.WriteLine("---Elements After Sort---");
// foreach (int num in array)
// {
//     Console.WriteLine(num);
// }

// //Module 2 Exercise 2 Challenge
// string[] arr = new string[5];
// string name;
// Console.Write("\n\nModule 2: Challenge\n");
// Console.Write("-----------------------------------------\n");
// Console.Write("Input 5 names into this array :\n");
// for (int i = 0; i < 5; i++)
// {
//     Console.Write("element - {0} : ", i);
//     arr[i] = Console.ReadLine();
// }
// Console.WriteLine("I will now display all the names plus the 2nd name.\n");
// for (int i = 0; i < 5; i++)
// {
//     Console.WriteLine($"{arr[i]} {arr[1]}");
// }
// Console.WriteLine($" ");
#endregion
#region Module3
//Module 3 Challenge

// Console.Clear();
// Console.WriteLine($"Let's make a list");
// Console.WriteLine($"Input some items into the list. Press 'x' to exit.");
// string userInput1 = "";
// List<string> itemList = new List<string>();
// while (userInput1 != "x")
// {
//     userInput1 = Console.ReadLine();
//     if (userInput1 != "x") itemList.Add(userInput1);
// }
// Console.WriteLine($"Your list is now:");
// foreach (string item in itemList)
// {
//     Console.WriteLine($"{item}");
// }

// Console.WriteLine($"Would you like to add items to the list? ");
// string userInput2 = "";
// int addIndex = 0;
// while (userInput2 != "x" && addIndex != -1)
// {
//     Console.WriteLine($"Add an item to the list. Press 'x' to cancel.");
//     Console.WriteLine($"What would you like to add?");
//     userInput2 = Console.ReadLine();
//     if (userInput2 != "x")
//     {
//         Console.WriteLine($"Where would you like to add it?");
//         if (addIndex > -1 && addIndex < itemList.Count)
//         {
//             addIndex = Convert.ToInt32(Console.ReadLine());
//         }
//         else
//         {
//             addIndex = 0;
//         }
//         itemList.Insert(addIndex, userInput2);
//     }
// }
// Console.WriteLine($"Your final list is:");
// foreach (string item in itemList)
// {
//     Console.WriteLine($"{item}");
// }
#endregion
#region Module4
//Module 4
// int total = 3;
// Person[] persons = new Person[total];
// for (int i = 0; i < total; i++)
// {
//     persons[i] = new Person(Console.ReadLine());
// }
// for (int i = 0; i < total; i++)
// {
//     Console.WriteLine(persons[i].ToString());
// }

// public class Person
// {
//     public string Name { get; set; }
//     public Person(string name)
//     {
//         Name = name;
//     }
//     public string ToString()
//     {
//         return "Hello! My name is " + Name;
//     }
//     ~Person()
//     {
//         Name = string.Empty;
//     }
// }
#endregion
#region Module5Ex1&2
// Console.WriteLine("Hierarchical inheritance");
// B obj1 = new B();
// C obj2 = new C();
// Console.WriteLine("Using class B object (obj1)");
// Console.WriteLine(obj1.a);
// Console.WriteLine(obj1.b);
// Console.WriteLine("Using class C object (obj2)");
// Console.WriteLine(obj2.a);
// Console.WriteLine(obj2.c);
// class A
// {
//     public int a;
//     public A()
//     {
//         a = 10;
//     }
// }
// class B : A
// {
//     public int b;
//     public B()
//     {
//         b = 7;
//     }
// }
// class C : A
// {
//     public int c;
//     public C()
//     {
//         c = 23;
//     }
// }
#endregion
#region Module5Ex3

// Animal myAnimal = new Animal(); Animal myPig = new Pig(); Animal myDog = new Dog(); myAnimal.animalSound();
// myPig.animalSound();
// myDog.animalSound();
// class Animal
// {
//     public virtual void animalSound()
//     {
//         Console.WriteLine("The animal makes a sound");
//     }
// }
// class Pig : Animal
// {
//     public override void animalSound()
//     {
//         Console.WriteLine("The pig says: wee wee");
//     }
// }
// class Dog : Animal
// {
//     public override void animalSound()
//     {
//         Console.WriteLine("The dog says: bow wow");
//     }
// }
#endregion
#region Module6

// string path = @"./Test.txt";

// if (!File.Exists(path))
// {
//     using (StreamWriter sw = File.CreateText(path))
//     {
//         sw.WriteLine("Test1 - There");
//         sw.WriteLine("Test2 - Was");
//         sw.WriteLine("Test3 - No File Here");
//     }
// }

// using (StreamReader sr = File.OpenText(path))
// {
//     string s;
//     while ((s = sr.ReadLine()) != null)
//     {
//         Console.WriteLine(s);
//     }
// }
#endregion
#region Module7

List<int> integerList = new List<int>()
{
1, 2, 3, 4, 5, 6, 7, 8, 9, 10
};

var QuerySyntax = from num in integerList
                  where num > 5
                  select num;

foreach (var item in QuerySyntax)
{
    Console.WriteLine(item);
}

#endregion