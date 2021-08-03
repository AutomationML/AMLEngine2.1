# AMLEngineAdapter.GetClassName Method (InternalElementType)
AutomationML 2.1 API 

**Note: This API is now obsolete.**

Gets the name of the referenced SystemUnit class.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Adapter">Aml.Engine.Adapter</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
[ObsoleteAttribute("Use the ReferencedClassName method.", false)]
public static string GetClassName(
	this InternalElementType internalElement
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
<ObsoleteAttribute("Use the ReferencedClassName method.", false)>
Public Shared Function GetClassName ( 
	internalElement As InternalElementType
) As String
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
[ObsoleteAttribute(L"Use the ReferencedClassName method.", false)]
static String^ GetClassName(
	InternalElementType^ internalElement
)
```


#### Parameters
&nbsp;<dl><dt>internalElement</dt><dd>Type: <a href="T_Aml_Engine_CAEX_InternalElementType">Aml.Engine.CAEX.InternalElementType</a><br />The InternalElement.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a><br />\[Missing <returns> documentation for "M:Aml.Engine.Adapter.AMLEngineAdapter.GetClassName(Aml.Engine.CAEX.InternalElementType)"\]

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_InternalElementType">InternalElementType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter Class</a><br /><a href="Overload_Aml_Engine_Adapter_AMLEngineAdapter_GetClassName">GetClassName Overload</a><br /><a href="N_Aml_Engine_Adapter">Aml.Engine.Adapter Namespace</a><br />