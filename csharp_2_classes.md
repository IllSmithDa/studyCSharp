
# Classes 

  1. Classes are the objected oriented nature of C sharp. You can declare clases
     uysing the Class name as the type and the 'new' keyword

    e.g
    class MyClass {};
    MyClass myObj = new MyClass();

      a. created an instance of 'MyClass' using variable 'myObj'

    e.g
    class Car 
    {
      int maxSpeed;
      
        public void fullThrottle()
        {
          Console.WriteLine("The car is going as fast as it can!"); 
        }

      static void Main(string[] args)
      {
        Car myCar = New Car();
        myCar.maxSpeed = 200;
        Console.WriteLine(myCar.maxSpeed);
        myCar.fullThrottle();
      }
    }
  
      a. example show adding properties and defining them in class context

      b. calls the 'fullThrottle method' which is part of the class

    e.g
    class Car
    {
      public string model;

      private string id;

      public Car()
      {
        model = "Mustang";
      }

      static void Main(string[] args)
      {
        Car Ford = new Car();
        Console.WriteLine(Ford.model);
      }
    }

      a. 'public Car()' is the constructor for class 'Car' which will auto define class properties upon creation of an instance which is why you can print property 'model' right away 

      b. private variables cannot be access externally from the instance of class but only within class itself.

  2. You can inherit from a parent class using ':' followed by name of Parent
     class. This will give access to all the 
  
    e.g
    class Car : Vehicle

      a. inherits the class Vehicle including private members though you still cannot access them directly


# Polymorphism and Overriding Methods (also known as method hiding)

  1. Polymorphism means "many forms", and it occurs when we have many classes
     that are related to each other by inheritance
  
    e.g
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

      a. Both 'Dog' and 'Pig' classes are inheriting from 'Animal' class

      b. Note that we are allowed to override the parent class using the child class's version of that method or variable

      b. Method hiding because we are hiding the parent version of the mehod. It is also known as method shadowing

      c. you can access base method by using 'base.animalSound()' in the scope of any of the child classes

      d. Should use Override and virtual keywords to explicit state intent to override this function

  2. With method overloading, multiple methods can have the same name with
     different parameters. It will match the parameters and call the matching
     method 
  
    e.g.
    static int PlusMethod(int x, int y)
    {
      return x + y;
    }

    static double PlusMethod(double x, double y)
    {
      return x + y;
    }

    static void Main(string[] args)
    {
      int myNum1 = PlusMethod(8, 5);
      double myNum2 = PlusMethod(4.3, 6.26);
      Console.WriteLine("Int: " + myNum1);
      Console.WriteLine("Double: " + myNum2);
    }

      a. Two different version of the same method 'PlusMethod()'

# Virtual and Override

  1. In C#, a virtual method is a method that can be overridden in a derived
     class. When a method is declared as virtual in a base class, it allows a
     derived class to provide its own implementation of the method.
  
    e.g 
    public class Animal
    {
      public virtual void MakeSound()
      {
        Console.WriteLine("The animal makes a sound");
      } 
    }
  
  2. In the derived class, the method can be overridden by using the "override"
     keyword in the method declaration.
  
    e.g
    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("The cat meows");
        }
    }


# Access Modifiers in Classes

  1. 'public' means that the code is accessible for all classes

  2. 'private' means that	the code is only accessible within the same class

  3. 'protected' means that the code is accessible within the same class, or in
     a class that is inherited from that class.
  
# 'Abstract' keyword

  1. Abstract class: is a restricted class that cannot be used to create
     objects. You access the class only through inheriting into a child class

    e.g 
    abstract class Animal 
    {
      public void sleep() 
      {
        Console.WriteLine("Zzz");
      }
    }
    class Dog: Animal {}
    Dog myDog = new Dog();
    myDog.sleep();

      a. Class Dog is used to inherit properties like 'sleep()' of class Animal; You cannot create an instance of Animal but you can create an instace of Dog and access Animal class that way

  2. Interfaces are another way to achieve abstaction. To access the interface
     methods, the interface must be implemented by another class. 

    e.g
    // Interface
    interface IAnimal 
    {
      void animalSound(); // interface method (does not have a body)
    }

    // Pig "implements" the IAnimal interface
    class Pig : IAnimal 
    {
      // actually defined here and is implemented by inheriting IAnimal
      public void animalSound() 
      {
        Console.WriteLine("The pig says: wee wee");
      }
    }
    
    Pig myPig = new Pig();  // Create a Pig object
    myPig.animalSound();

      a. Pig class fills the method body while the interface only declares them
    
# 'static' keyword

  1. To create a static member(class, variable, methods, constructor), precede
     its declaration with the keyword static. When a member is declared static,
     it can be accessed with the name of its class directly.
  
  2. Static classes are sealed and therefore cannot be inherited. They cannot
     inherit from any class except Object. 
  
    e.g
    using System;
    static class Tutorial {
        // Static data members of Tutorial
        public static string Topic = "Static class";
    }
    public class GFG {
    
        // Main Method
        static public void Main()
        {
        
            // Accessing the static data members of Tutorial
            Console.WriteLine("Topic name is : {0} ", Tutorial.Topic);
        }
    }

# partial classes

  1. classes can be defined across multiple files using the 'partial' keyword

    e.g
    public partial class Employee
    {
        public void DoWork()
        {
        }
    }

    public partial class Employee
    {
        public void GoToLunch()
        {
        }
    }

  2. Nested types can be partial, even if the type they are nested within is not
     partial itself.
  
    e.g
    class Container
    {
        partial class Nested
        {
            void Test() { }
        }

        partial class Nested
        {
            void Test2() { }
        }
    }

  3. All partial-type definitions meant to be parts of the same type must be
     modified with partial. For example, the following class declarations
     generate an error
  
  4. All partial-type definitions meant to be parts of the same type must be
     defined in the same assembly and the same module (.exe or .dll file).
     Partial definitions cannot span multiple modules.
  
    e.g
    public partial class Coords
    {
        private int x;
        private int y;

        public Coords(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public partial class Coords
    {
        public void PrintCoords()
        {
            Console.WriteLine("Coords: {0},{1}", x, y);
        }
    }

    class TestCoords
    {
        static void Main()
        {
            Coords myCoords = new Coords(10, 15);
            myCoords.PrintCoords();

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
    // Output: Coords: 10,15

# Enums 

  1. An enum is a special "class" that represents a group of constants (unchangeable/read-only variables).

  e.g
  enum Level 
  {
    Low,
    Medium,
    High
  }
  Level myVar = Level.Medium;
  Console.WriteLine(myVar);
