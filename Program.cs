﻿﻿System.Console.WriteLine("Enter your name;");
string name = Console.ReadLine();
string greeting = $"Hello, {name}";
System.Console.WriteLine(greeting);

System.Console.Write("Enter your age:");
string ageAsString = Console.ReadLine();
System.Console.WriteLine(ageAsString);
int age = Convert.ToInt32(ageAsString);
System.Console.WriteLine($"Successfully converted! {age}");
int keschasAge = 3;
int ageDifference = age - keschasAge;
System.Console.WriteLine($"The difference between your and Kesche's age is {ageDifference}");

if(age > keschasAge)
{
    System.Console.WriteLine("You are older!");
    
}
else if(age==keschasAge)
{
    System.Console.WriteLine("You are youngar!");

}