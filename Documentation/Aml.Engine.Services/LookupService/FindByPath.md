LookupService.FindByPath Method
===============================
AutomationML 2.1 APILocates a CAEX object in the provided document using the specified CAEX - Path for identification. If the path uses an alias reference and an [IExternalReferenceResolver][1] can be located, it is tried to resolve the external reference and to get the object from the external source.

  **Namespace:**  [Aml.Engine.Services][2]  
  **Assembly:**  AML.Engine.Services (in AML.Engine.Services.dll)

Syntax
------

```csharp
public CAEXObject FindByPath(
	CAEXDocument doc,
	string caexPath,
	bool resolveAlias = false
)
```

#### Parameters

##### *doc*
Type: [Aml.Engine.CAEX.CAEXDocument][3]  
The document.

##### *caexPath*
Type: [System.String][4]  
The path.

##### *resolveAlias* (Optional)
Type: [System.Boolean][5]  
 if set to `true` tries to resolve an alias reference with an ExternalReferenceResolver service.

#### Return Value
Type: [CAEXObject][6]  
 The first object which is found (if the path is not a unique identifier, than more than this object may exist). 
#### Implements
[IQuery.FindByPath(CAEXDocument, String, Boolean)][7]  


Exceptions
----------

Exception                  | Condition 
-------------------------- | --------- 
[ArgumentNullException][8] | doc       


See Also
--------

#### Reference
[LookupService Class][9]  
[Aml.Engine.Services Namespace][2]  

[1]: ../../Aml.Engine.Services.Interfaces/IExternalReferenceResolver/README.md
[2]: ../README.md
[3]: ../../Aml.Engine.CAEX/CAEXDocument/README.md
[4]: https://docs.microsoft.com/dotnet/api/system.string
[5]: https://docs.microsoft.com/dotnet/api/system.boolean
[6]: ../../Aml.Engine.CAEX/CAEXObject/README.md
[7]: ../../Aml.Engine.Services.Interfaces/IQuery/FindByPath.md
[8]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[9]: README.md
[10]: https://www.automationml.org
[11]: ../../icons/logoShade.png