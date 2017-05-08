## Properties

A property must have some attribute that makes it instantly recognizable as such and distinguishable from other values that are not properties.

### Java

##### Getters and Setters

* Private member variables in Java can only be accessed using getters and setters, if outside the scope of the class definition. The language does not have in-built support for default public getters and setters, and hence, require explicit declaration by the developer. For example:

```java
public class GetterSetter {
    private String name;

    // Getter
    public String getName() {
      return this.name;
    }

    // Setter
    public void setName(String name) {
      this.name = name;
    }
}
```

In Java if we have a private property, We do this;
```Java
private String name;

public void setName(String name) {
   this.name = name;
}

public String getName() {
   return this.name;
}
```
##### Backing Variables and Computed Properties

Backing Variables and Computed Properties are not useful without a separate concept of Properties, and hence, not applicable to Java



### C``#``

In C#, If we would like to access a private variable there are many ways of doing this.

We can do it like Java:

```cs
private string name;

public void setName(string name) {
   this.name = name;
}

public string getName() {
   return this.name;
}
```
Or We can do it this way:

```cs
private string name;

public string Name {
   get { return name; }
   set { name = value; }
}
```
Or:
```cs
public string Name { get; set; }
```

##### Backing Variables and Computed Properties

In C#, a backing variable is where the data is actually stored.
Below is the example:

```cs
private int age;
public int Age
{
    get { return age; }
    set { age = value; }
}
```

If we set the C# Property Age to 25

```cs
p.Age = 29;
```

The value 29 is actually stored in the member variable age. The member variable age is called a "backing variable" because it is used this way in a C# Property.

The point of C# Properties is to give a chance to execute some code when that Property is set or get. For example, we might do this:

```cs
private int age;
public int Age
{
    get { return age; }
    set
    {
        if(value < 0)
            throw new InvalidArgumentException("Age must be greater than or equal to zero.");
        age = value;
    }
}
```

In simple case, we can simply do
```cs
public int Age { get; set; }
```


#### C``#`` does not have computed properties
