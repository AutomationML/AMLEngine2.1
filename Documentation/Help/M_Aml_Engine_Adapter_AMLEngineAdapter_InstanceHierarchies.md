# AMLEngineAdapter.InstanceHierarchies Method 
AutomationML 2.1 API 

**Note: This API is now obsolete.**

Enumeration Method for all InstanceHierarchies of the CAEXFile.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Adapter">Aml.Engine.Adapter</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
[ObsoleteAttribute("Use InstanceHierarchy Property instead.")]
public static IEnumerable<InstanceHierarchyType> InstanceHierarchies(
	this CAEXFileType caexFile
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
<ObsoleteAttribute("Use InstanceHierarchy Property instead.")>
Public Shared Function InstanceHierarchies ( 
	caexFile As CAEXFileType
) As IEnumerable(Of InstanceHierarchyType)
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
[ObsoleteAttribute(L"Use InstanceHierarchy Property instead.")]
static IEnumerable<InstanceHierarchyType^>^ InstanceHierarchies(
	CAEXFileType^ caexFile
)
```


#### Parameters
&nbsp;<dl><dt>caexFile</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXFileType">Aml.Engine.CAEX.CAEXFileType</a><br />\[Missing <param name="caexFile"/> documentation for "M:Aml.Engine.Adapter.AMLEngineAdapter.InstanceHierarchies(Aml.Engine.CAEX.CAEXFileType)"\]</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_CAEX_InstanceHierarchyType">InstanceHierarchyType</a>)<br />IEnumerable<InstanceHierarchyType>.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_CAEXFileType">CAEXFileType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter Class</a><br /><a href="N_Aml_Engine_Adapter">Aml.Engine.Adapter Namespace</a><br />