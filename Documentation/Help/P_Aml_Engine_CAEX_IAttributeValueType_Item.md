# IAttributeValueType.Item Property 
AutomationML 2.1 API 

Gets and sets the attribute value for the named attribute using the decoding and encoding methods of <a href="T_Aml_Engine_CAEX_Extensions_CaexValue">CaexValue</a>.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
Object this[
	string attributeName
] { get; set; }
```

**VB**<br />
``` VB
Default Property Item ( 
	attributeName As String
) As Object
	Get
	Set
```

**C++**<br />
``` C++
property Object^ default[String^ attributeName] {
	Object^ get (String^ attributeName);
	void set (String^ attributeName, Object^ value);
}
```


#### Parameters
&nbsp;<dl><dt>attributeName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br /></dd></dl>

#### Property Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_parent" rel="noopener noreferrer">Object</a>

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_IAttributeValueType">IAttributeValueType Interface</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />