# IExternalReferenceResolver.LoadOrGetReferencedDocument Method 
AutomationML 2.1 API 


## Overload List
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_Interfaces_IExternalReferenceResolver_LoadOrGetReferencedDocument_1">LoadOrGetReferencedDocument(ExternalReferenceType)</a></td><td>
Loads the external reference in a new CAEXDocument. The new CAEXDocument is a separate document and no libraries are merged to the current document. This Method doesn't change any references, which use the alias of this external reference. Use the <a href="T_Aml_Engine_Services_Interfaces_IMerge">IMerge</a> service to achieve this.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_Interfaces_IExternalReferenceResolver_LoadOrGetReferencedDocument">LoadOrGetReferencedDocument(CAEXDocument, String)</a></td><td>
Determines, if the provided path contains an alias and gets the resolved document for that alias if it is already resolved. If the reference has not been resolved it is resolved.</td></tr></table>&nbsp;
<a href="#iexternalreferenceresolver.loadorgetreferenceddocument-method">Back to Top</a>

## See Also


#### Reference
<a href="T_Aml_Engine_Services_Interfaces_IExternalReferenceResolver">IExternalReferenceResolver Interface</a><br /><a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces Namespace</a><br />