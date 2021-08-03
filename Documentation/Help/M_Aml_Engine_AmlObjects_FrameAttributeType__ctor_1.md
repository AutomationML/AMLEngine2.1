# FrameAttributeType Constructor (XElement, FrameValues)
AutomationML 2.1 API 

Initializes a new instance of the <a href="T_Aml_Engine_AmlObjects_FrameAttributeType">FrameAttributeType</a> class. It is not checked, if the provided attribute Node represents a valid Frame attribute. If Frame attributes exist, they are initialized using the specified frame values.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public FrameAttributeType(
	XElement init,
	FrameValues frameValues
)
```

**VB**<br />
``` VB
Public Sub New ( 
	init As XElement,
	frameValues As FrameValues
)
```

**C++**<br />
``` C++
public:
FrameAttributeType(
	XElement^ init, 
	FrameValues^ frameValues
)
```


#### Parameters
&nbsp;<dl><dt>init</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement" target="_parent" rel="noopener noreferrer">System.Xml.Linq.XElement</a><br />The initialize.</dd><dt>frameValues</dt><dd>Type: <a href="T_Aml_Engine_AmlObjects_FrameValues">Aml.Engine.AmlObjects.FrameValues</a><br />The frame values.</dd></dl>

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_FrameAttributeType">FrameAttributeType Class</a><br /><a href="Overload_Aml_Engine_AmlObjects_FrameAttributeType__ctor">FrameAttributeType Overload</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />