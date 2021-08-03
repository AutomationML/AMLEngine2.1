# AMLEngineAdapter.GetParent Method 
AutomationML 2.1 API 

**Note: This API is now obsolete.**

This method returns the parent CAEXBasicObject of the current CAEXBasicObject.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Adapter">Aml.Engine.Adapter</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
[ObsoleteAttribute("Use the CAEXParent Property, which is defined for all CAEX objects.")]
public static CAEXBasicObject GetParent(
	this CAEXFileType caexFile,
	CAEXBasicObject obj
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
<ObsoleteAttribute("Use the CAEXParent Property, which is defined for all CAEX objects.")>
Public Shared Function GetParent ( 
	caexFile As CAEXFileType,
	obj As CAEXBasicObject
) As CAEXBasicObject
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
[ObsoleteAttribute(L"Use the CAEXParent Property, which is defined for all CAEX objects.")]
static CAEXBasicObject^ GetParent(
	CAEXFileType^ caexFile, 
	CAEXBasicObject^ obj
)
```


#### Parameters
&nbsp;<dl><dt>caexFile</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXFileType">Aml.Engine.CAEX.CAEXFileType</a><br />The CAEX file.</dd><dt>obj</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXBasicObject">Aml.Engine.CAEX.CAEXBasicObject</a><br />the CAEX Basic Object</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_CAEXBasicObject">CAEXBasicObject</a><br />the parent CAEXBasicObject

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_CAEXFileType">CAEXFileType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter Class</a><br /><a href="N_Aml_Engine_Adapter">Aml.Engine.Adapter Namespace</a><br />