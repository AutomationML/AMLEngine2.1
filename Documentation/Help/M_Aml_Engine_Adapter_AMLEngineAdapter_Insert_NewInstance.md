# AMLEngineAdapter.Insert_NewInstance Method 
AutomationML 2.1 API 

**Note: This API is now obsolete.**

Inserting a new class instance to this object. This method can be overridden in derived classes. The Instance is inserted as the first instance of any other element with the same type if nothing else is explicit defined.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Adapter">Aml.Engine.Adapter</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
[ObsoleteAttribute("Use Insert Method instead", false)]
public static bool Insert_NewInstance(
	this CAEXBasicObject caexObject,
	CAEXWrapper newInstanceObject,
	bool asFirst = true
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
<ObsoleteAttribute("Use Insert Method instead", false)>
Public Shared Function Insert_NewInstance ( 
	caexObject As CAEXBasicObject,
	newInstanceObject As CAEXWrapper,
	Optional asFirst As Boolean = true
) As Boolean
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
[ObsoleteAttribute(L"Use Insert Method instead", false)]
static bool Insert_NewInstance(
	CAEXBasicObject^ caexObject, 
	CAEXWrapper^ newInstanceObject, 
	bool asFirst = true
)
```


#### Parameters
&nbsp;<dl><dt>caexObject</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXBasicObject">Aml.Engine.CAEX.CAEXBasicObject</a><br />The CAEX object.</dd><dt>newInstanceObject</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXWrapper">Aml.Engine.CAEX.CAEXWrapper</a><br />The instance of a class to be inserted at this object. The instance can be of type</dd><dt>asFirst (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />if `true`, inserted as first (default), otherwise at last</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />True if insertion was successful, else false.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_CAEXBasicObject">CAEXBasicObject</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter Class</a><br /><a href="N_Aml_Engine_Adapter">Aml.Engine.Adapter Namespace</a><br />