# AmlObjectsExtensions.ReplaceMetaInformation Method 
AutomationML 2.1 API 

This function replaces any existing meta information corresponding to the identical oldWriterID with the new meta information defined in the newMetainformation

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects_Extensions">Aml.Engine.AmlObjects.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static bool ReplaceMetaInformation(
	this CAEXFileType caexFile,
	string oldWriterID,
	MetaInformation newMetainformation
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function ReplaceMetaInformation ( 
	caexFile As CAEXFileType,
	oldWriterID As String,
	newMetainformation As MetaInformation
) As Boolean
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static bool ReplaceMetaInformation(
	CAEXFileType^ caexFile, 
	String^ oldWriterID, 
	MetaInformation^ newMetainformation
)
```


#### Parameters
&nbsp;<dl><dt>caexFile</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXFileType">Aml.Engine.CAEX.CAEXFileType</a><br />My CAEX file.</dd><dt>oldWriterID</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />writerID of the old meta information</dd><dt>newMetainformation</dt><dd>Type: <a href="T_Aml_Engine_AmlObjects_MetaInformation">Aml.Engine.AmlObjects.MetaInformation</a><br />substitute for the old version of meta information</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />true if succeeded, false if meta information about the oldWriterID is not found

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_CAEXFileType">CAEXFileType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td>caexFile</td></tr></table>

## Remarks
Extension Method originally designed for AutomationML Versions based on CAEX 2.15. If this method is applied to a CAEX 3.0 document, the information is transformed to a <a href="T_Aml_Engine_CAEX_SourceDocumentInformationType">SourceDocumentInformationType</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions">AmlObjectsExtensions Class</a><br /><a href="N_Aml_Engine_AmlObjects_Extensions">Aml.Engine.AmlObjects.Extensions Namespace</a><br />