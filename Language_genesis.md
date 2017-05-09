# Language purpose/genesis

## Why was the language created?

#### Java:
The history of java starts from Green Team. Java team members (also known as Green Team), initiated a revolutionary task to develop a language for interactive television using digital devices such as set-top boxes, televisions etc. It was too advanced for the digital cable television industry at the time and later became popular for internet programming.

* There were five primary goals in the creation of the Java language:[16]
	1. It must be "simple, object-oriented, and familiar".
	1. It must be "robust and secure".
	1. It must be "architecture-neutral and portable".
	1. It must execute with "high performance".
	1. It must be "interpreted, threaded, and dynamic".

#### C#:
According to the C#'s principal designer and lead architect at Microsoft Anders Hejlsberg, the flaws in the major programming languages existed before c# came into existance like C++, Java etc drove the fundamentals of the Common Language Runtime (CLR), which, in turn, drove the design of the C# language.

The name "C sharp" was inspired by musical notation where a sharp indicates that the written note should be made a semitone higher in pitch. This is similar to the language name of C++, where "++" indicates that a variable should be incremented by 1. The sharp symbol also resembles a ligature of four "+" symbols (in a two-by-two grid), further implying that the language is an increment of C++.

James Gosling, the creator of Java programming language called C# an "imitation" of Java. C# is a language derived from C and C++, but it was created from the ground up. Microsoft started with what worked in C and C++ and included new features that would make these languages easier to use. Many of these features are very similar to what can be found in Java. Although C# looked similar to Java at the time it is first released, both languages have evolved on increasingly divergent trajectories, becoming somewhat less similar.

* design goals for C#:
	1. The language is intended to be a simple, modern, general-purpose, object-oriented programming language.
	1. The language, and implementations thereof, should provide support for software engineering principles such as strong type checking, array bounds checking, detection of attempts to use uninitialized variables, and automatic garbage collection. Software robustness, durability, and programmer productivity are important.
	1. The language is intended for use in developing software components suitable for deployment in distributed environments.
	1. Portability is very important for source code and programmers, especially those already familiar with C and C++.
	1. Support for internationalization is very important.
	1. C# is intended to be suitable for writing applications for both hosted and embedded systems, ranging from the very large that use sophisticated operating systems, down to the very small having dedicated functions.
	1. Although C# applications are intended to be economical with regard to memory and processing power requirements, the language was not intended to compete directly on performance and size with C or assembly language.



### What problems was the language trying to address?
#### Java:
Java was intended to let application developers "write once, run anywhere" (WORA), meaning that compiled Java code can run on all platforms that support Java without the need for recompilation. The trouble with C and C++(and most other languages) is that they are designed to be compiled for a specific target. Although it is possible to compile a C++ program for just about any type of CPU, to do so requires a full C++ compiler targeted for that CPU. The problem is that compilers are expensive and time- consuming to create. An easier - and more cost efficient solution was needed. In an attempt of find such a solution, Gosling and others began work on a portable, platform-independent language that could be used to produce code that would run on a variety of CPUs under differing environments. This effort ultimately led to the creation of Java.

Java is concurrent, class-based, object-oriented and specifically designed to have as few implementation dependencies as possible.  Java derives much of its character from C and C++. This is by intent. In addition to the surface similarities, Java shares some of the other attributes that helped make C and C++ Successful.

#### C#:

C# tries to remove some of the complexities and pitfalls of the languages such as Java and C++, including the removal of macros, templates, multiple inheritance, and virtual base classes. These are all areas that cause either confusion or potential problems for C++ developers.

C# is simple and is based on C and C++. Statements, expressions, operators, and other functions are taken directly from C and C++, but are improved to make them easy to use. Some of the improvements include eliminating redundancies. Other areas of improvement include additional syntax changes. For example, C++ has three operators for working with members: ::, ., and ->. Knowing when to use each of these three symbols can be very confusing in C++. In C#, these are all replaced with a single symbol--the "dot" operator.

C# is a modern language created by Microsoft as part of its .NET platform of languages. As the name implies, C# has its roots in C++, but over time, it has evolved its own techniques and elements that make it distinct. The language is disarmingly simple but also includes all the support for the structured, component-based, object-oriented programming that one expects of a modern language built on the shoulders of C++ and Java. In other words, it's a fully featured language appropriate for developing large-scale applications, but at the same time it is designed to be easy to learn.

C# is considered safe because the language is type-safe, which is an important mechanism to help you find bugs early in the development process. This makes for code that is easier to maintain and programs that are more reliable. C# was designed, from the very start, to support object-oriented programming. It is a multi-paradigm programming language encompassing strong typing, imperative, declarative, functional, generic, object-oriented (class-based), and component-oriented programming disciplines.

* The features and concepts that were in C# when Java was lacking them in the beginning.
	* Enums
	* Value Types (Structs)
	* Run Time Type Identification (as operator)
	* Delegates
	* Events
	* Attributes
	* Indexers
	* foreach Statement
	* Properties
	* Pointers
	* PreProcessor
	* Aliases
	* Boxing
	* Pass by Reference
	* params Keyword
	* Verbatim Strings
	* Static Constructors
	* Overflow Detection
	* Explicit Interface Implementation

### Is the language a reaction to a previous language or a replacement for another language?

#### Java:
The green team which developed Java language started thinking of replacing C++ with a better,  faster and a responsive version. Before Java emerged as a programming language, C++ was the dominant player in the trade. The primary goal of the creators of Java was to create a language that could tackle most of the things that C++ offered while getting rid of some of the more tedious tasks that came with the earlier languages.

The new language was supposed to be developed for an embedded system with limited resources. An embedded system is a computer system scaled to a minimalistic interface demanding only a few functions from its design. For such a system, C++ or any successor would seem too large as all the languages at the time demanded a larger footprint than what was desired. The team was anticipating and planning for the "next wave" in computing. The new language will converge digitally controlled consumer devices and computers. The team thus had to think in a different way to go about solving all these problems.

Co-founder of Sun Microsystems, Bill Joy, envisioned a language combining the power of Mesa and C in a paper named Further he wrote for the engineers at Sun. Gathering ideas, Gosling began work on enhancing C++ and named it "C++ ++ --", a pun on the evolutionary structure of the language's name. The ++ and -- meant, putting in and taking out stuff.

Computer hardware went through a performance and price revolution from 1972 to 1991. Better, faster hardware was available at ever lower prices, and the demand for big and complex software exponentially increased. To accommodate the demand, new development technologies were invented which led to Object-Oriented Programming (OOP). With OOP, one can write code that can be reused later without needing to rewrite the code over and over again.

#### C#:

As stated above, principal designer of C#, Anders Hejlsberg said the flaws in the major programming languages ((e.g. C++, Java, Delphi, and Smalltalk) existed before c# drove the fundamentals of the Common Language Runtime (CLR), which, in turn, drove the design of the C# language. So we can say C# is developed as a reaction to previous languages.
