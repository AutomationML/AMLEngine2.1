# ExternalReferenceResolver Class
AutomationML 2.1 API 

This class implements the <a href="T_Aml_Engine_Services_Interfaces_IExternalReferenceResolver">IExternalReferenceResolver</a> service interface. With this service it is possible to access CAEX objects which are outsourced into external documents and referenced using alias names. Normally the service is located by other services like query services. They can call this service to resolve an external reference if an alias is part of a CAEX path in any query.


## Inheritance Hierarchy
<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_parent" rel="noopener noreferrer">System.Object</a><br />&nbsp;&nbsp;Aml.Engine.Services.ExternalReferenceResolver<br />
**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine.Services (in AML.Engine.Services.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public class ExternalReferenceResolver : IExternalReferenceResolver, 
	IAMLService
```

**VB**<br />
``` VB
Public Class ExternalReferenceResolver
	Implements IExternalReferenceResolver, IAMLService
```

**C++**<br />
``` C++
public ref class ExternalReferenceResolver : IExternalReferenceResolver, 
	IAMLService
```

The ExternalReferenceResolver type exposes the following members.


## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_ExternalReferenceResolver_LoadOrGetReferencedDocument_1">LoadOrGetReferencedDocument(ExternalReferenceType)</a></td><td>
This method is used to load an outsourced CAEX document. The external representation for that document is defined in the provided ExternalReference object. The CAEXDocument is loaded as a new 'stand alone' document, which means that no libraries of the loaded document are merged to the original referencing document. The ExternalReference is not changed and all external references in the original document which use the alias name in a path- or id-reference will not change too. A merge of documents can only be requested by a <a href="T_Aml_Engine_Services_Interfaces_IMerge">IMerge</a> service.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_ExternalReferenceResolver_LoadOrGetReferencedDocument">LoadOrGetReferencedDocument(CAEXDocument, String)</a></td><td>
Determines, if the provided path contains an alias and gets the resolved document for that alias.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_ExternalReferenceResolver_Register">Register</a></td><td>
Registers a service to resolve external references.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_ExternalReferenceResolver_ResolvedDocuments">ResolvedDocuments</a></td><td>
Gets all already resolved externals for the provided CAEXDocument containing ExternalReference objects</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_ExternalReferenceResolver_UnRegister">UnRegister</a></td><td>
Unregister this service</td></tr></table>&nbsp;
<a href="#externalreferenceresolver-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br /><a href="T_Aml_Engine_Services_Interfaces_IExternalReferenceResolver">Aml.Engine.Services.Interfaces.IExternalReferenceResolver</a><br />