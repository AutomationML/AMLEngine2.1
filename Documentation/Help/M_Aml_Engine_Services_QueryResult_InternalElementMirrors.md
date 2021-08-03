# QueryResult.InternalElementMirrors Method 
AutomationML 2.1 API 

Returns all Mirrors of the specified InternalElement.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static IEnumerable<InternalElementType> InternalElementMirrors(
	this InternalElementType master
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function InternalElementMirrors ( 
	master As InternalElementType
) As IEnumerable(Of InternalElementType)
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static IEnumerable<InternalElementType^>^ InternalElementMirrors(
	InternalElementType^ master
)
```


#### Parameters
&nbsp;<dl><dt>master</dt><dd>Type: <a href="T_Aml_Engine_CAEX_InternalElementType">Aml.Engine.CAEX.InternalElementType</a><br />The master.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_CAEX_InternalElementType">InternalElementType</a>)<br />An enumeration of mirror InternalElements.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_InternalElementType">InternalElementType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_Services_QueryResult">QueryResult Class</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />