# CAEXSequence(*T*) Constructor 
AutomationML 2.1 API 

Creates a new instance of the CAEXSequencce for the specified owner and the specified name which has to be a valid name for child elements, which can be filtered out from the owner by this name.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public CAEXSequence(
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
CAEXSequence(
	XElement^ owner, 
	String^ caexName, 
	Func<XElement^, T>^ create
)
```


#### Parameters
&nbsp;<dl><dt>owner</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement" target="_parent" rel="noopener noreferrer">System.Xml.Linq.XElement</a><br />The owner</dd><dt>caexName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />CAEX-Name of the items in this sequence</dd><dt>create</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.func-2" target="_parent" rel="noopener noreferrer">System.Func</a>(<a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement" target="_parent" rel="noopener noreferrer">XElement</a>, <a href="T_Aml_Engine_CAEX_CAEXSequence_1">*T*</a>)<br />The constructor function</dd></dl>

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_CAEXSequence_1">CAEXSequence(T) Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />