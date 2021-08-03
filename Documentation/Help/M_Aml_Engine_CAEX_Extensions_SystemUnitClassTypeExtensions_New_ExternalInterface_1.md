# SystemUnitClassTypeExtensions.New_ExternalInterface Method (IObjectWithExternalInterface, String, String, Boolean)
AutomationML 2.1 API 

Adding a new ExternalInterface instance to the ExternalInterface-Collection of the *objectWithExternalInterface* referencing a specific InterfaceClass. The New ExternalInterface is inserted as the first ExternalInterface of any existing Interfaces if nothing else is explicit defined. The provided *interfaceClassPath* is set as the RefBaseClassPath value.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static ExternalInterfaceType New_ExternalInterface(
	this IObjectWithExternalInterface objectWithExternalInterface,
	string name,
	string interfaceClassPath,
	bool asFirst = true
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function New_ExternalInterface ( 
	objectWithExternalInterface As IObjectWithExternalInterface,
	name As String,
	interfaceClassPath As String,
	Optional asFirst As Boolean = true
) As ExternalInterfaceType
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static ExternalInterfaceType^ New_ExternalInterface(
	IObjectWithExternalInterface^ objectWithExternalInterface, 
	String^ name, 
	String^ interfaceClassPath, 
	bool asFirst = true
)
```


#### Parameters
&nbsp;<dl><dt>objectWithExternalInterface</dt><dd>Type: <a href="T_Aml_Engine_CAEX_IObjectWithExternalInterface">Aml.Engine.CAEX.IObjectWithExternalInterface</a><br />Any object with an ExternalInterface collection.</dd><dt>name</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The name of the new ExternalInterface</dd><dt>interfaceClassPath</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The CAEX Path of the InterfaceClass which should be referenced.</dd><dt>asFirst (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />If set to true, the interface is insert at first, otherwise at last Interface.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_ExternalInterfaceType">ExternalInterfaceType</a><br />The new ExternalInterface

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_IObjectWithExternalInterface">IObjectWithExternalInterface</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_SystemUnitClassTypeExtensions">SystemUnitClassTypeExtensions Class</a><br /><a href="Overload_Aml_Engine_CAEX_Extensions_SystemUnitClassTypeExtensions_New_ExternalInterface">New_ExternalInterface Overload</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />