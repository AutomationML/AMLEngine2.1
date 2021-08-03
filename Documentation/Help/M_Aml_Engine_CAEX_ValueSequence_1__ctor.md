# ValueSequence(*TDataType*) Constructor (XElement, String)
AutomationML 2.1 API 

Creates a new instance of the ValueSequence for the specified owner and the specified name which has to be a valid name for child elements, which can be filtered out from the owner by this name.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public ValueSequence(
	XElement owner,
	string elementName
)
```

**VB**<br />
``` VB
Public Sub New ( 
	owner As XElement,
	elementName As String
)
```

**C++**<br />
``` C++
public:
ValueSequence(
	XElement^ owner, 
	String^ elementName
)
```


#### Parameters
&nbsp;<dl><dt>owner</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement" target="_parent" rel="noopener noreferrer">System.Xml.Linq.XElement</a><br />The owner.</dd><dt>elementName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The element name.</dd></dl>

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_ValueSequence_1">ValueSequence(TDataType) Class</a><br /><a href="Overload_Aml_Engine_CAEX_ValueSequence_1__ctor">ValueSequence(TDataType) Overload</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />