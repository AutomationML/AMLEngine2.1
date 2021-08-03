AutomationMLContainer.AddAnyContent Method (PackagePart, Stream, Uri, String, Boolean)
======================================================================================
AutomationML 2.1 APIAdds any content from the specified stream resource to the package creating relationships to the package and to the part, containing the root document using the relationship type [AnyContent][1].

  **Namespace:**  [Aml.Engine.AmlObjects][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public PackagePart AddAnyContent(
	PackagePart rootDocument,
	Stream inStream,
	Uri partUri,
	string mimeType = null,
	bool addPackageRelation = true
)
```

#### Parameters

##### *rootDocument*
Type: [System.IO.Packaging.PackagePart][3]  
 package part, containing the parent root document

##### *inStream*
Type: [System.IO.Stream][4]  
 any content stream

##### *partUri*
Type: [System.Uri][5]  
 package internal name of the part

##### *mimeType* (Optional)
Type: [System.String][6]  
 optional mime type, the default mime type for the relationship is used if empty

##### *addPackageRelation* (Optional)
Type: [System.Boolean][7]  
 optional parameter, defining if a package relation should be added

#### Return Value
Type: [PackagePart][3]  
 PackagePart. 

Revision History
----------------

Date       | Version | Description                                                                                                     
---------- | ------- | --------------------------------------------------------------------------------------------------------------- 
07/29/2021 | 1.6.2.0 | *addPackageRelation* added as an additional optional parameter, defining if a package relation should be added. 


See Also
--------

#### Reference
[AutomationMLContainer Class][8]  
[Aml.Engine.AmlObjects Namespace][2]  

[1]: ../AutomationMLContainer_RelationshipType/AnyContent.md
[2]: ../README.md
[3]: https://docs.microsoft.com/dotnet/api/system.io.packaging.packagepart
[4]: https://docs.microsoft.com/dotnet/api/system.io.stream
[5]: https://docs.microsoft.com/dotnet/api/system.uri
[6]: https://docs.microsoft.com/dotnet/api/system.string
[7]: https://docs.microsoft.com/dotnet/api/system.boolean
[8]: README.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png