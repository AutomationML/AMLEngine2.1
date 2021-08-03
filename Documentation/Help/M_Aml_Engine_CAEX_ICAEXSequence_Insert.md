# ICAEXSequence.Insert Method 
AutomationML 2.1 API 

Inserts the specified CAEX object into this sequence. If no position is specified the element is appended. If 'asFirst' is set to `true`, the element is prepended to already existing ones.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
void Insert(
	ICAEXWrapper caexObject,
	bool asFirst = true
)
```

**VB**<br />
``` VB
Sub Insert ( 
	caexObject As ICAEXWrapper,
	Optional asFirst As Boolean = true
)
```

**C++**<br />
``` C++
void Insert(
	ICAEXWrapper^ caexObject, 
	bool asFirst = true
)
```


#### Parameters
&nbsp;<dl><dt>caexObject</dt><dd>Type: <a href="T_Aml_Engine_CAEX_ICAEXWrapper">Aml.Engine.CAEX.ICAEXWrapper</a><br />the CAEX object</dd><dt>asFirst (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />optional parameter, if set to `true (default)` the object is prepended to already existing ones, otherwise it is appended.</dd></dl>

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_ICAEXSequence">ICAEXSequence Interface</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />