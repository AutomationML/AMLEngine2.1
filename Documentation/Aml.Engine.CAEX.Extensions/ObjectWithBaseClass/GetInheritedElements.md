ObjectWithBaseClass.GetInheritedElements Method
===============================================
Gets a collection of InternalElement objects that are inherited from base classes. As default, the own InternalElements are included in the enumeration.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static IEnumerable<InternalElementType> GetInheritedElements(
	this SystemUnitFamilyType classWithBaseClass,
	bool includeSelf
)
```

#### Parameters

##### *classWithBaseClass*
Type: [Aml.Engine.CAEX.SystemUnitFamilyType][2]  
 The class with a possible base class reference for inheritance.

##### *includeSelf*
Type: [System.Boolean][3]  
if set to `true` includes the own Internal Elements.

#### Return Value
Type: [IEnumerable][4]&lt;[InternalElementType][5]>  
A collection of InternalElement objects
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [SystemUnitFamilyType][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][6] or [Extension Methods (C# Programming Guide)][7].

See Also
--------

#### Reference
[ObjectWithBaseClass Class][8]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/SystemUnitFamilyType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[5]: ../../Aml.Engine.CAEX/InternalElementType/README.md
[6]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[7]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[8]: README.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png