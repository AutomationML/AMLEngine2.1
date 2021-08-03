# CAEXTypeDictionary.Item Property 
AutomationML 2.1 API 

Gets or sets the data type associated with the specified key.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public Type this[
	string caexTagName
] { get; }
```

**VB**<br />
``` VB
Public ReadOnly Default Property Item ( 
	caexTagName As String
) As Type
	Get
```

**C++**<br />
``` C++
public:
property Type^ default[String^ caexTagName] {
	Type^ get (String^ caexTagName);
}
```


#### Parameters
&nbsp;<dl><dt>caexTagName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The key. The caexTagName is concatenated with the "Type" extension, to match a Type name of a CAEX wrapper class.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.type" target="_parent" rel="noopener noreferrer">Type</a><br />Type.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_CAEXTypeDictionary">CAEXTypeDictionary Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />