CAEXPathBuilder.IsIDReferenceWithAlias Method
=============================================
Determines whether the specified object reference is an alias reference to an ID in the specified document

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static bool IsIDReferenceWithAlias(
	string objectRefrence,
	CAEXDocument document,
	CAEXPathBuilder.IDRefEnum referenceType = CAEXPathBuilder.IDRefEnum.AllTypes
)
```

#### Parameters

##### *objectRefrence*
Type: [System.String][2]  
The object reference.

##### *document*
Type: [Aml.Engine.CAEX.CAEXDocument][3]  
The document.

##### *referenceType* (Optional)
Type: [Aml.Engine.CAEX.Extensions.CAEXPathBuilder.IDRefEnum][4]  
 Optional parameter to specify the type of the reference. If not set, all possible types are checked

#### Return Value
Type: [Boolean][5]  
`true` if the specified object reference is an alias reference to an ID; otherwise, `false`. 

See Also
--------

#### Reference
[CAEXPathBuilder Class][6]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.string
[3]: ../../Aml.Engine.CAEX/CAEXDocument/README.md
[4]: ../CAEXPathBuilder_IDRefEnum/README.md
[5]: https://docs.microsoft.com/dotnet/api/system.boolean
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png