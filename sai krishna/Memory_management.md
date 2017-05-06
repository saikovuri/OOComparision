

# Memory management


###	How is it handled?
#### Java
Memory is managed using Garbage collection in Java.  The objects reside in an area called the heap. The heap is created when the JVM starts up and may increase or decrease in size while the application runs. When the heap becomes full, garbage is collected. During the garbage collection objects that are no longer used are cleared, thus making space for new objects.

JVM uses more memory than just the heap. For example Java methods, thread stacks and native handles are allocated in memory separate from the heap, as well as JVM internal data structures.

#### C#:
The .NET Framework's garbage collector manages the allocation and release of memory for your application. Each time you create a new object, the common language runtime allocates memory for the object from the managed heap. As long as address space is available in the managed heap, the runtime continues to allocate space for new objects. However, memory is not infinite. Eventually the garbage collector must perform a collection in order to free some memory.

###	How does it work?
#### Java
During object allocation, the JRockit JVM distinguishes between small and large objects. The limit for when an object is considered large depends on the JVM version, the heap size, the garbage collection strategy and the platform used, but is usually somewhere between 2 and 128 kB.

Small objects are allocated in thread local areas (TLAs). The thread local areas are free chunks reserved from the heap and given to a Java thread for exclusive use. The thread can then allocate objects in its TLA without synchronizing with other threads. When the TLA becomes full, the thread simply requests a new TLA. The TLAs are reserved from the nursery if such exists, otherwise they are reserved anywhere in the heap.

Large objects that don’t fit inside a TLA are allocated directly on the heap. When a nursery is used, the large objects are allocated directly in old space. Allocation of large objects requires more synchronization between the Java threads, although the JRockit JVM uses a system of caches of free chunks of different sizes to reduce the need for synchronization and improve the allocation speed.

#### C#:
The garbage collector's optimizing engine determines the best time to perform a collection, based upon the allocations being made. When the garbage collector performs a collection, it checks for objects in the managed heap that are no longer being used by the application and performs the necessary operations to reclaim their memory.

When a garbage collection is triggered, the garbage collector reclaims the memory that is occupied by dead objects. The reclaiming process compacts live objects so that they are moved together, and the dead space is removed, thereby making the heap smaller. This ensures that objects that are allocated together stay together on the managed heap, to preserve their locality.

###	Garbage collection?
#### Java
The heap is sometimes divided into two areas (or generations) called the nursery (or young space) and the old space. The nursery is a part of the heap reserved for allocation of new objects. When the nursery becomes full, garbage is collected by running a special young collection, where all objects that have lived long enough in the nursery are promoted (moved) to the old space, thus freeing up the nursery for more object allocation. When the old space becomes full garbage is collected there, a process called an old collection.

The reasoning behind a nursery is that most objects are temporary and short lived. A young collection is designed to be swift at finding newly allocated objects that are still alive and moving them away from the nursery. Typically, a young collection frees a given amount of memory much faster than an old collection or a garbage collection of a single-generational heap (a heap without a nursery).

In R27.2.0 and later releases, a part of the nursery is reserved as a keep area. The keep area contains the most recently allocated objects in the nursery and is not garbage collected until the next young collection. This prevents objects from being promoted just because they were allocated right before a young collection started.

Below listed are the different models for garbage collection in the JRockit JVM.

1. The Mark and Sweep Model
2. Genrational Garbage Collection
3. Dynamic and Static Garbage Collection Modes
4. Compaction

#### C#:
The heap memory is divided into number of generations. Normally it is three generations. The Generation 0 is for short live objects, Generation 1 is for medium live objects which are moved from Generation 0. Generation 3 is mostly stable objects.

When an object is created then it will allocate the memory space which will be higher. It will be in the Generation 0 and the memory allocation will be continuous without any space between the generations of garbage collectors. When object is created then it will be placed in the Generation 0. The garbage collection uses an algorithm which checks the objects in the generation, the objects life time get over then it will be removed from the memory.

The garbage collector periodically checks the heap memory to reclaim the objects when the object has no valid references in the memory.

Garbage collection has the following phases:
1. A marking phase that finds and creates a list of all live objects.
2. A relocating phase that updates the references to the objects that will be compacted.
3. A compacting phase that reclaims the space occupied by the dead objects and compacts the surviving objects. The compacting phase moves objects that have survived a garbage collection toward the older end of the segment.



###	Automatic reference counting?
#### Both languages
Java uses Garbage Collection (or GC for short). It is the technique used for life cycle management on both .NET and Java platforms. GC runtime (either the Common Language Runtime for .NET or the Java Runtime) has infrastructure in place that detects unused objects and object graphs in the background.

This happens at indeterminate intervals (either after a certain amount of time has passed, or when the runtime sees available memory getting low), so objects are not necessarily released at the exact moment they are no longer used.

Automatic reference counting stores reference count (refcount) for each count tracking how many references exist to the object.
● Creating a reference to an object increments its refcount.
● Removing a reference to an object decrements its refcount.
● When an object has zero refcount, it is unreachable and can be reclaimed.


[Click here for sample code illustrating generations for garbage collection](Memory_management/garbage_collection.cs)

references:
1. https://docs.oracle.com/cd/E13150_01/jrockit_jvm/jrockit/geninfo/diagnos/garbage_collect.html
2. https://docs.elementscompiler.com/Concepts/ARCvsGC/
3. http://www.keithschwarz.com/cs143/WWW/sum2011/lectures/180_Garbage_Collection.pdf
4. https://msdn.microsoft.com/en-us/library/ee787088(v=vs.110).aspx
