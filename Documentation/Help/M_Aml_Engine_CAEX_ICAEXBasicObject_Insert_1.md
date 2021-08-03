# ICAEXBasicObject.Insert Method (Int32, CAEXWrapper)
AutomationML 2.1 API 

Inserts the specified CAEX object in it's associated sequence at the defined position. The CAEXBasicObject defines the <a href="P_Aml_Engine_CAEX_ICAEXBasicObject_Revision">Revision</a> and <a href="P_Aml_Engine_CAEX_ICAEXBasicObject_SourceObjectInformation">SourceObjectInformation</a> sequences.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
bool Insert(
	int pos,
	CAEXWrapper caexObject
)
```

**VB**<br />
``` VB
Function Insert ( 
	pos As Integer,
	caexObject As CAEXWrapper
) As Boolean
```

**C++**<br />
``` C++
bool Insert(
	int pos, 
	CAEXWrapper^ caexObject
)
```


#### Parameters
&nbsp;<dl><dt>pos</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.int32" target="_parent" rel="noopener noreferrer">System.Int32</a><br />The position</dd><dt>caexObject</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXWrapper">Aml.Engine.CAEX.CAEXWrapper</a><br />The CAEX object.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />true, if a sequence could be identified and the CAEX object has been inserted into this sequence.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_ICAEXBasicObject">ICAEXBasicObject Interface</a><br /><a href="Overload_Aml_Engine_CAEX_ICAEXBasicObject_Insert">Insert Overload</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />