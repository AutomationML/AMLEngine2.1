# UpdateEventArgs Constructor (XElement, XAttribute, String)
AutomationML 2.1 API 

Initializes a new instance of the <a href="T_Aml_Engine_Services_Interfaces_UpdateEventArgs">UpdateEventArgs</a> class.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public UpdateEventArgs(
	XElement referencedElement,
	XAttribute reference,
	string newValue
)
```

**VB**<br />
``` VB
Public Sub New ( 
	referencedElement As XElement,
	reference As XAttribute,
	newValue As String
)
```

**C++**<br />
``` C++
public:
UpdateEventArgs(
	XElement^ referencedElement, 
	XAttribute^ reference, 
	String^ newValue
)
```


#### Parameters
&nbsp;<dl><dt>referencedElement</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement" target="_parent" rel="noopener noreferrer">System.Xml.Linq.XElement</a><br />The referenced element.</dd><dt>reference</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xattribute" target="_parent" rel="noopener noreferrer">System.Xml.Linq.XAttribute</a><br />The reference.</dd><dt>newValue</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The updated new value for the reference</dd></dl>

## See Also


#### Reference
<a href="T_Aml_Engine_Services_Interfaces_UpdateEventArgs">UpdateEventArgs Class</a><br /><a href="Overload_Aml_Engine_Services_Interfaces_UpdateEventArgs__ctor">UpdateEventArgs Overload</a><br /><a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces Namespace</a><br />