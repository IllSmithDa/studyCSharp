# Installation for VS Code 

  1. Download the .NET Sdk to get the cli

    a. https://dotnet.microsoft.com/en-us/download

  2. Once downloaded, you can check if installation as well version that was
     successful, by going to command terminal and 'dotnet --version'

  3. Quickest way to create project is to use command 'dotnet new console -o
     sample-proj'
  
  4. use command 'dotnet run' to run your app

# Debugging .Net

  1. Debug .Net application requires the C# offical microsoft extension.

  2. use the command paleate  using 'ctrl' 'shift' 'p'

  3. Search '.NET Generate Assets for Build and Debug'

  4. Find And Debug on the Left panel of VS Code, will open a menu with
     'Variables', 'Watch' and 'Call Stack' 

  5. You can set breakpoints 'red dot' and then click play button on top to run
     app in debug node 

# Compile Code 

  1. Use command 'dotnet build' which will create the bin folder with your built
     application

# Using console logs

  1. use 'Console.WriteLine("Hello World!");'

# Writing Comments

  1. Exactly as same as JavaScript

    e.g
    // this is a single line comment

    e.g
    /* 
      This is a multi
      line comment
    */

# Initializing Variables and Variable Types

  1. Has standard types 

    a. int - whole number values

    b. double - decimal values, floating point numbers

    c. string - text and characters and must use double qoutes

    d. bool - true or false

    e. char - single charcter

  2. Variable examples

    e.g
    int myNum = 50;

  3. comma seprated list initialization for variables of same type

    e.g
    int x = 6, y = 4, z = 4;

# Data conversion

  1. Similar to JavaScript, you can convert data types using in built functions

  2. The 'Convert' methods will convert types explicitly and includes
     'Convert.ToBoolean()', 'Convert.ToDouble()', 'Convert.ToInt32()',
     'Convert.ToInt64()','Convert.ToString()', 

    e.g
    double myDouble = 5.25
  
    int convertedVal = Convert.ToInt32(myDouble)

# Read User Input

  1. Use Command 'Console.ReadLine()' to read user input which can also be typed
     using a variable 

    e.g
    Console.WriteLine("Enter Age")
    
    int userAge = Convert.ToInt32(Console.ReadLine());

      a. This saves user input age into a integer variable 'userAge'. We use 'ToInt32' because it will save as a string by default 

    Console.WriteLine("Your age is apparently: " + userAge);

      b. We can write the age on the log and even concatenate a string with a integer for a complete statement

# You can perform mathematical operations like in other languages 

  1. Addition '+', subtraction '-', multiplication '*' and division '/'

  2. You can use the '++' or '--' operator to increase or decrease value by one

    e.g 
    int age = 43;
    Console.WriteLine(age++);

      a. Will still print 43 because '++' afer the variable the '++' occurs after the 'Console.WriteLine()'' operation

    e.g
    int age = 43;
    age++;
    Console.WriteLine(age);

      b. '++' operation now happens before the 'Console.WriteLine()' operation and so it will print 44 as expected

    e.g
    int age = 43;
    Console.WriteLine(++age);

      c. Alternatively we can add '++' before variable name to also ensure that '++' occurs before the 'Console.WriteLine()' operation 

  3. You can also using addition assignment operation to add particular value to
     your variable 

    e.g
    int numOfVotes = 10;
    numVotes += 1;
    Console.WriteLine(numVotes);

      a. prints out 11;

    e.g
    int numOfVotes = 10;
    numVotes += 5;
    Console.WriteLine(numVotes);
  
      a. prints out 15

    e.g
    int numOfVotes = 10;
    Console.WriteLine(numVotes += 10);

      a. operation occurs before Console.WriteLine() so it will print out 20

4. In built 'Math' methods also exists

  1. Include 'Math.Max(x, y);',  'Math.min(x, y);', 'Math.Sqrt(x);', 'Math.Abs(x);'
     and Math.Roudn();'

# Strings

  1. You can add string together

    e.g
    string firstName = 'Jon';
    string lastName = 'Doe';
    string fullName = firstName + " " + lastName;

  2. You can use string interpolation

    e.g
    string firstName = "Jon";
    string lastName = "Doe";
    string name = $"My full name is: {firstName} {lastName}";
    Console.WriteLine(name);

  3. You can access string characters similar to retrieving array indexes from 0
     to maxlength of string - 1

    e.g
    string accountName = "John";
    Console.WriteLine(accountName[0]);

      a. returns 'J'
  
  4. Length of String use '.Length';

    e.g
    string powerName = "John";
    Console.WriteLine(powerName.Length);

      a. returns the string length which should be 4

  5. Uppercase and LowerCase

    a. use .ToUpper() and .ToLower() to change text casing 

# If and else

  1. Like other languages, you can use if else statements include '>', '<',
  '<=', '>=' and '=='

    e.g
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

  2. You can also ternary operators like in JavaScript using '()' to enclose the
     comparision and left hand of ':' being true and right hand of ':' being
     false 

    e.g
    int time = 20;
    string result = (time < 18) ? "Good day." : "Good evening.";
    Console.WriteLine(result);

      a. print out the false statement on the right hand side which is 'Good Evening'
  
# Switch Statement

  1. You can do swtich statements in C# including default cases 

    e.g
    int day = 2;
    switch (day) 
    {  
      case 1:
        Console.WriteLine("Monday");
        break;
      case 2:
        Console.WriteLine("Tuesday");
        break;
      default:
        Console.WriteLine("Probably Weekend")
    }

# Array declarations and initialization

  1. works very similar to TypeScript array initialization by declaring variable
     type followed by '[]'. You do use curly braces '{}' for the actual array
     unlike JavaScript which use '[]'

    e.g 
    string[] cars = { "volvo", "mazda", "ford", "toyota"};

  2. You can use for loops or foreach method to iterate throught the array 

    e.g
    string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
  
    foreach (string car in cars) 
    {
      Console.WriteLine(car);
    }
  
  3. You can also sort arrays unsing inbuilt method 'Array.Sort(arraryName)'

  4. You can use for loops 
    
    e.g
    for (int i = 0; i < 6; i++) {
      Console.WriteLine(i);
    }

  5. You can also use while loops 

    int i = -2;
    while(i < 6) {
      Console.WriteLine(i);
      i++
    }

# Methods

  1. You can call methods from main methods as demonstrated below

    static void MyMethod() 
    {
      Console.WriteLine("I just got executed!");
    }

    static void Main(string[] args)
    {
      MyMethod ();
    }

      a. note that void means the function does not return anything

  2. You can pass arguments in functions by declaring variable type followed by
     variable reference name

    e.g
    static void MyMethod(string fname) 
    {
      Console.WriteLine(fname + " Refsnes");
    }

    static void Main(string[] args)
    {
      MyMethod("Liam");
      MyMethod("Jenny");
      MyMethod("Anja");
    }

      a. The argument passed into the 'MyMethod()' is be referred to by the parameter variable name 'fname'

  3. While using 'void' means that method doesn't return at all, adding a
     variable type will enforce the method to return that declared type or
     face errors 

    e.g
    static int MyMethod(int x) 
    {
      return 5 + x;
    }

      a. method must return an integer because keyword 'int' before method name
      
# Exception Handling

  1. You can use try and catch to handle and catch errors

    e.g
    try
    {
      int[] myNumbers = {1, 2, 3};
      Console.WriteLine(myNumbers[10]);
    }
    catch (Exception e)
    {
      Console.WriteLine(e.Message);
    }
    finally
    {
      Console.WriteLine("The 'try catch' is finished.");
    }

      a. 'e' here is of type object 'Exception' which has a Message proeprty 

      b. The finally statement lets you execute code, after try...catch, regardless of the resul

# File Handling

  1. The File class from the System.IO namespace, allows us to work with files:

    e.g
    using System.IO;  // include the System.IO namespace

    File.SomeFileMethod();  // use the file class with methods

  2. List of Methods

    a. AppendText() -	Appends text at the end of an existing file
    
    b. Copy() -	Copies a file
    
    c. Create()	- Creates or overwrites a file
    
    d. Delete()	- Deletes a file
    
    e. Exists()	- Tests whether the file exists
    
    f. ReadAllText() - Reads the contents of a file
    
    g. Replace() -	Replaces the contents of a file with the contents of another file
    
    h. WriteAllText() -	Creates a new file and writes the contents to it. If the file already exists, it will be overwritten.