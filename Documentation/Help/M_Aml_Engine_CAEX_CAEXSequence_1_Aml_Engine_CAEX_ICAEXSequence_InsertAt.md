# CAEXSequence(*T*).ICAEXSequence.InsertAt Method 
AutomationML 2.1 API 

Inserts the specified CAEX object into this sequence at the defined index.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
void ICAEXSequence.InsertAt(
	int index,
	ICAEXWrapper caexObject
)
```

**VB**<br />
``` VB
Private Sub InsertAt ( 
	index As Integer,
	caexObject As ICAEXWrapper
) Implements ICAEXSequence.InsertAt
```

**C++**<br />
``` C++
private:
virtual void InsertAt(
	int index, 
	ICAEXWrapper^ caexObject
) sealed = ICAEXSequence::InsertAt
```


#### Parameters
&nbsp;<dl><dt>index</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.int32" target="_parent" rel="noopener noreferrer">System.Int32</a><br />The Position of the element</dd><dt>caexObject</dt><dd>Type: <a href="T_Aml_Engine_CAEX_ICAEXWrapper">Aml.Engine.CAEX.ICAEXWrapper</a><br />The CAEX object</dd></dl>

#### Implements
<a href="M_Aml_Engine_CAEX_ICAEXSequence_InsertAt">ICAEXSequence.InsertAt(Int32, ICAEXWrapper)</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_CAEXSequence_1">CAEXSequence(T) Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />