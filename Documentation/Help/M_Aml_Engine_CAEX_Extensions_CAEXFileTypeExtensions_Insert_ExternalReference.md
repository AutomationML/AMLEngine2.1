# CAEXFileTypeExtensions.Insert_ExternalReference Method 
AutomationML 2.1 API 

**Note: This API is now obsolete.**

Inserts the ExternalReference into the CAEX file.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
[ObsoleteAttribute("use CAEXFileType.Insert instead")]
public static void Insert_ExternalReference(
	this CAEXFileType caexFile,
	ExternalReferenceType externalReference
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
<ObsoleteAttribute("use CAEXFileType.Insert instead")>
Public Shared Sub Insert_ExternalReference ( 
	caexFile As CAEXFileType,
	externalReference As ExternalReferenceType
)
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
[ObsoleteAttribute(L"use CAEXFileType.Insert instead")]
static void Insert_ExternalReference(
	CAEXFileType^ caexFile, 
	ExternalReferenceType^ externalReference
)
```


#### Parameters
&nbsp;<dl><dt>caexFile</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXFileType">Aml.Engine.CAEX.CAEXFileType</a><br />The CAEX file.</dd><dt>externalReference</dt><dd>Type: <a href="T_Aml_Engine_CAEX_ExternalReferenceType">Aml.Engine.CAEX.ExternalReferenceType</a><br />The ExternalReference object.</dd></dl>

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_CAEXFileType">CAEXFileType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_CAEXFileTypeExtensions">CAEXFileTypeExtensions Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />