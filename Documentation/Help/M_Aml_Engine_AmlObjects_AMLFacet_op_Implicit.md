# AMLFacet&nbsp;Implicit Conversion (AMLFacet to ObjectWithAMLAttributes)
AutomationML 2.1 API 

Conversion to get access to specific AutomationML defined Attributes

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static implicit operator ObjectWithAMLAttributes (
	AMLFacet facet
)
```

**VB**<br />
``` VB
Public Shared Widening Operator CType ( 
	facet As AMLFacet
) As ObjectWithAMLAttributes
```

**C++**<br />
``` C++
static implicit operator ObjectWithAMLAttributes^ (
	AMLFacet^ facet
)
```


#### Parameters
&nbsp;<dl><dt>facet</dt><dd>Type: <a href="T_Aml_Engine_AmlObjects_AMLFacet">Aml.Engine.AmlObjects.AMLFacet</a><br />The 'AMLFacet' CAEX object.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_AmlObjects_ObjectWithAMLAttributes">ObjectWithAMLAttributes</a><br />The AMLFacet object, converted to an <a href="T_Aml_Engine_AmlObjects_ObjectWithAMLAttributes">ObjectWithAMLAttributes</a> type, which provides access to specific AML defined attributes.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td>attributeType</td></tr></table>

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_AMLFacet">AMLFacet Class</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />