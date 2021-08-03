# AMLEngineAdapter.findInternalElement Method 
AutomationML 2.1 API 

**Note: This API is now obsolete.**

Resolve a reference to an InternalElement and return the referenced element if found.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Adapter">Aml.Engine.Adapter</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
[ObsoleteAttribute("Use FindCaexObjectFromId<InternalElementType> instead.")]
public static InternalElementType findInternalElement(
	this CAEXBasicObject caexObject,
	string referenceGUID
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
<ObsoleteAttribute("Use FindCaexObjectFromId<InternalElementType> instead.")>
Public Shared Function findInternalElement ( 
	caexObject As CAEXBasicObject,
	referenceGUID As String
) As InternalElementType
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
[ObsoleteAttribute(L"Use FindCaexObjectFromId<InternalElementType> instead.")]
static InternalElementType^ findInternalElement(
	CAEXBasicObject^ caexObject, 
	String^ referenceGUID
)
```


#### Parameters
&nbsp;<dl><dt>caexObject</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXBasicObject">Aml.Engine.CAEX.CAEXBasicObject</a><br />The CAEX object.</dd><dt>referenceGUID</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The GUID of the InternalElement</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_InternalElementType">InternalElementType</a><br />The InternalElement with the specified GUID

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_CAEXBasicObject">CAEXBasicObject</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter Class</a><br /><a href="N_Aml_Engine_Adapter">Aml.Engine.Adapter Namespace</a><br />