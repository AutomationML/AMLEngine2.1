InterfaceIDMappingType.RoleClassMappingElements Method
======================================================
Gets the collection of possible mapping identifiers for this InterfaceIDMappingType for elements of the mapped RoleClass. The Collection contains all ExternalInterfaces (including inherited and descendants) of the RoleClass. The ExternalInterface ID is used as the Mapping identifier.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public override IEnumerable<(ExternalInterfaceType CaexObject, string MappingIdentifier)> RoleClassMappingElements(
	bool includeDuplicates = false
)
```

#### Parameters

##### *includeDuplicates* (Optional)
Type: [System.Boolean][2]  

[Missing &lt;param name="includeDuplicates"/> documentation for "M:Aml.Engine.CAEX.InterfaceIDMappingType.RoleClassMappingElements(System.Boolean)"]


#### Field Value
Type: [IEnumerable][3]&lt;[ValueTuple][4]&lt;[ExternalInterfaceType][5], [String][6]>>  
 The possible mapping identifiers to map ExternalInterfaces of the RoleClass. 
#### Return Value
Type: [IEnumerable][3]&lt;[ValueTuple][4]&lt;[ExternalInterfaceType][5], [String][6]>>  

[Missing &lt;returns> documentation for "M:Aml.Engine.CAEX.InterfaceIDMappingType.RoleClassMappingElements(System.Boolean)"]


See Also
--------

#### Reference
[InterfaceIDMappingType Class][7]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.boolean
[3]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[4]: https://docs.microsoft.com/dotnet/api/system.valuetuple-2
[5]: ../ExternalInterfaceType/README.md
[6]: https://docs.microsoft.com/dotnet/api/system.string
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png