# CAEXPathBuilder.CAEXPath Method (IEnumerable(XElement))
AutomationML 2.1 API 

Builds the Reference-Path which includes all Names of CAEXObjects in the given list of elements.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static string CAEXPath(
	IEnumerable<XElement> elementNodes
)
```

**VB**<br />
``` VB
Public Shared Function CAEXPath ( 
	elementNodes As IEnumerable(Of XElement)
) As String
```

**C++**<br />
``` C++
public:
static String^ CAEXPath(
	IEnumerable<XElement^>^ elementNodes
)
```


#### Parameters
&nbsp;<dl><dt>elementNodes</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">System.Collections.Generic.IEnumerable</a>(<a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement" target="_parent" rel="noopener noreferrer">XElement</a>)<br />The XML nodes of the CAEX objects.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a><br />The CAEX Path, build from the element XML nodes.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_CAEXPathBuilder">CAEXPathBuilder Class</a><br /><a href="Overload_Aml_Engine_CAEX_Extensions_CAEXPathBuilder_CAEXPath">CAEXPath Overload</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />