# AMLEngineAdapter.Insert_TypeBaseElement Method 
AutomationML 2.1 API 

**Note: This API is now obsolete.**

<a href="M_Aml_Engine_CAEX_CAEXBasicObject_Insert">Insert(CAEXWrapper, Boolean)</a>

**Namespace:**&nbsp;<a href="N_Aml_Engine_Adapter">Aml.Engine.Adapter</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
[ObsoleteAttribute("Use Insert")]
public static bool Insert_TypeBaseElement(
	this CAEXBasicObject caexObject,
	CAEXWrapper elementToInsert,
	bool asFirst = true
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
<ObsoleteAttribute("Use Insert")>
Public Shared Function Insert_TypeBaseElement ( 
	caexObject As CAEXBasicObject,
	elementToInsert As CAEXWrapper,
	Optional asFirst As Boolean = true
) As Boolean
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
[ObsoleteAttribute(L"Use Insert")]
static bool Insert_TypeBaseElement(
	CAEXBasicObject^ caexObject, 
	CAEXWrapper^ elementToInsert, 
	bool asFirst = true
)
```


#### Parameters
&nbsp;<dl><dt>caexObject</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXBasicObject">Aml.Engine.CAEX.CAEXBasicObject</a><br />The CAEX object.</dd><dt>elementToInsert</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXWrapper">Aml.Engine.CAEX.CAEXWrapper</a><br />an object to be inserted</dd><dt>asFirst (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />if `true`, the element is inserted as the first of it's type, otherwise as the last.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true` if successfully inserted, `false` otherwise.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_CAEXBasicObject">CAEXBasicObject</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter Class</a><br /><a href="N_Aml_Engine_Adapter">Aml.Engine.Adapter Namespace</a><br />