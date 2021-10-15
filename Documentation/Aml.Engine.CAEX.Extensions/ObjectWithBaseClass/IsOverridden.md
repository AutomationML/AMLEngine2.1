ObjectWithBaseClass.IsOverridden Method
=======================================
Determines, if an element of a class with an inheritance relation to a base class is an overridden element, what means a base class contains an element which is considered as equal to the provided element. In most cases, equality is defined by equality of the element names.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static bool IsOverridden(
	this IClassWithBaseClassReference classWithBaseClass,
	CAEXBasicObject element
)
```

#### Parameters

##### *classWithBaseClass*
Type: [Aml.Engine.CAEX.IClassWithBaseClassReference][2]  
the base class containing the element

##### *element*
Type: [Aml.Engine.CAEX.CAEXBasicObject][3]  
the element to test

#### Return Value
Type: [Boolean][4]  
`true`, if an element of a class with an inheritance relation to a base class is an overridden element 
#### Return Value
Type: [Boolean][4]  
`true` if the specified element is overridden; otherwise, `false`.
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [IClassWithBaseClassReference][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][5] or [Extension Methods (C# Programming Guide)][6].

See Also
--------

#### Reference
[ObjectWithBaseClass Class][7]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/IClassWithBaseClassReference/README.md
[3]: ../../Aml.Engine.CAEX/CAEXBasicObject/README.md
[4]: https://docs.microsoft.com/dotnet/api/system.boolean
[5]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[6]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png