# ValueSequence(*TDataType*).Append Method 
AutomationML 2.1 API 

Creates a new CAEX object and appends it to the value sequence. The value of the appended object is set to the provided value.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public XElement Append(
	TDataType value
)
```

**VB**<br />
``` VB
Public Function Append ( 
	value As TDataType
) As XElement
```

**C++**<br />
``` C++
public:
XElement^ Append(
	TDataType value
)
```


#### Parameters
&nbsp;<dl><dt>value</dt><dd>Type: <a href="T_Aml_Engine_CAEX_ValueSequence_1">*TDataType*</a><br />The value.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement" target="_parent" rel="noopener noreferrer">XElement</a><br />The created XML node.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="T_Aml_Engine_CAEX_SchemaConformanceException">SchemaConformanceException</a></td><td>The element could not be appended.</td></tr></table>

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_ValueSequence_1">ValueSequence(TDataType) Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />