# AMLFacet.SourceAttribute Method 
AutomationML 2.1 API 

Gets the original Attribute from the <a href="M_Aml_Engine_AmlObjects_AMLFacet_AssignedParentAttributes">AssignedParentAttributes()</a> which is related to this Facet Attribute.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public AttributeType SourceAttribute(
	AttributeType facetAttribute
)
```

**VB**<br />
``` VB
Public Function SourceAttribute ( 
	facetAttribute As AttributeType
) As AttributeType
```

**C++**<br />
``` C++
public:
AttributeType^ SourceAttribute(
	AttributeType^ facetAttribute
)
```


#### Parameters
&nbsp;<dl><dt>facetAttribute</dt><dd>Type: <a href="T_Aml_Engine_CAEX_AttributeType">Aml.Engine.CAEX.AttributeType</a><br />The facet attribute.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_AttributeType">AttributeType</a><br />An Attribute from the parent with the same name.

## Remarks
In CAEX 3.0 the Source Attribute is the Master Attribute of the *facetAttribute*. CAEX 2.15 the Source Attribute is the first identified Attribute of the parent with an identical name.

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_AMLFacet">AMLFacet Class</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />