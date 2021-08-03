# LookupService Class
AutomationML 2.1 API 

This class is a query service based on dictionaries.


## Inheritance Hierarchy
<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_parent" rel="noopener noreferrer">System.Object</a><br />&nbsp;&nbsp;Aml.Engine.Services.LookupService<br />
**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine.Services (in AML.Engine.Services.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public class LookupService : IQuery, 
	IAMLService, IAutoUpdate, IXMLDocumentRegistry
```

**VB**<br />
``` VB
Public Class LookupService
	Implements IQuery, IAMLService, IAutoUpdate, IXMLDocumentRegistry
```

**C++**<br />
``` C++
public ref class LookupService : IQuery, 
	IAMLService, IAutoUpdate, IXMLDocumentRegistry
```

The LookupService type exposes the following members.


## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_Services_LookupService_IsAutoUpdateEnabled">IsAutoUpdateEnabled</a></td><td>
Gets or sets a value indicating whether this instance will automatically update cross references between AutomationML objects.</td></tr></table>&nbsp;
<a href="#lookupservice-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_LookupService_AddDocument">AddDocument</a></td><td>
Adds the document to the query service. All tables for the document will be created.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_LookupService_AllClassReferences_1">AllClassReferences(CAEXObject)</a></td><td>
Gets all classes which have references to the provided CAEX object. Use this method to get all classes which have a class to class relation to the provided CAEX object.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_LookupService_AllClassReferences">AllClassReferences(CAEXDocument, String, String)</a></td><td>
Gets all classes which have references to the provided class path. Use this method to get all classes which have a class to class relation to the class, identified by the provided classPath. If the *elementName* is set, only classes with the defined element name are considered.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_LookupService_AllClassReferencesDeep_1">AllClassReferencesDeep(CAEXObject)</a></td><td>
Gets all classes which have references to the provided CAEX object and their referencing classes (recursive). This method extends the <a href="M_Aml_Engine_Services_Interfaces_IQuery_AllClassReferences_1">AllClassReferences(CAEXObject)</a> and gets not only the directly derived classes of a base class but also the derived classes of these classes and further on.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_LookupService_AllClassReferencesDeep">AllClassReferencesDeep(CAEXDocument, String, String)</a></td><td>
Gets all classes which have references to the provided CAEX object and their referencing classes (recursive). This method extends the <a href="M_Aml_Engine_Services_Interfaces_IQuery_AllClassReferences">AllClassReferences(CAEXDocument, String, String)</a> and gets not only the directly derived classes of a base class but also the derived classes of these classes and further on. If the *elementName* is set, only classes with the defined element name are considered.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_LookupService_AllElementsIdentifiedByCAEXPath">AllElementsIdentifiedByCAEXPath</a></td><td>
Gets all the elements which are descendants of the provided CAEX object and are identifiable by a CAEX path. Elements having the same path are grouped together. Use this method to validate the existence of ambiguous CAEXPaths.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_LookupService_AllElementsWithAliasReference">AllElementsWithAliasReference</a></td><td>
Gets all the elements which are descendants of the provided CAEX object and use an alias reference. Elements referencing the same Alias are grouped together. Use this method to validate the existence of referenced externals. If the *elementName* is set, only elements with the defined element name are considered.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_LookupService_AllElementsWithCAEXPathReference">AllElementsWithCAEXPathReference</a></td><td>
Gets all the elements which are descendants of the provided CAEX object and use a path reference. Elements referencing the same path are grouped together. Use this method to validate the existence of referenced classes. If the *elementName* is set, only elements with the defined element name are considered.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_LookupService_AllElementsWithIDReference">AllElementsWithIDReference</a></td><td>
Gets all the elements which are descendants of the provided CAEX object and which use identifier references. Elements referencing the same ID are grouped together. Use this method to validate the existence of referenced IDs. If the *elementName* is set, only elements with the defined element name are considered.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_LookupService_AllElementsWithIDs">AllElementsWithIDs</a></td><td>
Gets all the elements which are descendants of the provided CAEX object with IDs. Elements using the same ID are grouped together. Use this method to validate the uniqueness of IDs.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_LookupService_AllElementsWithInternalLinks">AllElementsWithInternalLinks</a></td><td>
Returns all Elements which are descendants of the provided CAEX object with InternalLinks. These elements are the owners of the InternalLink objects. The returned collection may contain InternalElements and SystemUnitClasses as well.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_LookupService_AllElementsWithNameReference">AllElementsWithNameReference</a></td><td>
Gets all the elements which are descendants of the provided CAEX object and use a name reference. Elements referencing the same name are grouped together. Use this method to validate the existence of referenced elements.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_LookupService_AllExternalDataReferences">AllExternalDataReferences</a></td><td>
Returns all ExternalInterfaces in the provided document or optionally in the caexObject and descendants, which are instances of the standard Interface class <a href="F_Aml_Engine_AmlObjects_AutomationMLInterfaceClassLib_ExternalDataConnector">ExternalDataConnector</a>.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_LookupService_AllExternalInterfacesOfType">AllExternalInterfacesOfType</a></td><td>
Returns all ExternalInterfaces in the provided document or optionally in the caexObject and descendants, which are instances of the Interface class defined by the provided *interfaceClassPath*.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_LookupService_AllInternalElementsWithInternalLinks">AllInternalElementsWithInternalLinks</a></td><td>
Returns all InternalElements which are descendants of the provided CAEX object with InternalLinks. These elements are the owners of the InternalLink objects.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_LookupService_AttributeMirrors">AttributeMirrors</a></td><td>
Returns all Mirrors of the specified Attribute</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_LookupService_ElementsWithAliasReference">ElementsWithAliasReference</a></td><td>
Gets alls the elements which are descendants of the provided CAEX object which use the provided Alias in a reference. The elements in the result collection are references, which define the CAEX object and the attribute, containing the reference . If the *elementName* is set, only elements with the defined element name are considered.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_LookupService_ElementsWithCAEXPathReference">ElementsWithCAEXPathReference</a></td><td>
Gets alls the elements which are descendants of the provided CAEX object which have a reference to the provided CAEXPath. The elements in the result collection are references, which define the CAEX object and the attribute, containing the reference . If the *elementName* is set, only elements with the defined element name are considered.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_LookupService_ElementsWithIDReference">ElementsWithIDReference</a></td><td>
Gets alls the elements from the document which have a reference to the provided ID. The elements in the result collection are references, which define the CAEX object and the attribute, containing the reference . If the *elementName* is set, only elements with the defined element name are considered.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_LookupService_ElementsWithInternalLinkRelations">ElementsWithInternalLinkRelations</a></td><td>
Returns all InternalElements and SystemUnitClasses which are descendants of the provided CAEX object, which are related to others via InternalLinks.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_LookupService_ExternalInterfaceMirrors">ExternalInterfaceMirrors</a></td><td>
Returns all Mirrors of the specified ExternalInterface</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_LookupService_FindByID">FindByID</a></td><td>
Locates a CAEX object in the provided document using the specified ID - Attribute for identification.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_LookupService_FindByPath">FindByPath</a></td><td>
Locates a CAEX object in the provided document using the specified CAEX - Path for identification. If the path uses an alias reference and an <a href="T_Aml_Engine_Services_Interfaces_IExternalReferenceResolver">IExternalReferenceResolver</a> can be located, it is tried to resolve the external reference and to get the object from the external source.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_LookupService_InterfacesWithInternalLinkRelations">InterfacesWithInternalLinkRelations</a></td><td>
Returns all ExternalInterface objects which are descendants of the provided CAEX object and are used in relations (InternalLinks).</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_LookupService_InternalElementMirrors">InternalElementMirrors</a></td><td>
Returns all Mirrors of the specified InternalElement</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_LookupService_InternalLinksToElement">InternalLinksToElement</a></td><td>
Gets all InternalLinks that reference the specified InternalElement or SystemUnitClass.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_LookupService_InternalLinksToInterface">InternalLinksToInterface</a></td><td>
Gets all InternalLinks that reference the specified ExternalInterface.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_LookupService_IsMaster">IsMaster(AttributeType)</a></td><td>
Determines whether the specified AttributeType is referenced by other AttributeType objects called 'Mirrors'.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_LookupService_IsMaster_1">IsMaster(ExternalInterfaceType)</a></td><td>
Determines whether the specified ExternalInterface is referenced by other ExternalInterface objects called 'Mirrors'.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_LookupService_IsMaster_2">IsMaster(InternalElementType)</a></td><td>
Determines whether the specified InternalElement is referenced by other InternalElement objects called 'Mirrors'.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_LookupService_IsReferenced">IsReferenced</a></td><td>
Determines whether the specified CAEX object is referenced.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_LookupService_Register">Register</a></td><td>
Registers a new instance of a LookupService with the <a href="T_Aml_Engine_Services_ServiceLocator">ServiceLocator</a> of the AMLEngine.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_LookupService_RemoveDocument">RemoveDocument</a></td><td>
Removes the document from the query service. All tables for the document will be unloaded.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_LookupService_UnRegister">UnRegister</a></td><td>
Unregisters this service</td></tr></table>&nbsp;
<a href="#lookupservice-class">Back to Top</a>

## Events
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td><a href="E_Aml_Engine_Services_LookupService_ReferenceUpdated">ReferenceUpdated</a></td><td>
Occurs when any reference has been updated.</td></tr></table>&nbsp;
<a href="#lookupservice-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br /><a href="T_Aml_Engine_Services_Interfaces_IQuery">Aml.Engine.Services.Interfaces.IQuery</a><br /><a href="T_Aml_Engine_Services_Interfaces_IAutoUpdate">Aml.Engine.Services.Interfaces.IAutoUpdate</a><br /><a href="https://docs.microsoft.com/dotnet/api/system.componentmodel.inotifypropertychanged" target="_parent" rel="noopener noreferrer">System.ComponentModel.INotifyPropertyChanged</a><br />