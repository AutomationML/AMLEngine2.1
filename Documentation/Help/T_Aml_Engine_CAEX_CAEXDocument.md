# CAEXDocument Class
AutomationML 2.1 API 

This class is a wrapper for the XDocument defining a CAEXDocument. Each CAEXDocument is associated to a specific CAEX-Schema. The Default Schema for newly created documents is always the most recently defined CAEX-Schema (currently Version 3.0). The Schema for existing documents loaded from files or other sources is set to the schema version defined in the document source. Transformations of CAEXDocuments from lower schema versions to higher schema versions is possible. Transformations from higher to lower schema versions can also be done but may result in documents containing not all the information. Schema transformations can be done with a registered schema transformation service which implements the <a href="T_Aml_Engine_Services_Interfaces_ISchemaTransform">ISchemaTransform</a> interface. Creation of new documents with lower schema versions is possible, but in this case, the schema version has to be defined explicitly.


## Inheritance Hierarchy
<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_parent" rel="noopener noreferrer">System.Object</a><br />&nbsp;&nbsp;<a href="T_Aml_Engine_XML_XDocumentWrapper">Aml.Engine.XML.XDocumentWrapper</a><br />&nbsp;&nbsp;&nbsp;&nbsp;Aml.Engine.CAEX.CAEXDocument<br />
**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public class CAEXDocument : XDocumentWrapper
```

**VB**<br />
``` VB
Public Class CAEXDocument
	Inherits XDocumentWrapper
```

**C++**<br />
``` C++
public ref class CAEXDocument : public XDocumentWrapper
```

The CAEXDocument type exposes the following members.


## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXDocument_CAEXFile">CAEXFile</a></td><td>
Gets the CAEXFile which is the wrapper for the root element in the CAEX document</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXDocument_Commands">Commands</a></td><td>
Gets the command instance for this document, which enables registration of change events</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Static member](media/static.gif "Static member")</td><td><a href="P_Aml_Engine_CAEX_CAEXDocument_DefaultSchema">DefaultSchema</a></td><td>
The Default schema for new CAEX documents</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXDocument_Schema">Schema</a></td><td>
Gets the Schema of the CAEXDocument</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXDocument_SchemaManager">SchemaManager</a></td><td>
Gets the schema manager for this document</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXDocument_SchemaVersionString">SchemaVersionString</a></td><td>
Gets the schema version string for the assigned schema</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_XML_XDocumentWrapper_XDocument">XDocument</a></td><td>
Gets the underlying XDocument
 (Inherited from <a href="T_Aml_Engine_XML_XDocumentWrapper">XDocumentWrapper</a>.)</td></tr></table>&nbsp;
<a href="#caexdocument-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_CAEXDocument_AMLSchemaManager_1">AMLSchemaManager(XElement)</a></td><td>
Gets the schema manager for the CAEX document which contains the provided XML node.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_CAEXDocument_AMLSchemaManager">AMLSchemaManager(CAEXWrapper)</a></td><td>
Gets the schema manager for the CAEX document which contains the provided CAEX object.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_CAEXDocument_Document_1">Document(XElement)</a></td><td>
Gets the CAEX document which contains the specified XML node.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_CAEXDocument_Document">Document(CAEXWrapper)</a></td><td>
Gets the CAEX document which contains the specified CAEX object. If the CAEX object has not been inserted into a CAEX document, no CAEX document is returned.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_CAEXDocument_LoadFromBinary">LoadFromBinary</a></td><td>
Loading a CAEX file from the specified Byte-Array.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_CAEXDocument_LoadFromFile">LoadFromFile</a></td><td>
Create a CAEX document with content, loaded from a file. The schema version of the CAEX document is set accordingly to the SchemaVersion-Attribute of the CAEXFile object.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_CAEXDocument_LoadFromStream">LoadFromStream</a></td><td>
Create a CAEX document with content, loaded from a stream. The schema version of the CAEX document is set accordingly to the SchemaVersion-Attribute of the CAEXFile object.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_CAEXDocument_New_CAEXDocument">New_CAEXDocument()</a></td><td>
Creates a new empty CAEX document containing only the CAEXFile Element as the root element. The CAEX document is created, using the default schema version <a href="P_Aml_Engine_CAEX_CAEXDocument_DefaultSchema">DefaultSchema</a>.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_CAEXDocument_New_CAEXDocument_1">New_CAEXDocument(CAEXDocument.CAEXSchema)</a></td><td>
Creates a new empty CAEX document containing only the CAEXFile element as the root element. The CAEX document is created using the specified schema version. The specified schema version defines the applicable editing methods.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXDocument_SaveToFile">SaveToFile</a></td><td>
Saves the CAEX document to the specified file path.
 (Overrides <a href="M_Aml_Engine_XML_XDocumentWrapper_SaveToFile">XDocumentWrapper.SaveToFile(String, Boolean)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXDocument_SaveToStream">SaveToStream</a></td><td>
Saves the CAEX document to the specified file path.
 (Overrides <a href="M_Aml_Engine_XML_XDocumentWrapper_SaveToStream">XDocumentWrapper.SaveToStream(Boolean)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_XML_XDocumentWrapper_Unload">Unload</a></td><td>
Unloads this document instance.
 (Inherited from <a href="T_Aml_Engine_XML_XDocumentWrapper">XDocumentWrapper</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXDocument_Validate">Validate</a></td><td>
Checks if the document is schema compliant.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXDocument_XName">XName</a></td><td>
Gets the correct XName for the provided CAEX element name (Tag name).The XName contains a namespace, if the assigned schema requires a namespace. If no namespace is defined for the assigned schema (as in CAEX 2.15), no namespace is added to the XName. The XName has to be used for all Xml.Linq queries, used to access objects with the CAEX element name.
 (Overrides <a href="M_Aml_Engine_XML_XDocumentWrapper_XName">XDocumentWrapper.XName(String)</a>.)</td></tr></table>&nbsp;
<a href="#caexdocument-class">Back to Top</a>

## Extension Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_Services_QueryResult_AllElementsIdentifiedByCAEXPath">AllElementsIdentifiedByCAEXPath</a></td><td>
Gets all the elements which are identifiable by a CAEX path. Elements having the same path are grouped together. Use this method to validate the existence of not unique CAEXPaths.
 (Defined by <a href="T_Aml_Engine_Services_QueryResult">QueryResult</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_Services_QueryResult_AllElementsWithAliasReference">AllElementsWithAliasReference</a></td><td>
Gets all the elements with an alias reference. Elements referencing the same Alias are grouped together. Use this method to validate the existence of referenced externals.
 (Defined by <a href="T_Aml_Engine_Services_QueryResult">QueryResult</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_Services_QueryResult_AllElementsWithCAEXPathReference">AllElementsWithCAEXPathReference</a></td><td>
Gets all the elements with a path reference. Elements referencing the same path are grouped together. Use this method to validate the existence of referenced classes.
 (Defined by <a href="T_Aml_Engine_Services_QueryResult">QueryResult</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_Services_QueryResult_AllElementsWithIDReference">AllElementsWithIDReference</a></td><td>
Gets all the elements with identifier references. Elements referencing the same ID are grouped together. Use this method to validate the existence of referenced IDs.
 (Defined by <a href="T_Aml_Engine_Services_QueryResult">QueryResult</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_Services_QueryResult_AllElementsWithIDs">AllElementsWithIDs</a></td><td>
Gets all the elements with IDs. Elements using the same ID are grouped together. Use this method to validate the uniqueness of IDs.
 (Defined by <a href="T_Aml_Engine_Services_QueryResult">QueryResult</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_Services_QueryResult_AllElementsWithNameReference">AllElementsWithNameReference</a></td><td>
Gets all the elements with a name reference. Elements referencing the same name are grouped together. Use this method to validate the existence of referenced elements.
 (Defined by <a href="T_Aml_Engine_Services_QueryResult">QueryResult</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_Services_QueryResult_AllInternalElementMasters">AllInternalElementMasters</a></td><td>
Gets all InternalElement objects from the document which are masters.
 (Defined by <a href="T_Aml_Engine_Services_QueryResult">QueryResult</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_Services_QueryResult_AllInternalElementMirrors">AllInternalElementMirrors</a></td><td>
Gets all InternalElement objects from the document which are mirrors.
 (Defined by <a href="T_Aml_Engine_Services_QueryResult">QueryResult</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_InheritanceExtensions_ClassIsDerivedFrom__1">ClassIsDerivedFrom(T)</a></td><td>
Determines, if the class, specified with the given class path is directly or indirectly (across multiple generations) a descendant of the class or identical to it, which is uniquely identified with the specified baseClass path. The base class path or the referenced class path may contain alias identifiers. If alias identifiers are present, the method tries to load the externally referenced document.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_InheritanceExtensions">InheritanceExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXElementFactory_Create">Create(String)</a></td><td>Overloaded.  
Factory method to create a new CAEX object in the provided CAEX document. The CAEX element is derived from the specified CAEX object Type. To insert the new CAEX object into the document an appropriate insertion method has to be used.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_CAEXElementFactory">CAEXElementFactory</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXElementFactory_Create__1">Create(T)()</a></td><td>Overloaded.  
Factory method to create a new CAEX object in the provided CAEX document. The CAEX element is derived from the specified CAEX object Type. To insert the new CAEX object into the document an appropriate insertion method has to be used.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_CAEXElementFactory">CAEXElementFactory</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_Services_QueryResult_ElementsWithAliasReference">ElementsWithAliasReference</a></td><td>
Gets alls the elements from the document which use the provided Alias in a reference
 (Defined by <a href="T_Aml_Engine_Services_QueryResult">QueryResult</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_Services_QueryResult_ElementsWithCAEXPathReference">ElementsWithCAEXPathReference</a></td><td>
Gets alls the elements from the document which have a reference to the provided Path.
 (Defined by <a href="T_Aml_Engine_Services_QueryResult">QueryResult</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_Services_QueryResult_ElementsWithIDReference">ElementsWithIDReference</a></td><td>
Gets alls the elements from the document which have a reference to the provided ID.
 (Defined by <a href="T_Aml_Engine_Services_QueryResult">QueryResult</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_Services_QueryResult_ElementsWithInternalLinkRelations">ElementsWithInternalLinkRelations</a></td><td>
Returns all InternalElements and SystemUnitClasses in the defined Document, which are related to others via InternalLinks.
 (Defined by <a href="T_Aml_Engine_Services_QueryResult">QueryResult</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXDocumentExtensions_FindByID">FindByID</a></td><td>
Tries to locate a CAEX object from the specified ID. If the ID uses an alias reference and an <a href="T_Aml_Engine_Services_Interfaces_IExternalReferenceResolver">IExternalReferenceResolver</a> can be located, it is tried to resolve the external reference and to get the object from the external source.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_CAEXDocumentExtensions">CAEXDocumentExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXDocumentExtensions_FindByPath">FindByPath</a></td><td>
Tries to locates a CAEX object from the specified CAEX path. If the path uses an alias reference and an <a href="T_Aml_Engine_Services_Interfaces_IExternalReferenceResolver">IExternalReferenceResolver</a> can be located, it is tried to resolve the external reference and to get the object from the external source.
 (Defined by <a href="T_Aml_Engine_CAEX_Extensions_CAEXDocumentExtensions">CAEXDocumentExtensions</a>.)</td></tr></table>&nbsp;
<a href="#caexdocument-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />