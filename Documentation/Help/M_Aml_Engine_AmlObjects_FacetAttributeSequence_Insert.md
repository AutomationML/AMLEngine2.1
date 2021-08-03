# FacetAttributeSequence.Insert Method 
AutomationML 2.1 API 

Inserts the specified attribute into this sequence. Before the attribute is inserted, it is checked, if it is a valid Facet attribute.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public override AttributeType Insert(
	AttributeType attribute,
	bool asFirst = true
)
```

**VB**<br />
``` VB
Public Overrides Function Insert ( 
	attribute As AttributeType,
	Optional asFirst As Boolean = true
) As AttributeType
```

**C++**<br />
``` C++
public:
virtual AttributeType^ Insert(
	AttributeType^ attribute, 
	bool asFirst = true
) override
```


#### Parameters
&nbsp;<dl><dt>attribute</dt><dd>Type: <a href="T_Aml_Engine_CAEX_AttributeType">Aml.Engine.CAEX.AttributeType</a><br />The Attribute.</dd><dt>asFirst (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />optional parameter, if set to `true (default)` the element is prepended to already existing ones, otherwise it is appended.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_AttributeType">AttributeType</a><br />\[Missing <returns> documentation for "M:Aml.Engine.AmlObjects.FacetAttributeSequence.Insert(Aml.Engine.CAEX.AttributeType,System.Boolean)"\]

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_FacetAttributeSequence">FacetAttributeSequence Class</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />