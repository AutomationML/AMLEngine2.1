AMLEngineAdapter.SystemUnitClassChildren Method
===============================================
AutomationML 2.1 API

**Note: This API is now obsolete.**
Gets all Children [SystemUnitFamilyType][1] Objects of this SystemUnitClass.

  **Namespace:**  [Aml.Engine.Adapter][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
[ObsoleteAttribute("Use SystemUnitClass Property instead.")]
public static IEnumerable<SystemUnitFamilyType> SystemUnitClassChildren(
	this SystemUnitFamilyType systemUnitClass
)
```

#### Parameters

##### *systemUnitClass*
Type: [Aml.Engine.CAEX.SystemUnitFamilyType][1]  

[Missing &lt;param name="systemUnitClass"/> documentation for "M:Aml.Engine.Adapter.AMLEngineAdapter.SystemUnitClassChildren(Aml.Engine.CAEX.SystemUnitFamilyType)"]


#### Return Value
Type: [IEnumerable][3]&lt;[SystemUnitFamilyType][1]>  
IEnumerable&lt;SystemUnitFamilyType>.
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [SystemUnitFamilyType][1]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][4] or [Extension Methods (C# Programming Guide)][5].

See Also
--------

#### Reference
[AMLEngineAdapter Class][6]  
[Aml.Engine.Adapter Namespace][2]  

[1]: ../../Aml.Engine.CAEX/SystemUnitFamilyType/README.md
[2]: ../README.md
[3]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[4]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[5]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png