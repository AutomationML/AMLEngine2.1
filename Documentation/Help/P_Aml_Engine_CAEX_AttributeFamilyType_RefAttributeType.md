# AttributeFamilyType.RefAttributeType Property 
AutomationML 2.1 API 

Gets and sets the RefAttributeType CAEX attribute of the Attribute object. This property is used to create class to class relations between AttributeType objects (classes). According to CAEX, a class shall not inherit from itself or from a derivative of itself, therefore any cyclic reference is denied.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public override string RefAttributeType { get; set; }
```

**VB**<br />
``` VB
Public Overrides Property RefAttributeType As String
	Get
	Set
```

**C++**<br />
``` C++
public:
virtual property String^ RefAttributeType {
	String^ get () override;
	void set (String^ value) override;
}
```


#### Property Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a>

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_AttributeFamilyType">AttributeFamilyType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br /><a href="P_Aml_Engine_CAEX_AttributeFamilyType_AttributeType">AttributeFamilyType.AttributeType</a><br /><a href="P_Aml_Engine_CAEX_AttributeType_AttributeTypeReference">AttributeType.AttributeTypeReference</a><br />