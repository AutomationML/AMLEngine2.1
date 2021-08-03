# CAEXSequence(*T*).Insert Method 
AutomationML 2.1 API 

Inserts the specified CAEX object into this sequence. If no position is specified the element is appended. If 'asFirst' is set to `true`, the element is prepended to already existing ones.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public virtual T Insert(
	T caexObject,
	bool asFirst = true
)
```

**VB**<br />
``` VB
Public Overridable Function Insert ( 
	caexObject As T,
	Optional asFirst As Boolean = true
) As T
```

**C++**<br />
``` C++
public:
virtual T Insert(
	T caexObject, 
	bool asFirst = true
)
```


#### Parameters
&nbsp;<dl><dt>caexObject</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXSequence_1">*T*</a><br />the CAEX object</dd><dt>asFirst (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />optional parameter, if set to `true (default)` the object is prepended to already existing ones, otherwise it is appended.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_CAEXSequence_1">*T*</a><br />The inserted CAEX object. If the provided CAEX object already belongs to a sequence, a copy of the CAEX object is inserted and returned as the result.

## Remarks
If the provided CAEX object already has an associated parent, a deep copy of the CAEX object and not the original provided CAEX Object is inserted. Please keep in mind, that the copied object contains identical attributes and elements. It might not represent a valid AutomationML object, because IDs and references are not automatically modified.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_CAEXSequence_1">CAEXSequence(T) Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />