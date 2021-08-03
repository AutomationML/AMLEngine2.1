ExternalReferenceResolver.LoadOrGetReferencedDocument Method (ExternalReferenceType)
====================================================================================
AutomationML 2.1 APIThis method is used to load an outsourced CAEX document. The external representation for that document is defined in the provided ExternalReference object. The CAEXDocument is loaded as a new 'stand alone' document, which means that no libraries of the loaded document are merged to the original referencing document. The ExternalReference is not changed and all external references in the original document which use the alias name in a path- or id-reference will not change too. A merge of documents can only be requested by a [IMerge][1] service.

  **Namespace:**  [Aml.Engine.Services][2]  
  **Assembly:**  AML.Engine.Services (in AML.Engine.Services.dll)

Syntax
------

```csharp
public CAEXDocument LoadOrGetReferencedDocument(
	ExternalReferenceType externalReference
)
```

#### Parameters

##### *externalReference*
Type: [Aml.Engine.CAEX.ExternalReferenceType][3]  
the ExternalReference object

#### Return Value
Type: [CAEXDocument][4]  
 If the ExternalReference doesn't have an alias, the document is not loaded. If a referenced document for the alias already exists, the existing document is returned. 
#### Implements
[IExternalReferenceResolver.LoadOrGetReferencedDocument(ExternalReferenceType)][5]  


See Also
--------

#### Reference
[ExternalReferenceResolver Class][6]  
[Aml.Engine.Services Namespace][2]  

[1]: ../../Aml.Engine.Services.Interfaces/IMerge/README.md
[2]: ../README.md
[3]: ../../Aml.Engine.CAEX/ExternalReferenceType/README.md
[4]: ../../Aml.Engine.CAEX/CAEXDocument/README.md
[5]: ../../Aml.Engine.Services.Interfaces/IExternalReferenceResolver/LoadOrGetReferencedDocument_1.md
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png