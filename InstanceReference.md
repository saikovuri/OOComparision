## Instance Reference
### Java :
Within an instance method or a constructor, this is a reference to the current object. The object whose method or constructor is being called.
```
public class Point {
    public int x = 0;
    public int y = 0;

    //constructor
    public Point(int a, int b) {
        x = a;
        y = b;
    }
}
```
The above set of lines can be written as
```
public class Point {
    public int x = 0;
    public int y = 0;

    //constructor
    public Point(int x, int y) {
        this.x = x;
        this.y = y;
    }
}
```
#### Using this with a Constructor
From within a constructor, you can also use the this keyword to call another constructor in the same class. Doing so is called an explicit constructor invocation
```
public class Rectangle {
    private int x, y;
    private int width, height;

    public Rectangle() {
        this(0, 0, 1, 1);
    }
    public Rectangle(int width, int height) {
        this(0, 0, width, height);
    }
    public Rectangle(int x, int y, int width, int height) {
        this.x = x;
        this.y = y;
        this.width = width;
        this.height = height;
    }
    ...
}
```
### C# :
The this keyword refers to the current instance of the class and is also used as a modifier of the first parameter of an extension method
The following are the common uses of this keyword
* To qualify members hidden by similar names
```
public Employee(string name, string alias)
{
    // Use this to qualify the fields, name and alias:
    this.name = name;
    this.alias = alias;
}
```
* To pass an object as a parameter to other methods
```
CalculateSomething(this);
```
* To declare indexers
```
public int this[int param]
{
    get { return array[param]; }
    set { array[param] = value; }
}
```

The following example shows the implementation of this keyword
```
class Employee
{
    private string name;
    private string alias;
    private decimal salary = 3000.00m;

    // Constructor:
    public Employee(string name, string alias)
    {
        // Use this to qualify the fields, name and alias:
        this.name = name;
        this.alias = alias;
    }
    // Printing method:
    public void printEmployee()
    {
        Console.WriteLine("Name: {0}\nAlias: {1}", name, alias);
        // Passing the object to the CalcTax method by using this:
        Console.WriteLine("Taxes: {0:C}", Tax.CalcTax(this));
    }

    public decimal Salary
    {
        get { return salary; }
    }
}

class Tax
{
    public static decimal CalcTax(Employee E)
    {
        return 0.08m * E.Salary;
    }
}

class MainClass
{
    static void Main()
    {
        // Create objects:
        Employee E1 = new Employee("Mingda Pan", "mpan");

        // Display results:
        E1.printEmployee();
    }
}
/*
Output:
    Name: Mingda Pan
    Alias: mpan
    Taxes: $240.00
 */
```
In the above example, this is used to qualify the Employee class members, name and alias, which are hidden by similar names. It is also used to pass an object to the method CalcTax, which belongs to another class

** This keyword can be used to prevent Instance variable hiding. **
