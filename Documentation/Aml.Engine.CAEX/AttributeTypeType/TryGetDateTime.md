AttributeTypeType.TryGetDateTime Method
=======================================
Tries to parse the Attribute Value string as dateTime. This method uses the XmlConvert [ToDateTime(String, XmlDateTimeSerializationMode)][1] method.

  **Namespace:**  [Aml.Engine.CAEX][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public bool TryGetDateTime(
	XmlDateTimeSerializationMode dateTimeOption,
	out DateTime dateTimeValue
)
```

#### Parameters

##### *dateTimeOption*
Type: [System.Xml.XmlDateTimeSerializationMode][3]  
The date time option.

##### *dateTimeValue*
Type: [System.DateTime][4]  
The DateTime value.

#### Return Value
Type: [Boolean][5]  
`true` if success, `false` otherwise.

See Also
--------

#### Reference
[AttributeTypeType Class][6]  
[Aml.Engine.CAEX Namespace][2]  

[1]: https://docs.microsoft.com/dotnet/api/system.xml.xmlconvert.todatetime#System_Xml_XmlConvert_ToDateTime_System_String_System_Xml_XmlDateTimeSerializationMode_
[2]: ../README.md
[3]: https://docs.microsoft.com/dotnet/api/system.xml.xmldatetimeserializationmode
[4]: https://docs.microsoft.com/dotnet/api/system.datetime
[5]: https://docs.microsoft.com/dotnet/api/system.boolean
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png