# ObjectWithExternalInterface Class
AutomationML 2.1 API 

Extension methods for all objects with ExternalInterface collections.


## Inheritance Hierarchy
<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_parent" rel="noopener noreferrer">System.Object</a><br />&nbsp;&nbsp;Aml.Engine.CAEX.Extensions.ObjectWithExternalInterface<br />
**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static class ObjectWithExternalInterface
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public NotInheritable Class ObjectWithExternalInterface
```

**C++**<br />
``` C++
[ExtensionAttribute]
public ref class ObjectWithExternalInterface abstract sealed
```

The ObjectWithExternalInterface type exposes the following members.


## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")![Code example](media/CodeExample.png "Code example")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ObjectWithExternalInterface_AddInterfaceClassReference">AddInterfaceClassReference(IObjectWithExternalInterface, InterfaceFamilyType, Boolean, Boolean, String)</a></td><td>
Adds an InterfaceClass reference to this ObjectWithExternalInterface using the provided InterfaceClass object. The InterfaceClass reference is added as a <a href="T_Aml_Engine_CAEX_ExternalInterfaceType">ExternalInterfaceType</a> object.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")![Code example](media/CodeExample.png "Code example")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ObjectWithExternalInterface_AddInterfaceClassReference_1">AddInterfaceClassReference(IObjectWithExternalInterface, String, Boolean, Boolean, String)</a></td><td>
Adds an InterfaceClass reference to this ObjectWithExternalInterface using the provided CAEX path, referencing an InterfaceClass object. The InterfaceClass reference is added as a <a href="T_Aml_Engine_CAEX_ExternalInterfaceType">ExternalInterfaceType</a> object.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")![Code example](media/CodeExample.png "Code example")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ObjectWithExternalInterface_HasInterfaceClassReference">HasInterfaceClassReference(IObjectWithExternalInterface, InterfaceFamilyType, Boolean)</a></td><td>
Determines whether an object with ExternalInterfaces has an associated reference to the specified InterfaceClass. If inheritance relations between InterfaceClasses should be regarded, the optional parameter 'regardInheritance' should be set. In this case the specified InterfaceClass is either identical to a referenced InterfaceClass or a referenced InterfaceClass is derived from the specified InterfaceClass.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")![Code example](media/CodeExample.png "Code example")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ObjectWithExternalInterface_HasInterfaceClassReference_1">HasInterfaceClassReference(IObjectWithExternalInterface, String, Boolean)</a></td><td>
Determines whether this Object with ExternalInterfaces has an associated InterfaceClass reference with the specified CAEX path interface reference. If inheritance relations between interface classes should be regarded, the optional parameter 'regardInheritance' should be set. In this case the specified InterfaceClass is either identical to a referenced InterfaceClass or a referenced InterfaceClass is derived from the specified InterfaceClass.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ObjectWithExternalInterface_InterfaceClassReferences">InterfaceClassReferences</a></td><td>
All external Interfaces of this Object with ExternalInterfaces with an associated InterfaceClass reference with the specified CAEX path interface reference. If inheritance relations between interface classes should be regarded, the optional parameter 'regardInheritance' should be set. In this case the specified InterfaceClass is either identical to a referenced InterfaceClass or a referenced InterfaceClass is derived from the specified InterfaceClass.</td></tr></table>&nbsp;
<a href="#objectwithexternalinterface-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />