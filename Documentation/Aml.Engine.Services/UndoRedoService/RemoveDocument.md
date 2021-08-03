UndoRedoService.RemoveDocument Method
=====================================
Removes the XML document from the internal registry of the service. Undo- and Redo Stacks for this document will be deleted.

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine.Services (in AML.Engine.Services.dll)

Syntax
------

```csharp
public void RemoveDocument(
	XDocumentWrapper doc
)
```

#### Parameters

##### *doc*
Type: [Aml.Engine.XML.XDocumentWrapper][2]  
The document.

#### Implements
[IXMLDocumentRegistry.RemoveDocument(XDocumentWrapper)][3]  


See Also
--------

#### Reference
[UndoRedoService Class][4]  
[Aml.Engine.Services Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.XML/XDocumentWrapper/README.md
[3]: ../../Aml.Engine.Services.Interfaces/IXMLDocumentRegistry/RemoveDocument.md
[4]: README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png