LookupService.AllExternalInterfacesOfType Method
================================================
Returns all ExternalInterfaces in the provided document or optionally in the caexObject and descendants, which are instances of the Interface class defined by the provided *interfaceClassPath*.

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine.Services (in AML.Engine.Services.dll)

Syntax
------

```csharp
public IEnumerable<ExternalInterfaceType> AllExternalInterfacesOfType(
	CAEXDocument document,
	string interfaceClassPath,
	CAEXBasicObject caexObject = null
)
```

#### Parameters

##### *document*
Type: [Aml.Engine.CAEX.CAEXDocument][2]  
The document.

##### *interfaceClassPath*
Type: [System.String][3]  
The CAEX ClassPath of the InterfaceClassType

##### *caexObject* (Optional)
Type: [Aml.Engine.CAEX.CAEXBasicObject][4]  
Optional parameter, defining a possible start object for the query.

#### Return Value
Type: [IEnumerable][5]&lt;[ExternalInterfaceType][6]>  
 A collection of all ExternalInterface which are instances of the Interface class defined by the provided *interfaceClassPath*. 
#### Implements
[IQuery.AllExternalInterfacesOfType(CAEXDocument, String, CAEXBasicObject)][7]  


See Also
--------

#### Reference
[LookupService Class][8]  
[Aml.Engine.Services Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXDocument/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: ../../Aml.Engine.CAEX/CAEXBasicObject/README.md
[5]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[6]: ../../Aml.Engine.CAEX/ExternalInterfaceType/README.md
[7]: ../../Aml.Engine.Services.Interfaces/IQuery/AllExternalInterfacesOfType.md
[8]: README.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png