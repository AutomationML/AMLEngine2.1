ISchemaTransform.TransformTo Method
===================================
AutomationML 2.1 APIMethod to do a schema transformation for the provided document to the defined schema. This method can be used for upward and downward transformations.

  **Namespace:**  [Aml.Engine.Services.Interfaces][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
CAEXDocument TransformTo(
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

See Also
--------

#### Reference
[ISchemaTransform Interface][4]  
[Aml.Engine.Services.Interfaces Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXDocument/README.md
[3]: ../../Aml.Engine.CAEX/CAEXDocument_CAEXSchema/README.md
[4]: README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png