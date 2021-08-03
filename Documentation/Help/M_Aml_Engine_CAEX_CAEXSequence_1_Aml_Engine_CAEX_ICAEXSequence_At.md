# CAEXSequence(*T*).ICAEXSequence.At Method 
AutomationML 2.1 API 

Gets the CAEX object at the specified index.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
ICAEXWrapperICAEXSequence.At(
	int index
)
```

**VB**<br />
``` VB
Private Function At ( 
	index As Integer
) As ICAEXWrapper Implements ICAEXSequence.At
```

**C++**<br />
``` C++
private:
virtual ICAEXWrapper^ At(
	int index
) sealed = ICAEXSequence::At
```


#### Parameters
&nbsp;<dl><dt>index</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.int32" target="_parent" rel="noopener noreferrer">System.Int32</a><br />The index.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_ICAEXWrapper">ICAEXWrapper</a><br />the CAEX object from the given index, or `null`.

#### Implements
<a href="M_Aml_Engine_CAEX_ICAEXSequence_At">ICAEXSequence.At(Int32)</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_CAEXSequence_1">CAEXSequence(T) Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />