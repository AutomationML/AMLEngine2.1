# AMLEngineAdapter.Ancestors Method 
AutomationML 2.1 API 

**Note: This API is now obsolete.**

Returns all SystemUnit Classes which are ancestors of this. This SystemUnit Class is included in the enumeration as the first Element, The farthest is the last Element in the enumeration.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Adapter">Aml.Engine.Adapter</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
[ObsoleteAttribute("use the generic extension method, Ancestors<T>.")]
public static IEnumerable<SystemUnitClassType> Ancestors(
	this SystemUnitClassType systemUnitClass
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
<ObsoleteAttribute("use the generic extension method, Ancestors<T>.")>
Public Shared Function Ancestors ( 
	systemUnitClass As SystemUnitClassType
) As IEnumerable(Of SystemUnitClassType)
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
[ObsoleteAttribute(L"use the generic extension method, Ancestors<T>.")]
static IEnumerable<SystemUnitClassType^>^ Ancestors(
	SystemUnitClassType^ systemUnitClass
)
```


#### Parameters
&nbsp;<dl><dt>systemUnitClass</dt><dd>Type: <a href="T_Aml_Engine_CAEX_SystemUnitClassType">Aml.Engine.CAEX.SystemUnitClassType</a><br />\[Missing <param name="systemUnitClass"/> documentation for "M:Aml.Engine.Adapter.AMLEngineAdapter.Ancestors(Aml.Engine.CAEX.SystemUnitClassType)"\]</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_CAEX_SystemUnitClassType">SystemUnitClassType</a>)<br />IEnumerable<SystemUnitClassType>.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_SystemUnitClassType">SystemUnitClassType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter Class</a><br /><a href="N_Aml_Engine_Adapter">Aml.Engine.Adapter Namespace</a><br />