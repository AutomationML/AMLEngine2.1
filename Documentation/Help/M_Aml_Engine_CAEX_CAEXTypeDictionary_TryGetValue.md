# CAEXTypeDictionary.TryGetValue Method 
AutomationML 2.1 API 

Tries to get the value.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public bool TryGetValue(
	string caexTagName,
	out Type t
)
```

**VB**<br />
``` VB
Public Function TryGetValue ( 
	caexTagName As String,
	<OutAttribute> ByRef t As Type
) As Boolean
```

**C++**<br />
``` C++
public:
bool TryGetValue(
	String^ caexTagName, 
	[OutAttribute] Type^% t
)
```


#### Parameters
&nbsp;<dl><dt>caexTagName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />Name of the CAEX tag.</dd><dt>t</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.type" target="_parent" rel="noopener noreferrer">System.Type</a><br />The type.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true` if type is registered, `false` otherwise.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_CAEXTypeDictionary">CAEXTypeDictionary Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />