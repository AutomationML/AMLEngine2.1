# AmlObjectsExtensions Class
AutomationML 2.1 API 

This class provides extensions methods for the identification of properties of AML objects, using CAEX objects.


## Inheritance Hierarchy
<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_parent" rel="noopener noreferrer">System.Object</a><br />&nbsp;&nbsp;Aml.Engine.AmlObjects.Extensions.AmlObjectsExtensions<br />
**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects_Extensions">Aml.Engine.AmlObjects.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static class AmlObjectsExtensions
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public NotInheritable Class AmlObjectsExtensions
```

**C++**<br />
``` C++
[ExtensionAttribute]
public ref class AmlObjectsExtensions abstract sealed
```

The AmlObjectsExtensions type exposes the following members.


## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions_AMLAttributes">AMLAttributes</a></td><td>
Conversion of any object which has an attribute collection to get access to specific AutomationML defined attributes.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions_AMLFacet">AMLFacet</a></td><td>
Converts an InternalElementType to an AMLFacet.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions_AMLFile">AMLFile</a></td><td>
Converts a CAEX file to an AML file.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions_AMLGroup">AMLGroup</a></td><td>
Converts an InternalElementType to an AMLGroup.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions_AMLPort">AMLPort</a></td><td>
Converts an InternalElementType to an AMLPort.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions_AMLSystemUnitClass">AMLSystemUnitClass</a></td><td>
Converts an SystemUnitClassType to an AMLSystemUnitClass.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions_AutomationMLVersion">AutomationMLVersion</a></td><td>
Gets the AutomationML version for this CAEXFile object.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions_ClearMetaInformation">ClearMetaInformation</a></td><td>
Removes all "Writer Header" specific meta information out of this CAEX file.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions_DeleteMetaInformation">DeleteMetaInformation</a></td><td>
This function deletes any existing meta information corresponding to the writerID.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions_FrameAttribute">FrameAttribute</a></td><td>
Gets a defined FrameAttribute from the <a href="P_Aml_Engine_CAEX_IObjectWithAttributes_Attribute">Attribute</a> collection of the <a href="T_Aml_Engine_CAEX_IObjectWithAttributes">IObjectWithAttributes</a>. If no such attribute exists, `null` is returned.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions_GetMetaInformation">GetMetaInformation(CAEXFileType)</a></td><td>
This methods returns an Enumeration of all "WriterHeader" meta information out of an existing AutomationML file.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions_GetMetaInformation_1">GetMetaInformation(CAEXFileType, String)</a></td><td>
This function returns the MetaInformation corresponding to the writerID, otherwise null.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions_IsAMLFacet">IsAMLFacet</a></td><td>
Determines whether the InternalElement instance is an AMLFacet.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions_IsAMLGroup">IsAMLGroup</a></td><td>
Determines whether the InternalElement instance is an AMLGroup.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions_IsAMLObject">IsAMLObject</a></td><td>
Determines whether the CAEX object is an AutomationML object. If the CAEX object is a SystemUnitClass or InternalElement, it is checked, if there exists a role reference to the AutomationMLBaseRole. If the CAEX object is an ExternalInterface, it is checked, if there exists an InterfaceClass reference to an AutomationMLBase Interface.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions_IsAMLPort">IsAMLPort</a></td><td>
Determines whether the InternalElement instance is an AMLPort.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions_IsFacetAttribute">IsFacetAttribute</a></td><td>
Determines, if the attribute is an attribute of an AMLFacet.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions_IsFacetInterface">IsFacetInterface</a></td><td>
Determines, if the ExternalInterface object is an ExternalInterface of an AMLFacet.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions_IsRefTypeAttribute">IsRefTypeAttribute</a></td><td>
Gets a value indicating whether this instance is a RefType attribute.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions_IsRefURIAttribute">IsRefURIAttribute</a></td><td>
Gets a value indicating whether this instance is a RefURI attribute.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions_New_FrameAttribute">New_FrameAttribute</a></td><td>
Creates a new Frame attribute for the <a href="T_Aml_Engine_CAEX_IObjectWithAttributes">IObjectWithAttributes</a> if no Frame attribute exists. The provided values are used to initialize the Frame attribute values.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions_RefTypeAttribute">RefTypeAttribute</a></td><td>
Gets the RefTypeAttribute from the *objectWithAttributes* if one exists.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions_RefURIAttribute">RefURIAttribute</a></td><td>
Gets the RefURIAttribute from the *objectWithAttributes* if one exists.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions_ReplaceMetaInformation">ReplaceMetaInformation</a></td><td>
This function replaces any existing meta information corresponding to the identical oldWriterID with the new meta information defined in the newMetainformation</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions_SetMetaInformation">SetMetaInformation(CAEXFileType, MetaInformation)</a></td><td>
This method is a short version of the setMetaInformation. Meta data with identical WriterID is replaced.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions_SetMetaInformation_2">SetMetaInformation(SourceDocumentInformationType, MetaInformation)</a></td><td>
Sets the properties for the specified SourceDocumentInformation object using the provided MetaInformation</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions_SetMetaInformation_1">SetMetaInformation(CAEXFileType, String, String, String, String, String, String, String, String, String)</a></td><td>
This function sets the meta information required from AutomationML standard. If meta information about the same writerID already exists, this meta information is replaced. These information comprise source information about the AutomationML file.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions_SetMetaInformationStandardAutomationMLLibrary">SetMetaInformationStandardAutomationMLLibrary</a></td><td>
This method labels this CAEX file as a standard AutomationML library coming from the AutomationML e.V. It removes all other meta information and should only be used from authorized persons in agreement with the AutomationML e.V.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions_SetSourceDocumentInformation">SetSourceDocumentInformation</a></td><td>
This function sets the meta information required from AutomationML standard. If meta information about the same writerID already exists, this meta information is replaced. These information comprise source information about the AutomationML file.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions_ToRefTypeAttribute">ToRefTypeAttribute</a></td><td>
Converts an AttributeType to a RefTypeAttribute.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions_ToRefURIAttribute">ToRefURIAttribute</a></td><td>
Converts an AttributeType to a RefUriAttribute.</td></tr></table>&nbsp;
<a href="#amlobjectsextensions-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Aml_Engine_AmlObjects_Extensions">Aml.Engine.AmlObjects.Extensions Namespace</a><br />