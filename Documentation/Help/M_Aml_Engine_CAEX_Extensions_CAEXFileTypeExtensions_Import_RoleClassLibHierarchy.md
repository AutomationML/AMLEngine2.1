# CAEXFileTypeExtensions.Import_RoleClassLibHierarchy Method 
AutomationML 2.1 API 

Imports the provided library into the RoleClassLib collection of this CAEX file.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static RoleClassLibType Import_RoleClassLibHierarchy(
	this CAEXFileType caexFile,
	RoleClassLibType roleClassLib
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function Import_RoleClassLibHierarchy ( 
	caexFile As CAEXFileType,
	roleClassLib As RoleClassLibType
) As RoleClassLibType
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static RoleClassLibType^ Import_RoleClassLibHierarchy(
	CAEXFileType^ caexFile, 
	RoleClassLibType^ roleClassLib
)
```


#### Parameters
&nbsp;<dl><dt>caexFile</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXFileType">Aml.Engine.CAEX.CAEXFileType</a><br />the CAEX file.</dd><dt>roleClassLib</dt><dd>Type: <a href="T_Aml_Engine_CAEX_RoleClassLibType">Aml.Engine.CAEX.RoleClassLibType</a><br />The source RoleClassLib.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_RoleClassLibType">RoleClassLibType</a><br />The imported RoleClassLib.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_CAEXFileType">CAEXFileType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_CAEXFileTypeExtensions">CAEXFileTypeExtensions Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />