# SystemUnitClassType&nbsp;Implicit Conversion (SystemUnitClassType to ObjectWithAMLAttributes)
AutomationML 2.1 API 

Conversion to get access to specific AutomationML defined Attributes

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static implicit operator ObjectWithAMLAttributes (
	SystemUnitClassType caexObject
)
```

**VB**<br />
``` VB
Public Shared Widening Operator CType ( 
	caexObject As SystemUnitClassType
) As ObjectWithAMLAttributes
```

**C++**<br />
``` C++
static implicit operator ObjectWithAMLAttributes^ (
	SystemUnitClassType^ caexObject
)
```


#### Parameters
&nbsp;<dl><dt>caexObject</dt><dd>Type: <a href="T_Aml_Engine_CAEX_SystemUnitClassType">Aml.Engine.CAEX.SystemUnitClassType</a><br />The CAEX object.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_AmlObjects_ObjectWithAMLAttributes">ObjectWithAMLAttributes</a><br />The result of the conversion.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td>caexObject</td></tr></table>

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_SystemUnitClassType">SystemUnitClassType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />