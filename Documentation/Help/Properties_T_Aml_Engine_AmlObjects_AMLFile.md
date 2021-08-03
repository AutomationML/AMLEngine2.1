# AMLFile Properties
AutomationML 2.1 API 

The <a href="T_Aml_Engine_AmlObjects_AMLFile">AMLFile</a> type exposes the following members.


## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXBasicObject_AdditionalInformation">AdditionalInformation</a></td><td>
Gets the collection of AdditionalInformation values contained in this instance.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXBasicObject">CAEXBasicObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXFileType_AttributeTypeLib">AttributeTypeLib</a></td><td>
Gets the collection of AttributeTypeLib objects contained in the CAEXFile.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXFileType">CAEXFileType</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_AmlObjects_AMLFile_AutomationMLVersion">AutomationMLVersion</a></td><td>
Gets or sets the AutomationML version. It is not allowed to set an AMLVersion which is higher than the <a href="P_Aml_Engine_AmlObjects_AMLFile_MaximalAMLVersion">MaximalAMLVersion</a>. If this is tried, the maximal known version is used for this document.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXWrapper_CAEXDocument">CAEXDocument</a></td><td>
Gets the CAEX document of this CAEX object. If the CAEX object has not been inserted into a document or has been removed from the document, the value is `null`.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXWrapper_CAEXParent">CAEXParent</a></td><td>
Gets the CAEXParent of this instance if it exists.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXWrapper_CAEXSequenceOfCAEXObject">CAEXSequenceOfCAEXObject</a></td><td>
Gets the CAEXSequence containing this CAEX object
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXBasicObject_ChangeMode">ChangeMode</a></td><td>
Gets and sets the change mode for a CAEX element (Optional in CAEX).
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXBasicObject">CAEXBasicObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXBasicObject_Copyright">Copyright</a></td><td>
Gets and sets the Copyright for this object.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXBasicObject">CAEXBasicObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXBasicObject_CopyrightElement">CopyrightElement</a></td><td>
Gets the wrapper for the Copyright element.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXBasicObject">CAEXBasicObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXBasicObject_Description">Description</a></td><td>
Gets and sets the Description for this object.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXBasicObject">CAEXBasicObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXBasicObject_DescriptionElement">DescriptionElement</a></td><td>
Gets the wrapper for the Description element.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXBasicObject">CAEXBasicObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXWrapper_Document">Document</a></td><td>
Gets the XDocument of the wrapped XML-Element
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_AmlObjects_AMLFile_DocumentVersion">DocumentVersion</a></td><td>
Gets the collection of defined document version information of the AMLFile</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXWrapper_Exists">Exists</a></td><td>
Determines if this is a wrapper around an existing XML-Element
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXFileType_ExternalReference">ExternalReference</a></td><td>
Gets the collection of ExternalReference objects contained in the CAEXFile.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXFileType">CAEXFileType</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXFileType_FileName">FileName</a></td><td>
Gets and sets the FileName attribute of the CAEXFile
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXFileType">CAEXFileType</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_AmlObjects_AMLFile_GenericAdditionalInformation">GenericAdditionalInformation</a></td><td>
Gets the AdditionalInformation values contained in this instance which are neither DocumentVersion or WriterHeader. DocumentVersion and WriterHeader objects are realized using AdditionalInformation objects, too. But these elements define a specific syntax to be recognized as specific AdditionalInformation objects.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXFileType_InstanceHierarchy">InstanceHierarchy</a></td><td>
Gets the collection of InstanceHierarchy objects contained in the CAEXFile.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXFileType">CAEXFileType</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXFileType_InterfaceClassLib">InterfaceClassLib</a></td><td>
Gets the collection of InterfaceClassLib objects contained in the CAEXFile.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXFileType">CAEXFileType</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXFileType_IsEmpty">IsEmpty</a></td><td>
Gets a value indicating whether this instance is empty.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXFileType">CAEXFileType</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_AmlObjects_AMLFile_MaximalAMLVersion">MaximalAMLVersion</a></td><td>
Gets the maximal AutomationML version, which can be associated with this AMLFile. The maximal AutomationML version depends on the used CAEX version. For CAEX 2.15 the maximal AutomationML version is 2.0. For CAEX 3.0 the maximal version is 2.10.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXWrapper_Node">Node</a></td><td>
Gets the wrapped XML-Element
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXWrapper_Owner">Owner</a></td><td>
Gets the wrapped Xml-Element's parent
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXBasicObject_Revision">Revision</a></td><td>
Gets the collection of Revision objects contained in this instance.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXBasicObject">CAEXBasicObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXFileType_RoleClassLib">RoleClassLib</a></td><td>
Gets the collection of RoleClassLib objects contained in the CAEXFile.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXFileType">CAEXFileType</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXFileType_SchemaLocation">SchemaLocation</a></td><td>
Gets and sets the SchemaLocation attribute of the CAEXFile.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXFileType">CAEXFileType</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXFileType_SchemaVersion">SchemaVersion</a></td><td>
Gets and sets the SchemaVersion attribute of the CAEXFile.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXFileType">CAEXFileType</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXFileType_SourceDocumentInformation">SourceDocumentInformation</a></td><td>
Gets the collection of SourceDocumentInformation objects contained in the CAEXFile.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXFileType">CAEXFileType</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXBasicObject_SourceObjectInformation">SourceObjectInformation</a></td><td>
Gets the collection of SourceObjectInformation objects contained in this instance.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXBasicObject">CAEXBasicObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXFileType_SuperiorStandardVersion">SuperiorStandardVersion</a></td><td>
Gets the collection of SuperiorStandardVersion objects contained in the CAEXFile. The value of the SuperiorStandardVersion object is defined as a string.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXFileType">CAEXFileType</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXFileType_SystemUnitClassLib">SystemUnitClassLib</a></td><td>
Gets the collection of SystemUnitClassLib objects contained in the CAEXFile.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXFileType">CAEXFileType</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXWrapper_TagName">TagName</a></td><td>
Gets the name of the CAEX tag for this CAEX object.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXBasicObject_Version">Version</a></td><td>
Gets and sets the Version for this object.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXBasicObject">CAEXBasicObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXBasicObject_VersionElement">VersionElement</a></td><td>
Gets the wrapper for the Version element.
 (Inherited from <a href="T_Aml_Engine_CAEX_CAEXBasicObject">CAEXBasicObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_AmlObjects_AMLFile_WriterHeader">WriterHeader</a></td><td>
Gets the collection of defined writer headers of the AMLFile</td></tr></table>&nbsp;
<a href="#amlfile-properties">Back to Top</a>

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_AMLFile">AMLFile Class</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />