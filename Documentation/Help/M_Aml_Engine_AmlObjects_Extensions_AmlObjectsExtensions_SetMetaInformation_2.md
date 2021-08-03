# AmlObjectsExtensions.SetMetaInformation Method (SourceDocumentInformationType, MetaInformation)
AutomationML 2.1 API 

Sets the properties for the specified SourceDocumentInformation object using the provided MetaInformation

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects_Extensions">Aml.Engine.AmlObjects.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static void SetMetaInformation(
	this SourceDocumentInformationType sourceDocumentInformation,
	MetaInformation metaInformation
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Sub SetMetaInformation ( 
	sourceDocumentInformation As SourceDocumentInformationType,
	metaInformation As MetaInformation
)
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static void SetMetaInformation(
	SourceDocumentInformationType^ sourceDocumentInformation, 
	MetaInformation^ metaInformation
)
```


#### Parameters
&nbsp;<dl><dt>sourceDocumentInformation</dt><dd>Type: <a href="T_Aml_Engine_CAEX_SourceDocumentInformationType">Aml.Engine.CAEX.SourceDocumentInformationType</a><br />The source document information.</dd><dt>metaInformation</dt><dd>Type: <a href="T_Aml_Engine_AmlObjects_MetaInformation">Aml.Engine.AmlObjects.MetaInformation</a><br />The meta information.</dd></dl>

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_SourceDocumentInformationType">SourceDocumentInformationType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td>sourceDocumentInformation or metaInformation</td></tr></table>

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions">AmlObjectsExtensions Class</a><br /><a href="Overload_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions_SetMetaInformation">SetMetaInformation Overload</a><br /><a href="N_Aml_Engine_AmlObjects_Extensions">Aml.Engine.AmlObjects.Extensions Namespace</a><br />