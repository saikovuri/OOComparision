# Multithreading


##	Threads or thread-like abilities
#### Java
A Java program runs in its own process and by default in one thread. Java supports threads as part of the Java language via the Thread code.

#### C#:
In C#, the **System.Threading.Thread** class is used for working with threads. It allows creating and accessing individual threads in a multithreaded application. The first thread to be executed in a process is called the main thread.

When a C# program starts execution, the main thread is automatically created. The threads created using the Thread class are called the child threads of the main thread. You can access a thread using the CurrentThread property of the Thread class.

##	How is multitasking accomplished?
#### Java
The base means for concurrency are is the java.lang.Threads class. A Thread executes an object of type java.lang.Runnable.

Runnable is an interface with defines the run() method. This method is called by the Thread object and contains the work which should be done. Therefore the "Runnable" is the task to perform. The Thread is the worker who is doing this task.

The following demonstrates a task (Runnable) which counts the sum of a given range of numbers.

```
public class MyRunnable implements Runnable {
        private final long countUntil;

        MyRunnable(long countUntil) {
                this.countUntil = countUntil;
        }

        @Override
        public void run() {
                long sum = 0;
                for (long i = 1; i < countUntil; i++) {
                        sum += i;
                }
                System.out.println(sum);
        }
}
```

Java provides locks to protect certain parts of the code to be executed by several threads at the same time. The simplest way of locking a certain method or Java class is to define the method or class with the synchronized keyword.

The synchronized keyword in Java ensures:

- that only a single thread can execute a block of code at the same time
- that each thread entering a synchronized block of code sees the effects of all previous modifications that were guarded by the same lock


#### There are two ways to create thread in java

Implement the Runnable interface (java.lang.Runnable)
By Extending the Thread class (java.lang.Thread)


**Implementing the Runnable interface**

The Runnable Interface Signature

```
public interface Runnable {

void run();
```

One way to create a thread in java is to implement the Runnable Interface and then instantiate an object of the class. Override the run() method into the class which is the only method that needs to be implemented. The run() method contains the logic of the thread.

The procedure for creating threads based on the Runnable interface is as follows:

1. A class implements the Runnable interface, providing the run() method that will be executed by the thread. An object of this class is a Runnable object.

2. An object of Thread class is created by passing a Runnable object as argument to the Thread constructor. The Thread object now has a Runnable object that implements the run() method.

3. The start() method is invoked on the Thread object created in the previous step. The start() method returns immediately after a thread has been spawned.

4. The thread ends when the run() method ends, either by normal completion or by throwing an uncaught exception.


**Extending thread class**

The procedure for creating threads based on extending the Thread is as follows:

1. A class extending the Thread class overrides the run() method from the Thread class to define the code executed by the thread.

2. This subclass may call a Thread constructor explicitly in its constructors to initialize the thread, using the super() call.

3. The start() method inherited from the Thread class is invoked on the object of the class to make the thread eligible for running.

[Click here for sample code that demonstrates multithreading using Runnable in Java](multithreading/implementingRunnable.java)

[Click here for sample code that demonstrates multithreading using Thread class in Java](multithreading/extendingThread.java)


#### C#:
There are two main ways of multi-threading which .NET encourages: starting your own threads with ThreadStart delegates, and using the ThreadPool class either directly (using ThreadPool.QueueUserWorkItem) or indirectly using asynchronous methods (such as Stream.BeginRead, or calling BeginInvoke on any delegate).

In general, you should create a new thread "manually" for long-running tasks, and use the thread pool only for brief jobs. The thread pool can only run so many jobs at once, and some framework classes use it internally, so you don't want to block it with a lot of tasks which need to block for other things.

[Click below for sample code that demonstrates threads creation in C#](multithreading/threads.cs)


[Click here for sample code that illustrates use of sleep() method for making a thread to pause](Multithreading/threadSleep.cs)


References:
1. https://www.tutorialspoint.com/csharp/csharp_multithreading.htm
2. http://www.yoda.arachsys.com/csharp/threads/
3. https://www.javatpoint.com/multithreading-in-java
4. https://www.tutorialspoint.com/java/java_multithreading.htm
5. http://beginnersbook.com/2013/03/multithreading-in-java/
