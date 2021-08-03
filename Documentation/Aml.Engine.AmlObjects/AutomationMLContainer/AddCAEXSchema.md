AutomationMLContainer.AddCAEXSchema Method (Stream, Uri)
========================================================
Adds a CAEX schema part retrieved from a stream resource to the package and creates a package - part relationship to the package using the relationship type [CAEXSchema][1].

  **Namespace:**  [Aml.Engine.AmlObjects][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public PackagePart AddCAEXSchema(
	Stream inStream,
	Uri partUri
)
```

#### Parameters

##### *inStream*
Type: [System.IO.Stream][3]  
 collard stream

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

[1]: ../AutomationMLContainer_RelationshipType/CAEXSchema.md
[2]: ../README.md
[3]: https://docs.microsoft.com/dotnet/api/system.io.stream
[4]: https://docs.microsoft.com/dotnet/api/system.uri
[5]: https://docs.microsoft.com/dotnet/api/system.io.packaging.packagepart
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png