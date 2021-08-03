# AMLEngineAdapter.GetExternalInterfaces Method 
AutomationML 2.1 API 

**Note: This API is now obsolete.**

Gets the external interfaces.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Adapter">Aml.Engine.Adapter</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
[ObsoleteAttribute("Direct enumeration of the ExternalInterface property is supported", 
	false)]
public static IEnumerable<InterfaceClassType> GetExternalInterfaces(
	this IObjectWithExternalInterface systemUnitClass,
	string interfaceName
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
<ObsoleteAttribute("Direct enumeration of the ExternalInterface property is supported", 
	false)>
Public Shared Function GetExternalInterfaces ( 
	systemUnitClass As IObjectWithExternalInterface,
	interfaceName As String
) As IEnumerable(Of InterfaceClassType)
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
[ObsoleteAttribute(L"Direct enumeration of the ExternalInterface property is supported", 
	false)]
static IEnumerable<InterfaceClassType^>^ GetExternalInterfaces(
	IObjectWithExternalInterface^ systemUnitClass, 
	String^ interfaceName
)
```


#### Parameters
&nbsp;<dl><dt>systemUnitClass</dt><dd>Type: <a href="T_Aml_Engine_CAEX_IObjectWithExternalInterface">Aml.Engine.CAEX.IObjectWithExternalInterface</a><br />\[Missing <param name="systemUnitClass"/> documentation for "M:Aml.Engine.Adapter.AMLEngineAdapter.GetExternalInterfaces(Aml.Engine.CAEX.IObjectWithExternalInterface,System.String)"\]</dd><dt>interfaceName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />\[Missing <param name="interfaceName"/> documentation for "M:Aml.Engine.Adapter.AMLEngineAdapter.GetExternalInterfaces(Aml.Engine.CAEX.IObjectWithExternalInterface,System.String)"\]</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_CAEX_InterfaceClassType">InterfaceClassType</a>)<br />IEnumerable<InterfaceClassType>.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_IObjectWithExternalInterface">IObjectWithExternalInterface</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter Class</a><br /><a href="N_Aml_Engine_Adapter">Aml.Engine.Adapter Namespace</a><br />