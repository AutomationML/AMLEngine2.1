# CAEXWrapper.CAEXChildren Method 
AutomationML 2.1 API 

Gets all children of this CAEX object with the defined CAEX tag name.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public IEnumerable<CAEXWrapper> CAEXChildren(
	string tagName
)
```

**VB**<br />
``` VB
Public Function CAEXChildren ( 
	tagName As String
) As IEnumerable(Of CAEXWrapper)
```

**C++**<br />
``` C++
public:
virtual IEnumerable<CAEXWrapper^>^ CAEXChildren(
	String^ tagName
) sealed
```


#### Parameters
&nbsp;<dl><dt>tagName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The CAEX tag name of the child.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a>)<br />The children, if existing; otherwise `Enumerable.Empty`.

#### Implements
<a href="M_Aml_Engine_CAEX_ICAEXWrapper_CAEXChildren">ICAEXWrapper.CAEXChildren(String)</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />