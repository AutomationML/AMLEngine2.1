# AMLEngineAdapter.New_RequiredMaxValue Method 
AutomationML 2.1 API 

**Note: This API is now obsolete.**

Adding a new RequiredMaxValue to this ordinal scaled constraint

**Namespace:**&nbsp;<a href="N_Aml_Engine_Adapter">Aml.Engine.Adapter</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
[ObsoleteAttribute("use the property OrdinalScaledTypeType.RequiredMaxValue instead.")]
public static void New_RequiredMaxValue(
	this OrdinalScaledTypeType ordinalScaledType,
	string value
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
<ObsoleteAttribute("use the property OrdinalScaledTypeType.RequiredMaxValue instead.")>
Public Shared Sub New_RequiredMaxValue ( 
	ordinalScaledType As OrdinalScaledTypeType,
	value As String
)
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
[ObsoleteAttribute(L"use the property OrdinalScaledTypeType.RequiredMaxValue instead.")]
static void New_RequiredMaxValue(
	OrdinalScaledTypeType^ ordinalScaledType, 
	String^ value
)
```


#### Parameters
&nbsp;<dl><dt>ordinalScaledType</dt><dd>Type: <a href="T_Aml_Engine_CAEX_OrdinalScaledTypeType">Aml.Engine.CAEX.OrdinalScaledTypeType</a><br />Type of the ordinal scaled.</dd><dt>value</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The value.</dd></dl>

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_OrdinalScaledTypeType">OrdinalScaledTypeType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter Class</a><br /><a href="N_Aml_Engine_Adapter">Aml.Engine.Adapter Namespace</a><br />