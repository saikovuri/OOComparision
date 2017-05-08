## Inheritance
In object-oriented programming, inheritance enables new objects to take on the properties of existing objects. A class that is used as the basis for inheritance is called a superclass or base class. A class that inherits from a superclass is called a subclass or derived class.
### Java :
In Java, the keyword extends to achieve inheritance. The following code example shows how inheritance is achieved in Java.
```
class A
{
    public void F() {
        System.out.println("A.F");
    }
}

class B extends A
{
    public void G() {
        System.out.println("B.G");
    }
}
class Test
{
    public static void main(String[] args) {
        B b = new B();
        b.F();            // Inherited from A
        b.G();            // Introduced in B

        A a = b;        // Treat a B as an A
        a.F();
    }
}
```
#### Referencing Super class
```
class A
{
    public void F() {
        System.out.println("A.F");
    }
}
class B extends A
{
    public void F() {
        super.F();
        System.out.println("B.F");
    }
}
class Test
{
    public static void main(String[] args) {
        B b = new B();
        b.F();
        A a = b;
        a.F();
    }
}  
```
### C# :
In C#, the symbol : is used to achieve inheritance.
```
<acess-specifier> class <base_class>
{
   ...
}
class <derived_class> : <base_class>
{
   ...
}
```
The following code example shows how inheritance is achieved in C#.
```
class A
{
    public void F() {
        Console.WriteLine("A.F");
    }
}

class B: A
{
    public void G() {
        Console.WriteLine("B.G");
    }
}
class Test
{
    static void Main() {
        B b = new B();
        b.F();            // Inherited from A
        b.G();            // Introduced in B

        A a = b;        // Treat a B as an A
        a.F();
    }
}  
```
#### Referencing Super class
```
class A
{
    public virtual void F() {
        Console.WriteLine("A.F");
    }
}
class B: A
{
    public override void F() {
        base.F();
        Console.WriteLine("B.F");
    }
}
class Test
{
    static void Main() {
        B b = new B();
        b.F();
        A a = b;
        a.F();
    }
}
```  
In the above example, to override the method F() in subclass B, the method F() must be declared virtual in class A.
### Conclusion :
* In C#, methods are not virtual by default. In Java, methods are virtual by default.
* To override a method in c#, the overridden methods should be declared virtual.
* Java and C# do not support Multiple Inheritance.
