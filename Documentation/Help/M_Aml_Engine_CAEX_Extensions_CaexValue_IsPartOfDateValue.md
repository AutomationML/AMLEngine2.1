# CaexValue.IsPartOfDateValue Method 
AutomationML 2.1 API 

Determines if the type code derived from the Attribute datatype defined a part of a date. The datatype `ushort` is used for a date part. The following type codes are recognized as date parts:
&nbsp;<ul><li><a href="https://docs.microsoft.com/dotnet/api/system.xml.schema.xmltypecode" target="_parent" rel="noopener noreferrer">GMonth</a></li><li><a href="https://docs.microsoft.com/dotnet/api/system.xml.schema.xmltypecode" target="_parent" rel="noopener noreferrer">GDay</a></li><li><a href="https://docs.microsoft.com/dotnet/api/system.xml.schema.xmltypecode" target="_parent" rel="noopener noreferrer">GYear</a></li></ul>&nbsp;
**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public bool IsPartOfDateValue()
```

**VB**<br />
``` VB
Public Function IsPartOfDateValue As Boolean
```

**C++**<br />
``` C++
public:
bool IsPartOfDateValue()
```


#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true`, if the type code is a date part; `false` otherwise.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_CaexValue">CaexValue Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />