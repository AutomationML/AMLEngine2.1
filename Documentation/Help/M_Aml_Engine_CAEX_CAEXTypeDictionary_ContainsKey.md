# CAEXTypeDictionary.ContainsKey Method 
AutomationML 2.1 API 

Determines whether this dictionary's key collection contains the specified CAEX Tag name as a key.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public bool ContainsKey(
	string caexTagName
)
```

**VB**<br />
``` VB
Public Function ContainsKey ( 
	caexTagName As String
) As Boolean
```

**C++**<br />
``` C++
public:
bool ContainsKey(
	String^ caexTagName
)
```


#### Parameters
&nbsp;<dl><dt>caexTagName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The CAEX Tag name, which is used to construct the dictionary key.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />true if the dictionary contains an element with the specified key; otherwise, false.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_CAEXTypeDictionary">CAEXTypeDictionary Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />