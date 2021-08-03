# CAEXBasicObject.Insert Method (CAEXWrapper, Boolean)
AutomationML 2.1 API 

Inserts the specified CAEX object in it's associated sequence. The CAEXBasicObject defines the <a href="P_Aml_Engine_CAEX_CAEXBasicObject_Revision">Revision</a> and <a href="P_Aml_Engine_CAEX_CAEXBasicObject_SourceObjectInformation">SourceObjectInformation</a> sequences.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public virtual bool Insert(
	CAEXWrapper caexObject,
	bool asFirst = true
)
```

**VB**<br />
``` VB
Public Overridable Function Insert ( 
	caexObject As CAEXWrapper,
	Optional asFirst As Boolean = true
) As Boolean
```

**C++**<br />
``` C++
public:
virtual bool Insert(
	CAEXWrapper^ caexObject, 
	bool asFirst = true
)
```


#### Parameters
&nbsp;<dl><dt>caexObject</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXWrapper">Aml.Engine.CAEX.CAEXWrapper</a><br />The CAEX object.</dd><dt>asFirst (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />if set to `true` it is inserted as the first item in its associated sequence.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />true, if a sequence could be identified and the CAEX object has been inserted into this sequence.

#### Implements
<a href="M_Aml_Engine_CAEX_ICAEXContainer_Insert">ICAEXContainer.Insert(CAEXWrapper, Boolean)</a><br /><a href="M_Aml_Engine_CAEX_ICAEXBasicObject_Insert">ICAEXBasicObject.Insert(CAEXWrapper, Boolean)</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_CAEXBasicObject">CAEXBasicObject Class</a><br /><a href="Overload_Aml_Engine_CAEX_CAEXBasicObject_Insert">Insert Overload</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />