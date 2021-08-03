# InterfaceClassType.ExternalInterface Property 
AutomationML 2.1 API 

Gets the collection of ExternalInterfaces for this Instance.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public ExternalInterfaceSequence ExternalInterface { get; }
```

**VB**<br />
``` VB
Public ReadOnly Property ExternalInterface As ExternalInterfaceSequence
	Get
```

**C++**<br />
``` C++
public:
virtual property ExternalInterfaceSequence^ ExternalInterface {
	ExternalInterfaceSequence^ get () sealed;
}
```


#### Property Value
Type: <a href="T_Aml_Engine_CAEX_ExternalInterfaceSequence">ExternalInterfaceSequence</a>

#### Implements
<a href="P_Aml_Engine_CAEX_IObjectWithExternalInterface_ExternalInterface">IObjectWithExternalInterface.ExternalInterface</a><br />

## Remarks
Nested Interfaces are allowed only in AMLDocuments based on CAEX Version 3.0 and later.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_InterfaceClassType">InterfaceClassType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />