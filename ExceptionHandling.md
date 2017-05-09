# Exception Handling in Java and C# :
An exception is an event that occurs during the execution of a program that disrupts the normal flow of instructions.
Both C# and Java have support for formal exception handling. Without exceptions, functions must define and return some invalid value in place of a valid one just in case preconditions are not met. This can be problematic since defining an invalid value may remove at least one otherwise valid item in the function range. And it can be messy because the client must then check the return value against some predefined invalid one

## JAVA:
Valid Java programming language code must honor the Catch or Specify Requirement. This means that code that might throw certain exceptions must be enclosed by either of the following:
* A try statement that catches the exception. The try must provide a handler for the exception, as described in Catching and Handling Exceptions.
*	A method that specifies that it can throw the exception. The method must provide a throws clause that lists the exception, as described in Specifying the Exceptions Thrown by a Method.
Code that fails to honor the Catch or Specify Requirement will not compile
### There are three types of Exceptions
##### Checked Exceptions:
These are exceptional conditions that a well-written application should anticipate and recover from. For example, suppose an application prompts a user for an input file name, then opens the file by passing the name to the constructor for java.io.FileReader. Normally, the user provides the name of an existing, readable file, so the construction of the FileReader object succeeds, and the execution of the application proceeds normally. But sometimes the user supplies the name of a nonexistent file, and the constructor throws java.io.FileNotFoundException. A well-written program will catch this exception and notify the user of the mistake, possibly prompting for a corrected file name.
Checked exceptions are subject to the Catch or Specify Requirement. All exceptions are checked exceptions, except for those indicated by Error, RuntimeException, and their subclasses.
##### Errors:
These are exceptional conditions that are external to the application, and that the application usually cannot anticipate or recover from. For example, suppose that an application successfully opens a file for input, but is unable to read the file because of a hardware or system malfunction. The unsuccessful read will throw java.io.IOError. An application might choose to catch this exception, in order to notify the user of the problem — but it also might make sense for the program to print a stack trace and exit.
Errors are not subject to the Catch or Specify Requirement. Errors are those exceptions indicated by Error and its subclasses.
##### Runtime Exceptions:
These are exceptional conditions that are internal to the application, and that the application usually cannot anticipate or recover from. These usually indicate programming bugs, such as logic errors or improper use of an API. For example, consider the application described previously that passes a file name to the constructor for FileReader. If a logic error causes a null to be passed to the constructor, the constructor will throw NullPointerException. The application can catch this exception, but it probably makes more sense to eliminate the bug that caused the exception to occur.
Runtime exceptions are not subject to the Catch or Specify Requirement. Runtime exceptions are those indicated by RuntimeException and its subclasses.
Errors and runtime exceptions are collectively known as unchecked exceptions.
### Catching and Handling Exceptions:
#### The try block:
The first step in constructing an exception handler is to enclose the code that might throw an exception within a try block. In general, a try block looks like the following:
```
  try
  {
      //do something
  }
```
The segment in the example labeled do something contains one or more legal lines of code that could throw an exception
If an exception occurs within the try block, that exception is handled by an exception handler associated with it. To associate an exception handler with a try block, you must put a catch block after it
#### The Catch Blocks:
You associate exception handlers with a try block by providing one or more catch blocks directly after the try block. No code can be between the end of the try block and the beginning of the first catch block.
```
try {
}
catch (ExceptionType name) {
  //do something
}
catch (ExceptionType name) {
  //do something
}
```
Each catch block is an exception handler that handles the type of exception indicated by its argument. The argument type, ExceptionType, declares the type of exception that the handler can handle and must be the name of a class that inherits from the Throwable class. The handler can refer to the exception with name.
The catch block contains code that is executed if and when the exception handler is invoked. The runtime system invokes the exception handler when the handler is the first one in the call stack whose ExceptionType matches the type of the exception thrown. The system considers it a match if the thrown object can legally be assigned to the exception handler's argument.
If the code could throw multiple exceptions and these need to be handled, then the catch blocks should be in the order of increasing generality of the exceptions i.e., from more specific to less specific.
#### The finally block:
The finally block always executes when the try block exits. This ensures that the finally block is executed even if an unexpected exception occurs. But finally is useful for more than just exception handling — it allows the programmer to avoid having cleanup code accidentally bypassed by a return, continue, or break. Putting cleanup code in a finally block is always a good practice, even when no exceptions are anticipated.
```
finally {
  //finally something is done
}
```
## C# :
Similarly to Exception handling in Java, C# handles exceptions in a similar way.
It has try, catch and finally blocks, which has the same meaning and purpose as in Java.
C# disallows the use of a throws list.

## Conclusion :
It is my opinion that the Java rules of exception handling are superior. Because,
* Requiring a throws list in a method definition clearly signals to the client developer what exceptions he may catch, and helps a compiler help this developer by explicitly dictating which Exceptions must be caught. With C#, the only way for the developer to know which Exceptions may be thrown is by manually inspecting documentation, pop-up help, code or code comments.
* C# choose not to use a throws list, and never require a developer to catch any Exception might be because of some interoperability issues between languages such as C# and C++.
