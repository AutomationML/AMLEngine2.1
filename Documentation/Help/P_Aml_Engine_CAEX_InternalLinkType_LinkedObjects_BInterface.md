# InternalLinkType.LinkedObjects.BInterface Property 
AutomationML 2.1 API 

Gets the B-Interface of the InternalLink by interpretation of the <a href="P_Aml_Engine_CAEX_InternalLinkType_RefPartnerSideB">RefPartnerSideB</a> Attribute on first access. Consecutive reads will return the at first calculated value. A Reinterpretation is performed, when the respective InternalLink property <a href="P_Aml_Engine_CAEX_InternalLinkType_BInterface">BInterface</a> is read or set.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public ExternalInterfaceType BInterface { get; }
```

**VB**<br />
``` VB
Public ReadOnly Property BInterface As ExternalInterfaceType
	Get
```

**C++**<br />
``` C++
public:
property ExternalInterfaceType^ BInterface {
	ExternalInterfaceType^ get ();
}
```


#### Property Value
Type: <a href="T_Aml_Engine_CAEX_ExternalInterfaceType">ExternalInterfaceType</a>

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_InternalLinkType_LinkedObjects">InternalLinkType.LinkedObjects Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />