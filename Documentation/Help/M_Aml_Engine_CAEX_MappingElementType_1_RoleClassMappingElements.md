# MappingElementType(*T*).RoleClassMappingElements Method 
AutomationML 2.1 API 

Gets the collection of all possible elements and their mapping identifiers of the mapped RoleClass and its ancestors in the inheritance tree for this mapping element. The mapping identifier uniquely identifies the mapped CAEX object. The syntax of the identifier is defined by the derived mapping element types and is build from the CAEX path of the object.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public abstract IEnumerable<(T , string MappingIdentifier)> RoleClassMappingElements(
	bool includeDuplicates = false
)
```

**VB**<br />
``` VB
Public MustOverride Function RoleClassMappingElements ( 
	Optional includeDuplicates As Boolean = false
) As IEnumerable(Of ( As T, MappingIdentifier As String))
```

**C++**<br />
``` C++
public:
virtual IEnumerable<ValueTuple<T, String^>>^ RoleClassMappingElements(
	bool includeDuplicates = false
) abstract
```


#### Parameters
&nbsp;<dl><dt>includeDuplicates (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />\[Missing <param name="includeDuplicates"/> documentation for "M:Aml.Engine.CAEX.MappingElementType`1.RoleClassMappingElements(System.Boolean)"\]</dd></dl>

#### Field Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="https://docs.microsoft.com/dotnet/api/system.valuetuple-2" target="_parent" rel="noopener noreferrer">ValueTuple</a>(<a href="T_Aml_Engine_CAEX_MappingElementType_1">*T*</a>, <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a>))<br />The possible mapping elements and their identifiers of the mapped RoleClass.

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="https://docs.microsoft.com/dotnet/api/system.valuetuple-2" target="_parent" rel="noopener noreferrer">ValueTuple</a>(<a href="T_Aml_Engine_CAEX_MappingElementType_1">*T*</a>, <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a>))<br />\[Missing <returns> documentation for "M:Aml.Engine.CAEX.MappingElementType`1.RoleClassMappingElements(System.Boolean)"\]

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_MappingElementType_1">MappingElementType(T) Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />