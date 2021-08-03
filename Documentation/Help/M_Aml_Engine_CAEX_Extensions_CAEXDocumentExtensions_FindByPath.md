# CAEXDocumentExtensions.FindByPath Method 
AutomationML 2.1 API 

Tries to locates a CAEX object from the specified CAEX path. If the path uses an alias reference and an <a href="T_Aml_Engine_Services_Interfaces_IExternalReferenceResolver">IExternalReferenceResolver</a> can be located, it is tried to resolve the external reference and to get the object from the external source.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static CAEXObject FindByPath(
	this CAEXDocument document,
	string caexPath,
	bool resolveAlias = false
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function FindByPath ( 
	document As CAEXDocument,
	caexPath As String,
	Optional resolveAlias As Boolean = false
) As CAEXObject
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static CAEXObject^ FindByPath(
	CAEXDocument^ document, 
	String^ caexPath, 
	bool resolveAlias = false
)
```


#### Parameters
&nbsp;<dl><dt>document</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">Aml.Engine.CAEX.CAEXDocument</a><br />The document.</dd><dt>caexPath</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The CAEX path.</dd><dt>resolveAlias (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />if set to `true` tries to resolve an alias reference with an ExternalReferenceResolver service.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_CAEXObject">CAEXObject</a><br />The CAEXObject if it is found; otherwise `null`.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_CAEXDocument">CAEXDocument</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_CAEXDocumentExtensions">CAEXDocumentExtensions Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />