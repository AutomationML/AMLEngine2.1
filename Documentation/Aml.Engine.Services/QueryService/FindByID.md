QueryService.FindByID Method
============================
AutomationML 2.1 APIFinds the first element in the defined document, which ID is equal to the provided ID.

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public CAEXObject FindByID(
	CAEXDocument doc,
	string id,
	bool resolveAlias = false
)
```

#### Parameters

##### *doc*
Type: [Aml.Engine.CAEX.CAEXDocument][2]  
The XDocument

##### *id*
Type: [System.String][3]  
The ID to look at

##### *resolveAlias* (Optional)
Type: [System.Boolean][4]  
 if set to `true` tries to resolve an alias reference with an ExternalReferenceResolver service.

#### Return Value
Type: [CAEXObject][5]  
 the CAEXObject or `null`, if no element with the specified ID could be found. 
#### Implements
[IQuery.FindByID(CAEXDocument, String, Boolean)][6]  


Exceptions
----------

Exception                  | Condition 
-------------------------- | --------- 
[ArgumentNullException][7] | doc       


See Also
--------

#### Reference
[QueryService Class][8]  
[Aml.Engine.Services Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXDocument/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: https://docs.microsoft.com/dotnet/api/system.boolean
[5]: ../../Aml.Engine.CAEX/CAEXObject/README.md
[6]: ../../Aml.Engine.Services.Interfaces/IQuery/FindByID.md
[7]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[8]: README.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png