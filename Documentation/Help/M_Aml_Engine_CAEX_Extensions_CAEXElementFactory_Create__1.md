# CAEXElementFactory.Create(*T*) Method (CAEXDocument)
AutomationML 2.1 API 

Factory method to create a new CAEX object in the provided CAEX document. The CAEX element is derived from the specified CAEX object Type. To insert the new CAEX object into the document an appropriate insertion method has to be used.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static T Create<T>(
	this CAEXDocument document
)
where T : CAEXWrapper

```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function Create(Of T As CAEXWrapper) ( 
	document As CAEXDocument
) As T
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
generic<typename T>
where T : CAEXWrapper
static T Create(
	CAEXDocument^ document
)
```


#### Parameters
&nbsp;<dl><dt>document</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">Aml.Engine.CAEX.CAEXDocument</a><br />The CAEX document.</dd></dl>

#### Type Parameters
&nbsp;<dl><dt>T</dt><dd>The CAEX object Type.</dd></dl>

#### Return Value
Type: *T*<br />The created CAEX object.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_CAEXDocument">CAEXDocument</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.notsupportedexception" target="_parent" rel="noopener noreferrer">NotSupportedException</a></td><td /></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td>document</td></tr></table>

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_CAEXElementFactory">CAEXElementFactory Class</a><br /><a href="Overload_Aml_Engine_CAEX_Extensions_CAEXElementFactory_Create">Create Overload</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />