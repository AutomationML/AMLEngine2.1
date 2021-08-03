# ValidationResults.UnresolvedPathRefs Method 
AutomationML 2.1 API 

Gets the validation results for all elements with CAEX path references which are not resolvable.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine.Services (in AML.Engine.Services.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static IEnumerable<ValidationElement> UnresolvedPathRefs(
	this IEnumerable<ValidationElement> validationResult
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function UnresolvedPathRefs ( 
	validationResult As IEnumerable(Of ValidationElement)
) As IEnumerable(Of ValidationElement)
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static IEnumerable<ValidationElement^>^ UnresolvedPathRefs(
	IEnumerable<ValidationElement^>^ validationResult
)
```


#### Parameters
&nbsp;<dl><dt>validationResult</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">System.Collections.Generic.IEnumerable</a>(<a href="T_Aml_Engine_Services_ValidationElement">ValidationElement</a>)<br />The validation result. Use the <a href="M_Aml_Engine_Services_ValidationResults_PathReferenceValidationResults">PathReferenceValidationResults(IEnumerable(ValidationElement))</a> as a parameter for this method.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_Services_ValidationElement">ValidationElement</a>)<br />All validation results, which are related to path references which are not resolvable.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_Services_ValidationElement">ValidationElement</a>). When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_Services_ValidationResults">ValidationResults Class</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />