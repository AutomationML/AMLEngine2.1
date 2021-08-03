# ObjectWithExternalInterface.HasInterfaceClassReference Method (IObjectWithExternalInterface, String, Boolean)
AutomationML 2.1 API 

Determines whether this Object with ExternalInterfaces has an associated InterfaceClass reference with the specified CAEX path interface reference. If inheritance relations between interface classes should be regarded, the optional parameter 'regardInheritance' should be set. In this case the specified InterfaceClass is either identical to a referenced InterfaceClass or a referenced InterfaceClass is derived from the specified InterfaceClass.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static bool HasInterfaceClassReference(
	this IObjectWithExternalInterface objectWithExternalInterface,
	string interfaceReference,
	bool regardInheritance = false
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function HasInterfaceClassReference ( 
	objectWithExternalInterface As IObjectWithExternalInterface,
	interfaceReference As String,
	Optional regardInheritance As Boolean = false
) As Boolean
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static bool HasInterfaceClassReference(
	IObjectWithExternalInterface^ objectWithExternalInterface, 
	String^ interfaceReference, 
	bool regardInheritance = false
)
```


#### Parameters
&nbsp;<dl><dt>objectWithExternalInterface</dt><dd>Type: <a href="T_Aml_Engine_CAEX_IObjectWithExternalInterface">Aml.Engine.CAEX.IObjectWithExternalInterface</a><br /></dd><dt>interfaceReference</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The interface reference.</dd><dt>regardInheritance (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />if set to `true` inheritance relations are regarded (default is `false`).</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true` if this object has an associated InterfaceClass reference with the specified CAEX path interface reference; otherwise, `false`.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_IObjectWithExternalInterface">IObjectWithExternalInterface</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td>interfaceReference</td></tr></table>

## Examples
This sample shows how to call the HasInterfaceClassReference(IObjectWithExternalInterface, String, Boolean) method using a standard base InterfaceClass path from the <a href="T_Aml_Engine_AmlObjects_AutomationMLInterfaceClassLib">AutomationMLInterfaceClassLib</a>
```
InternalElementType internalElement;
...
internalElement.HasInterfaceClassReference (AutomationMLInterfaceClassLib.COLLADA);
```


## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_ObjectWithExternalInterface">ObjectWithExternalInterface Class</a><br /><a href="Overload_Aml_Engine_CAEX_Extensions_ObjectWithExternalInterface_HasInterfaceClassReference">HasInterfaceClassReference Overload</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />