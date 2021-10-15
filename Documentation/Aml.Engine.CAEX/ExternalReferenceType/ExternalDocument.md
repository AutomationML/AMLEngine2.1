ExternalReferenceType.ExternalDocument Property
===============================================
Gets the external document referenced by this instance. To get the document, a [IExternalReferenceResolver][1] has to be registered. If no such service exists, the value is `null`.

  **Namespace:**  [Aml.Engine.CAEX][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public CAEXDocument ExternalDocument { get; }
```

#### Property Value
Type: [CAEXDocument][3]  
 The external document if a [ExternalReferenceResolverService][4] exists; otherwise `null`. 

See Also
--------

#### Reference
[ExternalReferenceType Class][5]  
[Aml.Engine.CAEX Namespace][2]  

[1]: ../../Aml.Engine.Services.Interfaces/IExternalReferenceResolver/README.md
[2]: ../README.md
[3]: ../CAEXDocument/README.md
[4]: ../../Aml.Engine.Services/ServiceLocator/ExternalReferenceResolverService.md
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png