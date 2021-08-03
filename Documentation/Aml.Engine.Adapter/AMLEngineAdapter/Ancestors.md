AMLEngineAdapter.Ancestors Method
=================================


**Note: This API is now obsolete.**
Returns all SystemUnit Classes which are ancestors of this. This SystemUnit Class is included in the enumeration as the first Element, The farthest is the last Element in the enumeration.

  **Namespace:**  [Aml.Engine.Adapter][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
[ObsoleteAttribute("use the generic extension method, Ancestors<T>.")]
public static IEnumerable<SystemUnitClassType> Ancestors(
	this SystemUnitClassType systemUnitClass
)
```

#### Parameters

##### *systemUnitClass*
Type: [Aml.Engine.CAEX.SystemUnitClassType][2]  

[Missing &lt;param name="systemUnitClass"/> documentation for "M:Aml.Engine.Adapter.AMLEngineAdapter.Ancestors(Aml.Engine.CAEX.SystemUnitClassType)"]


#### Return Value
Type: [IEnumerable][3]&lt;[SystemUnitClassType][2]>  
IEnumerable&lt;SystemUnitClassType>.
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [SystemUnitClassType][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][4] or [Extension Methods (C# Programming Guide)][5].

See Also
--------

#### Reference
[AMLEngineAdapter Class][6]  
[Aml.Engine.Adapter Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/SystemUnitClassType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[4]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[5]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png