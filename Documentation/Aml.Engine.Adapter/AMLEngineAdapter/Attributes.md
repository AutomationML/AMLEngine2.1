AMLEngineAdapter.Attributes Method
==================================


**Note: This API is now obsolete.**
Enumeration Method for direct Children of Type [AttributeType][1]

  **Namespace:**  [Aml.Engine.Adapter][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
[ObsoleteAttribute("Direct enumeration of the Attribute property is supported", 
	false)]
public static IEnumerable<AttributeType> Attributes(
	this IObjectWithAttributes systemUnitClass
)
```

#### Parameters

##### *systemUnitClass*
Type: [Aml.Engine.CAEX.IObjectWithAttributes][3]  

[Missing &lt;param name="systemUnitClass"/> documentation for "M:Aml.Engine.Adapter.AMLEngineAdapter.Attributes(Aml.Engine.CAEX.IObjectWithAttributes)"]


#### Return Value
Type: [IEnumerable][4]&lt;[AttributeType][1]>  
IEnumerable&lt;AttributeType>.
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [IObjectWithAttributes][3]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][5] or [Extension Methods (C# Programming Guide)][6].

See Also
--------

#### Reference
[AMLEngineAdapter Class][7]  
[Aml.Engine.Adapter Namespace][2]  

[1]: ../../Aml.Engine.CAEX/AttributeType/README.md
[2]: ../README.md
[3]: ../../Aml.Engine.CAEX/IObjectWithAttributes/README.md
[4]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[5]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[6]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png