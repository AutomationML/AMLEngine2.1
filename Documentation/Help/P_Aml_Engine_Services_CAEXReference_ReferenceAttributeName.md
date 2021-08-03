# CAEXReference.ReferenceAttributeName Property 
AutomationML 2.1 API 

Gets the name of the reference attribute which contains the value of the reference. To get or set the attribute value for the attribute with this name the <a href="M_Aml_Engine_CAEX_CAEXWrapper_SetXAttributeValue">SetXAttributeValue(XName, Object)</a> and <a href="M_Aml_Engine_CAEX_CAEXWrapper_GetXAttributeValue">GetXAttributeValue(XName)</a> methods can be used.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public string ReferenceAttributeName { get; }
```

**VB**<br />
``` VB
Public ReadOnly Property ReferenceAttributeName As String
	Get
```

**C++**<br />
``` C++
public:
virtual property String^ ReferenceAttributeName {
	String^ get () sealed;
}
```


#### Property Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a>

#### Implements
<a href="P_Aml_Engine_Services_Interfaces_ICAEXReference_ReferenceAttributeName">ICAEXReference.ReferenceAttributeName</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_Services_CAEXReference">CAEXReference Class</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />