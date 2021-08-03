CAEXPathBuilder.InstanceIDInAttributeReference Method
=====================================================
Gets the ID of the master parent instance from a reference defined in an Attribute mirror object in the specified CAEX document.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static string InstanceIDInAttributeReference(
	string reference,
	CAEXDocument document,
	out bool isAttributeReference
)
```

#### Parameters

##### *reference*
Type: [System.String][2]  
The reference from the Attribute mirror object.

##### *document*
Type: [Aml.Engine.CAEX.CAEXDocument][3]  
The document.

##### *isAttributeReference*
Type: [System.Boolean][4]  
if set to `true`, if the reference is an Attribute reference in a mirror.

#### Return Value
Type: [String][2]  
 The master parent ID 

Remarks
-------
 Only valid since CAEX Version 3.0 

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