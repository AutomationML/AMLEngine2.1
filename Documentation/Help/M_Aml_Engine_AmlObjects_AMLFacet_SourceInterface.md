# AMLFacet.SourceInterface Method 
AutomationML 2.1 API 

Gets the original ExternalInterface from the <a href="M_Aml_Engine_AmlObjects_AMLFacet_AssignedParentInterfaces">AssignedParentInterfaces()</a> which is related to this Facet Interface.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public ExternalInterfaceType SourceInterface(
	ExternalInterfaceType facetInterface
)
```

**VB**<br />
``` VB
Public Function SourceInterface ( 
	facetInterface As ExternalInterfaceType
) As ExternalInterfaceType
```

**C++**<br />
``` C++
public:
ExternalInterfaceType^ SourceInterface(
	ExternalInterfaceType^ facetInterface
)
```


#### Parameters
&nbsp;<dl><dt>facetInterface</dt><dd>Type: <a href="T_Aml_Engine_CAEX_ExternalInterfaceType">Aml.Engine.CAEX.ExternalInterfaceType</a><br />The facet ExternalInterface.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_ExternalInterfaceType">ExternalInterfaceType</a><br />An ExternalInterface from the parent with the same name.

## Remarks
In CAEX 3.0 the Source Interface is the Master Interface of the *facetInterface*. CAEX 2.15 the Source Interface is the first identified Interface of the parent with an identical name.

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_AMLFacet">AMLFacet Class</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />