# AttributeTypeType.GetDouble Method 
AutomationML 2.1 API 

Parse the Attribute Value string as double. If the string can not be parsed, a format exception is returned. This method uses the XmlConvert <a href="https://docs.microsoft.com/dotnet/api/system.xml.xmlconvert.todouble#System_Xml_XmlConvert_ToDouble_System_String_" target="_parent" rel="noopener noreferrer">ToDouble(String)</a> method and a fall back conversion, if the first conversion fails.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public double GetDouble()
```

**VB**<br />
``` VB
Public Function GetDouble As Double
```

**C++**<br />
``` C++
public:
double GetDouble()
```


#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.double" target="_parent" rel="noopener noreferrer">Double</a><br />Double.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.formatexception" target="_parent" rel="noopener noreferrer">FormatException</a></td><td /></tr></table>

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_AttributeTypeType">AttributeTypeType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />