QueryService.AllExternalDataReferences Method
=============================================
AutomationML 2.1 APIReturns all ExternalInterfaces in the provided document or optionally in the caexObject and descendants, which are instances of the standard Interface class [ExternalDataConnector][1].

  **Namespace:**  [Aml.Engine.Services][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public IEnumerable<ExternalInterfaceType> AllExternalDataReferences(
	CAEXDocument document,
	CAEXBasicObject caexObject = null
)
```

#### Parameters

##### *document*
Type: [Aml.Engine.CAEX.CAEXDocument][3]  
The document.

##### *caexObject* (Optional)
Type: [Aml.Engine.CAEX.CAEXBasicObject][4]  
Optional parameter, defining a possible start object for the query.

#### Return Value
Type: [IEnumerable][5]&lt;[ExternalInterfaceType][6]>  
 A collection of all ExternalInterface which are instances of the standard Interface class [ExternalDataConnector][1]. 
#### Implements
[IQuery.AllExternalDataReferences(CAEXDocument, CAEXBasicObject)][7]  


See Also
--------

#### Reference
[QueryService Class][8]  
[Aml.Engine.Services Namespace][2]  

[1]: ../../Aml.Engine.AmlObjects/AutomationMLInterfaceClassLib/ExternalDataConnector.md
[2]: ../README.md
[3]: ../../Aml.Engine.CAEX/CAEXDocument/README.md
[4]: ../../Aml.Engine.CAEX/CAEXBasicObject/README.md
[5]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[6]: ../../Aml.Engine.CAEX/ExternalInterfaceType/README.md
[7]: ../../Aml.Engine.Services.Interfaces/IQuery/AllExternalDataReferences.md
[8]: README.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png