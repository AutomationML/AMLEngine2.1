# AMLFacet.Create Method 
AutomationML 2.1 API 

Creates an AMLFacet AML object with this name, using the provided document.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static AMLFacet Create(
	CAEXDocument document,
	string name
)
```

**VB**<br />
``` VB
Public Shared Function Create ( 
	document As CAEXDocument,
	name As String
) As AMLFacet
```

**C++**<br />
``` C++
public:
static AMLFacet^ Create(
	CAEXDocument^ document, 
	String^ name
)
```


#### Parameters
&nbsp;<dl><dt>document</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">Aml.Engine.CAEX.CAEXDocument</a><br />The CAEX document.</dd><dt>name</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The name of the new AMLFacet.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_AmlObjects_AMLFacet">AMLFacet</a><br />The created AMLFacet.

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_AMLFacet">AMLFacet Class</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />