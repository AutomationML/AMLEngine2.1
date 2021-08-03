# AMLEngineAdapter.SystemUnitClassChildren Method 
AutomationML 2.1 API 

**Note: This API is now obsolete.**

Gets all Children <a href="T_Aml_Engine_CAEX_SystemUnitFamilyType">SystemUnitFamilyType</a> Objects of this SystemUnitClass.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Adapter">Aml.Engine.Adapter</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
[ObsoleteAttribute("Use SystemUnitClass Property instead.")]
public static IEnumerable<SystemUnitFamilyType> SystemUnitClassChildren(
	this SystemUnitFamilyType systemUnitClass
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
<ObsoleteAttribute("Use SystemUnitClass Property instead.")>
Public Shared Function SystemUnitClassChildren ( 
	systemUnitClass As SystemUnitFamilyType
) As IEnumerable(Of SystemUnitFamilyType)
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
[ObsoleteAttribute(L"Use SystemUnitClass Property instead.")]
static IEnumerable<SystemUnitFamilyType^>^ SystemUnitClassChildren(
	SystemUnitFamilyType^ systemUnitClass
)
```


#### Parameters
&nbsp;<dl><dt>systemUnitClass</dt><dd>Type: <a href="T_Aml_Engine_CAEX_SystemUnitFamilyType">Aml.Engine.CAEX.SystemUnitFamilyType</a><br />\[Missing <param name="systemUnitClass"/> documentation for "M:Aml.Engine.Adapter.AMLEngineAdapter.SystemUnitClassChildren(Aml.Engine.CAEX.SystemUnitFamilyType)"\]</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_CAEX_SystemUnitFamilyType">SystemUnitFamilyType</a>)<br />IEnumerable<SystemUnitFamilyType>.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_SystemUnitFamilyType">SystemUnitFamilyType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter Class</a><br /><a href="N_Aml_Engine_Adapter">Aml.Engine.Adapter Namespace</a><br />