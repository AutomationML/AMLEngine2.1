# InterfaceFamilyTypeExtensions.CreateInterfaceFamilyClass Method 
AutomationML 2.1 API 

Create an InterfaceClass from this interface (e.g. ExternalInterface). An InterfaceClass is of type InterfaceFamilyType and may contain InterfaceFamilyTypes as child elements.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static InterfaceFamilyType CreateInterfaceFamilyClass(
	this InterfaceClassType interfaceClass
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function CreateInterfaceFamilyClass ( 
	interfaceClass As InterfaceClassType
) As InterfaceFamilyType
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static InterfaceFamilyType^ CreateInterfaceFamilyClass(
	InterfaceClassType^ interfaceClass
)
```


#### Parameters
&nbsp;<dl><dt>interfaceClass</dt><dd>Type: <a href="T_Aml_Engine_CAEX_InterfaceClassType">Aml.Engine.CAEX.InterfaceClassType</a><br />\[Missing <param name="interfaceClass"/> documentation for "M:Aml.Engine.CAEX.Extensions.InterfaceFamilyTypeExtensions.CreateInterfaceFamilyClass(Aml.Engine.CAEX.InterfaceClassType)"\]</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_InterfaceFamilyType">InterfaceFamilyType</a><br />InterfaceFamilyType.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_InterfaceClassType">InterfaceClassType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_InterfaceFamilyTypeExtensions">InterfaceFamilyTypeExtensions Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />