# AttributeTypeType.AttributeDataType Property 
AutomationML 2.1 API 

Gets and sets the AttributeDataType attribute of this Attribute object. If the referenced attribute type does not base on an XML standard base type, the AttributeDataType may remain empty or not present.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public virtual string AttributeDataType { get; set; }
```

**VB**<br />
``` VB
Public Overridable Property AttributeDataType As String
	Get
	Set
```

**C++**<br />
``` C++
public:
virtual property String^ AttributeDataType {
	String^ get ();
	void set (String^ value);
}
```


#### Property Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a>

#### Implements
<a href="P_Aml_Engine_CAEX_IAttributeValueType_AttributeDataType">IAttributeValueType.AttributeDataType</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_AttributeTypeType">AttributeTypeType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />