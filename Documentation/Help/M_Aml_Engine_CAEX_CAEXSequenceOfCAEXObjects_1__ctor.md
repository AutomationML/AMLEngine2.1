# CAEXSequenceOfCAEXObjects(*T*) Constructor (XElement, String, Func(XElement, *T*))
AutomationML 2.1 API 

Initializes a new instance of the <a href="T_Aml_Engine_CAEX_CAEXSequenceOfCAEXObjects_1">CAEXSequenceOfCAEXObjects(T)</a> class.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public CAEXSequenceOfCAEXObjects(
	XElement owner,
	string caexName,
	Func<XElement, T> create
)
```

**VB**<br />
``` VB
Public Sub New ( 
	owner As XElement,
	caexName As String,
	create As Func(Of XElement, T)
)
```

**C++**<br />
``` C++
public:
CAEXSequenceOfCAEXObjects(
	XElement^ owner, 
	String^ caexName, 
	Func<XElement^, T>^ create
)
```


#### Parameters
&nbsp;<dl><dt>owner</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement" target="_parent" rel="noopener noreferrer">System.Xml.Linq.XElement</a><br />The owner.</dd><dt>caexName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The CAEX element name.</dd><dt>create</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.func-2" target="_parent" rel="noopener noreferrer">System.Func</a>(<a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement" target="_parent" rel="noopener noreferrer">XElement</a>, <a href="T_Aml_Engine_CAEX_CAEXSequenceOfCAEXObjects_1">*T*</a>)<br />The constructor function to create a wrapper.</dd></dl>

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_CAEXSequenceOfCAEXObjects_1">CAEXSequenceOfCAEXObjects(T) Class</a><br /><a href="Overload_Aml_Engine_CAEX_CAEXSequenceOfCAEXObjects_1__ctor">CAEXSequenceOfCAEXObjects(T) Overload</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />