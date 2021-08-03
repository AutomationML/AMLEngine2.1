# AutomationMLInterfaceClassLibType.InterfaceClassLib Method 
AutomationML 2.1 API 

Gets the standard AutomationMLInterfaceClassLib from the provided document. If the document doesn't contain the required library it will be automatically imported from an external resource.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static AutomationMLInterfaceClassLibType InterfaceClassLib(
	CAEXDocument document
)
```

**VB**<br />
``` VB
Public Shared Function InterfaceClassLib ( 
	document As CAEXDocument
) As AutomationMLInterfaceClassLibType
```

**C++**<br />
``` C++
public:
static AutomationMLInterfaceClassLibType^ InterfaceClassLib(
	CAEXDocument^ document
)
```


#### Parameters
&nbsp;<dl><dt>document</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">Aml.Engine.CAEX.CAEXDocument</a><br />The CAEX document.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_AmlObjects_AutomationMLInterfaceClassLibType">AutomationMLInterfaceClassLibType</a><br />The AutomationMLBaseRoleClassLib

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_AutomationMLInterfaceClassLibType">AutomationMLInterfaceClassLibType Class</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />