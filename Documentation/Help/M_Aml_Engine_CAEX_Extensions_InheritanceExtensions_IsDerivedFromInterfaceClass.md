# InheritanceExtensions.IsDerivedFromInterfaceClass Method 
AutomationML 2.1 API 

Determines whether the specified interface class has an inheritance relation from the interface class, uniquely identifiable by the given interface class path. The interface class path may contain an alias.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static bool IsDerivedFromInterfaceClass(
	this InterfaceClassType interfaceClass,
	string interfaceClassPath
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function IsDerivedFromInterfaceClass ( 
	interfaceClass As InterfaceClassType,
	interfaceClassPath As String
) As Boolean
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static bool IsDerivedFromInterfaceClass(
	InterfaceClassType^ interfaceClass, 
	String^ interfaceClassPath
)
```


#### Parameters
&nbsp;<dl><dt>interfaceClass</dt><dd>Type: <a href="T_Aml_Engine_CAEX_InterfaceClassType">Aml.Engine.CAEX.InterfaceClassType</a><br />The interface class.</dd><dt>interfaceClassPath</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />Class path of a base interface class which is tested for a inheritance relation to the specified interface class, which is the more specific class in this relation.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true` if an inheritance relation is resolved; otherwise, `false`.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_InterfaceClassType">InterfaceClassType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_InheritanceExtensions">InheritanceExtensions Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />