# MappingElementType(*T*).SystemUnitClassMappingElements Property 
AutomationML 2.1 API 

Gets the collection of all possible elements and their mapping identifiers of the mapped SystemUnitClass and its ancestors in the inheritance tree for this mapping element. The mapping identifier uniquely identifies the mapped CAEX object. The syntax of the identifier is defined by the derived mapping element types and is build from the CAEX path of the object.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public abstract IEnumerable<(T , string MappingIdentifier)> SystemUnitClassMappingElements { get; }
```

**VB**<br />
``` VB
Public MustOverride ReadOnly Property SystemUnitClassMappingElements As IEnumerable(Of ( As T, MappingIdentifier As String))
	Get
```

**C++**<br />
``` C++
public:
virtual property IEnumerable<ValueTuple<T, String^>>^ SystemUnitClassMappingElements {
	IEnumerable<ValueTuple<T, String^>>^ get () abstract;
}
```


#### Property Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="https://docs.microsoft.com/dotnet/api/system.valuetuple-2" target="_parent" rel="noopener noreferrer">ValueTuple</a>(<a href="T_Aml_Engine_CAEX_MappingElementType_1">*T*</a>, <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a>))<br />The possible mapping elements and their identifiers of the mapped SystemUnitClass.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_MappingElementType_1">MappingElementType(T) Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />