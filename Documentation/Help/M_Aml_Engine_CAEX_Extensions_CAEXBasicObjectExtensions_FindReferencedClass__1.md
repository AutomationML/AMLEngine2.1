# CAEXBasicObjectExtensions.FindReferencedClass(*T*) Method 
AutomationML 2.1 API 

Finds the CAEX object with the specified CAEX path and the specified Type.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static T FindReferencedClass<T>(
	this ICAEXWrapper caexObject,
	string caexPath
)
where T : CAEXBasicObject

```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function FindReferencedClass(Of T As CAEXBasicObject) ( 
	caexObject As ICAEXWrapper,
	caexPath As String
) As T
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
generic<typename T>
where T : CAEXBasicObject
static T FindReferencedClass(
	ICAEXWrapper^ caexObject, 
	String^ caexPath
)
```


#### Parameters
&nbsp;<dl><dt>caexObject</dt><dd>Type: <a href="T_Aml_Engine_CAEX_ICAEXWrapper">Aml.Engine.CAEX.ICAEXWrapper</a><br />CAEX object, used to identify the document for the search.</dd><dt>caexPath</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The CAEX path of the searched CAEX object.</dd></dl>

#### Type Parameters
&nbsp;<dl><dt>T</dt><dd>CAEX element type of the searched CAEX object.</dd></dl>

#### Return Value
Type: *T*<br />CAEX object with the given path or `null`, if not found.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_ICAEXWrapper">ICAEXWrapper</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td>caexObject</td></tr></table>

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions">CAEXBasicObjectExtensions Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />