# Name spaces

### How are name spaces implemented?

Packages in Java and namespaces in C# are both similar to the most part except for few differences. In Java the directory structure should match the package structure. There is no such restriction in C#. Also, in C# you can have multiple namespaces in one file but in Java one file belongs to one package. Java has default/package accessibility. C# internal accessibility goes in assemblies.

#### Java:

To make types easier to find and use, to avoid naming conflicts, and to control access, programmers bundle groups of related types into packages. Package constructs are mapped to file system. Packages cannot be nested. One source file can only have one package statement. With java you can do below things which is also possible in C#.

1. You can restrict the access of classes (or class members) to classes within the same package.

2. When importing a package, you can import a single class rather than all classes in the package.

```
// Import specific classes or all classes as shown below
package harding.compsci.graphics;

// Import single class
import harding.compsci.graphics.Rectangle;

// Import all classes
import harding.compsci.graphics.*;
```
The types that are part of the Java platform are members of various packages that bundle classes by function: fundamental classes are in java.lang, classes for reading and writing (input and output) are in java.io, and so on. You can put your types in packages too. Programs are organized as sets of packages. Each package has its own set of names for types, which helps to prevent name conflicts. A top level type is accessible outside the package that declares it only if the type is declared public.

```
System.Security.Cryptography.AsymmetricAlgorithm aa;

// above statement can be replaced with below

import System.Security.Crypography;
class abc
  {
    AsymmetricAlgorithm aa;
  }
```

#### C#:
Namespaces are used to organize programs, both as an "internal" organization system for a program, and as an "external" organization system. Accessibility of members is affected because of the packages in Java, where as C# namespaces and accessibility are not related at all. Namespaces can be nested in C# as shown below.

eg:
```
namespace Harding.Compsci.Graphics {
  ...
}

// or
namespace Harding {
  namespace Compsci {
    namespace Graphics {
      ...
    }
  }
}
```

Import single class or multiple classes as shown below.
```
// Import single class
using Rectangle = Harding.CompSci.Graphics.Rectangle;

// Import all class
using Harding.Compsci.Graphics;
```


### How are name spaces used?
#### Java:
Packages cannot be nested. The package keyword is used to create a package in java as shown below. One source file can only have one package statement. Some examples of namespaces in Java are classes and packages.
```
pacakge N1.N2;
    class A {}
    class B {}
or
package N1.N2;
   class A {}

//another source file
package N1.N2;
   class B {}
```

Two major results occur when a class is placed in a package −

- The name of the package becomes a part of the name of the class, as we just discussed in the previous section.

- The name of the package must match the directory structure where the corresponding bytecode resides.

**Defining a Package:**
This statement should be used in the beginning of the program to include that program in that particular package.
```
syntax: package <package name>;
```

**Access packages**: There are three ways to access the package from outside the package.

1. import package.*  - all the classes and interfaces of this package will be accessible but not subpackages.
2. import package.classname  - only declared class of this package will be accessible.
3. fully qualified name  - only declared class of this package will be accessible and there is no need to import.

**Access Specifiers**:

- private: accessible only in the class
- no modifier: so-called “package” access — accessible only in the same package
- protected: accessible (inherited) by subclasses, and accessible by code in same package
- public: accessible anywhere the class is accessible, and inherited by subclasses

Notice that private protected is not syntactically legal.

<table>
  <tr>
    <th>Access by</th>
    <th>private</th>
		<th>package</th>
    <th>protected</th>
		<th>public</th>
  </tr>
  <tr>
    <td colspan="1">The class itself</td>
		<td colspan="1">yes</td>
		<td colspan="1">yes</td>
		<td colspan="1">yes</td>
		<td colspan="1">yes</td>
  </tr>
	<tr>
    <td colspan="1">A subclass in same package</td>
		<td colspan="1">no</td>
		<td colspan="1">yes</td>
		<td colspan="1">yes</td>
		<td colspan="1">yes</td>
  </tr>
	<tr>
		<td colspan="1">Non subclass in same package</td>
		<td colspan="1">no</td>
		<td colspan="1">yes</td>
		<td colspan="1">yes</td>
		<td colspan="1">yes</td>
	</tr>
	<tr>
		<td colspan="1">A subclass in other package</td>
		<td colspan="1">no</td>
		<td colspan="1">no</td>
		<td colspan="1">yes</td>
		<td colspan="1">yes</td>
	</tr>
	<tr>
		<td colspan="1">Non-subclass in other package</td>
		<td colspan="1">no</td>
		<td colspan="1">no</td>
		<td colspan="1">yes</td>
		<td colspan="1">no</td>
	</tr>
</table>

[Click here for sample code](namespaces/Circle.java)

#### C#:
Namespaces are used in C# programs in two ways.
1. NET Framework classes use namespaces to organize its many classes.
2. Declaring ones own namespaces that helps control the scope of class and method names in larger programming projects.
3. Within a namespace, you can declare one or more of the following types:
	* another namespace
	* class
	* interface
	* struct
	* enum
	* delegate

```
namespace N1.N2
{
    class A {}
    class B {}
}
or
namespace N1
{
    namespace N2
    {
        class A {}
        class B {}
    }
}
```
**Accessing Namespaces**: Just like Java has an import section at the top of a program, most C# applications begin with a section of using directives. This section lists the namespaces that the application will be using frequently to save the programmer from specifying a fully qualified name every time that a method that is contained within is used.

```
using System;     // At the start of a program, the programmer can use the code.

Console.WriteLine("Hello, World!");


// instead of
System.Console.WriteLine("Hello, World!");
```

**Namespace Aliases**:
The using Directive can be used to create an alias for a namespace. For example, if you are using a previously written namespace that contains nested namespaces, you might want to declare an alias to provide a shorthand way of referencing one in particular, as in the following example:

```
using Co = Company.Proj.Nested;  // define an alias to represent a namespace
```

**Fully Qualified Names**: Namespaces and types have unique titles described by fully qualified names that indicate a logical hierarchy. For example, the statement A.B implies that A is the name of the namespace or type, and B is nested inside it.
In the following example, there are nested classes and namespaces. The fully qualified name is indicated as a comment following each entity.

```
namespace N1     // N1
{
    class C1      // N1.C1
    {
        class C2   // N1.C1.C2
        {
        }
    }
    namespace N2  // N1.N2
    {
        class C2   // N1.N2.C2
        {
        }
    }
}
```

**Keywords and syntax comparison**

<table>
  <tr>
    <td>C# Keyword</td>
    <td>Java Keyword</td>
		<td>Notes</td>
    <td>C# Example</td>
		<td>Java Example</td>
  </tr>
  <tr>
    <td colspan="1">namespace</td>
		<td colspan="1">package</td>
		<td colspan="1"><p>Create scope to avoid name collisions,group like classes, and so on</p></td>
		<td colspan="1">namespace MySpace <br>
										{<br><br>
										}</td>
		<td colspan="1">//package must be <br> first keyword in <br> class file. <br><br>
										package MySpace<br><br>
										public class MyClass <br>
										{<br><br>
											}</td>
  </tr>

  <tr>
    <td> internal</td>
    <td> private</td>
    <td> <p>Used as a class modifier to limit the class's use inside the current library. If another library imports this library and then attempts to create an instance or use this class, a compile-time error will occur.</p></td>
    <td> namespace Hidden <br>
		{<br>
			&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;internal class A<br>
			&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{<br><br>
			&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}<br>
		}<br><br>

		<p>//another library </p><br>
		<p>using Hidden; </p><br><br>
		<p>//attempt to illegally </p><br>
		<p>//use a Hidden class </p><br>
		<p>A a = new A(); </p><br>
		</td>
<td> package Hidden; <br>
		private class A <br>
			{ <br><br>
			}<br><br>

		<p>//another library</p> <br>
		<p>import Hidden; </p><br><br>
		<p>//attempt to illegally </p><br>
		<p>//use a Hidden class </p><br>
		<p>A a = new A();	</p></td>
</tr>
</table>

[Click here for sample code](namespaces/controlScope.cs)



References:
1. https://msdn.microsoft.com/en-us/library/ms836794.aspx
2. http://www.harding.edu/fmccown/java_csharp_comparison.html#namespaces
3. http://beginnersbook.com/2013/03/packages-in-java/
4. https://en.wikibooks.org/wiki/Introduction_to_Programming_Languages/Scoping_with_Namespaces
5. https://msdn.microsoft.com/en-us/library/dfb3cx8s.aspx
