# ExternalInterfaceTypeExtensions Class
AutomationML 2.1 API 

Extension methods for the CAEX element "ExternalInterface"


## Inheritance Hierarchy
<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_parent" rel="noopener noreferrer">System.Object</a><br />&nbsp;&nbsp;Aml.Engine.CAEX.Extensions.ExternalInterfaceTypeExtensions<br />
**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static class ExternalInterfaceTypeExtensions
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public NotInheritable Class ExternalInterfaceTypeExtensions
```

**C++**<br />
``` C++
[ExtensionAttribute]
public ref class ExternalInterfaceTypeExtensions abstract sealed
```

The ExternalInterfaceTypeExtensions type exposes the following members.


## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ExternalInterfaceTypeExtensions_IsMaster">IsMaster</a></td><td>
Determines whether the specified ExternalInterface is referenced by other ExternalInterface objects called 'Mirrors'.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ExternalInterfaceTypeExtensions_IsRelated">IsRelated</a></td><td>
Determines whether the specified ExternalInterface is related to other ExternalInterfaces using InternalLinks.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ExternalInterfaceTypeExtensions_OfInterfaceClass">OfInterfaceClass</a></td><td>
Gets all ExternalInterface objects from the specified *objectWithExternalInterface*, which are derived from an InterfaceClass, identified with the given *interfaceClassPath*.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ExternalInterfaceTypeExtensions_RelatedExternalInterfaces">RelatedExternalInterfaces</a></td><td>
Gets the related external interfaces of the specified ExternalInterface connected with InternalLinks. Either the <a href="P_Aml_Engine_CAEX_InternalLinkType_AInterface">AInterface</a> or the <a href="P_Aml_Engine_CAEX_InternalLinkType_BInterface">BInterface</a> of the InternalLink is equal to the specified ExternalInterface.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ExternalInterfaceTypeExtensions_RelatedInstances">RelatedInstances</a></td><td>
Gets the related instances (SystemUnitClass or InternalElement) of the specified ExternalInterface connected with InternalLinks. Either the <a href="P_Aml_Engine_CAEX_InternalLinkType_AInterface">AInterface</a> or the <a href="P_Aml_Engine_CAEX_InternalLinkType_BInterface">BInterface</a> of the InternalLink is equal to the specified ExternalInterface.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ExternalInterfaceTypeExtensions_RelatedInternalElementsWithRoleReference">RelatedInternalElementsWithRoleReference</a></td><td>
Gets the related InternalElements of the specified ExternalInterface connected with InternalLinks, which have a role reference to the provided *roleClassPath*. Inheritance is considered here. Either the <a href="P_Aml_Engine_CAEX_InternalLinkType_AInterface">AInterface</a> or the <a href="P_Aml_Engine_CAEX_InternalLinkType_BInterface">BInterface</a> of the InternalLink is equal to the specified ExternalInterface.</td></tr></table>&nbsp;
<a href="#externalinterfacetypeextensions-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />