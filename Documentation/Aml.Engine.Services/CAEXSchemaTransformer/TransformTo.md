CAEXSchemaTransformer.TransformTo Method
========================================
Method to do a schema transformation for the provided document to the defined schema. This method can be used for upward and downward transformations.

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine.Services (in AML.Engine.Services.dll)

Syntax
------

```csharp
public CAEXDocument TransformTo(
	CAEXDocument document,
	CAEXDocument.CAEXSchema targetSchema
)
```

#### Parameters

##### *document*
Type: [Aml.Engine.CAEX.CAEXDocument][2]  
the document to be transformed

##### *targetSchema*
Type: [Aml.Engine.CAEX.CAEXDocument.CAEXSchema][3]  
the target schema

#### Return Value
Type: [CAEXDocument][2]  
the transformed document
#### Implements
[ISchemaTransform.TransformTo(CAEXDocument, CAEXDocument.CAEXSchema)][4]  


See Also
--------

#### Reference
[CAEXSchemaTransformer Class][5]  
[Aml.Engine.Services Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXDocument/README.md
[3]: ../../Aml.Engine.CAEX/CAEXDocument_CAEXSchema/README.md
[4]: ../../Aml.Engine.Services.Interfaces/ISchemaTransform/TransformTo.md
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png