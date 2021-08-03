# InterfaceNameMappingType.RoleClassMappingElements Method 
AutomationML 2.1 API 

Gets the collection of possible mapping identifiers for this InterfaceNameMappingType for elements of the mapped RoleClass. The Collection contains all ExternalInterfaces (including inherited) of the RoleClass. The ExternalInterface Name is used as the Mapping identifier.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public override IEnumerable<(ExternalInterfaceType CaexObject, string MappingIdentifier)> RoleClassMappingElements(
	bool includeDuplicates = false
)
```

**VB**<br />
``` VB
Public Overrides Function RoleClassMappingElements ( 
	Optional includeDuplicates As Boolean = false
) As IEnumerable(Of (CaexObject As ExternalInterfaceType, MappingIdentifier As String))
```

**C++**<br />
``` C++
public:
virtual IEnumerable<ValueTuple<ExternalInterfaceType^, String^>>^ RoleClassMappingElements(
	bool includeDuplicates = false
) override
```


#### Parameters
&nbsp;<dl><dt>includeDuplicates (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />\[Missing <param name="includeDuplicates"/> documentation for "M:Aml.Engine.CAEX.InterfaceNameMappingType.RoleClassMappingElements(System.Boolean)"\]</dd></dl>

#### Field Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="https://docs.microsoft.com/dotnet/api/system.valuetuple-2" target="_parent" rel="noopener noreferrer">ValueTuple</a>(<a href="T_Aml_Engine_CAEX_ExternalInterfaceType">ExternalInterfaceType</a>, <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a>))<br />The possible mapping identifiers to map ExternalInterfaces of the RoleClass.

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="https://docs.microsoft.com/dotnet/api/system.valuetuple-2" target="_parent" rel="noopener noreferrer">ValueTuple</a>(<a href="T_Aml_Engine_CAEX_ExternalInterfaceType">ExternalInterfaceType</a>, <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a>))<br />\[Missing <returns> documentation for "M:Aml.Engine.CAEX.InterfaceNameMappingType.RoleClassMappingElements(System.Boolean)"\]

## Remarks
The MultipleRole Concept in AutomationML 2.0 based on CAEX 2.15 allows the definition of Mappings to SupportedRoleClass objects. These Elements are only included in this collection, if a qualified element has been already assigned to the RoleRequirements object. To get the possible qualified RoleClass ExternalInterfaces, which are not already assigned to the RoleRequirements object, the method <a href="P_Aml_Engine_CAEX_RoleRequirementsType_UnAssignedQualifiedRoleClassInterfacesOfMultipleRoles">UnAssignedQualifiedRoleClassInterfacesOfMultipleRoles</a> can be used. 
If an instance supports multiple roles and the requirements to the different roles shall be stored at the instance, this shall be done using the CAEX element "RoleRequirements" whereas the corresponding attributes or interfaces are directly assigned including the role name, a separator string "." and the attribute or interface name.


## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_InterfaceNameMappingType">InterfaceNameMappingType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />