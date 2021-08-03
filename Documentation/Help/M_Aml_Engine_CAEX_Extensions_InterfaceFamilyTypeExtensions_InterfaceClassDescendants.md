# InterfaceFamilyTypeExtensions.InterfaceClassDescendants Method 
AutomationML 2.1 API 

**Note: This API is now obsolete.**

Gets all descendant <a href="T_Aml_Engine_CAEX_InterfaceFamilyType">InterfaceFamilyType</a> Objects of the InterfaceClass. InterfaceClasses on all levels are returned.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
[ObsoleteAttribute("Use interfaceClass.Descendants<InterfaceFamilyType> instead.")]
public static IEnumerable<InterfaceFamilyType> InterfaceClassDescendants(
	this InterfaceFamilyType interfaceClass
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
<ObsoleteAttribute("Use interfaceClass.Descendants<InterfaceFamilyType> instead.")>
Public Shared Function InterfaceClassDescendants ( 
	interfaceClass As InterfaceFamilyType
) As IEnumerable(Of InterfaceFamilyType)
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
[ObsoleteAttribute(L"Use interfaceClass.Descendants<InterfaceFamilyType> instead.")]
static IEnumerable<InterfaceFamilyType^>^ InterfaceClassDescendants(
	InterfaceFamilyType^ interfaceClass
)
```


#### Parameters
&nbsp;<dl><dt>interfaceClass</dt><dd>Type: <a href="T_Aml_Engine_CAEX_InterfaceFamilyType">Aml.Engine.CAEX.InterfaceFamilyType</a><br />The InterfaceClass object</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_CAEX_InterfaceFamilyType">InterfaceFamilyType</a>)<br />IEnumerable<InterfaceFamilyType>.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_InterfaceFamilyType">InterfaceFamilyType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_InterfaceFamilyTypeExtensions">InterfaceFamilyTypeExtensions Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />