# AMLEngineAdapter.Create_UniqueCopy Method 
AutomationML 2.1 API 

**Note: This API is now obsolete.**

Creates a copy with a unique ID.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Adapter">Aml.Engine.Adapter</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
[ObsoleteAttribute("Use CAEXWrapper.Copy.")]
public static InternalElementType Create_UniqueCopy(
	this InternalElementType internalElement,
	bool deepClone
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
<ObsoleteAttribute("Use CAEXWrapper.Copy.")>
Public Shared Function Create_UniqueCopy ( 
	internalElement As InternalElementType,
	deepClone As Boolean
) As InternalElementType
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
[ObsoleteAttribute(L"Use CAEXWrapper.Copy.")]
static InternalElementType^ Create_UniqueCopy(
	InternalElementType^ internalElement, 
	bool deepClone
)
```


#### Parameters
&nbsp;<dl><dt>internalElement</dt><dd>Type: <a href="T_Aml_Engine_CAEX_InternalElementType">Aml.Engine.CAEX.InternalElementType</a><br />The internal element.</dd><dt>deepClone</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />if set to `true` [deep clone].</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_InternalElementType">InternalElementType</a><br />InternalElementType.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_InternalElementType">InternalElementType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter Class</a><br /><a href="N_Aml_Engine_Adapter">Aml.Engine.Adapter Namespace</a><br />