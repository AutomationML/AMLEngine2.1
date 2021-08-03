AttributeTypeType.GetDateTime Method
====================================
AutomationML 2.1 APIParse the Attribute Value string as dateTime. If the string can not be parsed, a format exception is returned. This method uses the XmlConvert [ToDateTime(String, XmlDateTimeSerializationMode)][1] method.

  **Namespace:**  [Aml.Engine.CAEX][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public DateTime GetDateTime(
	XmlDateTimeSerializationMode dateTimeOption
)
```

#### Parameters

##### *dateTimeOption*
Type: [System.Xml.XmlDateTimeSerializationMode][3]  
The date time option.

#### Return Value
Type: [DateTime][4]  
DateTime.

Exceptions
----------

Exception            | Condition 
-------------------- | --------- 
[FormatException][5] |           


See Also
--------

#### Reference
[AttributeTypeType Class][6]  
[Aml.Engine.CAEX Namespace][2]  

[1]: https://docs.microsoft.com/dotnet/api/system.xml.xmlconvert.todatetime#System_Xml_XmlConvert_ToDateTime_System_String_System_Xml_XmlDateTimeSerializationMode_
[2]: ../README.md
[3]: https://docs.microsoft.com/dotnet/api/system.xml.xmldatetimeserializationmode
[4]: https://docs.microsoft.com/dotnet/api/system.datetime
[5]: https://docs.microsoft.com/dotnet/api/system.formatexception
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png