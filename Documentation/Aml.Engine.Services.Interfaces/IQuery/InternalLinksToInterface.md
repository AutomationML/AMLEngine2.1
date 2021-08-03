IQuery.InternalLinksToInterface Method
======================================
Gets all InternalLinks that reference the specified ExternalInterface.

  **Namespace:**  [Aml.Engine.Services.Interfaces][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
IEnumerable<InternalLinkType> InternalLinksToInterface(
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

See Also
--------

#### Reference
[IQuery Interface][5]  
[Aml.Engine.Services.Interfaces Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/ExternalInterfaceType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[4]: ../../Aml.Engine.CAEX/InternalLinkType/README.md
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png