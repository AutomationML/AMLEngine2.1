IQuery.AllClassReferencesDeep Method (CAEXDocument, String, String)
===================================================================
AutomationML 2.1 APIGets all classes which have references to the provided CAEX object and their referencing classes (recursive). This method extends the [AllClassReferences(CAEXDocument, String, String)][1] and gets not only the directly derived classes of a base class but also the derived classes of these classes and further on. If the *elementName* is set, only classes with the defined element name are considered.

  **Namespace:**  [Aml.Engine.Services.Interfaces][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
IEnumerable<CAEXObject> AllClassReferencesDeep(
	CAEXDocument document,
	string classPath,
	string elementName = ""
)
```

#### Parameters

##### *document*
Type: [Aml.Engine.CAEX.CAEXDocument][3]  
The CAEX document which is searched through.

##### *classPath*
Type: [System.String][4]  
The class path.

##### *elementName* (Optional)
Type: [System.String][4]  
 Name of the element. Valid values are 'RoleClass', 'SystemUnitClass', 'InterfaceClass' and 'AttributeType'.

#### Return Value
Type: [IEnumerable][5]&lt;[CAEXObject][6]>  

[Missing &lt;returns> documentation for "M:Aml.Engine.Services.Interfaces.IQuery.AllClassReferencesDeep(Aml.Engine.CAEX.CAEXDocument,System.String,System.String)"]


See Also
--------

#### Reference
[IQuery Interface][7]  
[Aml.Engine.Services.Interfaces Namespace][2]  

[1]: AllClassReferences.md
[2]: ../README.md
[3]: ../../Aml.Engine.CAEX/CAEXDocument/README.md
[4]: https://docs.microsoft.com/dotnet/api/system.string
[5]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[6]: ../../Aml.Engine.CAEX/CAEXObject/README.md
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png