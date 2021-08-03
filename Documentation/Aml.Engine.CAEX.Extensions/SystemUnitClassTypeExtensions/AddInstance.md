SystemUnitClassTypeExtensions.AddInstance Method
================================================
Inserts a new class instance to the InternalElement collection of the parentInternalElement. If there are existing instances of the same Type, the Element is inserted after the last Element of that Type. Before Insertion, the Uniqueness of the Name among the siblings of that Type is checked.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static bool AddInstance(
	this SystemUnitClassType systemUnitClass,
	CAEXObject newInstanceObject
)
```

#### Parameters

##### *systemUnitClass*
Type: [Aml.Engine.CAEX.SystemUnitClassType][2]  
 The Parent-InternalElement

##### *newInstanceObject*
Type: [Aml.Engine.CAEX.CAEXObject][3]  
 The instance of a class to be inserted at the parentInternalElement. The instance can be of type InternalElementType or InterfaceClassType

#### Return Value
Type: [Boolean][4]  
 True if insertion was successful, otherwise false (name is not unique or wrong type of newInstanceObject) 
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [SystemUnitClassType][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][5] or [Extension Methods (C# Programming Guide)][6].

See Also
--------

#### Reference
[SystemUnitClassTypeExtensions Class][7]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/SystemUnitClassType/README.md
[3]: ../../Aml.Engine.CAEX/CAEXObject/README.md
[4]: https://docs.microsoft.com/dotnet/api/system.boolean
[5]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[6]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png