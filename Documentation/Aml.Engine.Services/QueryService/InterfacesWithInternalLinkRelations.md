QueryService.InterfacesWithInternalLinkRelations Method
=======================================================
AutomationML 2.1 APIReturns all ExternalInterface objects which are descendants of the provided CAEX object and are used in relations (InternalLinks).

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public IEnumerable<ExternalInterfaceType> InterfacesWithInternalLinkRelations(
	CAEXBasicObject caexObject
)
```

#### Parameters

##### *caexObject*
Type: [Aml.Engine.CAEX.CAEXBasicObject][2]  
The CAEX object.

#### Return Value
Type: [IEnumerable][3]&lt;[ExternalInterfaceType][4]>  
 A collection of related ExternalInterface objects 
#### Implements
[IQuery.InterfacesWithInternalLinkRelations(CAEXBasicObject)][5]  


See Also
--------

#### Reference
[QueryService Class][6]  
[Aml.Engine.Services Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXBasicObject/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[4]: ../../Aml.Engine.CAEX/ExternalInterfaceType/README.md
[5]: ../../Aml.Engine.Services.Interfaces/IQuery/InterfacesWithInternalLinkRelations.md
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png