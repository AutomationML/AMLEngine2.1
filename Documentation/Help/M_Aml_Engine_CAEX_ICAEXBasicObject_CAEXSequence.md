# ICAEXBasicObject.CAEXSequence Method 
AutomationML 2.1 API 

Gets the CAEXSequence owned by this instance, which contains the specified CAEX object. For example, if the specified object is a revision object, the sequence of the revision objects <a href="P_Aml_Engine_CAEX_ICAEXBasicObject_Revision">Revision</a> is returned.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
ICAEXSequence CAEXSequence(
	ICAEXWrapper caexObject
)
```

**VB**<br />
``` VB
Function CAEXSequence ( 
	caexObject As ICAEXWrapper
) As ICAEXSequence
```

**C++**<br />
``` C++
ICAEXSequence^ CAEXSequence(
	ICAEXWrapper^ caexObject
)
```


#### Parameters
&nbsp;<dl><dt>caexObject</dt><dd>Type: <a href="T_Aml_Engine_CAEX_ICAEXWrapper">Aml.Engine.CAEX.ICAEXWrapper</a><br />The CAEX object, contained in a sequence, owned by this CAEX object.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_ICAEXSequence">ICAEXSequence</a><br />The CAEX sequence or null, if no sequence exists, containing the specified CAEX object.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_ICAEXBasicObject">ICAEXBasicObject Interface</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />