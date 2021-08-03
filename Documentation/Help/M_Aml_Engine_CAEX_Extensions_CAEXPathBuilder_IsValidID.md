# CAEXPathBuilder.IsValidID Method 
AutomationML 2.1 API 

Determines whether the specified string can represent an ID

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static bool IsValidID(
	string idString,
	CAEXDocument document = null
)
```

**VB**<br />
``` VB
Public Shared Function IsValidID ( 
	idString As String,
	Optional document As CAEXDocument = Nothing
) As Boolean
```

**C++**<br />
``` C++
public:
static bool IsValidID(
	String^ idString, 
	CAEXDocument^ document = nullptr
)
```


#### Parameters
&nbsp;<dl><dt>idString</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The identifier string.</dd><dt>document (Optional)</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">Aml.Engine.CAEX.CAEXDocument</a><br />\[Missing <param name="document"/> documentation for "M:Aml.Engine.CAEX.Extensions.CAEXPathBuilder.IsValidID(System.String,Aml.Engine.CAEX.CAEXDocument)"\]</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true` if the specified identifier string can be used as an identifier; otherwise, `false`.

## Remarks
This method should only be used for testing strings which are retrieved from an attribute where an ID is a valid value. It is not possible to distinguish a Name from an ID, because it exists neither a defined syntax for object names nor for object IDs. Only if the UUID format is used to represent an ID the ID format is recognized.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_CAEXPathBuilder">CAEXPathBuilder Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />