QueryService.InternalLinksToInterface Method
============================================
Gets all InternalLinks that reference the specified ExternalInterface.

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public IEnumerable<InternalLinkType> InternalLinksToInterface(
	ExternalInterfaceType externalInterface
)
```

#### Parameters

##### *externalInterface*
Type: [Aml.Engine.CAEX.ExternalInterfaceType][2]  
The ExternalInterface.

#### Return Value
Type: [IEnumerable][3]&lt;[InternalLinkType][4]>  
a collection of InternalLinks.
#### Implements
[IQuery.InternalLinksToInterface(ExternalInterfaceType)][5]  


See Also
--------

#### Reference
[QueryService Class][6]  
[Aml.Engine.Services Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/ExternalInterfaceType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[4]: ../../Aml.Engine.CAEX/InternalLinkType/README.md
[5]: ../../Aml.Engine.Services.Interfaces/IQuery/InternalLinksToInterface.md
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png