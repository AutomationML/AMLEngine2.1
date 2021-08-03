# AttributeTypeType.TryGetDateTime Method 
AutomationML 2.1 API 

Tries to parse the Attribute Value string as dateTime. This method uses the XmlConvert <a href="https://docs.microsoft.com/dotnet/api/system.xml.xmlconvert.todatetime#System_Xml_XmlConvert_ToDateTime_System_String_System_Xml_XmlDateTimeSerializationMode_" target="_parent" rel="noopener noreferrer">ToDateTime(String, XmlDateTimeSerializationMode)</a> method.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public bool TryGetDateTime(
	XmlDateTimeSerializationMode dateTimeOption,
	out DateTime dateTimeValue
)
```

**VB**<br />
``` VB
Public Function TryGetDateTime ( 
	dateTimeOption As XmlDateTimeSerializationMode,
	<OutAttribute> ByRef dateTimeValue As DateTime
) As Boolean
```

**C++**<br />
``` C++
public:
bool TryGetDateTime(
	XmlDateTimeSerializationMode dateTimeOption, 
	[OutAttribute] DateTime% dateTimeValue
)
```


#### Parameters
&nbsp;<dl><dt>dateTimeOption</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.xmldatetimeserializationmode" target="_parent" rel="noopener noreferrer">System.Xml.XmlDateTimeSerializationMode</a><br />The date time option.</dd><dt>dateTimeValue</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.datetime" target="_parent" rel="noopener noreferrer">System.DateTime</a><br />The DateTime value.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true` if success, `false` otherwise.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_AttributeTypeType">AttributeTypeType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />