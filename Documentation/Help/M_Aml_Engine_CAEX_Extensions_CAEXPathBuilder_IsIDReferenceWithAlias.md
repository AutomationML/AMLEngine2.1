# CAEXPathBuilder.IsIDReferenceWithAlias Method 
AutomationML 2.1 API 

Determines whether the specified object reference is an alias reference to an ID in the specified document

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static bool IsIDReferenceWithAlias(
	string objectRefrence,
	CAEXDocument document,
	CAEXPathBuilder.IDRefEnum referenceType = CAEXPathBuilder.IDRefEnum.AllTypes
)
```

**VB**<br />
``` VB
Public Shared Function IsIDReferenceWithAlias ( 
	objectRefrence As String,
	document As CAEXDocument,
	Optional referenceType As CAEXPathBuilder.IDRefEnum = CAEXPathBuilder.IDRefEnum.AllTypes
) As Boolean
```

**C++**<br />
``` C++
public:
static bool IsIDReferenceWithAlias(
	String^ objectRefrence, 
	CAEXDocument^ document, 
	CAEXPathBuilder.IDRefEnum referenceType = CAEXPathBuilder.IDRefEnum::AllTypes
)
```


#### Parameters
&nbsp;<dl><dt>objectRefrence</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The object reference.</dd><dt>document</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">Aml.Engine.CAEX.CAEXDocument</a><br />The document.</dd><dt>referenceType (Optional)</dt><dd>Type: <a href="T_Aml_Engine_CAEX_Extensions_CAEXPathBuilder_IDRefEnum">Aml.Engine.CAEX.Extensions.CAEXPathBuilder.IDRefEnum</a><br />Optional parameter to specify the type of the reference. If not set, all possible types are checked</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true` if the specified object reference is an alias reference to an ID; otherwise, `false`.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_CAEXPathBuilder">CAEXPathBuilder Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />