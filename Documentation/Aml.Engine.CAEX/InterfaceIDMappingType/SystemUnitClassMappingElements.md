InterfaceIDMappingType.SystemUnitClassMappingElements Property
==============================================================
AutomationML 2.1 APIGets the collection of possible mapping identifiers for this InterfaceIDMappingType for elements of the mapped SystemUnitClass. The Collection contains all ExternalInterfaces (including inherited and descendants) of the SystemUnitClass. The ExternalInterface ID is used as the Mapping identifier.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public override IEnumerable<(ExternalInterfaceType CaexObject, string MappingIdentifier)> SystemUnitClassMappingElements { get; }
```

#### Property Value
Type: [IEnumerable][2]&lt;[ValueTuple][3]&lt;[ExternalInterfaceType][4], [String][5]>>  
 The possible mapping identifiers to map ExternalInterfaces of the SystemUnitClass. 

See Also
--------

#### Reference
[InterfaceIDMappingType Class][6]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[3]: https://docs.microsoft.com/dotnet/api/system.valuetuple-2
[4]: ../ExternalInterfaceType/README.md
[5]: https://docs.microsoft.com/dotnet/api/system.string
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png