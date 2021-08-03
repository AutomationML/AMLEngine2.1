# AMLEngineAdapter.New_RequiredValue Method (NominalScaledTypeType, String)
AutomationML 2.1 API 

**Note: This API is now obsolete.**

Adds a new required value to the NominalScaledType Constraint.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Adapter">Aml.Engine.Adapter</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
[ObsoleteAttribute("use the method NominalScaledTypeType.RequiredValue.Append instead.")]
public static void New_RequiredValue(
	this NominalScaledTypeType nominalScaledType,
	string value
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
<ObsoleteAttribute("use the method NominalScaledTypeType.RequiredValue.Append instead.")>
Public Shared Sub New_RequiredValue ( 
	nominalScaledType As NominalScaledTypeType,
	value As String
)
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
[ObsoleteAttribute(L"use the method NominalScaledTypeType.RequiredValue.Append instead.")]
static void New_RequiredValue(
	NominalScaledTypeType^ nominalScaledType, 
	String^ value
)
```


#### Parameters
&nbsp;<dl><dt>nominalScaledType</dt><dd>Type: <a href="T_Aml_Engine_CAEX_NominalScaledTypeType">Aml.Engine.CAEX.NominalScaledTypeType</a><br />Type of the nominal scaled.</dd><dt>value</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The value.</dd></dl>

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_NominalScaledTypeType">NominalScaledTypeType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter Class</a><br /><a href="Overload_Aml_Engine_Adapter_AMLEngineAdapter_New_RequiredValue">New_RequiredValue Overload</a><br /><a href="N_Aml_Engine_Adapter">Aml.Engine.Adapter Namespace</a><br />