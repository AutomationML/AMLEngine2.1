# ICAEXWrapper.CAEXChild Method 
AutomationML 2.1 API 

Gets the first child of this CAEX object with the defined CAEX tag name.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
CAEXWrapper CAEXChild(
	string tagName
)
```

**VB**<br />
``` VB
Function CAEXChild ( 
	tagName As String
) As CAEXWrapper
```

**C++**<br />
``` C++
CAEXWrapper^ CAEXChild(
	String^ tagName
)
```


#### Parameters
&nbsp;<dl><dt>tagName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The CAEX tag name of the child.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a><br />The child, if it exists; otherwise `null`.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_ICAEXWrapper">ICAEXWrapper Interface</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />