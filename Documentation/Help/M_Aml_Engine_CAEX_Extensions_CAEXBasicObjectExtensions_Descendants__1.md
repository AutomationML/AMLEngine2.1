# CAEXBasicObjectExtensions.Descendants(*T*) Method (CAEXWrapper)
AutomationML 2.1 API 

Finds the descendants of the provided CAEX object which are of the given type.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static IEnumerable<T> Descendants<T>(
	this CAEXWrapper caexObject
)
where T : CAEXWrapper

```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function Descendants(Of T As CAEXWrapper) ( 
	caexObject As CAEXWrapper
) As IEnumerable(Of T)
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
generic<typename T>
where T : CAEXWrapper
static IEnumerable<T>^ Descendants(
	CAEXWrapper^ caexObject
)
```


#### Parameters
&nbsp;<dl><dt>caexObject</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXWrapper">Aml.Engine.CAEX.CAEXWrapper</a><br />The CAEX object.</dd></dl>

#### Type Parameters
&nbsp;<dl><dt>T</dt><dd>CAEX element type of the descendants.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(*T*)<br />The descendants of the CAEX object which are of the given type.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td>caexObject</td></tr></table>

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions">CAEXBasicObjectExtensions Class</a><br /><a href="Overload_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions_Descendants">Descendants Overload</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />