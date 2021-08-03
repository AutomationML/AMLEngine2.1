# CAEXFileTypeExtensions.PreorderTraversal Method 
AutomationML 2.1 API 

Traversal method for a hierarchical tree, with identical childSelector for all tree nodes. The method uses a pre-order algorithm without recursion for the deep traversal of the complete tree.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static IEnumerable PreorderTraversal(
	this CAEXFileType caexFile,
	IEnumerator source,
	Func<Object, IEnumerator> childSelector
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function PreorderTraversal ( 
	caexFile As CAEXFileType,
	source As IEnumerator,
	childSelector As Func(Of Object, IEnumerator)
) As IEnumerable
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static IEnumerable^ PreorderTraversal(
	CAEXFileType^ caexFile, 
	IEnumerator^ source, 
	Func<Object^, IEnumerator^>^ childSelector
)
```


#### Parameters
&nbsp;<dl><dt>caexFile</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXFileType">Aml.Engine.CAEX.CAEXFileType</a><br />the CAEXFile</dd><dt>source</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.ienumerator" target="_parent" rel="noopener noreferrer">System.Collections.IEnumerator</a><br />The source.</dd><dt>childSelector</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.func-2" target="_parent" rel="noopener noreferrer">System.Func</a>(<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_parent" rel="noopener noreferrer">Object</a>, <a href="https://docs.microsoft.com/dotnet/api/system.collections.ienumerator" target="_parent" rel="noopener noreferrer">IEnumerator</a>)<br />The child selector.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.ienumerable" target="_parent" rel="noopener noreferrer">IEnumerable</a><br />IEnumerable.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_CAEXFileType">CAEXFileType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_CAEXFileTypeExtensions">CAEXFileTypeExtensions Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />