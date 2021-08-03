# CAEXFileTypeExtensions.FindFastByPath Method (CAEXFileType, String, Boolean)
AutomationML 2.1 API 

**Note: This API is now obsolete.**

Performs a document wide fast search and returns a CAEXObject given by its Path, e.g. "plant/unit" or -in case the document is based on CAEX 2.15 - "GUID:Interface".

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
[ObsoleteAttribute("Use the standard Query FindByPath. If fast dictionary based access is required, register a FastQueryService.")]
public static CAEXObject FindFastByPath(
	this CAEXFileType caexFile,
	string path,
	bool includeExternals = false
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
<ObsoleteAttribute("Use the standard Query FindByPath. If fast dictionary based access is required, register a FastQueryService.")>
Public Shared Function FindFastByPath ( 
	caexFile As CAEXFileType,
	path As String,
	Optional includeExternals As Boolean = false
) As CAEXObject
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
[ObsoleteAttribute(L"Use the standard Query FindByPath. If fast dictionary based access is required, register a FastQueryService.")]
static CAEXObject^ FindFastByPath(
	CAEXFileType^ caexFile, 
	String^ path, 
	bool includeExternals = false
)
```


#### Parameters
&nbsp;<dl><dt>caexFile</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXFileType">Aml.Engine.CAEX.CAEXFileType</a><br />the CAEXFile</dd><dt>path</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />the path of the object which is subject of the search</dd><dt>includeExternals (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />new optional parameter to enable this method (default=`false`), to search in referenced documents also.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_CAEXObject">CAEXObject</a><br />the found CAEXObject or null if not found

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_CAEXFileType">CAEXFileType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## Remarks
External references are resolved in the search if a <a href="T_Aml_Engine_Services_Interfaces_IExternalReferenceResolver">IExternalReferenceResolver</a> service is registered.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_CAEXFileTypeExtensions">CAEXFileTypeExtensions Class</a><br /><a href="Overload_Aml_Engine_CAEX_Extensions_CAEXFileTypeExtensions_FindFastByPath">FindFastByPath Overload</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />