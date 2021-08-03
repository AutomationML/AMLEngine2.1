SystemUnitClassTypeExtensions.Ancestors Method
==============================================
Returns all SystemUnit Classes which are ancestors of this. This SystemUnit Class is included in the enumeration as the first Element, The farthest is the last Element in the enumeration.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static IEnumerable<SystemUnitFamilyType> Ancestors(
	this SystemUnitFamilyType systemUnitClass
)
```

#### Parameters

##### *systemUnitClass*
Type: [Aml.Engine.CAEX.SystemUnitFamilyType][2]  
The SystemUnitClass.

#### Return Value
Type: [IEnumerable][3]&lt;[SystemUnitFamilyType][2]>  
 Enumeration of all SystemUnitClass ancestors. 
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [SystemUnitFamilyType][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][4] or [Extension Methods (C# Programming Guide)][5].

See Also
--------

#### Reference
[SystemUnitClassTypeExtensions Class][6]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/SystemUnitFamilyType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[4]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[5]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png