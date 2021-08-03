# ICAEXSequence.Append Method 
AutomationML 2.1 API 

Creates a new CAEX object and appends it to already existing elements in this sequence.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
ICAEXWrapper Append()
```

**VB**<br />
``` VB
Function Append As ICAEXWrapper
```

**C++**<br />
``` C++
ICAEXWrapper^ Append()
```


#### Return Value
Type: <a href="T_Aml_Engine_CAEX_ICAEXWrapper">ICAEXWrapper</a><br />the created CAEX object

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="T_Aml_Engine_CAEX_SchemaConformanceException">SchemaConformanceException</a></td><td>raised, when this parent child relation violates the CAEX schema.</td></tr></table>

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_ICAEXSequence">ICAEXSequence Interface</a><br /><a href="Overload_Aml_Engine_CAEX_ICAEXSequence_Append">Append Overload</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />