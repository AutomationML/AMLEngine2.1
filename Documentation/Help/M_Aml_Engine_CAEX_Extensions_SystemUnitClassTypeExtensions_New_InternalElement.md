# SystemUnitClassTypeExtensions.New_InternalElement Method 
AutomationML 2.1 API 

Adding a new InternalElement instance to the InternalElement-Collection of the *elementWithInternalElements*. The New InternalElement is inserted as the first InternalElement of any existing InternalElement objects if nothing else is explicit defined.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static InternalElementType New_InternalElement(
	this IInternalElementContainer elementWithInternalElements,
	string elementName,
	bool asFirst = true
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function New_InternalElement ( 
	elementWithInternalElements As IInternalElementContainer,
	elementName As String,
	Optional asFirst As Boolean = true
) As InternalElementType
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static InternalElementType^ New_InternalElement(
	IInternalElementContainer^ elementWithInternalElements, 
	String^ elementName, 
	bool asFirst = true
)
```


#### Parameters
&nbsp;<dl><dt>elementWithInternalElements</dt><dd>Type: <a href="T_Aml_Engine_CAEX_IInternalElementContainer">Aml.Engine.CAEX.IInternalElementContainer</a><br />Any object with an InternalElement collection.</dd><dt>elementName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />Name of the InternalElement</dd><dt>asFirst (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />If set to true, the InternalElement is insert at first, otherwise at last.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_InternalElementType">InternalElementType</a><br />The new InternalElement

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_IInternalElementContainer">IInternalElementContainer</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_SystemUnitClassTypeExtensions">SystemUnitClassTypeExtensions Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />