QueryService.InternalLinksToElement Method
==========================================
Gets all InternalLink objects referencing the provided SystemUnitClass object via an external interface attached to the SystemUnitClass.

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public IEnumerable<InternalLinkType> InternalLinksToElement(
	SystemUnitClassType systemUnitClass
)
```

#### Parameters

##### *systemUnitClass*
Type: [Aml.Engine.CAEX.SystemUnitClassType][2]  
The SystemUnitClass object

#### Return Value
Type: [IEnumerable][3]&lt;[InternalLinkType][4]>  
An enumeration of InternalLinks.
#### Implements
[IQuery.InternalLinksToElement(SystemUnitClassType)][5]  


See Also
--------

#### Reference
[QueryService Class][6]  
[Aml.Engine.Services Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/SystemUnitClassType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[4]: ../../Aml.Engine.CAEX/InternalLinkType/README.md
[5]: ../../Aml.Engine.Services.Interfaces/IQuery/InternalLinksToElement.md
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png