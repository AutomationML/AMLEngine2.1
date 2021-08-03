# ObjectWithBaseClass Class
AutomationML 2.1 API 

Extensions for all classes which implement the <a href="T_Aml_Engine_CAEX_IClassWithBaseClassReference">IClassWithBaseClassReference</a> interface.


## Inheritance Hierarchy
<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_parent" rel="noopener noreferrer">System.Object</a><br />&nbsp;&nbsp;Aml.Engine.CAEX.Extensions.ObjectWithBaseClass<br />
**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static class ObjectWithBaseClass
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public NotInheritable Class ObjectWithBaseClass
```

**C++**<br />
``` C++
[ExtensionAttribute]
public ref class ObjectWithBaseClass abstract sealed
```

The ObjectWithBaseClass type exposes the following members.


## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ObjectWithBaseClass_DeleteInheritedElement">DeleteInheritedElement</a></td><td>
Deletes the inherited element. According to CAEX [DIN EN 62424:2008-08 A.2.4.1 (pp.48-49)], deleting of inherited properties is possible by redefinition of the corresponding data again in the child object with the ChangeMode attribute set to "deleted".</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ObjectWithBaseClass_GetDerivedAttributes">GetDerivedAttributes</a></td><td>
Gets a list of Attribute objects that are inherited from base classes. The List will also contain the elements own Attribute objects, if the parameter is set (default). If an Attribute is overwritten, only the last defined is contained.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ObjectWithBaseClass_GetDerivedInterfaces">GetDerivedInterfaces</a></td><td>
Gets a list of ExternalInterface objects that are inherited from base classes. The List will also contain the elements own ExternalInterface objects, if the parameter is set (default). If an ExternalInterface is overwritten, only the last defined is contained.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ObjectWithBaseClass_GetInheritedAttributes">GetInheritedAttributes</a></td><td>
Gets a collection of Attribute objects that are inherited from base classes. The own attributes are included in the enumeration.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ObjectWithBaseClass_GetInheritedAttributesAndDescendants">GetInheritedAttributesAndDescendants</a></td><td>
Gets a list of Attribute objects that are inherited from base classes. The List will also contain the elements own Attribute objects, if the parameter is set (default). If an Attribute is overwritten, only the last defined is contained.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ObjectWithBaseClass_GetInheritedElements">GetInheritedElements</a></td><td>
Gets a collection of InternalElement objects that are inherited from base classes. As default, the own InternalElements are included in the enumeration.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ObjectWithBaseClass_GetInheritedInterfaces">GetInheritedInterfaces</a></td><td>
Gets a collection of ExternalInterface objects that are inherited from base classes.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ObjectWithBaseClass_GetInheritedInterfacesAndDescendants">GetInheritedInterfacesAndDescendants</a></td><td>
Gets a list of ExternalInterface objects that are inherited from base classes. The List will also contain the elements own ExternalInterface objects, if the parameter is set (default). If an ExternalInterface is overridden, only the last defined is contained. The result also contains the nested interface descendants of an external interface.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ObjectWithBaseClass_InheritedElements__1">InheritedElements(TInheritedElement)</a></td><td>
Gets a collection of objects of the defined InheritedElement-Type that are inherited from base classes.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ObjectWithBaseClass_IsInherited">IsInherited</a></td><td>
Determines, if the specified element is an inherited element. To be an inherited element, it has to be an AttributeType, ExternalInterfaceType or InternalElementType element.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ObjectWithBaseClass_IsOverridden">IsOverridden</a></td><td>
Determines, if an element of a class with an inheritance relation to a base class is an overridden element, what means a base class contains an element which is considered as equal to the provided element. In most cases, equality is defined by equality of the element names.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ObjectWithBaseClass_OverriddenElement">OverriddenElement</a></td><td>
Determines, if an element of a class with an inheritance relation to a base class has an overridden element with the specified name and type, what means a base class contains an element which name is equal to the provided elementName.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ObjectWithBaseClass_ReferencedClassName">ReferencedClassName(IClassWithBaseClassReference)</a></td><td>
Name of the referenced Class without path information.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ObjectWithBaseClass_ReferencedClassName_1">ReferencedClassName(InterfaceClassType)</a></td><td>
Name of the referenced InterfaceClass without path information.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ObjectWithBaseClass_ReferencedClassName_2">ReferencedClassName(InternalElementType)</a></td><td>
Name of the referenced SystemUnitClass without path information.</td></tr></table>&nbsp;
<a href="#objectwithbaseclass-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />