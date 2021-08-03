# AMLEngineAdapter.AssignNewGUIDs Method 
AutomationML 2.1 API 

**Note: This API is now obsolete.**

Assigns new GUIDs to this InternalElement and all of its child InternalElements

**Namespace:**&nbsp;<a href="N_Aml_Engine_Adapter">Aml.Engine.Adapter</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
[ObsoleteAttribute("It is not recommended to this method anymore, because ID references are not updated, which can led to an invalid document.", 
	false)]
public static void AssignNewGUIDs(
	this InternalElementType element
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
<ObsoleteAttribute("It is not recommended to this method anymore, because ID references are not updated, which can led to an invalid document.", 
	false)>
Public Shared Sub AssignNewGUIDs ( 
	element As InternalElementType
)
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
[ObsoleteAttribute(L"It is not recommended to this method anymore, because ID references are not updated, which can led to an invalid document.", 
	false)]
static void AssignNewGUIDs(
	InternalElementType^ element
)
```


#### Parameters
&nbsp;<dl><dt>element</dt><dd>Type: <a href="T_Aml_Engine_CAEX_InternalElementType">Aml.Engine.CAEX.InternalElementType</a><br />\[Missing <param name="element"/> documentation for "M:Aml.Engine.Adapter.AMLEngineAdapter.AssignNewGUIDs(Aml.Engine.CAEX.InternalElementType)"\]</dd></dl>

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_InternalElementType">InternalElementType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter Class</a><br /><a href="N_Aml_Engine_Adapter">Aml.Engine.Adapter Namespace</a><br />