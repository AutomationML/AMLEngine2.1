# CAEXObjectExtensions.SetDescription Method 
AutomationML 2.1 API 

**Note: This API is now obsolete.**

This method sets a description. If no description exists, it is created.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
[ObsoleteAttribute("Set the value with the Description Property")]
public static void SetDescription(
	this ICAEXObject caexObject,
	string description
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
<ObsoleteAttribute("Set the value with the Description Property")>
Public Shared Sub SetDescription ( 
	caexObject As ICAEXObject,
	description As String
)
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
[ObsoleteAttribute(L"Set the value with the Description Property")]
static void SetDescription(
	ICAEXObject^ caexObject, 
	String^ description
)
```


#### Parameters
&nbsp;<dl><dt>caexObject</dt><dd>Type: <a href="T_Aml_Engine_CAEX_ICAEXObject">Aml.Engine.CAEX.ICAEXObject</a><br />the CAEX object</dd><dt>description</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />the description</dd></dl>

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_ICAEXObject">ICAEXObject</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_CAEXObjectExtensions">CAEXObjectExtensions Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />