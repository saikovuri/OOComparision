## Comparison of references
To compare object references, the operators == and != are used. The equals method is also used to comapare object references.
### Java :
#### String references
The equals() method compares the "value" inside String instances irrespective of the two object references refer to the same String instance or not. If any two object references of type String refer to the same String instance then great! If the two object references refer to two different String instances it doesn't make a difference. Its the "value" (that is: the contents of the character array) inside each String instance that is being compared.
```
class StringComparison{  
 public static void main(String args[]){  
   String s1="abc";  
   String s2="abc";  
   String s3=new String("abc");  
   String s4="xyz";  
   System.out.println(s1.equals(s2));//true  
   System.out.println(s1.equals(s3));//true  
   System.out.println(s1.equals(s4));//false  
 }  
}  
```

The "==" operator compares the value of two object references to see whether they refer to the same String instance. If the value of both object references "refer to" the same String instance then the result of the boolean expression would be "true". If, on the other hand, the value of both object references "refer to" different String instances (even though both String instances have identical "values", that is, the contents of the character arrays of each String instance are the same) the result of the boolean expression would be "false".
```
class StringComparison{  
 public static void main(String args[]){  
   String s1="abc";  
   String s2="abc";  
   String s3=new String("abc");  
   System.out.println(s1==s2); //true
   System.out.println(s1==s3); //false
 }  
}
```
#### Object references
When two object references are to be compared, the == operator will simply compare the bits in the variable, they are either identical or they are not.
Hence the equals() method should be used. The equals method in Object class simply uses the == operator to compare objects, so unless the equals() method is overridden, two objects are considered equal only if the two references refer to the same object.
```
public class EqualsTest {
  public static void main (String [] args) {
    Moof one = new Moof(8);
    Moof two = new Moof(8);
    if (one.equals(two)) {
      System.out.println("one and two are equal");
    }
  }
}

class Moof {
  private int moofValue;
  Moof(int val) {
    moofValue = val;
  }
  public int getMoofValue() {
    return moofValue;
  }
  public boolean equals(Object o) {
    if ((o instanceof Moof) && (((Moof)o).getMoofValue()
        == this.moofValue)) {
          return true;
    } else {
      return false;
    }
  }
}
```
The equals() method from the class Object is overridden in the class Moof. The equals method is overridden to compare two Moof objects.
Frist, be sure that the object being tested is of the correct type. Hence the instanceOf() test is performed on it.
### C# :
#### Object.Equals(Object) method
Equals supports reference equality for reference types, and bitwise equality for value types. Reference equality means the object references that are compared refer to the same object. Bitwise equality means the objects that are compared have the same binary representation.
```
using System;
class Program
{
    static void Main(string[] args)
    {
        Object Obj1 = new Object();
        Object Obj2 = new Object();
        Console.WriteLine(Obj1.Equals(Obj2));
        Obj2 = Obj1;
        Console.WriteLine(Obj1.Equals(Obj2));
    }
}

/* This example produces the following output:
False
True
 */
```
* This method can be overridden by a derived class. For example, many of the base data types return true if both objects represent the same value; otherwise, false.
* This method only compares primitives and objects. It must be overridden to compare more complex structures, such as arrays of objects.

The following example shows a Point class that overrides the Equals method to provide value equality and a class Point3D, which is derived from Point. Because Point 's override of Equals is the first in the inheritance chain to introduce value equality, the Equals method of the base class (which is inherited from Object and checks for referential equality) is not invoked. However, Point3D.Equals invokes Point.Equals because Point implements Equals in a manner that provides value equality
```
using System;

class Point
{
   protected int x, y;

   public Point() {
     this.x = 0;
     this.y = 0;
   }

   public Point(int X, int Y) {
      this.x = X;
      this.y = Y;
   }

   public override bool Equals(Object obj) {
      //Check for null and compare run-time types.
      if (obj == null || this.GetType() != obj.GetType()) {
         return false;
      }   
      else {
      Point p = (Point) obj;
      return (x == p.x) && (y == p.y);
      }
   }

   public override int GetHashCode() {
      return x ^ y;
   }
}

class Point3D: Point
{
   int z;

   public Point3D(int X, int Y, int Z) {
      this.x = X;
      this.y = Y;
      this.z = Z;
   }

   public override bool Equals(Object obj) {
      return base.Equals(obj) && z == ((Point3D)obj).z;
   }

   public override int GetHashCode() {
      return base.GetHashCode() ^ z;
   }
}

class Example
{
  public static void Main()
  {
     Point point2D = new Point(5, 5);
     Point3D point3Da = new Point3D(5, 5, 2);
     Point3D point3Db = new Point3D(5, 5, 2);

     if (!point2D.Equals(point3Da)) {
        Console.WriteLine("point2D does not equal point3Da");
     }
     if (!point3Db.Equals(point2D)) {
        Console.WriteLine("point3Db does not equal point2D");
     }
     if (point3Da.Equals(point3Db)) {
        Console.WriteLine("point3Da equals point3Db");
     }

  }
}
// The example displays the following output:
//       point2D does not equal point3Da
//       point3Db does not equal point2D
//       point3Da equals point3Db
```

The following statements must be true for all implementations of the Equals method. In the list, x, y, and z represent object references that are not null.
* x.Equals(x) returns true, except in cases that involve floating-point types. See IEC 60559:1989, Binary Floating-point Arithmetic for Microprocessor Systems.
* x.Equals(y) returns the same value as y.Equals(x).
* x.Equals(y) returns true if both x and y are NaN.
* If (x.Equals(y) && y.Equals(z)) returns true, then x.Equals(z) returns true.
* Successive calls to x.Equals(y) return the same value as long as the objects referenced by x and y are not modified.
* x.Equals(null) returns false
