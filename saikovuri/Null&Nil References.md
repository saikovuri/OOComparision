## Null/nil references
### Java:

* Java uses `null` keyword which is used as a special value to signify:
  * Uninitialized state
  * Termination condition
  * Non-existing object
  * An unknown value

* In Java, null is a singleton member of the null type, which is defined to be the subtype of every other Java type.

* `null` is a reference type and its value is the only reference value which doesn't refer to any object. Therefore there is no representation of null in memory.

* Java does not implicitly check for null references. Developer has to implement ways to handle null references. For example:

```java
String name;
List<String> stringList;
if (stringList == null) {
  stringList = new ArrayList<>();
} else {
  if (name != null) {
    stringList.add(name);
  }
}
```
### C#:

C# uses `null` keyword which represents a null reference, one that does not refer to any object. null is the default value of reference-type variables.

Like in Java, C# does not check for null references implicitly. Developer has to write code to handle null checks. Below is an example to check for null values

```cs
using System;

namespace Application
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string str =null;

			if (str == null)
			{
				MessageBox.Show("String is null");
			}
			else
			{
				MessageBox.Show("String is not null");
			}

			str = "test";

			if (string.IsNullOrEmpty(str))
			{
				MessageBox.Show("String is empty or null");
			}
			else
			{
				MessageBox.Show("String is not empty or null");
			}

		}
	}
}
```
If we do not handle null values we get NullReferenceException.
