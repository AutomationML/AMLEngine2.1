AMLFile.IsGenericAdditionalInformation Method
=============================================
Determines whether the specified XML element represents an AdditionalInformation object, not using any specific syntax as the [DocumentVersion][1] or [WriterHeader][2] elements.

  **Namespace:**  [Aml.Engine.AmlObjects][3]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public bool IsGenericAdditionalInformation(
	XElement element
)
```

#### Parameters

##### *element*
Type: [System.Xml.Linq.XElement][4]  
The element.

#### Return Value
Type: [Boolean][5]  
`true` if the specified element is a generic AdditionalInformation element; otherwise, `false`. 

See Also
--------

#### Reference
[AMLFile Class][6]  
[Aml.Engine.AmlObjects Namespace][3]  

[1]: DocumentVersion.md
[2]: WriterHeader.md
[3]: ../README.md
[4]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement
[5]: https://docs.microsoft.com/dotnet/api/system.boolean
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png