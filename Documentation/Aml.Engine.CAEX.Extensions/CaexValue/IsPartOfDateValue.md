CaexValue.IsPartOfDateValue Method
==================================
Determines if the type code derived from the Attribute datatype defined a part of a date. The datatype `ushort` is used for a date part. The following type codes are recognized as date parts: [GMonth][1][GDay][1][GYear][1]

  **Namespace:**  [Aml.Engine.CAEX.Extensions][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public bool IsPartOfDateValue()
```

#### Return Value
Type: [Boolean][3]  
`true`, if the type code is a date part; `false` otherwise.

See Also
--------

#### Reference
[CaexValue Class][4]  
[Aml.Engine.CAEX.Extensions Namespace][2]  

[1]: https://docs.microsoft.com/dotnet/api/system.xml.schema.xmltypecode
[2]: ../README.md
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png