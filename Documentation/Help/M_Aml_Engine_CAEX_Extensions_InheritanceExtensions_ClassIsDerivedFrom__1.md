# InheritanceExtensions.ClassIsDerivedFrom(*T*) Method (CAEXDocument, String, String)
AutomationML 2.1 API 

Determines, if the class, specified with the given class path is directly or indirectly (across multiple generations) a descendant of the class or identical to it, which is uniquely identified with the specified baseClass path. The base class path or the referenced class path may contain alias identifiers. If alias identifiers are present, the method tries to load the externally referenced document.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static bool? ClassIsDerivedFrom<T>(
	this CAEXDocument document,
	string classPath,
	string baseClassPath
)
where T : CAEXObject

```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function ClassIsDerivedFrom(Of T As CAEXObject) ( 
	document As CAEXDocument,
	classPath As String,
	baseClassPath As String
) As Boolean?
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
generic<typename T>
where T : CAEXObject
static Nullable<bool> ClassIsDerivedFrom(
	CAEXDocument^ document, 
	String^ classPath, 
	String^ baseClassPath
)
```


#### Parameters
&nbsp;<dl><dt>document</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">Aml.Engine.CAEX.CAEXDocument</a><br />The document where the classes are searched</dd><dt>classPath</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The class path of the tested class.</dd><dt>baseClassPath</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The base class path.</dd></dl>

#### Type Parameters
&nbsp;<dl><dt>T</dt><dd>The type of the CAEX class.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.nullable-1" target="_parent" rel="noopener noreferrer">Nullable</a>(<a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a>)<br />`true` if the class is derived, `false` if it is not. If no value is returned, some references could not be resolved to get the answer.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_CAEXDocument">CAEXDocument</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_InheritanceExtensions">InheritanceExtensions Class</a><br /><a href="Overload_Aml_Engine_CAEX_Extensions_InheritanceExtensions_ClassIsDerivedFrom">ClassIsDerivedFrom Overload</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />