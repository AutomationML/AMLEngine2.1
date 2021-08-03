# ISplit.SetSplitPoint Method 
AutomationML 2.1 API 

Sets the split point for the provided CAEX object. If the actual list of split points for the same document already contains a split point which is a child of the provided CAEX object, this existing split point is removed from the list.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
void SetSplitPoint(
	ISplitPoint caexObject
)
```

**VB**<br />
``` VB
Sub SetSplitPoint ( 
	caexObject As ISplitPoint
)
```

**C++**<br />
``` C++
void SetSplitPoint(
	ISplitPoint^ caexObject
)
```


#### Parameters
&nbsp;<dl><dt>caexObject</dt><dd>Type: <a href="T_Aml_Engine_Services_Interfaces_ISplitPoint">Aml.Engine.Services.Interfaces.ISplitPoint</a><br />The CAEX object.</dd></dl>

## See Also


#### Reference
<a href="T_Aml_Engine_Services_Interfaces_ISplit">ISplit Interface</a><br /><a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces Namespace</a><br />