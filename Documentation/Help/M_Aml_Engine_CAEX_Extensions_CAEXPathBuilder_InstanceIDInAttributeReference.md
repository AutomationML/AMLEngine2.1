# CAEXPathBuilder.InstanceIDInAttributeReference Method 
AutomationML 2.1 API 

Gets the ID of the master parent instance from a reference defined in an Attribute mirror object in the specified CAEX document.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static string InstanceIDInAttributeReference(
	string reference,
	CAEXDocument document,
	out bool isAttributeReference
)
```

**VB**<br />
``` VB
Public Shared Function InstanceIDInAttributeReference ( 
	reference As String,
	document As CAEXDocument,
	<OutAttribute> ByRef isAttributeReference As Boolean
) As String
```

**C++**<br />
``` C++
public:
static String^ InstanceIDInAttributeReference(
	String^ reference, 
	CAEXDocument^ document, 
	[OutAttribute] bool% isAttributeReference
)
```


#### Parameters
&nbsp;<dl><dt>reference</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The reference from the Attribute mirror object.</dd><dt>document</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">Aml.Engine.CAEX.CAEXDocument</a><br />The document.</dd><dt>isAttributeReference</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />if set to `true`, if the reference is an Attribute reference in a mirror.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a><br />The master parent ID

## Remarks
Only valid since CAEX Version 3.0

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_CAEXPathBuilder">CAEXPathBuilder Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />