# CAEXPathBuilder.PathPartSeparator Method (XElement)
AutomationML 2.1 API 

Returns the Path part separator for an element, which should be put before that element in a Path

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static char PathPartSeparator(
	XElement element
)
```

**VB**<br />
``` VB
Public Shared Function PathPartSeparator ( 
	element As XElement
) As Char
```

**C++**<br />
``` C++
public:
static wchar_t PathPartSeparator(
	XElement^ element
)
```


#### Parameters
&nbsp;<dl><dt>element</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement" target="_parent" rel="noopener noreferrer">System.Xml.Linq.XElement</a><br />The Xml-Node of the CAEX-Element.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.char" target="_parent" rel="noopener noreferrer">Char</a><br />The Path Separation character for the given element

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_CAEXPathBuilder">CAEXPathBuilder Class</a><br /><a href="Overload_Aml_Engine_CAEX_Extensions_CAEXPathBuilder_PathPartSeparator">PathPartSeparator Overload</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />