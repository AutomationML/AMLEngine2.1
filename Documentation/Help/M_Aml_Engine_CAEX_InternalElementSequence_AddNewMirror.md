# InternalElementSequence.AddNewMirror Method 
AutomationML 2.1 API 

Adds a new mirror InternalElement to this sequence.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public InternalElementType AddNewMirror(
	InternalElementType masterInternalElement
)
```

**VB**<br />
``` VB
Public Function AddNewMirror ( 
	masterInternalElement As InternalElementType
) As InternalElementType
```

**C++**<br />
``` C++
public:
InternalElementType^ AddNewMirror(
	InternalElementType^ masterInternalElement
)
```


#### Parameters
&nbsp;<dl><dt>masterInternalElement</dt><dd>Type: <a href="T_Aml_Engine_CAEX_InternalElementType">Aml.Engine.CAEX.InternalElementType</a><br />The master internal element.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_InternalElementType">InternalElementType</a><br />The newly created Mirror

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td>masterInternalElement</td></tr></table>

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_InternalElementSequence">InternalElementSequence Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />