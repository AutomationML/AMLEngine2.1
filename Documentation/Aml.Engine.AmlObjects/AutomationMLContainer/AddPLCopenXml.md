AutomationMLContainer.AddPLCopenXml Method (PackagePart, Stream, Uri, Boolean)
==============================================================================
Adds a PLCopenXml part read from a stream resource to the package and creates relationships to the package and to the package part containing the root document using the relationship type [PLCopenXml][1].

  **Namespace:**  [Aml.Engine.AmlObjects][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public PackagePart AddPLCopenXml(
	PackagePart rootDocument,
	Stream inStream,
	Uri partUri,
	bool addPackageRelation = true
)
```

#### Parameters

##### *rootDocument*
Type: [System.IO.Packaging.PackagePart][3]  
 package part, containing the parent root document

##### *inStream*
Type: [System.IO.Stream][4]  
 PLCopenXml stream

##### *partUri*
Type: [System.Uri][5]  
 package internal name of the part

##### *addPackageRelation* (Optional)
Type: [System.Boolean][6]  
 optional parameter, defining if a package relation should be added

#### Return Value
Type: [PackagePart][3]  
 added part 

Revision History
----------------

Date       | Version | Description                                                                                                     
---------- | ------- | --------------------------------------------------------------------------------------------------------------- 
08/03/2021 | 1.6.3.0 | *addPackageRelation* added as an additional optional parameter, defining if a package relation should be added. 


See Also
--------

#### Reference
[AutomationMLContainer Class][7]  
[Aml.Engine.AmlObjects Namespace][2]  

[1]: ../AutomationMLContainer_RelationshipType/PLCopenXml.md
[2]: ../README.md
[3]: https://docs.microsoft.com/dotnet/api/system.io.packaging.packagepart
[4]: https://docs.microsoft.com/dotnet/api/system.io.stream
[5]: https://docs.microsoft.com/dotnet/api/system.uri
[6]: https://docs.microsoft.com/dotnet/api/system.boolean
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png