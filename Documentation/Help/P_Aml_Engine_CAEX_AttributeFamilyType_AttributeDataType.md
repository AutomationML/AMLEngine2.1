# AttributeFamilyType.AttributeDataType Property 
AutomationML 2.1 API 

Gets and set the AttributeDataType. If the AttributeDataType is not defined for this AttributeType but a <a href="P_Aml_Engine_CAEX_AttributeFamilyType_BaseClass">BaseClass</a> exists, the AttributeDataType of the BaseClass is returned. If this optional attribute is not defined, the data type is assumed to be "xs:string", according to CAEX (DIN EN 62424:2008-08)

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public override string AttributeDataType { get; set; }
```

**VB**<br />
``` VB
Public Overrides Property AttributeDataType As String
	Get
	Set
```

**C++**<br />
``` C++
public:
virtual property String^ AttributeDataType {
	String^ get () override;
	void set (String^ value) override;
}
```


#### Property Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a>

#### Implements
<a href="P_Aml_Engine_CAEX_IAttributeValueType_AttributeDataType">IAttributeValueType.AttributeDataType</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_AttributeFamilyType">AttributeFamilyType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br /><a href="P_Aml_Engine_CAEX_AttributeFamilyType_BaseClass">AttributeFamilyType.BaseClass</a><br />