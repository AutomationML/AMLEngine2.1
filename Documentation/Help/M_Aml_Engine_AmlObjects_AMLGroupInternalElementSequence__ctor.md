# AMLGroupInternalElementSequence Constructor 
AutomationML 2.1 API 

Initializes a new instance of the <a href="T_Aml_Engine_AmlObjects_AMLGroupInternalElementSequence">AMLGroupInternalElementSequence</a> class.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public AMLGroupInternalElementSequence(
	XElement owner,
	Func<XElement, InternalElementType> create
)
```

**VB**<br />
``` VB
Public Sub New ( 
	owner As XElement,
	create As Func(Of XElement, InternalElementType)
)
```

**C++**<br />
``` C++
public:
AMLGroupInternalElementSequence(
	XElement^ owner, 
	Func<XElement^, InternalElementType^>^ create
)
```


#### Parameters
&nbsp;<dl><dt>owner</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement" target="_parent" rel="noopener noreferrer">System.Xml.Linq.XElement</a><br />The owner.</dd><dt>create</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.func-2" target="_parent" rel="noopener noreferrer">System.Func</a>(<a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement" target="_parent" rel="noopener noreferrer">XElement</a>, <a href="T_Aml_Engine_CAEX_InternalElementType">InternalElementType</a>)<br />Function to create an <a href="T_Aml_Engine_CAEX_InternalElementType">InternalElementType</a>.</dd></dl>

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_AMLGroupInternalElementSequence">AMLGroupInternalElementSequence Class</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />