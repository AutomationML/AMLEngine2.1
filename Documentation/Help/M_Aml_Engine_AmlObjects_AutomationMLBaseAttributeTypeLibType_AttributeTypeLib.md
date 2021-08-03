# AutomationMLBaseAttributeTypeLibType.AttributeTypeLib Method 
AutomationML 2.1 API 

Gets the AutomationMLBaseAttributeTypeLib from the provided document. If the document doesn't contain the required library it will be automatically imported from an external resource.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static AutomationMLBaseAttributeTypeLibType AttributeTypeLib(
	CAEXDocument document
)
```

**VB**<br />
``` VB
Public Shared Function AttributeTypeLib ( 
	document As CAEXDocument
) As AutomationMLBaseAttributeTypeLibType
```

**C++**<br />
``` C++
public:
static AutomationMLBaseAttributeTypeLibType^ AttributeTypeLib(
	CAEXDocument^ document
)
```


#### Parameters
&nbsp;<dl><dt>document</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">Aml.Engine.CAEX.CAEXDocument</a><br />The CAEX document.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_AmlObjects_AutomationMLBaseAttributeTypeLibType">AutomationMLBaseAttributeTypeLibType</a><br />The AutomationMLBaseAttributeTypeLib

## Remarks
Not available for CAEX version 2.15

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_AutomationMLBaseAttributeTypeLibType">AutomationMLBaseAttributeTypeLibType Class</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />