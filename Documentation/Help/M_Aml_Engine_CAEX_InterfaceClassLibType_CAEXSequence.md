# InterfaceClassLibType.CAEXSequence Method 
AutomationML 2.1 API 

Gets the CAEXSequence owned by this CAEX object, which contains the specified CAEX object.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public override ICAEXSequence CAEXSequence(
	ICAEXWrapper caexObject
)
```

**VB**<br />
``` VB
Public Overrides Function CAEXSequence ( 
	caexObject As ICAEXWrapper
) As ICAEXSequence
```

**C++**<br />
``` C++
public:
virtual ICAEXSequence^ CAEXSequence(
	ICAEXWrapper^ caexObject
) override
```


#### Parameters
&nbsp;<dl><dt>caexObject</dt><dd>Type: <a href="T_Aml_Engine_CAEX_ICAEXWrapper">Aml.Engine.CAEX.ICAEXWrapper</a><br />The CAEX object, contained in a sequence, owned by this CAEX object.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_ICAEXSequence">ICAEXSequence</a><br />The CAEX sequence or null, if no sequence exists, containing the specified CAEX object.

#### Implements
<a href="M_Aml_Engine_CAEX_ICAEXBasicObject_CAEXSequence">ICAEXBasicObject.CAEXSequence(ICAEXWrapper)</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_InterfaceClassLibType">InterfaceClassLibType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />