# InterfaceNameMappingType.SystemUnitClassMappingElements Property 
AutomationML 2.1 API 

Gets the collection of possible mapping identifiers for this InterfaceNameMappingType for elements of the mapped SystemUnitClass. The Collection contains all ExternalInterfaces (including inherited) of the SystemUnitClass. The ExternalInterface Name is used as the Mapping identifier.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public override IEnumerable<(ExternalInterfaceType CaexObject, string MappingIdentifier)> SystemUnitClassMappingElements { get; }
```

**VB**<br />
``` VB
Public Overrides ReadOnly Property SystemUnitClassMappingElements As IEnumerable(Of (CaexObject As ExternalInterfaceType, MappingIdentifier As String))
	Get
```

**C++**<br />
``` C++
public:
virtual property IEnumerable<ValueTuple<ExternalInterfaceType^, String^>>^ SystemUnitClassMappingElements {
	IEnumerable<ValueTuple<ExternalInterfaceType^, String^>>^ get () override;
}
```


#### Property Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="https://docs.microsoft.com/dotnet/api/system.valuetuple-2" target="_parent" rel="noopener noreferrer">ValueTuple</a>(<a href="T_Aml_Engine_CAEX_ExternalInterfaceType">ExternalInterfaceType</a>, <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a>))<br />The possible mapping identifiers to map ExternalInterfaces of the SystemUnitClass.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_InterfaceNameMappingType">InterfaceNameMappingType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />