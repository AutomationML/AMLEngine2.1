# CaexValue.IsDateTimeType Method 
AutomationML 2.1 API 

Determines if the type code derived from the Attribute datatype is a date time type. The following type codes are recognized as date time types:
&nbsp;<ul><li><a href="https://docs.microsoft.com/dotnet/api/system.xml.schema.xmltypecode" target="_parent" rel="noopener noreferrer">Time</a></li><li><a href="https://docs.microsoft.com/dotnet/api/system.xml.schema.xmltypecode" target="_parent" rel="noopener noreferrer">Date</a></li><li><a href="https://docs.microsoft.com/dotnet/api/system.xml.schema.xmltypecode" target="_parent" rel="noopener noreferrer">DateTime</a></li><li><a href="https://docs.microsoft.com/dotnet/api/system.xml.schema.xmltypecode" target="_parent" rel="noopener noreferrer">GYearMonth</a></li><li><a href="https://docs.microsoft.com/dotnet/api/system.xml.schema.xmltypecode" target="_parent" rel="noopener noreferrer">GMonthDay</a></li></ul>&nbsp;
**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public bool IsDateTimeType()
```

**VB**<br />
``` VB
Public Function IsDateTimeType As Boolean
```

**C++**<br />
``` C++
public:
bool IsDateTimeType()
```


#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true`, if the type code is a date time type; `false` otherwise.

## Remarks
The AttributeDataType 'duration' is not marked as a DateTime Type, because it should be transformed into a <a href="https://docs.microsoft.com/dotnet/api/system.timespan" target="_parent" rel="noopener noreferrer">TimeSpan</a> CLR type.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_CaexValue">CaexValue Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />