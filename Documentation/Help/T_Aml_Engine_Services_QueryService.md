# QueryService Class
AutomationML 2.1 API 

This class defines the default query service for a <a href="T_Aml_Engine_CAEX_CAEXDocument">CAEXDocument</a>. The query methods of this service are based on System.Xml.Linq and System.Xml.XPath.


## Inheritance Hierarchy
<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_parent" rel="noopener noreferrer">System.Object</a><br />&nbsp;&nbsp;Aml.Engine.Services.QueryService<br />
**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public class QueryService : IQuery, 
	IAMLService
```

**VB**<br />
``` VB
Public Class QueryService
	Implements IQuery, IAMLService
```

**C++**<br />
``` C++
public ref class QueryService : IQuery, 
	IAMLService
```

The QueryService type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_QueryService__ctor">QueryService</a></td><td>
Initializes a new instance of the QueryService class</td></tr></table>&nbsp;
<a href="#queryservice-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_QueryService_AllClassReferences_1">AllClassReferences(CAEXObject)</a></td><td>
Gets all classes which have references to the provided CAEX object.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_QueryService_AllClassReferences">AllClassReferences(CAEXDocument, String, String)</a></td><td>
Gets all classes which have references to the provided class path. Use this method to get all classes which have a class to class relation to the class, identified by the provided classPath. If the *elementName* is set, only classes with the defined element name are considered.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_QueryService_AllClassReferencesDeep_1">AllClassReferencesDeep(CAEXObject)</a></td><td>
Gets all classes which have references to the provided CAEX object and their referencing classes (recursive)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_QueryService_AllClassReferencesDeep">AllClassReferencesDeep(CAEXDocument, String, String)</a></td><td>
Gets all classes which have references to the provided CAEX object and their referencing classes (recursive). This method extends the <a href="M_Aml_Engine_Services_QueryService_AllClassReferences">AllClassReferences(CAEXDocument, String, String)</a> and gets not only the directly derived classes of a base class but also the derived classes of these classes and further on. If the *elementName* is set, only classes with the defined element name are considered.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_QueryService_AllElementsIdentifiedByCAEXPath">AllElementsIdentifiedByCAEXPath</a></td><td>
Gets all the elements which are descendants of the provided CAEX object and are identifiable by a CAEX path. Elements having the same path are grouped together. Use this method to validate the existence of ambiguous CAEXPaths.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_QueryService_AllElementsWithAliasReference">AllElementsWithAliasReference</a></td><td>
Gets all the elements which are descendants of the provided CAEX object and use an alias reference. Elements referencing the same Alias are grouped together. Use this method to validate the existence of referenced externals.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_QueryService_AllElementsWithCAEXPathReference">AllElementsWithCAEXPathReference</a></td><td>
Gets all the elements which are descendants of the provided CAEX object and use a path reference. Elements referencing the same path are grouped together. Use this method to validate the existence of referenced classes. If the *elementName* is set, only elements with the defined element name are considered.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_QueryService_AllElementsWithIDReference">AllElementsWithIDReference</a></td><td>
Gets all the elements which are descendants of the provided CAEX object which use identifier references. Elements referencing the same ID are grouped together. Use this method to validate the existence of referenced IDs. If the *elementName* is set, only elements with the defined element name are considered.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_QueryService_AllElementsWithIDs">AllElementsWithIDs</a></td><td>
Gets all the elements which are descendants of the provided CAEX object with IDs. Elements using the same ID are grouped together. Use this method to validate the uniqueness of IDs.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_QueryService_AllElementsWithInternalLinks">AllElementsWithInternalLinks</a></td><td>
Returns all Elements which are descendants of the provided CAEX object with InternalLinks. These elements are the owners of the InternalLink objects. The returned collection may contain InternalElements and SystemUnitClasses as well.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_QueryService_AllElementsWithNameReference">AllElementsWithNameReference</a></td><td>
Gets all the elements which are descendants of the provided CAEX object and use a name reference. Elements referencing the same name are grouped together. Use this method to validate the existence of referenced elements.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_QueryService_AllExternalDataReferences">AllExternalDataReferences</a></td><td>
Returns all ExternalInterfaces in the provided document or optionally in the caexObject and descendants, which are instances of the standard Interface class <a href="F_Aml_Engine_AmlObjects_AutomationMLInterfaceClassLib_ExternalDataConnector">ExternalDataConnector</a>.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_QueryService_AllExternalInterfacesOfType">AllExternalInterfacesOfType</a></td><td>
Returns all ExternalInterfaces which are instances of the Interface class defined by the provided *interfaceClassPath*.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_QueryService_AllInternalElementsWithInternalLinks">AllInternalElementsWithInternalLinks</a></td><td>
Returns all InternalElements which are descendants of the provided CAEX object with InternalLinks. These elements are the owners of the InternalLink objects.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_QueryService_AttributeMirrors">AttributeMirrors</a></td><td>
Returns all Mirrors of the specified Attribute</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_QueryService_ElementsWithAliasReference">ElementsWithAliasReference</a></td><td>
Gets alls the elements which are descendants of the provided CAEX object which use the provided Alias in a reference. The elements in the result collection are references, which define the CAEX object and the attribute, containing the reference . If the *elementName* is set, only elements with the defined element name are considered.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_QueryService_ElementsWithCAEXPathReference">ElementsWithCAEXPathReference</a></td><td>
Gets alls the elements which are descendants of the provided CAEX object which have a reference to the provided CAEXPath.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_QueryService_ElementsWithIDReference">ElementsWithIDReference</a></td><td>
Gets alls the elements from the document which have a reference to the provided ID. The elements in the result collection are references, which define the CAEX object and the attribute, containing the reference . If the *elementName* is set, only elements with the defined element name are considered.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_QueryService_ElementsWithInternalLinkRelations">ElementsWithInternalLinkRelations</a></td><td>
Returns all InternalElements and SystemUnitClasses which are descendants of the provided CAEX object, which are related to others via InternalLinks.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_QueryService_ExternalInterfaceMirrors">ExternalInterfaceMirrors</a></td><td>
Returns all Mirrors of the specified ExternalInterface</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_QueryService_FindByID">FindByID</a></td><td>
Finds the first element in the defined document, which ID is equal to the provided ID.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_QueryService_FindByPath">FindByPath</a></td><td>
This method tries to find the first element in the defined document, which CAEXPath is equal to the provided path. If the path uses an alias to reference an object in a external document it is tried to locate an <a href="T_Aml_Engine_Services_Interfaces_IExternalReferenceResolver">IExternalReferenceResolver</a> service. If such a service is registered, the CAEXObject is tried to be found in the resolved document.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_QueryService_InterfacesWithInternalLinkRelations">InterfacesWithInternalLinkRelations</a></td><td>
Returns all ExternalInterface objects which are descendants of the provided CAEX object and are used in relations (InternalLinks).</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_QueryService_InternalElementMirrors">InternalElementMirrors</a></td><td>
Returns all Mirrors of the specified InternalElement</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_QueryService_InternalLinksToElement">InternalLinksToElement</a></td><td>
Gets all InternalLink objects referencing the provided SystemUnitClass object via an external interface attached to the SystemUnitClass.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_QueryService_InternalLinksToInterface">InternalLinksToInterface</a></td><td>
Gets all InternalLinks that reference the specified ExternalInterface.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_QueryService_IsMaster">IsMaster(AttributeType)</a></td><td>
Determines whether the specified attribute is a master attribute.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_QueryService_IsMaster_1">IsMaster(ExternalInterfaceType)</a></td><td>
Determines whether the specified ExternalInterface is referenced by other ExternalInterface objects called 'Mirrors'.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_QueryService_IsMaster_2">IsMaster(InternalElementType)</a></td><td>
Determines whether the specified InternalElement is referenced by other InternalElement objects called 'Mirrors'.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_QueryService_IsReferenced">IsReferenced</a></td><td>
Determines whether the specified CAEX object is referenced.</td></tr></table>&nbsp;
<a href="#queryservice-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br /><a href="T_Aml_Engine_Services_Interfaces_IQuery">Aml.Engine.Services.Interfaces.IQuery</a><br />