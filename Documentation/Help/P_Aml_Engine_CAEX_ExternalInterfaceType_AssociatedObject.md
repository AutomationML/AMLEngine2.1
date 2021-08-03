# ExternalInterfaceType.AssociatedObject Property 
AutomationML 2.1 API 

Determines, if this external interface is associated to a SystemUnitClass, InternalElement, InterfaceClass, RoleClass or RoleRequirement and returns the Wrapper for this associated object. Also works for nested Interfaces.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public IObjectWithExternalInterface AssociatedObject { get; }
```

**VB**<br />
``` VB
Public ReadOnly Property AssociatedObject As IObjectWithExternalInterface
	Get
```

**C++**<br />
``` C++
public:
property IObjectWithExternalInterface^ AssociatedObject {
	IObjectWithExternalInterface^ get ();
}
```


#### Property Value
Type: <a href="T_Aml_Engine_CAEX_IObjectWithExternalInterface">IObjectWithExternalInterface</a><br />The associated object.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_ExternalInterfaceType">ExternalInterfaceType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />