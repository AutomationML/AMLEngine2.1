# ExternalInterfaceType.Master Property 
AutomationML 2.1 API 

Gets and sets the Master. A Master is only defined, if this instance is a <a href="P_Aml_Engine_CAEX_ExternalInterfaceType_IsMirror">IsMirror</a>. Setting a master will transform this instance into a mirror.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public ExternalInterfaceType Master { get; set; }
```

**VB**<br />
``` VB
Public Property Master As ExternalInterfaceType
	Get
	Set
```

**C++**<br />
``` C++
public:
property ExternalInterfaceType^ Master {
	ExternalInterfaceType^ get ();
	void set (ExternalInterfaceType^ value);
}
```


#### Property Value
Type: <a href="T_Aml_Engine_CAEX_ExternalInterfaceType">ExternalInterfaceType</a><br />The master.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_ExternalInterfaceType">ExternalInterfaceType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />