CAEXPathBuilder.IsAttributeReference Method
===========================================
AutomationML 2.1 APIDetermines, if the path is an Attribute reference. This method is able to distinguish if an UUID is combined with a CAEX path

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static bool IsAttributeReference(
	CAEXDocument document,
	string attributeReference
)
```

#### Parameters

##### *document*
Type: [Aml.Engine.CAEX.CAEXDocument][2]  
The document, where the reference is tested.

##### *attributeReference*
Type: [System.String][3]  
The attribute reference.

#### Return Value
Type: [Boolean][4]  
`true`, if the provided reference is an attribute reference. 

Remarks
-------
 This method should only be used for CAEXDocuments based at least on CAEX Version 3.0 

See Also
--------

#### Reference
[CAEXPathBuilder Class][5]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXDocument/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: https://docs.microsoft.com/dotnet/api/system.boolean
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png