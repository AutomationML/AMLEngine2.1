# AttributeTypeType.SetDateTime Method 
AutomationML 2.1 API 

Sets the specified dateTime value as the attribute value. The AttributeDataType is set to xs:dateTime

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public void SetDateTime(
	DateTime value,
	XmlDateTimeSerializationMode mode
)
```

**VB**<br />
``` VB
Public Sub SetDateTime ( 
	value As DateTime,
	mode As XmlDateTimeSerializationMode
)
```

**C++**<br />
``` C++
public:
void SetDateTime(
	DateTime value, 
	XmlDateTimeSerializationMode mode
)
```


#### Parameters
&nbsp;<dl><dt>value</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.datetime" target="_parent" rel="noopener noreferrer">System.DateTime</a><br />The value.</dd><dt>mode</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.xmldatetimeserializationmode" target="_parent" rel="noopener noreferrer">System.Xml.XmlDateTimeSerializationMode</a><br />The serialization mode, use UTC</dd></dl>

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_AttributeTypeType">AttributeTypeType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />