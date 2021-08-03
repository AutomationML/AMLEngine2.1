AutomationMLContainer.AddLibrary Method (String, Uri)
=====================================================
AutomationML 2.1 APIAdds a library file to the package and creates a package - part relationship of type [Library][1].

  **Namespace:**  [Aml.Engine.AmlObjects][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public PackagePart AddLibrary(
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

[1]: ../AutomationMLContainer_RelationshipType/Library.md
[2]: ../README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: https://docs.microsoft.com/dotnet/api/system.uri
[5]: https://docs.microsoft.com/dotnet/api/system.io.packaging.packagepart
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png