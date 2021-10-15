ExternalReferenceResolver Class
===============================
This class implements the [IExternalReferenceResolver][1] service interface. With this service it is possible to access CAEX objects which are outsourced into external documents and referenced using alias names. Normally the service is located by other services like query services. They can call this service to resolve an external reference if an alias is part of a CAEX path in any query.


Inheritance Hierarchy
---------------------
[System.Object][2]  
  **Aml.Engine.Services.ExternalReferenceResolver**  

  **Namespace:**  [Aml.Engine.Services][3]  
  **Assembly:**  AML.Engine.Services (in AML.Engine.Services.dll)

Syntax
------

```csharp
public class ExternalReferenceResolver : IExternalReferenceResolver, 
	IAMLService, IXMLDocumentRegistry, IXMLExternalUnload
```

The **ExternalReferenceResolver** type exposes the following members.


Methods
-------

                                 | Name                                                    | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           
-------------------------------- | ------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method]                 | [LoadOrGetReferencedDocument(ExternalReferenceType)][4] | This method is used to load an outsourced CAEX document. The external representation for that document is defined in the provided ExternalReference object. The CAEXDocument is loaded as a new 'stand alone' document, which means that no libraries of the loaded document are merged to the original referencing document. The ExternalReference is not changed and all external references in the original document which use the alias name in a path- or id-reference will not change too. A merge of documents can only be requested by a [IMerge][5] service. 
![Public method]                 | [LoadOrGetReferencedDocument(CAEXDocument, String)][6]  | Determines, if the provided path contains an alias and gets the resolved document for that alias.                                                                                                                                                                                                                                                                                                                                                                                                                                                                     
![Public method]![Static member] | [Register][7]                                           | Registers a service to resolve external references.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   
![Public method]                 | [RemoveDocument][8]                                     | Removes the document from the internal registry of the service.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       
![Public method]                 | [ResolvedDocuments][9]                                  | Gets all already resolved externals for the provided CAEXDocument containing ExternalReference objects                                                                                                                                                                                                                                                                                                                                                                                                                                                                
![Public method]                 | [UnloadExternalDocument][10]                            | Unloads the external document which was referenced by the provided externalReference.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 
![Public method]![Static member] | [UnRegister][11]                                        | Unregister this service                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               


See Also
--------

#### Reference
[Aml.Engine.Services Namespace][3]  
[Aml.Engine.Services.Interfaces.IExternalReferenceResolver][1]  

[1]: ../../Aml.Engine.Services.Interfaces/IExternalReferenceResolver/README.md
[2]: https://docs.microsoft.com/dotnet/api/system.object
[3]: ../README.md
[4]: LoadOrGetReferencedDocument_1.md
[5]: ../../Aml.Engine.Services.Interfaces/IMerge/README.md
[6]: LoadOrGetReferencedDocument.md
[7]: Register.md
[8]: RemoveDocument.md
[9]: ResolvedDocuments.md
[10]: UnloadExternalDocument.md
[11]: UnRegister.md
[12]: https://www.automationml.org
[13]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Static member]: ../../icons/static.gif "Static member"