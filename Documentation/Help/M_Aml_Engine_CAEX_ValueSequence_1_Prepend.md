# ValueSequence(*TDataType*).Prepend Method 
AutomationML 2.1 API 

Creates a new CAEX object with the provided value and prepends it to already existing elements.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public XElement Prepend(
	TDataType value
)
```

**VB**<br />
``` VB
Public Function Prepend ( 
	value As TDataType
) As XElement
```

**C++**<br />
``` C++
public:
XElement^ Prepend(
	TDataType value
)
```


#### Parameters
&nbsp;<dl><dt>value</dt><dd>Type: <a href="T_Aml_Engine_CAEX_ValueSequence_1">*TDataType*</a><br />The value.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement" target="_parent" rel="noopener noreferrer">XElement</a><br />The XML node of the created CAEX object.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.exception" target="_parent" rel="noopener noreferrer">Exception</a></td><td>Could not add</td></tr></table>

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_ValueSequence_1">ValueSequence(TDataType) Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />