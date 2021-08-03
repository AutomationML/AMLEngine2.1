# CAEXElementChangeEventArgs Constructor (XElement, XElement, CAEXDocument, XAttribute, String, Object, Object, CAEXElementChangeMode)
AutomationML 2.1 API 

Constructs arguments for an element's attribute changing event

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Commands">Aml.Engine.CAEX.Commands</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public CAEXElementChangeEventArgs(
	XElement caexElement,
	XElement caexParent,
	CAEXDocument document,
	XAttribute attribute,
	string attributeName,
	Object oldValue,
	Object newValue,
	CAEXElementChangeMode changeMode
)
```

**VB**<br />
``` VB
Public Sub New ( 
	caexElement As XElement,
	caexParent As XElement,
	document As CAEXDocument,
	attribute As XAttribute,
	attributeName As String,
	oldValue As Object,
	newValue As Object,
	changeMode As CAEXElementChangeMode
)
```

**C++**<br />
``` C++
public:
CAEXElementChangeEventArgs(
	XElement^ caexElement, 
	XElement^ caexParent, 
	CAEXDocument^ document, 
	XAttribute^ attribute, 
	String^ attributeName, 
	Object^ oldValue, 
	Object^ newValue, 
	CAEXElementChangeMode changeMode
)
```


#### Parameters
&nbsp;<dl><dt>caexElement</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement" target="_parent" rel="noopener noreferrer">System.Xml.Linq.XElement</a><br />The CAEX element.</dd><dt>caexParent</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement" target="_parent" rel="noopener noreferrer">System.Xml.Linq.XElement</a><br />The CAEX parent.</dd><dt>document</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">Aml.Engine.CAEX.CAEXDocument</a><br />The document.</dd><dt>attribute</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xattribute" target="_parent" rel="noopener noreferrer">System.Xml.Linq.XAttribute</a><br />The attribute.</dd><dt>attributeName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />Name of the attribute.</dd><dt>oldValue</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_parent" rel="noopener noreferrer">System.Object</a><br />The old value.</dd><dt>newValue</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_parent" rel="noopener noreferrer">System.Object</a><br />The new value.</dd><dt>changeMode</dt><dd>Type: <a href="T_Aml_Engine_CAEX_Commands_CAEXElementChangeMode">Aml.Engine.CAEX.Commands.CAEXElementChangeMode</a><br />The change mode.</dd></dl>

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Commands_CAEXElementChangeEventArgs">CAEXElementChangeEventArgs Class</a><br /><a href="Overload_Aml_Engine_CAEX_Commands_CAEXElementChangeEventArgs__ctor">CAEXElementChangeEventArgs Overload</a><br /><a href="N_Aml_Engine_CAEX_Commands">Aml.Engine.CAEX.Commands Namespace</a><br />