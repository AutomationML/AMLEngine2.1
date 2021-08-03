# CAEXSequenceOfCAEXObjects(*T*).Insert Method 
AutomationML 2.1 API 

Inserts the specified element into this sequence. If nothing is specified the element is added. If the asFirst is set to `true`, the element is prepended to already existing ones. If a UniqueNameService can be located, the name of the inserted element is changed to be unique.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public override T Insert(
	T caexObject,
	bool asFirst = true
)
```

**VB**<br />
``` VB
Public Overrides Function Insert ( 
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
) override
```


#### Parameters
&nbsp;<dl><dt>caexObject</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXSequenceOfCAEXObjects_1">*T*</a><br />The CAEX object.</dd><dt>asFirst (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />optional parameter, if set to `true (default)` the element is prepended to already existing ones, otherwise it is appended.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_CAEXSequenceOfCAEXObjects_1">*T*</a><br />The inserted CAEX object. If the provided CAEX object already belongs to a sequence, a copy of the CAEX object is inserted and returned as the result.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td>caexObject</td></tr></table>

## Remarks
If the provided CAEX object already has an associated parent, a deep copy of the CAEX object and not the original provided CAEX Object is inserted. Please keep in mind, that the copied object contains identical attributes and elements. It might not represent a valid AutomationML object, because IDs and references are not automatically modified.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_CAEXSequenceOfCAEXObjects_1">CAEXSequenceOfCAEXObjects(T) Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />