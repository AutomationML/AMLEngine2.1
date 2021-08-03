# OrdinalScaledTypeType.ValueAttributes Property 
AutomationML 2.1 API 

Gets all the CAEXValue objects for the defined value attributes of this instance. Recognized value attributes are <a href="F_Aml_Engine_CAEX_CAEX_CLASSModel_TagNames_ATTRIBUTE_CONSTRAINT_ORDINAL_MAX_STRING">ATTRIBUTE_CONSTRAINT_ORDINAL_MAX_STRING</a> and <a href="F_Aml_Engine_CAEX_CAEX_CLASSModel_TagNames_ATTRIBUTE_CONSTRAINT_ORDINAL_MIN_STRING">ATTRIBUTE_CONSTRAINT_ORDINAL_MIN_STRING</a> and <a href="F_Aml_Engine_CAEX_CAEX_CLASSModel_TagNames_ATTRIBUTE_CONSTRAINT_ORDINAL_VALUE_STRING">ATTRIBUTE_CONSTRAINT_ORDINAL_VALUE_STRING</a>.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public List<CaexValue> ValueAttributes { get; }
```

**VB**<br />
``` VB
Public ReadOnly Property ValueAttributes As List(Of CaexValue)
	Get
```

**C++**<br />
``` C++
public:
virtual property List<CaexValue^>^ ValueAttributes {
	List<CaexValue^>^ get () sealed;
}
```


#### Property Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.list-1" target="_parent" rel="noopener noreferrer">List</a>(<a href="T_Aml_Engine_CAEX_Extensions_CaexValue">CaexValue</a>)

#### Implements
<a href="P_Aml_Engine_CAEX_IAttributeValueType_ValueAttributes">IAttributeValueType.ValueAttributes</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_OrdinalScaledTypeType">OrdinalScaledTypeType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />