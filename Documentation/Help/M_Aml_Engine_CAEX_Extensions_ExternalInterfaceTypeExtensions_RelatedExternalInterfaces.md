# ExternalInterfaceTypeExtensions.RelatedExternalInterfaces Method 
AutomationML 2.1 API 

Gets the related external interfaces of the specified ExternalInterface connected with InternalLinks. Either the <a href="P_Aml_Engine_CAEX_InternalLinkType_AInterface">AInterface</a> or the <a href="P_Aml_Engine_CAEX_InternalLinkType_BInterface">BInterface</a> of the InternalLink is equal to the specified ExternalInterface.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static IEnumerable<ExternalInterfaceType> RelatedExternalInterfaces(
	this ExternalInterfaceType externalInterface
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function RelatedExternalInterfaces ( 
	externalInterface As ExternalInterfaceType
) As IEnumerable(Of ExternalInterfaceType)
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static IEnumerable<ExternalInterfaceType^>^ RelatedExternalInterfaces(
	ExternalInterfaceType^ externalInterface
)
```


#### Parameters
&nbsp;<dl><dt>externalInterface</dt><dd>Type: <a href="T_Aml_Engine_CAEX_ExternalInterfaceType">Aml.Engine.CAEX.ExternalInterfaceType</a><br />The ExternalInterface CAEX element.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_CAEX_ExternalInterfaceType">ExternalInterfaceType</a>)<br />An enumeration of related ExternalInterface elements

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_ExternalInterfaceType">ExternalInterfaceType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_ExternalInterfaceTypeExtensions">ExternalInterfaceTypeExtensions Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />