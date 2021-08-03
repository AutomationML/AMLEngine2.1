# CAEXTypeDictionary.TryGetCreator Method 
AutomationML 2.1 API 

Tries to get the constructor function which can be used to create a CAEX wrapper for an CAEX element with the provided element name.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public bool TryGetCreator(
	string elementName,
	out Func<XElement, CAEXWrapper> creatorFunc
)
```

**VB**<br />
``` VB
Public Function TryGetCreator ( 
	elementName As String,
	<OutAttribute> ByRef creatorFunc As Func(Of XElement, CAEXWrapper)
) As Boolean
```

**C++**<br />
``` C++
public:
bool TryGetCreator(
	String^ elementName, 
	[OutAttribute] Func<XElement^, CAEXWrapper^>^% creatorFunc
)
```


#### Parameters
&nbsp;<dl><dt>elementName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The local name of the CAEX element.</dd><dt>creatorFunc</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.func-2" target="_parent" rel="noopener noreferrer">System.Func</a>(<a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement" target="_parent" rel="noopener noreferrer">XElement</a>, <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a>)<br />The function to create the CAEX wrapper.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true` (`True` in Visual Basic)if a function exists.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_CAEXTypeDictionary">CAEXTypeDictionary Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />