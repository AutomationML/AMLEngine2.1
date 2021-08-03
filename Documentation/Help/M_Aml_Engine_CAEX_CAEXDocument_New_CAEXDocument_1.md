# CAEXDocument.New_CAEXDocument Method (CAEXDocument.CAEXSchema)
AutomationML 2.1 API 

Creates a new empty CAEX document containing only the CAEXFile element as the root element. The CAEX document is created using the specified schema version. The specified schema version defines the applicable editing methods.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static CAEXDocument New_CAEXDocument(
	CAEXDocument.CAEXSchema schema
)
```

**VB**<br />
``` VB
Public Shared Function New_CAEXDocument ( 
	schema As CAEXDocument.CAEXSchema
) As CAEXDocument
```

**C++**<br />
``` C++
public:
static CAEXDocument^ New_CAEXDocument(
	CAEXDocument.CAEXSchema schema
)
```


#### Parameters
&nbsp;<dl><dt>schema</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument_CAEXSchema">Aml.Engine.CAEX.CAEXDocument.CAEXSchema</a><br />The schema version which defines the CAEX document.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">CAEXDocument</a><br />The created CAEX document containing the CAEXFile root element.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_CAEXDocument">CAEXDocument Class</a><br /><a href="Overload_Aml_Engine_CAEX_CAEXDocument_New_CAEXDocument">New_CAEXDocument Overload</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />