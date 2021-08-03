# CAEXElementChangeEventArgs.CAEXParent Property 
AutomationML 2.1 API 

The changed CAEXElement's parent. This Property should be used, to detect a former parent of a CAEXElement, when the CAEXElement has been deleted and has no associated parent.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Commands">Aml.Engine.CAEX.Commands</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public XElement CAEXParent { get; }
```

**VB**<br />
``` VB
Public ReadOnly Property CAEXParent As XElement
	Get
```

**C++**<br />
``` C++
public:
property XElement^ CAEXParent {
	XElement^ get ();
}
```


#### Property Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement" target="_parent" rel="noopener noreferrer">XElement</a>

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Commands_CAEXElementChangeEventArgs">CAEXElementChangeEventArgs Class</a><br /><a href="N_Aml_Engine_CAEX_Commands">Aml.Engine.CAEX.Commands Namespace</a><br />