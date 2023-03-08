// See https://aka.ms/new-console-template for more information
using System;

      
namespace HelloWorld
{
      class Animal  // Base class (parent) 
    {
      public virtual void animalSound() 
      {
        Console.WriteLine("The animal makes a sound");
      }
    }

    class Pig : Animal  // Derived class (child) 
    {
      public override void animalSound() 
      {
        Console.WriteLine("The pig says: wee wee");
      }
    }

    class Dog : Animal  // Derived class (child) 
    {
      public override void animalSound() 
      {
        Console.WriteLine("The dog says: bow wow");
      }
    }

  class Program
  {
    enum Level 
    {
      Low,
      Medium,
      High
    }

    static void Main(string[] args)
    {
      // convert double to string
      double piVal = 3.14;
      string piString = Convert.ToString(piVal);
      Console.WriteLine(piString);

      // ask user for age and convert input to integer
      Console.WriteLine("Enter Age");
      int userAge = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Your age is apparently: " + userAge);

      int age = 43;
      age++;
      Console.WriteLine(age);

      int numOfVotes = 10;
      Console.WriteLine(numOfVotes += 10);


      string firstName = "Jon";
      string lastName = "Doe";
      string name = $"My full name is: {firstName} {lastName}";
      string fullName = firstName + " " + lastName;
      Console.WriteLine(fullName);

      string accountName = "John";
      Console.WriteLine(accountName[0]);

      string powerName = "John";
      Console.WriteLine(powerName.Length);
      int x = 50;
      int y = 10;

      if (x == 0) 
      {
        Console.WriteLine("Hello World!");
      }
      else if (x <= y) {
        Console.WriteLine("In World!");
      }
      else
      {
         Console.WriteLine("Bye World!");
      }

      int time = 20;
      string result = (time < 18) ? "Good day." : "Good evening.";
      Console.WriteLine(result);
      Level myVar3 = Level.Medium;
      Console.WriteLine(myVar3);

      Dog myDog = new Dog();
      myDog.animalSound();
      
    }
  }
}
