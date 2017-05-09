# Interfaces / protocols

## What does the language support?
### Java:
Java has interfaces.  A class implements an interface, thereby inheriting the abstract methods of the interface.

### C#:
C# supports interfaces.


## What abilities does it have?
### Java:
An interface is a reference type in Java. It is similar to class. It is a collection of abstract methods. Along with abstract methods, an interface may also contain constants, default methods, static methods, and nested types. Method bodies exist only for default methods and static methods. An interface can contain any number of methods.

- We can’t instantiate an interface in java.
- Interface provides complete abstraction as none of its methods can have body. On the other hand, abstract class provides partial abstraction as it can have abstract and concrete(methods with body) methods both
- Interface fields are public, static and final by default, and methods are public and abstract. Following are some of the abilities/properties of java interfaces.
```
interface Try
{
   int a=10;
   public int a=10;
   public static final int a=10;
   final int a=10;
   static int a=0;
}
```
All of the above statements are identical.
- Any interface can extend any interface but cannot implement it. Class implements interface and interface extends interface.
- A class can implement any number of interfaces.
- Variable names conflicts can be resolved by interface name when a class implements multiple interfaces.
- multiple inheritance can be achieved by implementing multiple interfaces.

#### C#:
An interface can inherit from one or more base interfaces. When a base type list contains a base class and interfaces, the base class must come first in the list.
A class that implements an interface can explicitly implement members of that interface. An explicitly implemented member cannot be accessed through a class instance, but only through an instance of the interface.

An interface contains only the signatures of methods, properties, events or indexers. A class or struct that implements the interface must implement the members of the interface that are specified in the interface definition. In the following example, class ImplementationClass must implement a method named SampleMethod that has no parameters and returns void.

```
interface ISampleInterface
{
    void SampleMethod();
}

class ImplementationClass : ISampleInterface
{
    // Explicit interface member implementation:
    void ISampleInterface.SampleMethod()
    {
        // Method implementation.
    }

    static void Main()
    {
        // Declare an interface instance.
        ISampleInterface obj = new ImplementationClass();

        // Call the member.
        obj.SampleMethod();
    }
}

```

**Implementing More Than One Interface:**

Classes can derive from only one class (and if it doesn't explicitly derive from a class, it implicitly derives from Object).

[Click here for sample code that illustrates implementing multiple interfaces](interfaces/multiple_interfaces.cs)

**Casting to an Interface:**
you cannot instantiate an interface directly; that is, you cannot write

```
IStorable isDoc = new IStorable;
```

However, create an instance of the implementing class and then assign that object to a reference to any of the interfaces it implements:

```
Document myDoc = new Document(…);
IStorable myStorable = myDoc;
```

You can read above line as "assign the IStorable-implementing object myDoc to the IStorable reference myStorable." You are now free to use the IStorable reference to access the IStorable methods and properties of the document.

```
myStorable.Status = 0;
myStorable.Read( );
```

**Extending Interfaces:**
You can extend an existing interface to add new methods or members. For example, you might extend ICompressible with a new interface, ILoggedCompressible, which extends the original interface with methods to keep track of the bytes saved.

```
interface ILoggedCompressible : ICompressible
{
    void LogSavedBytes( );
}
```

**Combining Interfaces:**

You can also create new interfaces by combining existing interfaces and optionally adding new methods or properties. For example, you might decide to combine the definitions of IStorable and ICompressible into a new interface called IStorableCompressible. This interface would combine the methods of each of the other two interfaces

```
interface IStorableCompressible : IStorable, ILoggedCompressible
{
    void LogOriginalSize( );
}
```



## How is it used?
### Java
**Declaring Interfaces**: The interface keyword is used to declare an interface. Here is a simple example to declare an interface

```
import java.lang.*;
// Any number of import statements

public interface NameOfInterface {
   // Any number of final, static fields
   // Any number of abstract method declarations\
}
```

An interface is implicitly abstract. Also each method is implicitly abstract and public.

**Implementing Interfaces**: A class implements an interface using the keyword `implements` agreeing to perform the specific behaviors inside the interface. If the class does not implements all the methods of the interface, the class must declare itself as abstract.

Example code:
```
public class MammalInt implements Animal {

   public void eat() {
      System.out.println("Mammal eats");
   }

   public void travel() {
      System.out.println("Mammal travels");
   }

   public int noOfLegs() {
      return 0;
   }

   public static void main(String args[]) {
      MammalInt m = new MammalInt();
      m.eat();
      m.travel();
   }
}
```
**Tag or Marker interface**: An empty interface is known as tag or marker interface. For example Serializable, EventListener, Remote(java.rmi.Remote) are tag interfaces. These interfaces do not have any field and methods in it.

**Nested interfaces**: An interface which is declared inside another interface or class is called nested interface. They are also known as inner interface. For example Entry interface in collections framework is declared inside Map interface, that’s why we don't use it directly, rather we use it as follows: Map.Entry.

#### C#:

**The interface**: This is the contract. By convention, interface names begin with a capital I, so your interface might have a name such as IPrintable. The IPrintable interface might require, among other things, a Print( ) method. This states that any class that wants to implement IPrintable must implement a Print( ) method, but it does not specify how that method works internally. That is up to the designer of the implementing class.

**The implementing class**: This is the class that agrees to the contract described by the interface. For example, Document might be a class that implements IPrintable and thus implements the Print( ) method in whatever way the designer of the Document class thinks is appropriate.

**Implementing an Interface: **

syntax for defining an interface:

[attributes] [access-modifier] interface interface-name [:base-list]
{interface-body}

For example,
```
public class Document : IStorable
{
     public void Read( ) {...}
     public void Write(object obj) {...}
     // ...
}
```

Implementing an interface simply requires implementing all of its properties and methods. Below example illustrates defining and implementing the IStorable interface.

```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_13_1_ _ _ _Implementing_Interface
{
   interface IStorable
   {
       void Read( );
       void Write( object obj );
       int Status { get; set; }
   }

   public class Document : IStorable
   {

       public Document( string s )
      {
         Console.WriteLine( "Creating document with: {0}", s );
      }

#region IStorable

      public void Read( )
      {
         Console.WriteLine( "Executing Document's Read
                             Method for IStorable" );
      }

      public void Write( object o )
      {
         Console.WriteLine( "Executing Document's Write
                             Method for IStorable" );
      }

      // property required by IStorable
      public int Status { get; set;}

#endregion

   }

   class Tester
   {
      public void Run( )
      {
         Document doc = new Document( "Test Document" );
         doc.Status = -1;
         doc.Read( );
         Console.WriteLine( "Document Status: {0}", doc.Status );
      }

      static void Main( )
      {
         Tester t = new Tester( );
         t.Run( );
      }
   }
}
```

The output looks like this:

Creating document with: Test Document

Executing Document's Read Method for IStorable

Document Status: -1

[Click here for a sample piece of code that illustrates implementing interfaces](interfaces/interfaces.cs)



Refrences:
1. http://beginnersbook.com/2013/05/java-interface/
2.  https://www.tutorialspoint.com/java/java_interfaces.htm
3. https://msdn.microsoft.com/en-us/library/orm-9780596521066-01-13.aspx
4. https://docs.microsoft.com/en-us/dotnet/articles/csharp/programming-guide/interfaces/index
5. https://www.tutorialspoint.com/csharp/csharp_interfaces.htm
