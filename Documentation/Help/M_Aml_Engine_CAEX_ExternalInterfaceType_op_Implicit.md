# ExternalInterfaceType&nbsp;Implicit Conversion (ExternalInterfaceType to ObjectWithAMLAttributes)
AutomationML 2.1 API 

Conversion to get access to specific AutomationML defined Attributes, assigned to the specified External Interface object.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static implicit operator ObjectWithAMLAttributes (
	ExternalInterfaceType interfaceClass
)
```

**VB**<br />
``` VB
Public Shared Widening Operator CType ( 
	interfaceClass As ExternalInterfaceType
) As ObjectWithAMLAttributes
```

**C++**<br />
``` C++
static implicit operator ObjectWithAMLAttributes^ (
	ExternalInterfaceType^ interfaceClass
)
```


#### Parameters
&nbsp;<dl><dt>interfaceClass</dt><dd>Type: <a href="T_Aml_Engine_CAEX_ExternalInterfaceType">Aml.Engine.CAEX.ExternalInterfaceType</a><br />The CAEX External Interface object.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_AmlObjects_ObjectWithAMLAttributes">ObjectWithAMLAttributes</a><br />The InterfaceClass object, converted to an <a href="T_Aml_Engine_AmlObjects_ObjectWithAMLAttributes">ObjectWithAMLAttributes</a> type, which provides access to specific AML defined attributes.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td>interfaceClass</td></tr></table>

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_ExternalInterfaceType">ExternalInterfaceType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />