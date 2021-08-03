# InterfaceClassLibTypeExtensions.New_InterfaceClass Method 
AutomationML 2.1 API 

A new InterfaceClass is added to the specified InterfaceClassLib object.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static InterfaceClassType New_InterfaceClass(
	this InterfaceClassLibType interfaceClassLib,
	string name
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function New_InterfaceClass ( 
	interfaceClassLib As InterfaceClassLibType,
	name As String
) As InterfaceClassType
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static InterfaceClassType^ New_InterfaceClass(
	InterfaceClassLibType^ interfaceClassLib, 
	String^ name
)
```


#### Parameters
&nbsp;<dl><dt>interfaceClassLib</dt><dd>Type: <a href="T_Aml_Engine_CAEX_InterfaceClassLibType">Aml.Engine.CAEX.InterfaceClassLibType</a><br />The InterfaceClassLib object</dd><dt>name</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The name of the InterfaceClass to add</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_InterfaceClassType">InterfaceClassType</a><br />The new InterfaceClass element

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_InterfaceClassLibType">InterfaceClassLibType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_InterfaceClassLibTypeExtensions">InterfaceClassLibTypeExtensions Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />