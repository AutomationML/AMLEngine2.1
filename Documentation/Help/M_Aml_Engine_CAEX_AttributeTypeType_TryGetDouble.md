# AttributeTypeType.TryGetDouble Method 
AutomationML 2.1 API 

Tries to parse the Attribute Value string as double. This method uses the XmlConvert <a href="https://docs.microsoft.com/dotnet/api/system.xml.xmlconvert.todouble#System_Xml_XmlConvert_ToDouble_System_String_" target="_parent" rel="noopener noreferrer">ToDouble(String)</a> method and a fall back conversion, if the first conversion fails.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public bool TryGetDouble(
	out double doubleValue
)
```

**VB**<br />
``` VB
Public Function TryGetDouble ( 
	<OutAttribute> ByRef doubleValue As Double
) As Boolean
```

**C++**<br />
``` C++
public:
bool TryGetDouble(
	[OutAttribute] double% doubleValue
)
```


#### Parameters
&nbsp;<dl><dt>doubleValue</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.double" target="_parent" rel="noopener noreferrer">System.Double</a><br />The double value.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true` if success, `false` otherwise.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_AttributeTypeType">AttributeTypeType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />