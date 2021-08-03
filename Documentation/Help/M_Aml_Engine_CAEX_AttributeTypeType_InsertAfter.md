# AttributeTypeType.InsertAfter Method 
AutomationML 2.1 API 

Inserts the provided CAEX object as a new sibling after this CAEX object.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public void InsertAfter(
	AttributeTypeType caexObject
)
```

**VB**<br />
``` VB
Public Sub InsertAfter ( 
	caexObject As AttributeTypeType
)
```

**C++**<br />
``` C++
public:
virtual void InsertAfter(
	AttributeTypeType^ caexObject
) sealed
```


#### Parameters
&nbsp;<dl><dt>caexObject</dt><dd>Type: <a href="T_Aml_Engine_CAEX_AttributeTypeType">Aml.Engine.CAEX.AttributeTypeType</a><br />The CAEX object to be inserted.</dd></dl>

#### Implements
<a href="M_Aml_Engine_CAEX_IMultipleOccurrences_1_InsertAfter">IMultipleOccurrences(T).InsertAfter(T)</a><br />

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td>caexObject</td></tr><tr><td><a href="T_Aml_Engine_CAEX_SchemaConformanceException">SchemaConformanceException</a></td><td>The provided object is not allowed to be a sibling of this instance.</td></tr></table>

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_AttributeTypeType">AttributeTypeType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />