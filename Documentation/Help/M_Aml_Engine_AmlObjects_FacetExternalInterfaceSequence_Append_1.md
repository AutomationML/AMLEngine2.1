# FacetExternalInterfaceSequence.Append Method (String)
AutomationML 2.1 API 

Appends a new element with the provided name to this sequence. Before the ExternalInterface is appended, it is checked, if the ExternalInterface name is already used for any ExternalInterface of the AMLFacet parent.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public override ExternalInterfaceType Append(
	string name
)
```

**VB**<br />
``` VB
Public Overrides Function Append ( 
	name As String
) As ExternalInterfaceType
```

**C++**<br />
``` C++
public:
virtual ExternalInterfaceType^ Append(
	String^ name
) override
```


#### Parameters
&nbsp;<dl><dt>name</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The name of the new ExternalInterface object.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_ExternalInterfaceType">ExternalInterfaceType</a><br />The appended ExternalInterface.

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_FacetExternalInterfaceSequence">FacetExternalInterfaceSequence Class</a><br /><a href="Overload_Aml_Engine_AmlObjects_FacetExternalInterfaceSequence_Append">Append Overload</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />