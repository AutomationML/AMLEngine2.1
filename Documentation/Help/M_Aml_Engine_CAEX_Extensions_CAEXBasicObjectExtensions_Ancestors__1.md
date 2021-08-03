# CAEXBasicObjectExtensions.Ancestors(*T*) Method 
AutomationML 2.1 API 

Finds the ancestors of the provided CAEX object which have the given type.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static IEnumerable<T> Ancestors<T>(
	this ICAEXWrapper caexObject,
	bool includeSelf = false
)
where T : CAEXWrapper

```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function Ancestors(Of T As CAEXWrapper) ( 
	caexObject As ICAEXWrapper,
	Optional includeSelf As Boolean = false
) As IEnumerable(Of T)
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
generic<typename T>
where T : CAEXWrapper
static IEnumerable<T>^ Ancestors(
	ICAEXWrapper^ caexObject, 
	bool includeSelf = false
)
```


#### Parameters
&nbsp;<dl><dt>caexObject</dt><dd>Type: <a href="T_Aml_Engine_CAEX_ICAEXWrapper">Aml.Engine.CAEX.ICAEXWrapper</a><br />The CAEX object.</dd><dt>includeSelf (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />\[Missing <param name="includeSelf"/> documentation for "M:Aml.Engine.CAEX.Extensions.CAEXBasicObjectExtensions.Ancestors``1(Aml.Engine.CAEX.ICAEXWrapper,System.Boolean)"\]</dd></dl>

#### Type Parameters
&nbsp;<dl><dt>T</dt><dd>CAEX element type of the ancestors.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(*T*)<br />The ancestors of the CAEX object which are of the given type.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_ICAEXWrapper">ICAEXWrapper</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td>caexObject</td></tr></table>

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions">CAEXBasicObjectExtensions Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />