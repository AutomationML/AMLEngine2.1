# NominalScaledTypeType.Item Property 
AutomationML 2.1 API 

Gets the type-decoded value and sets the type-encoded value for the nominal value attribute with the defined value.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public Object this[
	string nominalValue
] { get; set; }
```

**VB**<br />
``` VB
Public Default Property Item ( 
	nominalValue As String
) As Object
	Get
	Set
```

**C++**<br />
``` C++
public:
virtual property Object^ default[String^ nominalValue] {
	Object^ get (String^ nominalValue) sealed;
	void set (String^ nominalValue, Object^ value) sealed;
}
```


#### Parameters
&nbsp;<dl><dt>nominalValue</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br /></dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_parent" rel="noopener noreferrer">Object</a><br />

#### Implements
<a href="P_Aml_Engine_CAEX_IAttributeValueType_Item">IAttributeValueType.Item(String)</a><br />

## Remarks
This indexer should only be used, if the list of nominal values contains distinct values only.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_NominalScaledTypeType">NominalScaledTypeType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />