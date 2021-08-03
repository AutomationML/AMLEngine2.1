IExternalReferenceResolver Interface
====================================
This service interface defines methods to resolve external references of an AutomationML document. If references are resolved, queries will be able to find referenced objects. Be aware, that the resolved documents will not be merged and the references, containing an alias will not be changed.

  **Namespace:**  [Aml.Engine.Services.Interfaces][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public interface IExternalReferenceResolver : IAMLService
```

The **IExternalReferenceResolver** type exposes the following members.


Methods
-------

                 | Name                                                    | Description                                                                                                                                                                                                                                                                                  
---------------- | ------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method] | [LoadOrGetReferencedDocument(ExternalReferenceType)][2] | Loads the external reference in a new CAEXDocument. The new CAEXDocument is a separate document and no libraries are merged to the current document. This Method doesn't change any references, which use the alias of this external reference. Use the [IMerge][3] service to achieve this. 
![Public method] | [LoadOrGetReferencedDocument(CAEXDocument, String)][4]  | Determines, if the provided path contains an alias and gets the resolved document for that alias if it is already resolved. If the reference has not been resolved it is resolved.                                                                                                           
![Public method] | [ResolvedDocuments][5]                                  | Gets all already resolved externals for the provided CAEXDocument containing ExternalReference objects                                                                                                                                                                                       


See Also
--------

#### Reference
[Aml.Engine.Services.Interfaces Namespace][1]  
[Aml.Engine.Services.Interfaces.IAMLService][6]  

[1]: ../README.md
[2]: LoadOrGetReferencedDocument_1.md
[3]: ../IMerge/README.md
[4]: LoadOrGetReferencedDocument.md
[5]: ResolvedDocuments.md
[6]: ../IAMLService/README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"