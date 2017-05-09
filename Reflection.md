## Reflection

The name reflection is used to describe code which is able to inspect other code in the same system (or itself).

### Java:

Reflection is commonly used by programs which require the ability to examine or modify the runtime behavior of applications running in the Java virtual machine.

This is a relatively advanced feature and should be used only by developers who have a strong grasp of the fundamentals of the language. With that caveat in mind, reflection is a powerful technique and can enable applications to perform operations which would otherwise be impossible.

For example, say we have an object of an unknown type in Java, and we would like to call a 'doSomething' method on it if one exists. Java's static typing system isn't really designed to support this unless the object conforms to a known interface, but using reflection, your code can look at the object and find out if it has a method called 'doSomething' and then call it if you want to.

Code example of this in Java (imagine the object is foo) :

```Java
Method method = foo.getClass().getMethod("doSomething", null);
method.invoke(foo, null);

```

#### Why do we need reflection?

Reflection enables us to:
  * Examine an object's class at runtime
  * Construct an object for a class at runtime
  * Examine a class's field and method at runtime
  * Invoke any method of an object at runtime
  * Change accessibility flag of Constructor, Method and Field etc.
  * Reflection is the common approach of framework.

One very common use case in Java is the usage with annotations. JUnit 4, will use reflection to look through your classes for methods tagged with the @Test annotation, and will then call them when running the unit test.

#### How to use reflection?

How to use reflection API can be shown by using a small set of typical code examples.


Example 1: Get class name from object


 ```Java
 package myreflection;
 import java.lang.reflect.Method;

 public class ReflectionHelloWorld {
 	public static void main(String[] args){
 		Foo f = new Foo();
 		System.out.println(f.getClass().getName());			
 	}
 }

 class Foo {
 	public void print() {
 		System.out.println("abc");
 	}
}y
 ```
Example 2: Invoke method on unknown object

```Java
package myreflection;
import java.lang.reflect.Method;

public class ReflectionHelloWorld {
	public static void main(String[] args){
		Foo f = new Foo();

		Method method;
		try {
			method = f.getClass().getMethod("print", new Class<?>[0]);
			method.invoke(f);
		} catch (Exception e) {
			e.printStackTrace();
		}			
	}
}

class Foo {
	public void print() {
		System.out.println("abc");
	}
}
```

Example 3: Create object from Class instance

```Java
package myreflection;

public class ReflectionHelloWorld {
	public static void main(String[] args){
		//create instance of "Class"
		Class<?> c = null;
		try{
			c=Class.forName("myreflection.Foo");
		}catch(Exception e){
			e.printStackTrace();
		}

		//create instance of "Foo"
		Foo f = null;

		try {
			f = (Foo) c.newInstance();
		} catch (Exception e) {
			e.printStackTrace();
		}

		f.print();
	}
}

class Foo {
	public void print() {
		System.out.println("abc");
	}
}

```


### C#:

Reflection is C# is similar like reflection in Java , but much broader in scope and capability.

By using Reflection in C#, one is able to find out details of an object, method, and create objects and invoke methods at runtime.

Reflection provides objects that describe assemblies, modules and types. We can use reflection to dynamically create an instance of a type, bind the type to an existing object, or get the type from an existing object and invoke its methods or access its fields and properties. If we are using attributes in our code, reflection enables you to access them.

Simple example of reflection using the static method GetType - inherited by all types from the Object base class - to obtain the type of a variable:

```cs
// Using GetType to obtain type information:  
int i = 42;  
System.Type type = i.GetType();  
System.Console.WriteLine(type);  
```
Output:

``System.Int32
``

The below example uses reflection to obtain the full name of the loaded assembly.

```cs
// Using Reflection to get information from an Assembly:  
System.Reflection.Assembly info = typeof(System.Int32).Assembly;  
System.Console.WriteLine(info);  
```
Output:

``
mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
``


##### When is Reflection used in C#?

* When you have to access attributes in your program's metadata. For more information, see Retrieving Information Stored in Attributes.
* For examining and instantiating types in an assembly.
* For building new types at runtime. Use classes in System.Reflection.Emit.
* For performing late binding, accessing methods on types created at run time. See the topic Dynamically Loading and Using Types.
