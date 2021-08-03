# CAEXSequence(*T*).InsertAt Method 
AutomationML 2.1 API 

Inserts the specified CAEX object into this sequence at the defined index.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public T InsertAt(
	int index,
	T caexObject
)
```

**VB**<br />
``` VB
Public Function InsertAt ( 
	index As Integer,
	caexObject As T
) As T
```

**C++**<br />
``` C++
public:
T InsertAt(
	int index, 
	T caexObject
)
```


#### Parameters
&nbsp;<dl><dt>index</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.int32" target="_parent" rel="noopener noreferrer">System.Int32</a><br />The Position of the element</dd><dt>caexObject</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXSequence_1">*T*</a><br />The CAEX object</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_CAEXSequence_1">*T*</a><br />The inserted CAEX object. If the provided CAEX object already belongs to a sequence, a copy of the CAEX object is inserted and returned as the result.

## Remarks
If the provided CAEX object already has an associated parent, a deep copy of the CAEX object and not the original provided CAEX Object is inserted. Please keep in mind, that the copied object contains identical attributes and elements. It might not represent a valid AutomationML object, because IDs and references are not automatically modified.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_CAEXSequence_1">CAEXSequence(T) Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />