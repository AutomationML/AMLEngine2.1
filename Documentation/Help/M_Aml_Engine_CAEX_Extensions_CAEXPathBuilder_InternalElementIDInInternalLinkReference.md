# CAEXPathBuilder.InternalElementIDInInternalLinkReference Method 
AutomationML 2.1 API 

Gets the InternalElement ID from a reference defined in an InternalLink object.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static string InternalElementIDInInternalLinkReference(
	string reference,
	out bool isInterfaceReference
)
```

**VB**<br />
``` VB
Public Shared Function InternalElementIDInInternalLinkReference ( 
	reference As String,
	<OutAttribute> ByRef isInterfaceReference As Boolean
) As String
```

**C++**<br />
``` C++
public:
static String^ InternalElementIDInInternalLinkReference(
	String^ reference, 
	[OutAttribute] bool% isInterfaceReference
)
```


#### Parameters
&nbsp;<dl><dt>reference</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The reference from the InternalLink object.</dd><dt>isInterfaceReference</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />if set to `true` [is interface reference].</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a><br />The InternalElement ID

## Remarks
Only valid for CAEX Version 2.15

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_CAEXPathBuilder">CAEXPathBuilder Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />