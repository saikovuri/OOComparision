### Unique features of the language

C# and Java are similar languages that are typed statically, strongly, and manifestly. Both are object-oriented, and designed with semi-interpretation or runtime just-in-time compilation, and both are curly brace languages, like C and C++.

### JAVA:
* Java programs are compiled into platform-independent byte-codes.
* Java runs [Java Virtual Machine](https://en.wikipedia.org/wiki/Java_virtual_machine) (JVM)
* In Java the primitive types are special in that they are not object-oriented and they could not have been defined using the language itself.
* They also do not share a common ancestor with reference types.
* Java support many built-in types that are copied and passed by value rather than by reference. These are called primitive types in java.
* Parallel operations introduced in Java 8. Actual iteration over a collection on which a Lambda function is carried out by the core library itself.
* Code snippet of Parallel processing capabilities in Java:
  ``` ConcurrentMap<Person.Sex, List<Person>> byGender = roster.parallelStream().collect(
      Collectors.groupingByConcurrent(Person::getGender));
  ```

### C#:
* C# is not quite as platform-independent, but will run under Windows and Mac OS-X (but not Linux).  
* C# runs on [Common Language Runtime or CLR](https://en.wikipedia.org/wiki/Common_Language_Runtime). This is the runtime that supports not just C# but also other .NET languages, such as Visual Basic.NET.   
* C# has a unified type system in which all types ultimately derive from a common root type.
* C# also support many built-in types that are copied and passed by value rather than by reference. These are called simple types in C#.
* C# implements object-oriented method pointers in the form of delegates. A delegate is a special type that can capture a type-safe reference to a method.
