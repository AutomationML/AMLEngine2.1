# ExternalInterfaceTypeExtensions.OfInterfaceClass Method 
AutomationML 2.1 API 

Gets all ExternalInterface objects from the specified *objectWithExternalInterface*, which are derived from an InterfaceClass, identified with the given *interfaceClassPath*.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static IEnumerable<ExternalInterfaceType> OfInterfaceClass(
	this IObjectWithExternalInterface objectWithExternalInterface,
	string interfaceClassPath
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function OfInterfaceClass ( 
	objectWithExternalInterface As IObjectWithExternalInterface,
	interfaceClassPath As String
) As IEnumerable(Of ExternalInterfaceType)
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static IEnumerable<ExternalInterfaceType^>^ OfInterfaceClass(
	IObjectWithExternalInterface^ objectWithExternalInterface, 
	String^ interfaceClassPath
)
```


#### Parameters
&nbsp;<dl><dt>objectWithExternalInterface</dt><dd>Type: <a href="T_Aml_Engine_CAEX_IObjectWithExternalInterface">Aml.Engine.CAEX.IObjectWithExternalInterface</a><br />The object with external interface.</dd><dt>interfaceClassPath</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The interface class path.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_CAEX_ExternalInterfaceType">ExternalInterfaceType</a>)<br />An enumeration of selected ExternalInterfaces of the given object.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_IObjectWithExternalInterface">IObjectWithExternalInterface</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_ExternalInterfaceTypeExtensions">ExternalInterfaceTypeExtensions Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />