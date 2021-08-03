# CAEXPathBuilder.IsAttributeReference Method 
AutomationML 2.1 API 

Determines, if the path is an Attribute reference. This method is able to distinguish if an UUID is combined with a CAEX path

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static bool IsAttributeReference(
	CAEXDocument document,
	string attributeReference
)
```

**VB**<br />
``` VB
Public Shared Function IsAttributeReference ( 
	document As CAEXDocument,
	attributeReference As String
) As Boolean
```

**C++**<br />
``` C++
public:
static bool IsAttributeReference(
	CAEXDocument^ document, 
	String^ attributeReference
)
```


#### Parameters
&nbsp;<dl><dt>document</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">Aml.Engine.CAEX.CAEXDocument</a><br />The document, where the reference is tested.</dd><dt>attributeReference</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The attribute reference.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true`, if the provided reference is an attribute reference.

## Remarks
This method should only be used for CAEXDocuments based at least on CAEX Version 3.0

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_CAEXPathBuilder">CAEXPathBuilder Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />