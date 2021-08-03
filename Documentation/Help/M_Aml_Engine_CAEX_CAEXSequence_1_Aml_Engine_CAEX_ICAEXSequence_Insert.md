# CAEXSequence(*T*).ICAEXSequence.Insert Method 
AutomationML 2.1 API 

Inserts the specified CAEX object into this sequence. If no position is specified the element is appended. If 'asFirst' is set to `true`, the element is prepended to already existing ones.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
void ICAEXSequence.Insert(
	ICAEXWrapper caexObject,
	bool asFirst
)
```

**VB**<br />
``` VB
Private Sub Insert ( 
	caexObject As ICAEXWrapper,
	asFirst As Boolean
) Implements ICAEXSequence.Insert
```

**C++**<br />
``` C++
private:
virtual void Insert(
	ICAEXWrapper^ caexObject, 
	bool asFirst
) sealed = ICAEXSequence::Insert
```


#### Parameters
&nbsp;<dl><dt>caexObject</dt><dd>Type: <a href="T_Aml_Engine_CAEX_ICAEXWrapper">Aml.Engine.CAEX.ICAEXWrapper</a><br />the CAEX object</dd><dt>asFirst</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />optional parameter, if set to `true (default)` the object is prepended to already existing ones, otherwise it is appended.</dd></dl>

#### Implements
<a href="M_Aml_Engine_CAEX_ICAEXSequence_Insert">ICAEXSequence.Insert(ICAEXWrapper, Boolean)</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_CAEXSequence_1">CAEXSequence(T) Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />