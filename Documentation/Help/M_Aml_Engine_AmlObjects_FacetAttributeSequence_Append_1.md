# FacetAttributeSequence.Append Method (String)
AutomationML 2.1 API 

Appends a new Attribute with the provided name to the sequence of Attributes, if the conditions for Facet Attributes are fulfilled. Facet Attributes are a subset of Attributes which are defined for the Parent object of an <a href="T_Aml_Engine_AmlObjects_AMLFacet">AMLFacet</a>. An Attribute with the specified name can only be added as a Facet Attribute, if the Facets parent has an identical Attribute with that name and the Attribute has not been associated to the Facet before.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public override AttributeType Append(
	string name
)
```

**VB**<br />
``` VB
Public Overrides Function Append ( 
	name As String
) As AttributeType
```

**C++**<br />
``` C++
public:
virtual AttributeType^ Append(
	String^ name
) override
```


#### Parameters
&nbsp;<dl><dt>name</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The name of the Attribute.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_AttributeType">AttributeType</a><br />The created and appended Attribute, if the conditions were fulfilled; otherwise `null`.

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_FacetAttributeSequence">FacetAttributeSequence Class</a><br /><a href="Overload_Aml_Engine_AmlObjects_FacetAttributeSequence_Append">Append Overload</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />