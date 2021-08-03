# CAEXFileTypeExtensions.New_RoleClassLibHierarchy Method 
AutomationML 2.1 API 

Adding a new RoleClassLib to this CAEX file.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static RoleClassLibType New_RoleClassLibHierarchy(
	this CAEXFileType caexFile,
	string name
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function New_RoleClassLibHierarchy ( 
	caexFile As CAEXFileType,
	name As String
) As RoleClassLibType
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static RoleClassLibType^ New_RoleClassLibHierarchy(
	CAEXFileType^ caexFile, 
	String^ name
)
```


#### Parameters
&nbsp;<dl><dt>caexFile</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXFileType">Aml.Engine.CAEX.CAEXFileType</a><br />the CAEX file.</dd><dt>name</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The name of the RoleClassLib.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_RoleClassLibType">RoleClassLibType</a><br />A new RoleClassLib

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_CAEXFileType">CAEXFileType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_CAEXFileTypeExtensions">CAEXFileTypeExtensions Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />