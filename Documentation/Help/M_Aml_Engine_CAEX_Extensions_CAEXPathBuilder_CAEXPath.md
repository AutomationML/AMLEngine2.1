# CAEXPathBuilder.CAEXPath Method (IEnumerable(CAEXObject))
AutomationML 2.1 API 

Builds the Reference-Path which includes all Names of CAEXObjects in the given list of CAEX objects.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static string CAEXPath(
	IEnumerable<CAEXObject> elements
)
```

**VB**<br />
``` VB
Public Shared Function CAEXPath ( 
	elements As IEnumerable(Of CAEXObject)
) As String
```

**C++**<br />
``` C++
public:
static String^ CAEXPath(
	IEnumerable<CAEXObject^>^ elements
)
```


#### Parameters
&nbsp;<dl><dt>elements</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">System.Collections.Generic.IEnumerable</a>(<a href="T_Aml_Engine_CAEX_CAEXObject">CAEXObject</a>)<br />The CAEX objects.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a><br />The CAEX Path, build from the object list.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_CAEXPathBuilder">CAEXPathBuilder Class</a><br /><a href="Overload_Aml_Engine_CAEX_Extensions_CAEXPathBuilder_CAEXPath">CAEXPath Overload</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />