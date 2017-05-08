### Types




### Java:
* The Primitive Data Types are all value types
* Both Reference and Primitive Data types are supported in Java
* Creation of new values types is not supported. Any new type can only be of reference type
* For each primitive data type in Java, the core class library provides a wrapper class that represents it as a Java object. For example, the Int32 class wraps the int data type, and the Double class wraps the double data type.

* Primitive Data Types : General and fundamental data types that we have in Java
  * Byte : Byte data type is an 8-bit signed two's complement integer
  * short : Short data type is a 16-bit signed two's complement integer
  * int : Int data type is a 32-bit signed two's complement integer.
  * long : Long data type is a 64-bit signed two's complement integer.
  * float : Float data type is a single-precision 32-bit IEEE 754 floating point.
  * double : double data type is a double-precision 64-bit IEEE 754 floating point.
  * boolean : boolean data type represents one bit of information.
  * char : char data type is a single 16-bit Unicode character.


* Derived Data Types : These are made by using any other data type
    * Arrays


* User-defined Data Types : These are those that user/programmer himself defines
    * Classes
    * Interfaces


### C#:

###### The variables in C#, are categorized into the following types:
  * Value types : These are the built-in primitive data types, such as char, int, and float, as well as user-defined types declared with struct.
  * Reference types : Classes and other complex data types that are constructed from the primitive types. Variables of such types do not contain an instance of the type, but merely a reference to an instance.
  * Pointer types
  * C# provides all the data types that are available in Java, and adds support for unsigned numerals and a new 128-bit high-precision floating-point type.
  * All primitive data types in C# are objects in the System namespace. For each data type, a short name, or alias, is provided. For instance, int is the short name for System.Int32 and double is the short form of System.Double.

* Primitive Data Types:
  * byte
  * short
  * int
  * long
  * float
  * double
  * boolean
  * char


* Value Types
  * A data type is a value type if it holds the data within its own memory allocation. Value types include the following:
   * All numeric data types
   * Boolean, Char, and Date
   * All structures, even if their members are reference types
   * Enumerations, since their underlying type is always SByte, Short, Integer, Long, Byte, UShort, UInteger, or ULong


* Reference Data Types:
  * A reference type contains a pointer to another memory location that holds the data. Reference types include the following:
    * String
    * All arrays, even if their elements are value types
    * Class types, such as Form
    * Delegates




## Data Types Comparision

</table>
      <table style="width:80%;">
      <tr>
      <th style="width:40%;">Data types</th>
      <th style="width:30%;">Java</th>
      <th style="width:30%;">C#</th>
      </tr>
      <tr>
      <td>Arbitrary-size decimals</a></td>
      <td style="vertical-align:middle;text-align:center;" class="table-yes">Reference type; no operators</td>
      <td style="vertical-align:middle;text-align:center;" class="table-no">Third party library</td>
      </tr>
      <tr>
      <td>Arbitrary-size integers</td>
      <td style="vertical-align:middle;text-align:center;" class="table-yes">Reference type; no operators</td>
      <td style="vertical-align:middle;text-align:center;" class="table-yes">Yes</td>
      </tr>
      <tr>
      <td>Arrays</td>
      <td style="vertical-align:middle;text-align:center;" class="table-yes">Yes</td>
      <td style="vertical-align:middle;text-align:center;" class="table-yes">Yes</td>
      </tr>
      <tr>
      <td>Boolean type</td>
      <td style="vertical-align:middle;text-align:center;" class="table-yes">Yes</td>
      <td style="vertical-align:middle;text-align:center;" class="table-yes">Yes</td>
      </tr>
      <tr>
      <td>Character</td>
      <td style="vertical-align:middle;text-align:center;" class="table-yes">Yes</td>
      <td style="vertical-align:middle;text-align:center;" class="table-yes">Yes</td>
      </tr>
      <tr>
      <td>Complex numbers</td>
      <td style="vertical-align:middle;text-align:center;" class="table-no">Third-party library</td>
      <td style="vertical-align:middle;text-align:center;" class="table-yes">Yes</td>
      </tr>
      <tr>
      <td>Date/time</td>
      <td style="vertical-align:middle;text-align:center;" class="table-yes">Yes; reference type</td>
      <td style="vertical-align:middle;text-align:center;" class="table-yes">Yes; value type</td>
      </tr>
      <tr>
      <td>Enumerated types</td>
      <td style="vertical-align:middle;text-align:center;" class="table-yes">Yes; reference type</td>
      <td style="vertical-align:middle;text-align:center;" class="table-yes">Yes; scalar</td>
      </tr>
      <tr>
      <td>High-precision decimal number</td>
      <td style="vertical-align:middle;text-align:center;" class="table-no">No</td>
      <td style="vertical-align:middle;text-align:center;" class="table-yes">128-bit (28 digits) Decimal type</td>
      </tr>
      <tr>
      <td>IEEE 754 binary32 floating point number</td>
      <td style="vertical-align:middle;text-align:center;" class="table-yes">Yes</td>
      <td style="vertical-align:middle;text-align:center;" class="table-yes">Yes</td>
      </tr>
      <tr>
      <td>IEEE 754 binary64 floating point number</td>
      <td style="vertical-align:middle;text-align:center;" class="table-yes">Yes</td>
      <td style="vertical-align:middle;text-align:center;" class="table-yes">Yes</td>
      </tr>
      <tr>
      <td>Lifted (nullable) types</a></td>
      <td style="vertical-align:middle;text-align:center;" class="table-no">No; but wrapper types</td>
      <td style="vertical-align:middle;text-align:center;" class="table-yes">Yes</td>
      </tr>
      <tr>
      <td>Pointers</td>
      <td style="vertical-align:middle;text-align:center;" class="table-no">No; only method references </td>
      <td style="vertical-align:middle;text-align:center;" class="table-yes">Yes</td>
      </tr>
      <tr>
      <td>Reference types</td>
      <td style="vertical-align:middle;text-align:center;" class="table-yes">Yes</td>
      <td style="vertical-align:middle;text-align:center;" class="table-yes">Yes</td>
      </tr>
      <tr>
      <td>Signed integers</a></td>
      <td style="vertical-align:middle;text-align:center;" class="table-yes">Yes; 8, 16, 32, 64 bits</td>
      <td style="vertical-align:middle;text-align:center;" class="table-yes">Yes; 8, 16, 32, 64 bits</td>
      </tr>
      <tr>
      <td>Strings</td>
      <td style="vertical-align:middle;text-align:center;" class="table-yes">Immutable reference type, Unicode</td>
      <td style="vertical-align:middle;text-align:center;" class="table-yes">Immutable reference type, Unicode</td>
      </tr>
      <tr>
      <td>Type annotations</td>
      <td style="vertical-align:middle;text-align:center;" class="table-yes">Yes</td>
      <td style="vertical-align:middle;text-align:center;" class="table-yes">Yes</td>
      </tr>
      <tr>
      <td>Single-root (unified) type system</td>
      <td style="vertical-align:middle;text-align:center;" class="table-no">No; but wrapper types</td>
      <td style="vertical-align:middle;text-align:center;" class="table-yes">Yes</td>
      </tr>
      <tr>
      <td>Tuples</td>
      <td style="vertical-align:middle;text-align:center;" class="table-no">No; limited 3rd party available.</td>
      <td style="vertical-align:middle;text-align:center;" class="table-yes">Yes</td>
      </tr>
      <tr>
      <td>Unsigned integers</td>
      <td style="vertical-align:middle;text-align:center;" class="table-no">No; but some method support.</td>
      <td style="vertical-align:middle;text-align:center;" class="table-yes">Yes; 8, 16, 32, 64 bits</td>
      </tr>
      <tr>
      <td>Value types</td>
      <td style="vertical-align:middle;text-align:center;" class="table-no">No; only primitive types</td>
      <td style="vertical-align:middle;text-align:center;" class="table-yes">Yes</td>
      </tr>
  </table>
