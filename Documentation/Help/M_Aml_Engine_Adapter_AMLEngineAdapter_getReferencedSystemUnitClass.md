# AMLEngineAdapter.getReferencedSystemUnitClass Method 
AutomationML 2.1 API 

**Note: This API is now obsolete.**

Gets the referenced SystemUnitClass using the <a href="P_Aml_Engine_CAEX_InternalElementType_RefBaseSystemUnitPath">RefBaseSystemUnitPath</a>.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Adapter">Aml.Engine.Adapter</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
[ObsoleteAttribute("use the SystemUnitClass Property of InternalElementType which allows to get and set the referenced Class")]
public static SystemUnitFamilyType getReferencedSystemUnitClass(
	this InternalElementType element
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
<ObsoleteAttribute("use the SystemUnitClass Property of InternalElementType which allows to get and set the referenced Class")>
Public Shared Function getReferencedSystemUnitClass ( 
	element As InternalElementType
) As SystemUnitFamilyType
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
[ObsoleteAttribute(L"use the SystemUnitClass Property of InternalElementType which allows to get and set the referenced Class")]
static SystemUnitFamilyType^ getReferencedSystemUnitClass(
	InternalElementType^ element
)
```


#### Parameters
&nbsp;<dl><dt>element</dt><dd>Type: <a href="T_Aml_Engine_CAEX_InternalElementType">Aml.Engine.CAEX.InternalElementType</a><br />\[Missing <param name="element"/> documentation for "M:Aml.Engine.Adapter.AMLEngineAdapter.getReferencedSystemUnitClass(Aml.Engine.CAEX.InternalElementType)"\]</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_SystemUnitFamilyType">SystemUnitFamilyType</a><br />\[Missing <returns> documentation for "M:Aml.Engine.Adapter.AMLEngineAdapter.getReferencedSystemUnitClass(Aml.Engine.CAEX.InternalElementType)"\]

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_InternalElementType">InternalElementType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter Class</a><br /><a href="N_Aml_Engine_Adapter">Aml.Engine.Adapter Namespace</a><br />