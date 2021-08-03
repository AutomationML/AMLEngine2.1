# ExternalInterfaceTypeExtensions.RelatedInternalElementsWithRoleReference Method 
AutomationML 2.1 API 

Gets the related InternalElements of the specified ExternalInterface connected with InternalLinks, which have a role reference to the provided *roleClassPath*. Inheritance is considered here. Either the <a href="P_Aml_Engine_CAEX_InternalLinkType_AInterface">AInterface</a> or the <a href="P_Aml_Engine_CAEX_InternalLinkType_BInterface">BInterface</a> of the InternalLink is equal to the specified ExternalInterface.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static IEnumerable<InternalElementType> RelatedInternalElementsWithRoleReference(
	this ExternalInterfaceType externalInterface,
	string roleClassPath
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function RelatedInternalElementsWithRoleReference ( 
	externalInterface As ExternalInterfaceType,
	roleClassPath As String
) As IEnumerable(Of InternalElementType)
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static IEnumerable<InternalElementType^>^ RelatedInternalElementsWithRoleReference(
	ExternalInterfaceType^ externalInterface, 
	String^ roleClassPath
)
```


#### Parameters
&nbsp;<dl><dt>externalInterface</dt><dd>Type: <a href="T_Aml_Engine_CAEX_ExternalInterfaceType">Aml.Engine.CAEX.ExternalInterfaceType</a><br />The ExternalInterface CAEX element.</dd><dt>roleClassPath</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The role class path.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_CAEX_InternalElementType">InternalElementType</a>)<br />An enumeration of selected related InternalElements.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_ExternalInterfaceType">ExternalInterfaceType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_ExternalInterfaceTypeExtensions">ExternalInterfaceTypeExtensions Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />