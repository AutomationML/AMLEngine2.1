# QueryResult.ElementsWithInternalLinkRelations Method 
AutomationML 2.1 API 

Returns all InternalElements and SystemUnitClasses in the defined Document, which are related to others via InternalLinks.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static IEnumerable<SystemUnitClassType> ElementsWithInternalLinkRelations(
	this CAEXDocument doc
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function ElementsWithInternalLinkRelations ( 
	doc As CAEXDocument
) As IEnumerable(Of SystemUnitClassType)
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static IEnumerable<SystemUnitClassType^>^ ElementsWithInternalLinkRelations(
	CAEXDocument^ doc
)
```


#### Parameters
&nbsp;<dl><dt>doc</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">Aml.Engine.CAEX.CAEXDocument</a><br />the Document</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_CAEX_SystemUnitClassType">SystemUnitClassType</a>)<br />A collection of related SystemUnitClass objects

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_CAEXDocument">CAEXDocument</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_Services_QueryResult">QueryResult Class</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />