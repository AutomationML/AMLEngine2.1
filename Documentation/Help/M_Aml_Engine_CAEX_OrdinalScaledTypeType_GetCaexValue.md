# OrdinalScaledTypeType.GetCaexValue Method 
AutomationML 2.1 API 

Gets the <a href="T_Aml_Engine_CAEX_Extensions_CaexValue">CaexValue</a> for the value attribute with the defined attribute name. are <a href="F_Aml_Engine_CAEX_CAEX_CLASSModel_TagNames_ATTRIBUTE_CONSTRAINT_ORDINAL_VALUE_STRING">ATTRIBUTE_CONSTRAINT_ORDINAL_VALUE_STRING</a> and <a href="F_Aml_Engine_CAEX_CAEX_CLASSModel_TagNames_ATTRIBUTE_CONSTRAINT_ORDINAL_MIN_STRING">ATTRIBUTE_CONSTRAINT_ORDINAL_MIN_STRING</a> and <a href="F_Aml_Engine_CAEX_CAEX_CLASSModel_TagNames_ATTRIBUTE_CONSTRAINT_ORDINAL_MAX_STRING">ATTRIBUTE_CONSTRAINT_ORDINAL_MAX_STRING</a>.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public CaexValue GetCaexValue(
	string attributeName
)
```

**VB**<br />
``` VB
Public Function GetCaexValue ( 
	attributeName As String
) As CaexValue
```

**C++**<br />
``` C++
public:
virtual CaexValue^ GetCaexValue(
	String^ attributeName
) sealed
```


#### Parameters
&nbsp;<dl><dt>attributeName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br /></dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_Extensions_CaexValue">CaexValue</a><br />The CAEXValue for the named attribute.

#### Implements
<a href="M_Aml_Engine_CAEX_IAttributeValueType_GetCaexValue">IAttributeValueType.GetCaexValue(String)</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_OrdinalScaledTypeType">OrdinalScaledTypeType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />