AMLEngineAdapter.GetAttributeValue Method
=========================================


**Note: This API is now obsolete.**
Returns an attribute value of a given attribute name.

  **Namespace:**  [Aml.Engine.Adapter][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
[ObsoleteAttribute("Use Indexer of Attribute Property with access to the Attribute Value Property: ...Attribute[attName]?.Value")]
public static string GetAttributeValue(
	this IObjectWithAttributes objWithAttr,
	string attName
)
```

#### Parameters

##### *objWithAttr*
Type: [Aml.Engine.CAEX.IObjectWithAttributes][2]  
 Object with attributes

##### *attName*
Type: [System.String][3]  
 name of attribute

#### Return Value
Type: [String][3]  
 attribute value, "" if attribute does not exist 
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [IObjectWithAttributes][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][4] or [Extension Methods (C# Programming Guide)][5].

See Also
--------

#### Reference
[AMLEngineAdapter Class][6]  
[Aml.Engine.Adapter Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/IObjectWithAttributes/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[5]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png