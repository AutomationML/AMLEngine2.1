# InterfaceClassLibTypeExtensions.Insert_InterfaceClass Method 
AutomationML 2.1 API 

**Note: This API is now obsolete.**

Inserting an InterfaceClass element to the InterfaceClassLib object.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
[ObsoleteAttribute("use interfaceClassLib.Insert instead.")]
public static void Insert_InterfaceClass(
	this InterfaceClassLibType interfaceClassLib,
	InterfaceFamilyType interfaceFamilyType
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
<ObsoleteAttribute("use interfaceClassLib.Insert instead.")>
Public Shared Sub Insert_InterfaceClass ( 
	interfaceClassLib As InterfaceClassLibType,
	interfaceFamilyType As InterfaceFamilyType
)
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
[ObsoleteAttribute(L"use interfaceClassLib.Insert instead.")]
static void Insert_InterfaceClass(
	InterfaceClassLibType^ interfaceClassLib, 
	InterfaceFamilyType^ interfaceFamilyType
)
```


#### Parameters
&nbsp;<dl><dt>interfaceClassLib</dt><dd>Type: <a href="T_Aml_Engine_CAEX_InterfaceClassLibType">Aml.Engine.CAEX.InterfaceClassLibType</a><br />The InterfaceClassLib object</dd><dt>interfaceFamilyType</dt><dd>Type: <a href="T_Aml_Engine_CAEX_InterfaceFamilyType">Aml.Engine.CAEX.InterfaceFamilyType</a><br />The InterfaceClass object to insert</dd></dl>

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_InterfaceClassLibType">InterfaceClassLibType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_InterfaceClassLibTypeExtensions">InterfaceClassLibTypeExtensions Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />