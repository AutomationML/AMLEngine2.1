# ExternalReferenceResolver.LoadOrGetReferencedDocument Method 
AutomationML 2.1 API 


## Overload List
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_ExternalReferenceResolver_LoadOrGetReferencedDocument_1">LoadOrGetReferencedDocument(ExternalReferenceType)</a></td><td>
This method is used to load an outsourced CAEX document. The external representation for that document is defined in the provided ExternalReference object. The CAEXDocument is loaded as a new 'stand alone' document, which means that no libraries of the loaded document are merged to the original referencing document. The ExternalReference is not changed and all external references in the original document which use the alias name in a path- or id-reference will not change too. A merge of documents can only be requested by a <a href="T_Aml_Engine_Services_Interfaces_IMerge">IMerge</a> service.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_ExternalReferenceResolver_LoadOrGetReferencedDocument">LoadOrGetReferencedDocument(CAEXDocument, String)</a></td><td>
Determines, if the provided path contains an alias and gets the resolved document for that alias.</td></tr></table>&nbsp;
<a href="#externalreferenceresolver.loadorgetreferenceddocument-method">Back to Top</a>

## See Also


#### Reference
<a href="T_Aml_Engine_Services_ExternalReferenceResolver">ExternalReferenceResolver Class</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />