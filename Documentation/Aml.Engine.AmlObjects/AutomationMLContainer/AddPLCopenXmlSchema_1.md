AutomationMLContainer.AddPLCopenXmlSchema Method (String, Uri)
==============================================================
AutomationML 2.1 APIAdds a PLCopenXml schema file to the package and creates a package - part relationship of type [PLCopenXmlSchema][1] to the package.

  **Namespace:**  [Aml.Engine.AmlObjects][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public PackagePart AddPLCopenXmlSchema(
	string fileName,
	Uri partUri
)
```

#### Parameters

##### *fileName*
Type: [System.String][3]  
 full name of the file which should be added

##### *partUri*
Type: [System.Uri][4]  
 package internal name of the part

#### Return Value
Type: [PackagePart][5]  
 added part 

See Also
--------

#### Reference
[AutomationMLContainer Class][6]  
[Aml.Engine.AmlObjects Namespace][2]  

[1]: ../AutomationMLContainer_RelationshipType/PLCopenXmlSchema.md
[2]: ../README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: https://docs.microsoft.com/dotnet/api/system.uri
[5]: https://docs.microsoft.com/dotnet/api/system.io.packaging.packagepart
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png