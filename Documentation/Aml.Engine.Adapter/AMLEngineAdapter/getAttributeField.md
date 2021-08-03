AMLEngineAdapter.getAttributeField Method
=========================================


**Note: This API is now obsolete.**
Get the whole attribute field containing a collection of all attributes of this object.

  **Namespace:**  [Aml.Engine.Adapter][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
[ObsoleteAttribute("Direct enumeration of the Attribute property is supported", 
	false)]
public static IEnumerable<AttributeType> getAttributeField(
	this IObjectWithAttributes objectWithAttributes
)
```

#### Parameters

##### *objectWithAttributes*
Type: [Aml.Engine.CAEX.IObjectWithAttributes][2]  
The object with attributes.

#### Return Value
Type: [IEnumerable][3]&lt;[AttributeType][4]>  
 CAEX_ClassModel.MemberElement_Attribute. 
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [IObjectWithAttributes][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][5] or [Extension Methods (C# Programming Guide)][6].

See Also
--------

#### Reference
[AMLEngineAdapter Class][7]  
[Aml.Engine.Adapter Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/IObjectWithAttributes/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[4]: ../../Aml.Engine.CAEX/AttributeType/README.md
[5]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[6]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png