QueryService.FindByPath Method
==============================
This method tries to find the first element in the defined document, which CAEXPath is equal to the provided path. If the path uses an alias to reference an object in a external document it is tried to locate an [IExternalReferenceResolver][1] service. If such a service is registered, the CAEXObject is tried to be found in the resolved document.

  **Namespace:**  [Aml.Engine.Services][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public CAEXObject FindByPath(
	CAEXDocument caexDocument,
	string path,
	bool resolveAlias = false
)
```

#### Parameters

##### *caexDocument*
Type: [Aml.Engine.CAEX.CAEXDocument][3]  
The XDocument

##### *path*
Type: [System.String][4]  
The CAEXPath to look at

##### *resolveAlias* (Optional)
Type: [System.Boolean][5]  
if set to `true` [resolve alias].

#### Return Value
Type: [CAEXObject][6]  
 the CAEXObject or `null`, if no element with the specified path could be found. 
#### Implements
[IQuery.FindByPath(CAEXDocument, String, Boolean)][7]  


Exceptions
----------

Exception                  | Condition    
-------------------------- | ------------ 
[ArgumentNullException][8] | caexDocument 


See Also
--------

#### Reference
[QueryService Class][9]  
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