IExternalReferenceResolver.LoadOrGetReferencedDocument Method (CAEXDocument, String)
====================================================================================
AutomationML 2.1 APIDetermines, if the provided path contains an alias and gets the resolved document for that alias if it is already resolved. If the reference has not been resolved it is resolved.

  **Namespace:**  [Aml.Engine.Services.Interfaces][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
CAEXDocument LoadOrGetReferencedDocument(
	CAEXDocument document,
	string path
)
```

#### Parameters

##### *document*
Type: [Aml.Engine.CAEX.CAEXDocument][2]  
The CAEX document.

##### *path*
Type: [System.String][3]  
The path.

#### Return Value
Type: [CAEXDocument][2]  
 the resolved document for the alias, extracted from the path. 

See Also
--------

#### Reference
[IExternalReferenceResolver Interface][4]  
[Aml.Engine.Services.Interfaces Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXDocument/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png