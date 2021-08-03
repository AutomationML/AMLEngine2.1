# IExternalReferenceResolver Interface
AutomationML 2.1 API 

This service interface defines methods to resolve external references of an AutomationML document. If references are resolved, queries will be able to find referenced objects. Be aware, that the resolved documents will not be merged and the references, containing an alias will not be changed.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public interface IExternalReferenceResolver : IAMLService
```

**VB**<br />
``` VB
Public Interface IExternalReferenceResolver
	Inherits IAMLService
```

**C++**<br />
``` C++
public interface class IExternalReferenceResolver : IAMLService
```

The IExternalReferenceResolver type exposes the following members.


## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_Interfaces_IExternalReferenceResolver_LoadOrGetReferencedDocument_1">LoadOrGetReferencedDocument(ExternalReferenceType)</a></td><td>
Loads the external reference in a new CAEXDocument. The new CAEXDocument is a separate document and no libraries are merged to the current document. This Method doesn't change any references, which use the alias of this external reference. Use the <a href="T_Aml_Engine_Services_Interfaces_IMerge">IMerge</a> service to achieve this.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_Interfaces_IExternalReferenceResolver_LoadOrGetReferencedDocument">LoadOrGetReferencedDocument(CAEXDocument, String)</a></td><td>
Determines, if the provided path contains an alias and gets the resolved document for that alias if it is already resolved. If the reference has not been resolved it is resolved.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_Interfaces_IExternalReferenceResolver_ResolvedDocuments">ResolvedDocuments</a></td><td>
Gets all already resolved externals for the provided CAEXDocument containing ExternalReference objects</td></tr></table>&nbsp;
<a href="#iexternalreferenceresolver-interface">Back to Top</a>

## See Also


#### Reference
<a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces Namespace</a><br /><a href="T_Aml_Engine_Services_Interfaces_IAMLService">Aml.Engine.Services.Interfaces.IAMLService</a><br />