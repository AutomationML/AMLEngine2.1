# SystemUnitClassTypeExtensions.Insert_InternalElement Method 
AutomationML 2.1 API 

**Note: This API is now obsolete.**

Inserting an InternalElement to the InternalElement-Collection of the *objectWithInternalElements*.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
[ObsoleteAttribute("Use systemUnitClass.InternalElement.Insert() or systemUnitClass.Insert() instead")]
public static void Insert_InternalElement(
	this IInternalElementContainer objectWithInternalElements,
	InternalElementType internalElement,
	bool asFirst = true
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
<ObsoleteAttribute("Use systemUnitClass.InternalElement.Insert() or systemUnitClass.Insert() instead")>
Public Shared Sub Insert_InternalElement ( 
	objectWithInternalElements As IInternalElementContainer,
	internalElement As InternalElementType,
	Optional asFirst As Boolean = true
)
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
[ObsoleteAttribute(L"Use systemUnitClass.InternalElement.Insert() or systemUnitClass.Insert() instead")]
static void Insert_InternalElement(
	IInternalElementContainer^ objectWithInternalElements, 
	InternalElementType^ internalElement, 
	bool asFirst = true
)
```


#### Parameters
&nbsp;<dl><dt>objectWithInternalElements</dt><dd>Type: <a href="T_Aml_Engine_CAEX_IInternalElementContainer">Aml.Engine.CAEX.IInternalElementContainer</a><br />Any object with an InternalElement collection.</dd><dt>internalElement</dt><dd>Type: <a href="T_Aml_Engine_CAEX_InternalElementType">Aml.Engine.CAEX.InternalElementType</a><br />The InternalElement to insert.</dd><dt>asFirst (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />Insert as first if set to true (default), otherwise append as last</dd></dl>

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_IInternalElementContainer">IInternalElementContainer</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## Remarks


## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_SystemUnitClassTypeExtensions">SystemUnitClassTypeExtensions Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br /><a href="M_Aml_Engine_CAEX_CAEXSequence_1_Insert">CAEXSequence(T).Insert(T, Boolean)</a><br />