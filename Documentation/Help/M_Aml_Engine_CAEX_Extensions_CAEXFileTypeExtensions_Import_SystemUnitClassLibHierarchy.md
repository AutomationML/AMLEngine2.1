# CAEXFileTypeExtensions.Import_SystemUnitClassLibHierarchy Method 
AutomationML 2.1 API 

Imports the provided library into the SystemUnitClassLib collection of this CAEX file.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static SystemUnitClassLibType Import_SystemUnitClassLibHierarchy(
	this CAEXFileType caexFile,
	SystemUnitClassLibType systemUnitClassLib
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function Import_SystemUnitClassLibHierarchy ( 
	caexFile As CAEXFileType,
	systemUnitClassLib As SystemUnitClassLibType
) As SystemUnitClassLibType
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static SystemUnitClassLibType^ Import_SystemUnitClassLibHierarchy(
	CAEXFileType^ caexFile, 
	SystemUnitClassLibType^ systemUnitClassLib
)
```


#### Parameters
&nbsp;<dl><dt>caexFile</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXFileType">Aml.Engine.CAEX.CAEXFileType</a><br />the CAEX file</dd><dt>systemUnitClassLib</dt><dd>Type: <a href="T_Aml_Engine_CAEX_SystemUnitClassLibType">Aml.Engine.CAEX.SystemUnitClassLibType</a><br />The source SystemUnitClassLib.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_SystemUnitClassLibType">SystemUnitClassLibType</a><br />The imported SystemUnitClassLib.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_CAEXFileType">CAEXFileType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_CAEXFileTypeExtensions">CAEXFileTypeExtensions Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />