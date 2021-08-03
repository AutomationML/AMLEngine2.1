# AMLEngineAdapter.getReferencedInterfaceClass Method 
AutomationML 2.1 API 

**Note: This API is now obsolete.**

Getting a referenced InterfaceClass. Use FindFastByPath for speed optimizations.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Adapter">Aml.Engine.Adapter</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
[ObsoleteAttribute("Use the generic method FindReferencedClass<T> instead.")]
public static InterfaceFamilyType getReferencedInterfaceClass(
	this CAEXBasicObject caexObject,
	string interfaceClassReference
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
<ObsoleteAttribute("Use the generic method FindReferencedClass<T> instead.")>
Public Shared Function getReferencedInterfaceClass ( 
	caexObject As CAEXBasicObject,
	interfaceClassReference As String
) As InterfaceFamilyType
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
[ObsoleteAttribute(L"Use the generic method FindReferencedClass<T> instead.")]
static InterfaceFamilyType^ getReferencedInterfaceClass(
	CAEXBasicObject^ caexObject, 
	String^ interfaceClassReference
)
```


#### Parameters
&nbsp;<dl><dt>caexObject</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXBasicObject">Aml.Engine.CAEX.CAEXBasicObject</a><br />The CAEX object.</dd><dt>interfaceClassReference</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />Full path to an InterfaceClass</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_InterfaceFamilyType">InterfaceFamilyType</a><br />The referenced InterfaceClass.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_CAEXBasicObject">CAEXBasicObject</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter Class</a><br /><a href="N_Aml_Engine_Adapter">Aml.Engine.Adapter Namespace</a><br />