## Classes

### Java:

#### Defining

* A class can be defined as a template/blueprint that describes the behavior/state that the object of its type support.
* Classes can be defined in Java using the keyword `class`. For example:
```java
public class Dog
 {
   String breed;
   int age;
   String color;
   void barking()
   {
    some code
   }
   void hungry()
   {
     some code
   }
   void sleeping()
   {
     some code
   }
}
```

#### Creating new instances


A class provides the blueprint for objects; we create an object from a class. Some examples are shown below

    * Point originOne = new Point(23, 94);
    * Rectangle rectOne = new Rectangle(originOne, 100, 200);
    * Rectangle rectTwo = new Rectangle(50, 100);

The first line creates an object of the Point class, and the second and third lines each create an object of the Rectangle class.

Each of these statements has three parts:

* Declaration: The code on the left hand side are all variable declarations that associate a variable name with an object type.
* Instantiation: The new keyword is a Java operator that creates the object.
* Initialization: The new operator is followed by a call to a constructor, which initializes the new object.


New instances of the class are created by usual variable declaration syntax. For example:
```java
Dog dogInstance = new Dog();
```

#### Constructing/Initializing

* Instances require a constructor. Every class has an implicit empty default constructor. Explicit default constructor or parameterized constructor can be defined if needed, using access specifier and class name. For example:
```java
public class Animal {
   String type;
   String color;

   // Explicit default constructor
   public Animal() {
     this.type = "Bird";
     this.color = "Blue";
   }

   // Explicit parameterized constructor
   public Animal(String type, String color) {
     this.type = type;
     this.color = color;
   }
}
```

#### Destructing/de-initializing

* **Java's Garbage Collector** requires a call to a class's destructor. Every class has an implicit destructor, which frees all states associated with the class. Explicit destructor can be defined if needed, using access specifier and the class name prefixed with a tilde symbol (~). For example:
```java
public class Animal {
   String type;
   String color;

   // Destructor
   public ~Animal() {
     this.type = null;
     this.color = null;
   }
}
```

###  ``C#``
#### Defining

A class definition starts with the keyword class followed by the class name; and the class body enclosed by a pair of curly braces.
For example:
```cs
public class Customer
{
    //Fields, properties, methods and events go here...
}

```


#### Creating new instances

Class and an object are different things. A class defines a type of object, but it is not an object itself. An object is a concrete entity based on a class, and is sometimes referred to as an instance of a class.

Objects can be created by using the new keyword followed by the name of the class that the object will be based on, like this:

```cs
Customer obj = new Customer();

```

When an instance of a class is created, a reference to the object is passed back to the programmer. In the above example, obj is a reference to an object that is based on Customer. This reference refers to the new object but does not contain the object data itself. In fact, you can create an object reference without creating an object at all:

```cs
Customer object2;
```

#### Constructing/initializing

When a class or struct is created, its constructor is called. Constructors have the same name as the class or struct, and they usually initialize the data members of the new object.

In the below example, a class named Taxi is defined by using a simple constructor. This class is then instantiated with the new operator. The Taxi constructor is invoked by the new operator immediately after memory is allocated for the new object.

```cs
public class Taxi
{
    public bool isInitialized;
    public Taxi()
    {
        isInitialized = true;
    }
}

class TestTaxi
{
    static void Main()
    {
        Taxi t = new Taxi();
        Console.WriteLine(t.isInitialized);
    }
}

```

A constructor that takes no parameters is called a default constructor. Default constructors are invoked whenever an object is instantiated by using the new operator and no arguments are provided to new.


#### Destructing/de-initializing


Destructors in C# are used to destruct instances of classes.

  * Destructors cannot be defined in structs. They are only used with classes.
  * A class can only have one destructor.
  * Destructors cannot be inherited or overloaded.
  * Destructors cannot be called. They are invoked automatically.
  * A destructor does not take modifiers or have parameters.

  Below is an example of declaration of a destructor for the class:

```cs
  class Car
{
    ~Car()  // destructor
    {
        // cleanup statements...
    }
}
```

The destructor implicitly calls Finalize on the base class of the object. Therefore, the above destructor code is implicitly translated to the following code:

```cs
protected override void Finalize()  
{  
    try  
    {  
        // Cleanup statements...  
    }  
    finally  
    {  
        base.Finalize();  
    }  
}  

```

This means that the Finalize method is called recursively for all instances in the inheritance chain, from the most-derived to the least-derived.
