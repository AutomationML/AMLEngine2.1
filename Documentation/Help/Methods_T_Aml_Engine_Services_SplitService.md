# SplitService Methods
AutomationML 2.1 API 

The <a href="T_Aml_Engine_Services_SplitService">SplitService</a> type exposes the following members.


## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_SplitService_Register">Register</a></td><td>
Registers a new instance of a SplitService with the <a href="T_Aml_Engine_Services_ServiceLocator">ServiceLocator</a> of the AMLEngine.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_SplitService_RemoveDocument">RemoveDocument</a></td><td>
Removes the document from the internal registry of the split service. All registered split points for this document will be removed.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_SplitService_RemoveSplitPoint">RemoveSplitPoint</a></td><td>
Removes the split point for the provided CAEX object.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_SplitService_SetSplitPoint">SetSplitPoint</a></td><td>
Sets the split point for the provided CAEX object. If the actual list of split points for the same document already contains a split point which is a child of the provided CAEX object, this existing split point is removed from the list.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_SplitService_Split_1">Split(CAEXDocument, String, String)</a></td><td>
Splits the specified document on all currently defined split points. The created libraries are saved in an AutomationML document and an ExternalReference is created, using the specified alias. All remaining references to the external source are renamed using the provided alias. After splitting, the document doesn't contain any SplitPoints any more.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_SplitService_Split">Split(CAEXDocument, ISplitPoint, String, String)</a></td><td>
Splits the specified source document.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_SplitService_SplitPoints">SplitPoints</a></td><td>
Gets a collection of all split points for the provided document.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_SplitService_UnRegister">UnRegister</a></td><td>
Unregisters this service</td></tr></table>&nbsp;
<a href="#splitservice-methods">Back to Top</a>

## See Also


#### Reference
<a href="T_Aml_Engine_Services_SplitService">SplitService Class</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />