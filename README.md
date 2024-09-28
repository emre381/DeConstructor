
---

## C# Program: Constructor, Destructor, and Static Methods

This C# program demonstrates several key concepts in object-oriented programming, including:
- **Constructors and Destructors**: These are special methods used for initializing and cleaning up objects.
- **Static Methods and Fields**: These belong to the class itself rather than instances of the class.
- **Static Constructors**: These are used to initialize static fields before any instance of the class is created or any static members are accessed.

### Key Concepts

1. **Human Class (Commented Out)**:
   - This class contains a **constructor**, a **destructor**, and a **static method**. Though currently commented out, it demonstrates how these components work.
   - The class includes:
     - A constructor (`Human()`): Called when a new object is created.
     - A destructor (`~Human()`): Called when the object is destroyed by the garbage collector.
     - A static field (`humanCount`): Tracks the number of `Human` objects created.
     - A static method (`TellHumanCount()`): Returns the total number of human objects created.
     - A constant (`PI = 3.14`): A constant field that never changes.

   Here's a breakdown of the commented code:

   ```csharp
   public Human()
   {
       humanCount++;
   }

   ~Human()
   {
       Console.WriteLine("Object destroyed..");
   }
   ```

   The constructor increments the `humanCount` each time a new object is created. The destructor runs when an object is destroyed.

2. **Coordinate Class**:
   - The **`Coordinate`** class demonstrates the use of **static fields** and a **static constructor**.
   - **Static Fields**: `X` and `Y` are static properties, meaning they belong to the class and not to any specific instance.
   - **Static Constructor**: The static constructor (`static Coordinate()`) initializes `X` and `Y` when the class is first used, before any object is created.

   ```csharp
   class Coordinate
   {
       public static int X { get; set; }
       public static int Y { get; set; }

       static Coordinate()
       {
           X = 10;
           Y = 20;
       }
   }
   ```

   When the program creates a `Coordinate` object, the static constructor initializes the values of `X` and `Y` to `10` and `20` respectively. These values are then printed in the `Main()` method.

3. **Main Method**:
   - The `Main()` method instantiates the `Coordinate` class and prints the values of the static fields `X` and `Y`:

   ```csharp
   Coordinate coordinate = new Coordinate();
   Console.WriteLine(Coordinate.X + " " + Coordinate.Y); // Output: 10 20
   ```

   Since `X` and `Y` are static, they are accessed through the class name (`Coordinate.X` and `Coordinate.Y`) rather than through an object.

### Additional Features (Commented Out)

The program includes additional functionality that is currently commented out but can be enabled:
- **Multiple `Human` Objects**: This code creates several `Human` objects, sets their ages, and prints them, along with the total count of objects created and the constant value of `PI`.
- **Garbage Collection**: A `CreatObject()` method shows how objects are created. When uncommented, you can manually invoke the garbage collector with `GC.Collect()` to trigger the destructors.

### Console Output

The program produces the following output:

```
10 20
```

### Summary

- **Static Fields and Methods**: They belong to the class and can be accessed without creating an instance of the class.
- **Constructors and Destructors**: Constructors initialize objects, and destructors clean them up when they are no longer in use.
- **Static Constructors**: These initialize static fields the first time the class is accessed.

This program is a good example of how to work with object-oriented programming concepts in C#, including constructors, destructors, static members, and garbage collection.

--- 

