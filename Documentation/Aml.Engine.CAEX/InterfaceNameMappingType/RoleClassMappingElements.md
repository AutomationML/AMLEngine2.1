InterfaceNameMappingType.RoleClassMappingElements Method
========================================================
Gets the collection of possible mapping identifiers for this InterfaceNameMappingType for elements of the mapped RoleClass. The Collection contains all ExternalInterfaces (including inherited) of the RoleClass. The ExternalInterface Name is used as the Mapping identifier.

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

[Missing &lt;param name="includeDuplicates"/> documentation for "M:Aml.Engine.CAEX.InterfaceNameMappingType.RoleClassMappingElements(System.Boolean)"]


#### Field Value
Type: [IEnumerable][3]&lt;[ValueTuple][4]&lt;[ExternalInterfaceType][5], [String][6]>>  
 The possible mapping identifiers to map ExternalInterfaces of the RoleClass. 
#### Return Value
Type: [IEnumerable][3]&lt;[ValueTuple][4]&lt;[ExternalInterfaceType][5], [String][6]>>  

[Missing &lt;returns> documentation for "M:Aml.Engine.CAEX.InterfaceNameMappingType.RoleClassMappingElements(System.Boolean)"]


Remarks
-------
 The MultipleRole Concept in AutomationML 2.0 based on CAEX 2.15 allows the definition of Mappings to SupportedRoleClass objects. These Elements are only included in this collection, if a qualified element has been already assigned to the RoleRequirements object. To get the possible qualified RoleClass ExternalInterfaces, which are not already assigned to the RoleRequirements object, the method [UnAssignedQualifiedRoleClassInterfacesOfMultipleRoles][7] can be used. 

If an instance supports multiple roles and the requirements to the different roles shall be stored at the instance, this shall be done using the CAEX element "RoleRequirements" whereas the corresponding attributes or interfaces are directly assigned including the role name, a separator string "." and the attribute or interface name.


See Also
--------

#### Reference
[InterfaceNameMappingType Class][8]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.boolean
[3]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[4]: https://docs.microsoft.com/dotnet/api/system.valuetuple-2
[5]: ../ExternalInterfaceType/README.md
[6]: https://docs.microsoft.com/dotnet/api/system.string
[7]: ../RoleRequirementsType/UnAssignedQualifiedRoleClassInterfacesOfMultipleRoles.md
[8]: README.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png