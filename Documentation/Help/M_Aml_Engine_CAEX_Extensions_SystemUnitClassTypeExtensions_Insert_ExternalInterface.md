# SystemUnitClassTypeExtensions.Insert_ExternalInterface Method 
AutomationML 2.1 API 

**Note: This API is now obsolete.**

Inserting an ExternalInterface to the ExternalInterface-Collection of the *objectWithExternalInterface*. The Element is inserted at the first Element of any existing ExternalInterfaces if no other position is defined.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
[ObsoleteAttribute("Use ExternalInterface.Insert")]
public static void Insert_ExternalInterface(
	this IObjectWithExternalInterface objectWithExternalInterface,
	ExternalInterfaceType interfaceElement,
	bool asFirst = true
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
<ObsoleteAttribute("Use ExternalInterface.Insert")>
Public Shared Sub Insert_ExternalInterface ( 
	objectWithExternalInterface As IObjectWithExternalInterface,
	interfaceElement As ExternalInterfaceType,
	Optional asFirst As Boolean = true
)
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
[ObsoleteAttribute(L"Use ExternalInterface.Insert")]
static void Insert_ExternalInterface(
	IObjectWithExternalInterface^ objectWithExternalInterface, 
	ExternalInterfaceType^ interfaceElement, 
	bool asFirst = true
)
```


#### Parameters
&nbsp;<dl><dt>objectWithExternalInterface</dt><dd>Type: <a href="T_Aml_Engine_CAEX_IObjectWithExternalInterface">Aml.Engine.CAEX.IObjectWithExternalInterface</a><br />Any object with an ExternalInterface collection.</dd><dt>interfaceElement</dt><dd>Type: <a href="T_Aml_Engine_CAEX_ExternalInterfaceType">Aml.Engine.CAEX.ExternalInterfaceType</a><br />The ExternalInterface object.</dd><dt>asFirst (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />Explicit definition of the position asFirst (true) or asLast (false)</dd></dl>

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_IObjectWithExternalInterface">IObjectWithExternalInterface</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_SystemUnitClassTypeExtensions">SystemUnitClassTypeExtensions Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />