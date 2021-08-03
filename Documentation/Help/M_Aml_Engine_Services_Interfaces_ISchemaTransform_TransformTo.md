# ISchemaTransform.TransformTo Method 
AutomationML 2.1 API 

Method to do a schema transformation for the provided document to the defined schema. This method can be used for upward and downward transformations.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
CAEXDocument TransformTo(
	CAEXDocument document,
	CAEXDocument.CAEXSchema targetSchema
)
```

**VB**<br />
``` VB
Function TransformTo ( 
	document As CAEXDocument,
	targetSchema As CAEXDocument.CAEXSchema
) As CAEXDocument
```

**C++**<br />
``` C++
CAEXDocument^ TransformTo(
	CAEXDocument^ document, 
	CAEXDocument.CAEXSchema targetSchema
)
```


#### Parameters
&nbsp;<dl><dt>document</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">Aml.Engine.CAEX.CAEXDocument</a><br />the document to be transformed</dd><dt>targetSchema</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument_CAEXSchema">Aml.Engine.CAEX.CAEXDocument.CAEXSchema</a><br />the target schema</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">CAEXDocument</a><br />the transformed document

## See Also


#### Reference
<a href="T_Aml_Engine_Services_Interfaces_ISchemaTransform">ISchemaTransform Interface</a><br /><a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces Namespace</a><br />