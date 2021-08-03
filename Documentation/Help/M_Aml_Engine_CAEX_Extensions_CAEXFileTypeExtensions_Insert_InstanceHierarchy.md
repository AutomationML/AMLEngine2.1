# CAEXFileTypeExtensions.Insert_InstanceHierarchy Method 
AutomationML 2.1 API 

**Note: This API is now obsolete.**

Insert an existing InstanceHierarchy to this CAEX file as the last InstanceHierarchy.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
[ObsoleteAttribute("use CAEXFileType.Insert instead")]
public static void Insert_InstanceHierarchy(
	this CAEXFileType caexFile,
	InstanceHierarchyType instanceHierarchyNode
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
<ObsoleteAttribute("use CAEXFileType.Insert instead")>
Public Shared Sub Insert_InstanceHierarchy ( 
	caexFile As CAEXFileType,
	instanceHierarchyNode As InstanceHierarchyType
)
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
[ObsoleteAttribute(L"use CAEXFileType.Insert instead")]
static void Insert_InstanceHierarchy(
	CAEXFileType^ caexFile, 
	InstanceHierarchyType^ instanceHierarchyNode
)
```


#### Parameters
&nbsp;<dl><dt>caexFile</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXFileType">Aml.Engine.CAEX.CAEXFileType</a><br />The CAEX file.</dd><dt>instanceHierarchyNode</dt><dd>Type: <a href="T_Aml_Engine_CAEX_InstanceHierarchyType">Aml.Engine.CAEX.InstanceHierarchyType</a><br />The InstanceHierarchy to insert.</dd></dl>

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_CAEXFileType">CAEXFileType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_CAEXFileTypeExtensions">CAEXFileTypeExtensions Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />