QueryService.AllClassReferences Method (CAEXDocument, String, String)
=====================================================================
Gets all classes which have references to the provided class path. Use this method to get all classes which have a class to class relation to the class, identified by the provided classPath. If the *elementName* is set, only classes with the defined element name are considered.

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public IEnumerable<CAEXObject> AllClassReferences(
	CAEXDocument document,
	string classPath,
	string elementName = ""
)
```

#### Parameters

##### *document*
Type: [Aml.Engine.CAEX.CAEXDocument][2]  
The CAEX document which is searched through.

##### *classPath*
Type: [System.String][3]  
The class path.

##### *elementName* (Optional)
Type: [System.String][3]  
 Name of the element. Valid values are 'RoleClass', 'SystemUnitClass', 'InterfaceClass' and 'AttributeType'.

#### Return Value
Type: [IEnumerable][4]&lt;[CAEXObject][5]>  
 An enumeration of all classes which use the identified class as a base class. 
#### Implements
[IQuery.AllClassReferences(CAEXDocument, String, String)][6]  


See Also
--------

#### Reference
[QueryService Class][7]  
[Aml.Engine.Services Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXDocument/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[5]: ../../Aml.Engine.CAEX/CAEXObject/README.md
[6]: ../../Aml.Engine.Services.Interfaces/IQuery/AllClassReferences.md
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png