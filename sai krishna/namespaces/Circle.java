import calc.math.*;
 2
 3 package geometry;
 4
 5 public class Circle {
 6   private double radius;
 7
 8   public Circle(double r) {
 9     radius = r;
10   }
11
12   public double getRadius() {
13     return radius;
14   }
15
16   public double getArea() {
17     return calc.math.pi * radius * radius;
18   }
19 }
