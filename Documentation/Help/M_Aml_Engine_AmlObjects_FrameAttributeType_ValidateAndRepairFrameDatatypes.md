# FrameAttributeType.ValidateAndRepairFrameDatatypes Method 
AutomationML 2.1 API 

Validates and repairs the frame data types if the data type is not defined or not of type 'xs:double'

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static bool ValidateAndRepairFrameDatatypes(
	XElement node
)
```

**VB**<br />
``` VB
Public Shared Function ValidateAndRepairFrameDatatypes ( 
	node As XElement
) As Boolean
```

**C++**<br />
``` C++
public:
static bool ValidateAndRepairFrameDatatypes(
	XElement^ node
)
```


#### Parameters
&nbsp;<dl><dt>node</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement" target="_parent" rel="noopener noreferrer">System.Xml.Linq.XElement</a><br />The node.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true` if XXXX, `false` otherwise.

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_FrameAttributeType">FrameAttributeType Class</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />