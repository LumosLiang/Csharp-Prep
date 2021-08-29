﻿

# Introduction C# and .Net

## .Net Concept

.net core VS. net framework VS .net standard VS .net SDK


My understanding:
- .Net core is cross-platform, open-source, CLI(common line) supported
- .Net framework is mainly target for windows OS and web development
- .Net standrad is a interface, a wider, more common library definition. .Net core and .Net framework are the implemetation of .Net library.

"In short: to achieve maximum portability, make your library target .NET Standard."

ref:

https://www.c-sharpcorner.com/article/net-framework-vs-net-core-vs-net-standard/
https://stackoverflow.com/questions/38063837/whats-the-difference-between-net-core-net-framework-and-xamarin
https://stackoverflow.com/questions/57720865/dot-net-framework-vs-dot-net-core-sdk
https://stackoverflow.com/questions/44085424/net-standard-vs-net-core
https://gist.github.com/davidfowl/8939f305567e1755412d6dc0b8baf1b7


## .Net component

- .Net = CLR + FCL, + compiler, so complier is not part of .Net I guess.

### Some terms

- CLR - common language runtime -> Runtime, a virtual machine.
- FCL - Framework class library -> library
- BCL - Base Class library, BCL is includedd in the FCL
- IL - Inmediate language
- CLS - Common language Specifications
- CTS - Common language Type

My understanding: 
- CLR is the virtual machine, that being responsible for executing code with JIT compliers, managing memory,
handling exceptions, debugging, collecting garbage, supporting threads, etc. CLR can of course run other language's IL.
- FCL is the library, that includes the implementations ASP.Net, ADO.Net. etc. 
- BCL is just like the name defines, the very base library, used to define basic fundamental types like System.string.
- IL is the immediate language, which is being complied during compling the source code of the .Net based source code
- CLS: CLS is includes in the CTS

Ref:

https://stackoverflow.com/questions/807880/bcl-base-class-library-vs-fcl-framework-class-library
https://www.linkedin.com/pulse/what-ctscls-fcl-bcl-crl-net-framework-pawan-verma
https://www.cnblogs.com/eshizhan/archive/2010/01/26/1657041.html


## .net complie 

### Complier:
- csc.exe - the obsolete complier
- roslyn, - the complier API

ref:

https://www.cnblogs.com/chucklu/p/11300738.html

### process

C# source code -> complier-> CIL(dll, exe) -> CLR
 
ref:

https://zhuanlan.zhihu.com/p/37146324
https://www.cnblogs.com/May-day/p/6594574.html

## command line

cmd dotnet

dotnet --info
dotnet --help
dotnet --new


## .net project in IDE

### how complier, CLR, language packed in the IDE

### how do I know my langauge version, 

### how do I know CLR version, 

###  how do I know the complier I am using


### project folder

- .csproj --> c# project
- bin
- obj

## .Net's packages -> nuget

.net run - what happen after .net run
- .net restore: restore all the packages
- .net build

## Managed Code VS Unmanaged Code

**Managed Code**

- Managed code is the code that is developed using the .NET framework and its supported programming languages such as C# or VB.NET. 
- Managed code is directly executed by the Common Language Runtime (CLR or Runtime) and its lifecycle including object creation, 
memory allocation, and object disposal is managed by the Runtime. 
- Any language that is written in .NET Framework is managed code.
 
**Unmanaged Code**
 
- The code that is developed outside of the .NET framework is known as unmanaged code. 
- “Applications that do not run under the control of the CLR are said to be unmanaged. 
- Languages such as C or C++ or Visual Basic are unmanaged.
- The object creation, execution, and disposal of unmanaged code is directly managed by the programmers.If programmers write bad code, it may lead to memory leaks and unwanted resource allocations.”
 
The .NET Framework provides a mechanism for unmanaged code to be used in managed code and vice versa. The process is done with the help of wrapper classes.

**PDB, dll, exe, debug**

# C# Syntax

## main() method
- The Main method is the entry point of the C# application.
- Library and Service Does not require a Main method as an entry point
- There can only be one entry point in a C# program
- The Main method can be declared with or without a string[] parameter that contains **command-line arguments**.
- Main must be static and it need not be public. 
ref:

https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/program-structure/main-command-line

## data type $ variable declarision

- sbyte, byte
- short, int, long
- float
- double
- char
- string 
- implcity typing -> var. implcit type varible must be initialized

## Varibles: Reference Types and Value Types

### concept

The reference type varible holds a reference to the object

    var b = new Book("Grades");

Anytime you are working with the Class, or writing a Class or using a class, the class provided by .Net or Nuget packages,
You are using what is Known as the reference type.

The value type varible holds itself


    var b = 3;

When you work with Int, float, doubles..., you are working with the value type

A method to differentiate a valye type object and a reference type object is to check it is a struct or a class

string is reference type, but it act like a value type 

### struct and class

**Struct**
- The struct is a value type in C# and it inherits from System.Value Type.
- Struct is usually used for smaller amounts of data.
- Struct can’t be inherited from other types ?? so struct can inherit others, but it can't be inherited by others.
- A structure can't be abstract.
- No need to create an object with a **new** keyword.
- Do not have permission to create any default constructor.

**Class**
- The class is a reference type in C# and it inherits from the System.Object Type.
- Classes are usually used for large amounts of data.
- Classes can be inherited from other classes.
- A class can be an abstract type.
- We can create a default constructor.

### Pass by reference and Pass by value and ref/out

See demo

### boxing and unboxing

Boxing and Unboxing both are used for type conversions.
 
The process of converting from a value type to a reference type is called boxing. 
Boxing is an implicit conversion. 

Why do we need boxing and unboxing?


### ref:
https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-types
https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/out-parameter-modifier
https://www.c-sharpcorner.com/UploadFile/ff2f08/ref-vs-out-keywords-in-C-Sharp/ 
https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/structs
https://stackoverflow.com/questions/2111857/why-do-we-need-boxing-and-unboxing-in-c


## array initialization

    float[] numbers = new float[3];
    float[] numbers = new float[3]{1.1,2.2,3.3};
    float[] numbers = new float[]{1.1,2.2,3.3};
    var numbers = new[]{1,2,3,4};

## Generics



### List

    List<int> numbers = new List<int>();
    var numbers = new List<double>(){1.1, 1.2, 1.3};

The Parentheses --> ? 


## flow control

### foreach

    foreach(float number in numbers)
    {
    }

    foreach(int i = 0, i < numbers.Length, i++)
    {
    }

### do while

### Switch, Case

### Continue, Break


# Classes

    Class Name
    {
        # state

        # behavior
    }

- Class should be in a namespace, otherwise it will be in the global namespace, but this is dangerous
- One Class per file.

## Class Basics

### defining a method


    Class Name
    {
        # state

        # behavior
        public void AddGrade(double grade)
        {
        }
    }

#### method overloading



### defining a field


    Class Name
    {
        # state
        List<double> grades        

        # behavior
        public void AddGrade(double grade)
        {
            # local variable
            # List<double> grades;
            grades.Add(grade)
        }
    }



### class field initilization

this

### Constructors

```<C#>
Class Name
{
    # state
    List<double> grades;     
        
    # constructor method
    public book()
    {
        grades = new List<double>();
    }
           

    # behavior
    public void AddGrade(double grade)
    {
        # local variable
        # List<double> grades;
        grades.Add(grade)
    }
}
```


## C# Class Charcteristics

C# is of course Object-Oriented programming language, which have that three main charateristics:
- Encapsulation:
  - try to do not repeat implementations. But 
- Polymorphism
- Inheritance

C# has memebers such as fields, methods, properties, events.

### Properties: getter and setter

### access modifiers
- public 
- private
- internal
- protected

### readonly, constant 

### delegate

### Event   



## C# Class OOP, from the logic perspective

### Inheritance, overriding

### Constructor Chain

### Abstract

**Concept**
- The abstract modifier indicates that the thing being modified has a missing or incomplete implementation. 
- The abstract modifier can be used with classes, methods, properties, indexers, and events. 
- Use the abstract modifier in a class declaration to indicate that a class is intended only to be a base class of other classes, not instantiated on its own. 
- Members marked as abstract must be implemented by non-abstract classes that derive from the abstract class.

**Abstract Class feature**

- Cannot be instantiated
- An abstract class may contain abstract methods and accessors, so abstract class can have actual implementation for method
- A non-abstract class derived from an abstract class must include actual implementations of all inherited abstract methods and accessors.
- Abstract 

**Abstract method feature**
- Abstract method declarations are only permitted in abstract classes.
- It is an error to use the static or virtual modifiers in an abstract method declaration

**Abstract properties feature**
- It is an error to use the abstract modifier on a static property.
- An abstract inherited property can be overridden in a derived class by including a property declaration that uses the override modifier

### Interface



### Abstract VS Interface
