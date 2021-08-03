# ObjectWithBaseClass.GetDerivedInterfaces Method 
AutomationML 2.1 API 

Gets a list of ExternalInterface objects that are inherited from base classes. The List will also contain the elements own ExternalInterface objects, if the parameter is set (default). If an ExternalInterface is overwritten, only the last defined is contained.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static List<ExternalInterfaceType> GetDerivedInterfaces(
	this IClassWithExternalInterface classWithBaseClass,
	bool includeOwn = true
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function GetDerivedInterfaces ( 
	classWithBaseClass As IClassWithExternalInterface,
	Optional includeOwn As Boolean = true
) As List(Of ExternalInterfaceType)
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static List<ExternalInterfaceType^>^ GetDerivedInterfaces(
	IClassWithExternalInterface^ classWithBaseClass, 
	bool includeOwn = true
)
```


#### Parameters
&nbsp;<dl><dt>classWithBaseClass</dt><dd>Type: <a href="T_Aml_Engine_CAEX_IClassWithExternalInterface">Aml.Engine.CAEX.IClassWithExternalInterface</a><br />The class with a possible base class reference for inheritance.</dd><dt>includeOwn (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />if set to `true` includes the elements own ExternalInterface objects; otherwise not</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.list-1" target="_parent" rel="noopener noreferrer">List</a>(<a href="T_Aml_Engine_CAEX_ExternalInterfaceType">ExternalInterfaceType</a>)<br />A list of ExternalInterface objects

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_IClassWithExternalInterface">IClassWithExternalInterface</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_ObjectWithBaseClass">ObjectWithBaseClass Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />