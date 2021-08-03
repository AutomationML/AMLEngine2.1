# InternalLinkType.InterfaceFromAttributeValue Method 
AutomationML 2.1 API 

Gets the Interface from the provided InternalLink Attribute value, which is from <a href="P_Aml_Engine_CAEX_InternalLinkType_RefPartnerSideA">RefPartnerSideA</a> or from the <a href="P_Aml_Engine_CAEX_InternalLinkType_RefPartnerSideB">RefPartnerSideB</a> attribute.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public ExternalInterfaceType InterfaceFromAttributeValue(
	string internalLinkAttributeValue
)
```

**VB**<br />
``` VB
Public Function InterfaceFromAttributeValue ( 
	internalLinkAttributeValue As String
) As ExternalInterfaceType
```

**C++**<br />
``` C++
public:
ExternalInterfaceType^ InterfaceFromAttributeValue(
	String^ internalLinkAttributeValue
)
```


#### Parameters
&nbsp;<dl><dt>internalLinkAttributeValue</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The value of the InternalLink attribute, defining the Interface reference.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_ExternalInterfaceType">ExternalInterfaceType</a><br />the external interface

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_InternalLinkType">InternalLinkType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />