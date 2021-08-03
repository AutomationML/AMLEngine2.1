# AMLEngineAdapter.findExternalInterface Method 
AutomationML 2.1 API 

**Note: This API is now obsolete.**

Searches for an ExternalInterface in this InternalElement

**Namespace:**&nbsp;<a href="N_Aml_Engine_Adapter">Aml.Engine.Adapter</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
[ObsoleteAttribute("Use the Indexer of the ExternalInterface sequence ExternalInterface[interfaceName]", 
	false)]
public static ExternalInterfaceType findExternalInterface(
	this IObjectWithExternalInterface systemUnitClass,
	string interfaceName
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
<ObsoleteAttribute("Use the Indexer of the ExternalInterface sequence ExternalInterface[interfaceName]", 
	false)>
Public Shared Function findExternalInterface ( 
	systemUnitClass As IObjectWithExternalInterface,
	interfaceName As String
) As ExternalInterfaceType
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
[ObsoleteAttribute(L"Use the Indexer of the ExternalInterface sequence ExternalInterface[interfaceName]", 
	false)]
static ExternalInterfaceType^ findExternalInterface(
	IObjectWithExternalInterface^ systemUnitClass, 
	String^ interfaceName
)
```


#### Parameters
&nbsp;<dl><dt>systemUnitClass</dt><dd>Type: <a href="T_Aml_Engine_CAEX_IObjectWithExternalInterface">Aml.Engine.CAEX.IObjectWithExternalInterface</a><br />The system unit class.</dd><dt>interfaceName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />Name of the ExternalInterface to search for</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_ExternalInterfaceType">ExternalInterfaceType</a><br />An ExternalInterface of the given element with name attribute equal to interfaceName

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_IObjectWithExternalInterface">IObjectWithExternalInterface</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter Class</a><br /><a href="N_Aml_Engine_Adapter">Aml.Engine.Adapter Namespace</a><br />