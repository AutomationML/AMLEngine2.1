# SchemaTransformationEventArgs Constructor 
AutomationML 2.1 API 

Initializes a new instance of the <a href="T_Aml_Engine_Services_Interfaces_SchemaTransformationEventArgs">SchemaTransformationEventArgs</a> class.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public SchemaTransformationEventArgs(
	CAEXDocument sourceDocument,
	CAEXDocument.CAEXSchema targetSchema
)
```

**VB**<br />
``` VB
Public Sub New ( 
	sourceDocument As CAEXDocument,
	targetSchema As CAEXDocument.CAEXSchema
)
```

**C++**<br />
``` C++
public:
SchemaTransformationEventArgs(
	CAEXDocument^ sourceDocument, 
	CAEXDocument.CAEXSchema targetSchema
)
```


#### Parameters
&nbsp;<dl><dt>sourceDocument</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">Aml.Engine.CAEX.CAEXDocument</a><br />The source document.</dd><dt>targetSchema</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument_CAEXSchema">Aml.Engine.CAEX.CAEXDocument.CAEXSchema</a><br />The target schema.</dd></dl>

## See Also


#### Reference
<a href="T_Aml_Engine_Services_Interfaces_SchemaTransformationEventArgs">SchemaTransformationEventArgs Class</a><br /><a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces Namespace</a><br />