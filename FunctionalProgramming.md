## Functional Programming
In computer science, functional programming is a programming paradigm—a style of building the structure and elements of computer programs—that treats computation as the evaluation of mathematical functions and avoids changing-state and mutable data.

|Fucntional Programming| Java | C# |
|----------------------|:----:|:--:|
|Method References|Yes|Yes|
|Closures|All lambdas do not introduce a new level of scope. All referenced variables must be effectively final|Yes|
|Lambda Expressions|Yes (Java 8)|Yes|
|Expression Trees|No|Yes|
|Generic Query Language|No|Yes|
|Tail recursion compiler optimizations|No|only in x64|

### Closures
* A closure is an inline function that captures variables from its lexical scope.
* C# supports closures as anonymous methods or lambda expressions with full-featured closure semantics.
* In Java, anonymous inner classes will remain the preferred way to emulate closures until Java 8 has become the new standard. This is a more verbose construction. This approach also has some differences compared to real closures, notably more controlled access to variables from the enclosing scopes: only final members can be referenced. Java 8, however introduces lambdas that fully inherit the current scope and, in fact, do not introduce a new scope.
* When a reference to a method can be passed around for later execution, a problem arises about what to do when the method has references to variables/parameters in its lexical scope. C# closures can access any variable/parameter from its lexical scope. In Java's anonymous inner classes, only references to final members of the lexical scope are allowed, thus requiring the developer to mark which variables to make available, and in what state (possibly requiring boxing).

### Lambdas and Expression Trees
* C# and Java feature a special type of in-line closures called lambdas. These are anonymous methods: they have a signature and a body, but no name. They are mainly used to specify local function-valued arguments in calls to other methods, a technique mainly associated with functional programming.
* C#, unlike Java, allows the use of lambda functions as a way to define special data structures called expression trees. Whether they are seen as an executable function or as a data structure depends on compiler type inference and what type of variable or parameter they are assigned or cast to. Lambdas and expression trees play key roles in Language Integrated Query (LINQ)

### Lambda Expressions
#### Java :
Lambda expressions provide a clear and concise way to represent one method interface using an expression. Lambda expressions also improve the Collection libraries making it easier to iterate through, filter, and extract data from a Collection. In addition, new concurrency features improve performance in multicore environments.

Lambda expressions address the bulkiness of anonymous inner classes by converting multiple lines of code into a single statement. This simple horizontal solution solves the "vertical problem" presented by inner classes.
A lambda expression is composed of three parts

|Argument List| Arrow Token | Body |
|----------------------|:----:|:--:|
|(int x, int y)|->| x + y|

The body can be either a single expression or a statement block. In the expression form, the body is simply evaluated and returned. In the block form, the body is evaluated like a method body and a return statement returns control to the caller of the anonymous method. The break and continue keywords are illegal at the top level, but are permitted within loops. If the body produces a result, every control path must return something or throw an exception.
##### Runnable Lambda
```
public class RunnableTest {
   public static void main(String[] args) {

     System.out.println("=== RunnableTest ===");

     // Anonymous Runnable
     Runnable r1 = new Runnable(){

       @Override
       public void run(){
         System.out.println("Hello world one!");
       }
     };

     // Lambda Runnable
     Runnable r2 = () -> System.out.println("Hello world two!");

     // Run em!
     r1.run();
     r2.run();

   }
 }
```
##### Comparator Lambda
```
public class ComparatorTest {

   public static void main(String[] args) {

     List<Person> personList = Person.createShortList();

     // Sort with Inner Class
     Collections.sort(personList, new Comparator<Person>(){
       public int compare(Person p1, Person p2){
         return p1.getSurName().compareTo(p2.getSurName());
       }
     });

     System.out.println("=== Sorted Asc SurName ===");
     for(Person p:personList){
       p.printName();
     }

     // Use Lambda instead

     // Print Asc
     System.out.println("=== Sorted Asc SurName ===");
     Collections.sort(personList, (Person p1, Person p2) -> p1.getSurName().compareTo(p2.getSurName()));

     for(Person p:personList){
       p.printName();
     }

     // Print Desc
     System.out.println("=== Sorted Desc SurName ===");
     Collections.sort(personList, (p1,  p2) -> p2.getSurName().compareTo(p1.getSurName()));

     for(Person p:personList){
       p.printName();
     }

   }
 }
```
#### C# :
A lambda expression is an anonymous function that you can use to create delegates or expression tree types. By using lambda expressions, you can write local functions that can be passed as arguments or returned as the value of function calls. Lambda expressions are particularly helpful for writing LINQ query expressions
To create a lambda expression, you specify input parameters (if any) on the left side of the lambda operator =>, and you put the expression or statement block on the other side. For example, the lambda expression x => x * x specifies a parameter that’s named x and returns the value of x squared. You can assign this expression to a delegate type, as the following example shows:
```
delegate int del(int i);  
static void Main(string[] args)  
{  
    del myDelegate = x => x * x;  
    int j = myDelegate(5); //j = 25  
}  
```
To create an expression tree type
```
using System.Linq.Expressions;  

namespace ConsoleApplication1  
{  
    class Program  
    {  
        static void Main(string[] args)  
        {  
            Expression<del> myET = x => x * x;  
        }  
    }  
}
```

You can easily create lambda expressions and statements that incorporate asynchronous processing by using the async and await keywords
```
public partial class Form1 : Form  
{  
    public Form1()  
    {  
        InitializeComponent();  
    }  

    private async void button1_Click(object sender, EventArgs e)  
    {  
        // ExampleMethodAsync returns a Task.  
        await ExampleMethodAsync();  
        textBox1.Text += "\r\nControl returned to Click event handler.\n";  
    }  

    async Task ExampleMethodAsync()  
    {  
        // The following line simulates a task-returning asynchronous process.  
        await Task.Delay(1000);  
    }  
}  
```
You can add the same event handler by using an async lambda. To add this handler, add an async modifier before the lambda parameter list
```
public partial class Form1 : Form  
{  
    public Form1()  
    {  
        InitializeComponent();  
        button1.Click += async (sender, e) =>  
        {  
            // ExampleMethodAsync returns a Task.  
            await ExampleMethodAsync();  
            textBox1.Text += "\nControl returned to Click event handler.\n";  
        };  
    }  

    async Task ExampleMethodAsync()  
    {  
        // The following line simulates a task-returning asynchronous process.  
        await Task.Delay(1000);  
    }  
}  
```
