# CAEXPathBuilder.PathPart Method (XElement, Boolean)
AutomationML 2.1 API 

transforms the name of the defined element to a path Part (special characters are escaped).

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static string PathPart(
	XElement element,
	bool useId = false
)
```

**VB**<br />
``` VB
Public Shared Function PathPart ( 
	element As XElement,
	Optional useId As Boolean = false
) As String
```

**C++**<br />
``` C++
public:
static String^ PathPart(
	XElement^ element, 
	bool useId = false
)
```


#### Parameters
&nbsp;<dl><dt>element</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement" target="_parent" rel="noopener noreferrer">System.Xml.Linq.XElement</a><br />The element.</dd><dt>useId (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />if set to `true` use the Elements ID, otherwise use its name.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a><br />System.String.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_CAEXPathBuilder">CAEXPathBuilder Class</a><br /><a href="Overload_Aml_Engine_CAEX_Extensions_CAEXPathBuilder_PathPart">PathPart Overload</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />