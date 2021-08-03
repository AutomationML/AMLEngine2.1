# CAEXFileTypeExtensions.Import_AttributeTypeLib Method 
AutomationML 2.1 API 

Imports the provided library into the AttributeTypeLib collection of this CAEX file.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static AttributeTypeLibType Import_AttributeTypeLib(
	this CAEXFileType caexFile,
	AttributeTypeLibType attributeTypeLib
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function Import_AttributeTypeLib ( 
	caexFile As CAEXFileType,
	attributeTypeLib As AttributeTypeLibType
) As AttributeTypeLibType
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static AttributeTypeLibType^ Import_AttributeTypeLib(
	CAEXFileType^ caexFile, 
	AttributeTypeLibType^ attributeTypeLib
)
```


#### Parameters
&nbsp;<dl><dt>caexFile</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXFileType">Aml.Engine.CAEX.CAEXFileType</a><br />the CAEX file.</dd><dt>attributeTypeLib</dt><dd>Type: <a href="T_Aml_Engine_CAEX_AttributeTypeLibType">Aml.Engine.CAEX.AttributeTypeLibType</a><br />The source AttributeTypeLib object.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_AttributeTypeLibType">AttributeTypeLibType</a><br />The imported AttributeTypeLib.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_CAEXFileType">CAEXFileType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_CAEXFileTypeExtensions">CAEXFileTypeExtensions Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />