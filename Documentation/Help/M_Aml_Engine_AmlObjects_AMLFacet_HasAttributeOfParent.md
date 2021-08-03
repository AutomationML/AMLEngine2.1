# AMLFacet.HasAttributeOfParent Method 
AutomationML 2.1 API 

Determines whether the AMLFacet contains this attribute of the parent AML object.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public bool HasAttributeOfParent(
	AttributeType attribute
)
```

**VB**<br />
``` VB
Public Function HasAttributeOfParent ( 
	attribute As AttributeType
) As Boolean
```

**C++**<br />
``` C++
public:
bool HasAttributeOfParent(
	AttributeType^ attribute
)
```


#### Parameters
&nbsp;<dl><dt>attribute</dt><dd>Type: <a href="T_Aml_Engine_CAEX_AttributeType">Aml.Engine.CAEX.AttributeType</a><br />An attribute of the parent.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true` if this attribute of the parent is assigned to the AMLFacet; otherwise, `false`.

## Remarks
In CAEX 3.0 the Attribute of the AMLFacet has to be a Mirror Attribute. CAEX 2.15 identifies Attributes with identical names.

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_AMLFacet">AMLFacet Class</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />