# QueryResult.ElementsWithAliasReference Method 
AutomationML 2.1 API 

Gets alls the elements from the document which use the provided Alias in a reference

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static IEnumerable<ICAEXReference> ElementsWithAliasReference(
	this CAEXDocument doc,
	string alias
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function ElementsWithAliasReference ( 
	doc As CAEXDocument,
	alias As String
) As IEnumerable(Of ICAEXReference)
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static IEnumerable<ICAEXReference^>^ ElementsWithAliasReference(
	CAEXDocument^ doc, 
	String^ alias
)
```


#### Parameters
&nbsp;<dl><dt>doc</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">Aml.Engine.CAEX.CAEXDocument</a><br />The document.</dd><dt>alias</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The Alias.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_Services_Interfaces_ICAEXReference">ICAEXReference</a>)<br />A collection of elements which use the provided Alias in a reference

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_CAEXDocument">CAEXDocument</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_Services_QueryResult">QueryResult Class</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />