# AMLFacet.HasInterfaceOfParent Method 
AutomationML 2.1 API 

Determines whether the AMLFacet contains this interface of the parent AML object.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public bool HasInterfaceOfParent(
	ExternalInterfaceType externalInterface
)
```

**VB**<br />
``` VB
Public Function HasInterfaceOfParent ( 
	externalInterface As ExternalInterfaceType
) As Boolean
```

**C++**<br />
``` C++
public:
bool HasInterfaceOfParent(
	ExternalInterfaceType^ externalInterface
)
```


#### Parameters
&nbsp;<dl><dt>externalInterface</dt><dd>Type: <a href="T_Aml_Engine_CAEX_ExternalInterfaceType">Aml.Engine.CAEX.ExternalInterfaceType</a><br />The external interface.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true` if this interface of the parent is assigned to the AMLFacet; otherwise, `false`.

## Remarks
In CAEX 3.0 the Interface of the AMLFacet has to be a Mirror Interface. CAEX 2.15 identifies Interfaces with identical names.

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_AMLFacet">AMLFacet Class</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />