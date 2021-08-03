CaexValue.IsDateTimeType Method
===============================
Determines if the type code derived from the Attribute datatype is a date time type. The following type codes are recognized as date time types: [Time][1][Date][1][DateTime][1][GYearMonth][1][GMonthDay][1]

  **Namespace:**  [Aml.Engine.CAEX.Extensions][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public bool IsDateTimeType()
```

#### Return Value
Type: [Boolean][3]  
`true`, if the type code is a date time type; `false` otherwise.

Remarks
-------
 The AttributeDataType 'duration' is not marked as a DateTime Type, because it should be transformed into a [TimeSpan][4] CLR type. 

See Also
--------

#### Reference
[CaexValue Class][5]  
[Aml.Engine.CAEX.Extensions Namespace][2]  

[1]: https://docs.microsoft.com/dotnet/api/system.xml.schema.xmltypecode
[2]: ../README.md
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: https://docs.microsoft.com/dotnet/api/system.timespan
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png