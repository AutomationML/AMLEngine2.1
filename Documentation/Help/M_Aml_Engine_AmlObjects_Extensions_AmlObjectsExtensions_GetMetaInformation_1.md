# AmlObjectsExtensions.GetMetaInformation Method (CAEXFileType, String)
AutomationML 2.1 API 

This function returns the MetaInformation corresponding to the writerID, otherwise null.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects_Extensions">Aml.Engine.AmlObjects.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static MetaInformation GetMetaInformation(
	this CAEXFileType caexFile,
	string writerID
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function GetMetaInformation ( 
	caexFile As CAEXFileType,
	writerID As String
) As MetaInformation
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static MetaInformation^ GetMetaInformation(
	CAEXFileType^ caexFile, 
	String^ writerID
)
```


#### Parameters
&nbsp;<dl><dt>caexFile</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXFileType">Aml.Engine.CAEX.CAEXFileType</a><br />this CAEX file</dd><dt>writerID</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />the writerID</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_AmlObjects_MetaInformation">MetaInformation</a><br />This function returns the MetaInformation corresponding to the writerID, otherwise null.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_CAEXFileType">CAEXFileType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td>caexFile</td></tr></table>

## Remarks
Extension Method originally designed for AutomationML Versions based on CAEX 2.15. If this method is applied to a CAEX 3.0 document, the information is transformed from a <a href="T_Aml_Engine_CAEX_SourceDocumentInformationType">SourceDocumentInformationType</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions">AmlObjectsExtensions Class</a><br /><a href="Overload_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions_GetMetaInformation">GetMetaInformation Overload</a><br /><a href="N_Aml_Engine_AmlObjects_Extensions">Aml.Engine.AmlObjects.Extensions Namespace</a><br />