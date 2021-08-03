AttributeNameMappingType.SystemUnitClassMappingElements Property
================================================================
AutomationML 2.1 APIGets the collection of possible mapping identifiers for this AttributeNameMappingType for elements of the mapped SystemUnitClass. The Collection contains all attributes (including inherited attributes) of the SystemUnitClass and also the attributes of the ExternalInterfaces (including inherited external interfaces) of the SystemUnitClass. The Attribute Identifiers are the unique CAEXPath's of the attributes relative to the SystemUnitClass.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public override IEnumerable<(AttributeType CaexObject, string MappingIdentifier)> SystemUnitClassMappingElements { get; }
```

#### Property Value
Type: [IEnumerable][2]&lt;[ValueTuple][3]&lt;[AttributeType][4], [String][5]>>  
 The possible mapping identifiers to map Attributes of the SystemUnitClass and its ExternalInterface objects. 

See Also
--------

#### Reference
[AttributeNameMappingType Class][6]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[3]: https://docs.microsoft.com/dotnet/api/system.valuetuple-2
[4]: ../AttributeType/README.md
[5]: https://docs.microsoft.com/dotnet/api/system.string
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png