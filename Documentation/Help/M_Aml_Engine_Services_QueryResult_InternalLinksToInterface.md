# QueryResult.InternalLinksToInterface Method 
AutomationML 2.1 API 

Gets all InternalLinks that reference the specified ExternalInterface.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static IEnumerable<InternalLinkType> InternalLinksToInterface(
	this ExternalInterfaceType externalInterface
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function InternalLinksToInterface ( 
	externalInterface As ExternalInterfaceType
) As IEnumerable(Of InternalLinkType)
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static IEnumerable<InternalLinkType^>^ InternalLinksToInterface(
	ExternalInterfaceType^ externalInterface
)
```


#### Parameters
&nbsp;<dl><dt>externalInterface</dt><dd>Type: <a href="T_Aml_Engine_CAEX_ExternalInterfaceType">Aml.Engine.CAEX.ExternalInterfaceType</a><br />The ExternalInterface.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_CAEX_InternalLinkType">InternalLinkType</a>)<br />a collection of InternalLinks.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_ExternalInterfaceType">ExternalInterfaceType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_Services_QueryResult">QueryResult Class</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />