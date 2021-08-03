# FacetExternalInterfaceSequence.Insert Method 
AutomationML 2.1 API 

Inserts the specified ExternalInterface into this sequence. Before the ExternalInterface is inserted, it is checked, if it is a valid Facet-ExternalInterface.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public override ExternalInterfaceType Insert(
	ExternalInterfaceType extInterface,
	bool asFirst = true
)
```

**VB**<br />
``` VB
Public Overrides Function Insert ( 
	extInterface As ExternalInterfaceType,
	Optional asFirst As Boolean = true
) As ExternalInterfaceType
```

**C++**<br />
``` C++
public:
virtual ExternalInterfaceType^ Insert(
	ExternalInterfaceType^ extInterface, 
	bool asFirst = true
) override
```


#### Parameters
&nbsp;<dl><dt>extInterface</dt><dd>Type: <a href="T_Aml_Engine_CAEX_ExternalInterfaceType">Aml.Engine.CAEX.ExternalInterfaceType</a><br />The ExternalInterface.</dd><dt>asFirst (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />optional parameter, if set to `true (default)` the element is prepended to already existing ones, otherwise it is appended.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_ExternalInterfaceType">ExternalInterfaceType</a><br />\[Missing <returns> documentation for "M:Aml.Engine.AmlObjects.FacetExternalInterfaceSequence.Insert(Aml.Engine.CAEX.ExternalInterfaceType,System.Boolean)"\]

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_FacetExternalInterfaceSequence">FacetExternalInterfaceSequence Class</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />