# AttributeTypeType.Item Property 
AutomationML 2.1 API 

Gets the type-decoded value and sets the type-encoded value for the value attribute with the defined name. The allowed Names as <a href="F_Aml_Engine_CAEX_CAEX_CLASSModel_TagNames_ATTRIBUTE_VALUE_STRING">ATTRIBUTE_VALUE_STRING</a> and <a href="F_Aml_Engine_CAEX_CAEX_CLASSModel_TagNames_ATTRIBUTE_DEFAULTVALUE_STRING">ATTRIBUTE_DEFAULTVALUE_STRING</a>.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public Object this[
	string attributeName
] { get; set; }
```

**VB**<br />
``` VB
Public Default Property Item ( 
	attributeName As String
) As Object
	Get
	Set
```

**C++**<br />
``` C++
public:
virtual property Object^ default[String^ attributeName] {
	Object^ get (String^ attributeName) sealed;
	void set (String^ attributeName, Object^ value) sealed;
}
```


#### Parameters
&nbsp;<dl><dt>attributeName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br /></dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_parent" rel="noopener noreferrer">Object</a><br />

#### Implements
<a href="P_Aml_Engine_CAEX_IAttributeValueType_Item">IAttributeValueType.Item(String)</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_AttributeTypeType">AttributeTypeType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />