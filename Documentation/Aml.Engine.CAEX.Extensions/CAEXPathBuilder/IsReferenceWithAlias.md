CAEXPathBuilder.IsReferenceWithAlias Method
===========================================
AutomationML 2.1 APIDetermines whether the specified reference is defined with an alias separator.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static bool IsReferenceWithAlias(
	string classReference,
	CAEXDocument.CAEXSchema schema
)
```

#### Parameters

##### *classReference*
Type: [System.String][2]  
The class reference string.

##### *schema*
Type: [Aml.Engine.CAEX.CAEXDocument.CAEXSchema][3]  
The CAEX schema version.

#### Return Value
Type: [Boolean][4]  
`true` if the reference is a reference with an alias; otherwise, `false`. 

See Also
--------

#### Reference
[CAEXPathBuilder Class][5]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.string
[3]: ../../Aml.Engine.CAEX/CAEXDocument_CAEXSchema/README.md
[4]: https://docs.microsoft.com/dotnet/api/system.boolean
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png