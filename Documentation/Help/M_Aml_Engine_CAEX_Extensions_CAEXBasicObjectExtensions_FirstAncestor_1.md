# CAEXBasicObjectExtensions.FirstAncestor Method (ICAEXWrapper, String)
AutomationML 2.1 API 

Finds the first ancestor of the specified CAEX object with the given Tag name

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static CAEXWrapper FirstAncestor(
	this ICAEXWrapper caexObject,
	string tagName
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function FirstAncestor ( 
	caexObject As ICAEXWrapper,
	tagName As String
) As CAEXWrapper
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static CAEXWrapper^ FirstAncestor(
	ICAEXWrapper^ caexObject, 
	String^ tagName
)
```


#### Parameters
&nbsp;<dl><dt>caexObject</dt><dd>Type: <a href="T_Aml_Engine_CAEX_ICAEXWrapper">Aml.Engine.CAEX.ICAEXWrapper</a><br />The CAEX object.</dd><dt>tagName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />Name of the tag.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a><br />First ancestor of the specified CAEX object or `null`, if no ancestor with this Tag name exists.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_ICAEXWrapper">ICAEXWrapper</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td>caexObject</td></tr></table>

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions">CAEXBasicObjectExtensions Class</a><br /><a href="Overload_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions_FirstAncestor">FirstAncestor Overload</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />