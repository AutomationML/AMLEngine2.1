# InterfaceFamilyType.CreateClassInstance Method 
AutomationML 2.1 API 

Creates an ExternalInterface object as an instance of this InterfaceClass object. All Base-Class references are resolved to create the instance - copying the Attribute and ExternalInterface objects to the created ExternalInterface object. The IDs of the ExternalInterface objects are made unique.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public ExternalInterfaceType CreateClassInstance()
```

**VB**<br />
``` VB
Public Function CreateClassInstance As ExternalInterfaceType
```

**C++**<br />
``` C++
public:
virtual ExternalInterfaceType^ CreateClassInstance() sealed
```


#### Return Value
Type: <a href="T_Aml_Engine_CAEX_ExternalInterfaceType">ExternalInterfaceType</a><br />The ExternalInterface object

#### Implements
<a href="M_Aml_Engine_CAEX_IInstantiable_1_CreateClassInstance">IInstantiable(TINSTANCE).CreateClassInstance()</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_InterfaceFamilyType">InterfaceFamilyType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />