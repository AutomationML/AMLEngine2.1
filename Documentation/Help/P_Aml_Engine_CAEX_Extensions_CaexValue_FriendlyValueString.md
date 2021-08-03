# CaexValue.FriendlyValueString Property 
AutomationML 2.1 API 

Gets a friendly string of the Attribute value. This string is not in any case equal to the attribute value string, which is always an encoded string, according to the AttributeDataType. The conversion format used to convert the value to its string representation is fix and cannot be changed.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public string FriendlyValueString { get; }
```

**VB**<br />
``` VB
Public ReadOnly Property FriendlyValueString As String
	Get
```

**C++**<br />
``` C++
public:
property String^ FriendlyValueString {
	String^ get ();
}
```


#### Property Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a><br />The friendly string.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_CaexValue">CaexValue Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />