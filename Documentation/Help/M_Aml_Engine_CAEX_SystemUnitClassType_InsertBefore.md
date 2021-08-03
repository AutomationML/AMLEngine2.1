# SystemUnitClassType.InsertBefore Method 
AutomationML 2.1 API 

Inserts the provided CAEX object as a new sibling before this CAEX object.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public virtual void InsertBefore(
	InternalElementType caexObject
)
```

**VB**<br />
``` VB
Public Overridable Sub InsertBefore ( 
	caexObject As InternalElementType
)
```

**C++**<br />
``` C++
public:
virtual void InsertBefore(
	InternalElementType^ caexObject
)
```


#### Parameters
&nbsp;<dl><dt>caexObject</dt><dd>Type: <a href="T_Aml_Engine_CAEX_InternalElementType">Aml.Engine.CAEX.InternalElementType</a><br />The CAEX object to be inserted</dd></dl>

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td>caexObject</td></tr><tr><td><a href="T_Aml_Engine_CAEX_SchemaConformanceException">SchemaConformanceException</a></td><td>The provided object is not allowed to be a sibling of this instance.</td></tr></table>

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_SystemUnitClassType">SystemUnitClassType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />