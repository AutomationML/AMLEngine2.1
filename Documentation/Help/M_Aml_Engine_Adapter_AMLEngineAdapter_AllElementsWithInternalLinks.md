# AMLEngineAdapter.AllElementsWithInternalLinks Method 
AutomationML 2.1 API 

**Note: This API is now obsolete.**

Getting an enumerable of all Elements with InternalLinks of all InstanceHierarchies and SystemUnitClassLibraries in the CAEXFile. The enumeration may return InternalElements or SystemUnitClass elements.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Adapter">Aml.Engine.Adapter</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
[ObsoleteAttribute("Use the Services.ServiceLocator.QueryService for any query.")]
public static IEnumerable<CAEXBasicObject> AllElementsWithInternalLinks(
	this CAEXFileType caexFile
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
<ObsoleteAttribute("Use the Services.ServiceLocator.QueryService for any query.")>
Public Shared Function AllElementsWithInternalLinks ( 
	caexFile As CAEXFileType
) As IEnumerable(Of CAEXBasicObject)
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
[ObsoleteAttribute(L"Use the Services.ServiceLocator.QueryService for any query.")]
static IEnumerable<CAEXBasicObject^>^ AllElementsWithInternalLinks(
	CAEXFileType^ caexFile
)
```


#### Parameters
&nbsp;<dl><dt>caexFile</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXFileType">Aml.Engine.CAEX.CAEXFileType</a><br />\[Missing <param name="caexFile"/> documentation for "M:Aml.Engine.Adapter.AMLEngineAdapter.AllElementsWithInternalLinks(Aml.Engine.CAEX.CAEXFileType)"\]</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_CAEX_CAEXBasicObject">CAEXBasicObject</a>)<br />An IEnumerable with SystemUnitClasses is returned.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_CAEXFileType">CAEXFileType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter Class</a><br /><a href="N_Aml_Engine_Adapter">Aml.Engine.Adapter Namespace</a><br />