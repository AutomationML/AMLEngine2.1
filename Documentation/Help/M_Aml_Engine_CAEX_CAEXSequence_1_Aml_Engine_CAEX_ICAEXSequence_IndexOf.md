# CAEXSequence(*T*).ICAEXSequence.IndexOf Method 
AutomationML 2.1 API 

Gets the Index of the specified CAEX object in this sequence of elements.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
int ICAEXSequence.IndexOf(
	ICAEXWrapper caexObject
)
```

**VB**<br />
``` VB
Private Function IndexOf ( 
	caexObject As ICAEXWrapper
) As Integer Implements ICAEXSequence.IndexOf
```

**C++**<br />
``` C++
private:
virtual int IndexOf(
	ICAEXWrapper^ caexObject
) sealed = ICAEXSequence::IndexOf
```


#### Parameters
&nbsp;<dl><dt>caexObject</dt><dd>Type: <a href="T_Aml_Engine_CAEX_ICAEXWrapper">Aml.Engine.CAEX.ICAEXWrapper</a><br />the CAEX object</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.int32" target="_parent" rel="noopener noreferrer">Int32</a><br />the Index of the specified CAEX object.

#### Implements
<a href="M_Aml_Engine_CAEX_ICAEXSequence_IndexOf">ICAEXSequence.IndexOf(ICAEXWrapper)</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_CAEXSequence_1">CAEXSequence(T) Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />