# FrameAttributeType.IsFrame Method 
AutomationML 2.1 API 

Determines whether the specified node models an AutomationML Frame-Attribute.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static bool IsFrame(
	XElement node
)
```

**VB**<br />
``` VB
Public Shared Function IsFrame ( 
	node As XElement
) As Boolean
```

**C++**<br />
``` C++
public:
static bool IsFrame(
	XElement^ node
)
```


#### Parameters
&nbsp;<dl><dt>node</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement" target="_parent" rel="noopener noreferrer">System.Xml.Linq.XElement</a><br />The node.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true` if the specified node is frame; otherwise, `false`.

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_FrameAttributeType">FrameAttributeType Class</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />