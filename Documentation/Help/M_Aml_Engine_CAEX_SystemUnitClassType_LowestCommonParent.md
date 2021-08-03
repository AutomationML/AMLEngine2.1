# SystemUnitClassType.LowestCommonParent Method 
AutomationML 2.1 API 

Gets the Lowest common parent to this SystemUnitClass and the provided SystemUnitClass. The common parent is used to store an InternalLink relating this two SystemUnitClass objects. An InternalLink is not allowed to leave the boundary of a SystemUnitClass which means, that no common parent is defined for two different SystemUnitClass objects. If one Element is a SystemUnitClass the other one should be an InternalElement descendant of the SystemUnitClass.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public SystemUnitClassType LowestCommonParent(
	SystemUnitClassType systemUnitClass
)
```

**VB**<br />
``` VB
Public Function LowestCommonParent ( 
	systemUnitClass As SystemUnitClassType
) As SystemUnitClassType
```

**C++**<br />
``` C++
public:
SystemUnitClassType^ LowestCommonParent(
	SystemUnitClassType^ systemUnitClass
)
```


#### Parameters
&nbsp;<dl><dt>systemUnitClass</dt><dd>Type: <a href="T_Aml_Engine_CAEX_SystemUnitClassType">Aml.Engine.CAEX.SystemUnitClassType</a><br />The system unit class.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_SystemUnitClassType">SystemUnitClassType</a><br />the SystemUnitClass object which is the lowest common parent

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td>systemUnitClass</td></tr></table>

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_SystemUnitClassType">SystemUnitClassType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />