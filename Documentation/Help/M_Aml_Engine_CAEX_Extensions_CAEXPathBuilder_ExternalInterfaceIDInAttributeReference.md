# CAEXPathBuilder.ExternalInterfaceIDInAttributeReference Method 
AutomationML 2.1 API 

Check, if the provided reference is a reference to an attribute of an ExternalInterface, using the ID of an ExternalInterface.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static string ExternalInterfaceIDInAttributeReference(
	string reference,
	CAEXDocument cAEXDocument,
	out bool isIdReference
)
```

**VB**<br />
``` VB
Public Shared Function ExternalInterfaceIDInAttributeReference ( 
	reference As String,
	cAEXDocument As CAEXDocument,
	<OutAttribute> ByRef isIdReference As Boolean
) As String
```

**C++**<br />
``` C++
public:
static String^ ExternalInterfaceIDInAttributeReference(
	String^ reference, 
	CAEXDocument^ cAEXDocument, 
	[OutAttribute] bool% isIdReference
)
```


#### Parameters
&nbsp;<dl><dt>reference</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The reference.</dd><dt>cAEXDocument</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">Aml.Engine.CAEX.CAEXDocument</a><br />The CAEX document.</dd><dt>isIdReference</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />if set to `true` a valid ID is used to reference an ExternalInterface.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a><br />the normalized ID if the reference contains an ID

## Remarks
This method only recognizes GUIDs in a reference.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_CAEXPathBuilder">CAEXPathBuilder Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />