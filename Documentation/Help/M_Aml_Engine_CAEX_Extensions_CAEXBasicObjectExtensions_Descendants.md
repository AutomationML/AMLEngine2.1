# CAEXBasicObjectExtensions.Descendants Method (CAEXWrapper, Type)
AutomationML 2.1 API 

Finds the descendants of the provided CAEX object which are of the given type.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static IEnumerable<CAEXBasicObject> Descendants(
	this CAEXWrapper caexObject,
	Type caexType
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function Descendants ( 
	caexObject As CAEXWrapper,
	caexType As Type
) As IEnumerable(Of CAEXBasicObject)
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static IEnumerable<CAEXBasicObject^>^ Descendants(
	CAEXWrapper^ caexObject, 
	Type^ caexType
)
```


#### Parameters
&nbsp;<dl><dt>caexObject</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXWrapper">Aml.Engine.CAEX.CAEXWrapper</a><br />The CAEX object.</dd><dt>caexType</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.type" target="_parent" rel="noopener noreferrer">System.Type</a><br />CAEX element type of the descendants.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_CAEX_CAEXBasicObject">CAEXBasicObject</a>)<br />The descendants of the CAEX object which are of the given type.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td>caexObject</td></tr></table>

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions">CAEXBasicObjectExtensions Class</a><br /><a href="Overload_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions_Descendants">Descendants Overload</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />