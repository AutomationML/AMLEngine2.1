# AutomationMLInterfaceClassLib.IsPortConnector Method 
AutomationML 2.1 API 

Determines whether the specified interface class is derived from the PortConnector interface class. The method can resolve alias references anywhere in the inheritance hierarchy.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static bool IsPortConnector(
	this InterfaceClassType interfaceClass
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function IsPortConnector ( 
	interfaceClass As InterfaceClassType
) As Boolean
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static bool IsPortConnector(
	InterfaceClassType^ interfaceClass
)
```


#### Parameters
&nbsp;<dl><dt>interfaceClass</dt><dd>Type: <a href="T_Aml_Engine_CAEX_InterfaceClassType">Aml.Engine.CAEX.InterfaceClassType</a><br />The interface class.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true` if an inheritance relation could be resolved; otherwise, `false`.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_InterfaceClassType">InterfaceClassType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_AutomationMLInterfaceClassLib">AutomationMLInterfaceClassLib Class</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />