# SplitService.SetSplitPoint Method 
AutomationML 2.1 API 

Sets the split point for the provided CAEX object. If the actual list of split points for the same document already contains a split point which is a child of the provided CAEX object, this existing split point is removed from the list.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine.Services (in AML.Engine.Services.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public void SetSplitPoint(
	ISplitPoint caexObject
)
```

**VB**<br />
``` VB
Public Sub SetSplitPoint ( 
	caexObject As ISplitPoint
)
```

**C++**<br />
``` C++
public:
virtual void SetSplitPoint(
	ISplitPoint^ caexObject
) sealed
```


#### Parameters
&nbsp;<dl><dt>caexObject</dt><dd>Type: <a href="T_Aml_Engine_Services_Interfaces_ISplitPoint">Aml.Engine.Services.Interfaces.ISplitPoint</a><br />The CAEX object.</dd></dl>

#### Implements
<a href="M_Aml_Engine_Services_Interfaces_ISplit_SetSplitPoint">ISplit.SetSplitPoint(ISplitPoint)</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_Services_SplitService">SplitService Class</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />