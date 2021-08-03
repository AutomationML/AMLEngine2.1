# AttributeNameMappingType.SystemUnitClassMappingElements Property 
AutomationML 2.1 API 

Gets the collection of possible mapping identifiers for this AttributeNameMappingType for elements of the mapped SystemUnitClass. The Collection contains all attributes (including inherited attributes) of the SystemUnitClass and also the attributes of the ExternalInterfaces (including inherited external interfaces) of the SystemUnitClass. The Attribute Identifiers are the unique CAEXPath's of the attributes relative to the SystemUnitClass.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public override IEnumerable<(AttributeType CaexObject, string MappingIdentifier)> SystemUnitClassMappingElements { get; }
```

**VB**<br />
``` VB
Public Overrides ReadOnly Property SystemUnitClassMappingElements As IEnumerable(Of (CaexObject As AttributeType, MappingIdentifier As String))
	Get
```

**C++**<br />
``` C++
public:
virtual property IEnumerable<ValueTuple<AttributeType^, String^>>^ SystemUnitClassMappingElements {
	IEnumerable<ValueTuple<AttributeType^, String^>>^ get () override;
}
```


#### Property Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="https://docs.microsoft.com/dotnet/api/system.valuetuple-2" target="_parent" rel="noopener noreferrer">ValueTuple</a>(<a href="T_Aml_Engine_CAEX_AttributeType">AttributeType</a>, <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a>))<br />The possible mapping identifiers to map Attributes of the SystemUnitClass and its ExternalInterface objects.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_AttributeNameMappingType">AttributeNameMappingType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />