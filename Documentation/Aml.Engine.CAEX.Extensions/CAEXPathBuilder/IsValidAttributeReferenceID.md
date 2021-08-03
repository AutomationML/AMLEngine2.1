CAEXPathBuilder.IsValidAttributeReferenceID Method
==================================================
AutomationML 2.1 APIDetermines whether the ID is valid to be used in an attribute mirror reference.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static bool IsValidAttributeReferenceID(
	string idString,
	CAEXDocument document
)
```

#### Parameters

##### *idString*
Type: [System.String][2]  
The identifier string.

##### *document*
Type: [Aml.Engine.CAEX.CAEXDocument][3]  
The document.

#### Return Value
Type: [Boolean][4]  
`true` if the ID is valid to be used in an attribute mirror reference; otherwise, `false`. 

See Also
--------

#### Reference
[CAEXPathBuilder Class][5]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.string
[3]: ../../Aml.Engine.CAEX/CAEXDocument/README.md
[4]: https://docs.microsoft.com/dotnet/api/system.boolean
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png