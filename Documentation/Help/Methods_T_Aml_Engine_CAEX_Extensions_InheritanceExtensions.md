# InheritanceExtensions Methods
AutomationML 2.1 API 

The <a href="T_Aml_Engine_CAEX_Extensions_InheritanceExtensions">InheritanceExtensions</a> type exposes the following members.


## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_InheritanceExtensions_ClassIsDerivedFrom__1_1">ClassIsDerivedFrom(T)(IClassWithBaseClassReference(T), IClassWithBaseClassReference(T))</a></td><td>
Determines, if the specified class is directly or indirectly (across multiple generations) a descendant of the specified base class or identical to it. This method can be used, if the classes are distributed over different CAEX documents, the documents should be referenced by external references and alias references.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_InheritanceExtensions_ClassIsDerivedFrom__1_2">ClassIsDerivedFrom(T)(IClassWithBaseClassReference(T), String)</a></td><td>
Determines, if the specified class is directly or indirectly (across multiple generations) a descendant of the class or identical to it, which is uniquely identified with the specified baseClass path. The base class path or the referenced class path may contain alias identifiers. If alias identifiers are present, the method tries to load the external referenced document.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_InheritanceExtensions_ClassIsDerivedFrom__1">ClassIsDerivedFrom(T)(CAEXDocument, String, String)</a></td><td>
Determines, if the class, specified with the given class path is directly or indirectly (across multiple generations) a descendant of the class or identical to it, which is uniquely identified with the specified baseClass path. The base class path or the referenced class path may contain alias identifiers. If alias identifiers are present, the method tries to load the externally referenced document.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_InheritanceExtensions_IsDerivedFromAttributeType">IsDerivedFromAttributeType</a></td><td>
Determines whether the specified attribute defines an inheritance relation from the attribute, uniquely identifiable by the given attribute type path. The attribute type path may contain an alias.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_InheritanceExtensions_IsDerivedFromInterfaceClass">IsDerivedFromInterfaceClass</a></td><td>
Determines whether the specified interface class has an inheritance relation from the interface class, uniquely identifiable by the given interface class path. The interface class path may contain an alias.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_InheritanceExtensions_IsDerivedFromRoleClass">IsDerivedFromRoleClass</a></td><td>
Determines whether the specified role reference defines an inheritance relation from the role, uniquely identifiable by the given role class path. The role class path may contain an alias.</td></tr></table>&nbsp;
<a href="#inheritanceextensions-methods">Back to Top</a>

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_InheritanceExtensions">InheritanceExtensions Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />