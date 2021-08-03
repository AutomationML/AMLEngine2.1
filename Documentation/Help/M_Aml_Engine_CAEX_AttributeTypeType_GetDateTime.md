# AttributeTypeType.GetDateTime Method 
AutomationML 2.1 API 

Parse the Attribute Value string as dateTime. If the string can not be parsed, a format exception is returned. This method uses the XmlConvert <a href="https://docs.microsoft.com/dotnet/api/system.xml.xmlconvert.todatetime#System_Xml_XmlConvert_ToDateTime_System_String_System_Xml_XmlDateTimeSerializationMode_" target="_parent" rel="noopener noreferrer">ToDateTime(String, XmlDateTimeSerializationMode)</a> method.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public DateTime GetDateTime(
	XmlDateTimeSerializationMode dateTimeOption
)
```

**VB**<br />
``` VB
Public Function GetDateTime ( 
	dateTimeOption As XmlDateTimeSerializationMode
) As DateTime
```

**C++**<br />
``` C++
public:
DateTime GetDateTime(
	XmlDateTimeSerializationMode dateTimeOption
)
```


#### Parameters
&nbsp;<dl><dt>dateTimeOption</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.xmldatetimeserializationmode" target="_parent" rel="noopener noreferrer">System.Xml.XmlDateTimeSerializationMode</a><br />The date time option.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.datetime" target="_parent" rel="noopener noreferrer">DateTime</a><br />DateTime.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.formatexception" target="_parent" rel="noopener noreferrer">FormatException</a></td><td /></tr></table>

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_AttributeTypeType">AttributeTypeType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />