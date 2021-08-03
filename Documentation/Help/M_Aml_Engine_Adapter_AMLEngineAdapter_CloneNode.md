# AMLEngineAdapter.CloneNode Method 
AutomationML 2.1 API 

**Note: This API is now obsolete.**

Clones the node.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Adapter">Aml.Engine.Adapter</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
[ObsoleteAttribute("Use CAEXWrapper.Copy.")]
public static CAEXWrapper CloneNode(
	this CAEXBasicObject caexObject,
	bool deepClone,
	bool assignNewGuidsToIEs
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
<ObsoleteAttribute("Use CAEXWrapper.Copy.")>
Public Shared Function CloneNode ( 
	caexObject As CAEXBasicObject,
	deepClone As Boolean,
	assignNewGuidsToIEs As Boolean
) As CAEXWrapper
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
[ObsoleteAttribute(L"Use CAEXWrapper.Copy.")]
static CAEXWrapper^ CloneNode(
	CAEXBasicObject^ caexObject, 
	bool deepClone, 
	bool assignNewGuidsToIEs
)
```


#### Parameters
&nbsp;<dl><dt>caexObject</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXBasicObject">Aml.Engine.CAEX.CAEXBasicObject</a><br />The CAEX object.</dd><dt>deepClone</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />if set to `true` [deep clone].</dd><dt>assignNewGuidsToIEs</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />if set to `true` [assign new GUIDs to IEs].</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a><br />The cloned node CAEXWrapper.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_CAEXBasicObject">CAEXBasicObject</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter Class</a><br /><a href="N_Aml_Engine_Adapter">Aml.Engine.Adapter Namespace</a><br />