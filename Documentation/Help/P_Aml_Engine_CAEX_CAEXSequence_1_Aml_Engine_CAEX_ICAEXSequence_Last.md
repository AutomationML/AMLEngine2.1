# CAEXSequence(*T*).ICAEXSequence.Last Property 
AutomationML 2.1 API 

Gets a wrapper for the last CAEX element in this sequence, if the sequence contains no elements `null` is returned.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
ICAEXWrapperICAEXSequence.Last { get; }
```

**VB**<br />
``` VB
Private ReadOnly Property Last As ICAEXWrapper
	Implements ICAEXSequence.Last
	Get
```

**C++**<br />
``` C++
private:
virtual property ICAEXWrapper^ Last {
	ICAEXWrapper^ get () sealed = ICAEXSequence::Last::get;
}
```


#### Property Value
Type: <a href="T_Aml_Engine_CAEX_ICAEXWrapper">ICAEXWrapper</a>

#### Implements
<a href="P_Aml_Engine_CAEX_ICAEXSequence_Last">ICAEXSequence.Last</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_CAEXSequence_1">CAEXSequence(T) Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />