IExternalReferenceResolver.LoadOrGetReferencedDocument Method (ExternalReferenceType)
=====================================================================================
Loads the external reference in a new CAEXDocument. The new CAEXDocument is a separate document and no libraries are merged to the current document. This Method doesn't change any references, which use the alias of this external reference. Use the [IMerge][1] service to achieve this.

  **Namespace:**  [Aml.Engine.Services.Interfaces][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
CAEXDocument LoadOrGetReferencedDocument(
	ExternalReferenceType externalReference
)
```

#### Parameters

##### *externalReference*
Type: [Aml.Engine.CAEX.ExternalReferenceType][3]  
the external reference

#### Return Value
Type: [CAEXDocument][4]  
 If the ExternalReference doesn't have an alias, the document is not loaded. If a referenced document for the alias already exists, the existing document is returned. 

See Also
--------

#### Reference
[IExternalReferenceResolver Interface][5]  
[Aml.Engine.Services.Interfaces Namespace][2]  

[1]: ../IMerge/README.md
[2]: ../README.md
[3]: ../../Aml.Engine.CAEX/ExternalReferenceType/README.md
[4]: ../../Aml.Engine.CAEX/CAEXDocument/README.md
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png