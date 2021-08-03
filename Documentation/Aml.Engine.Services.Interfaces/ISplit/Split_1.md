ISplit.Split Method (CAEXDocument, String, String)
==================================================
AutomationML 2.1 APISplits the specified document on all currently defined split points. The created libraries are saved in an AutomationML document and an ExternalReference is created, using the specified alias. All remaining references to the external source are renamed using the provided alias. After splitting, the document doesn't contain any SplitPoints any more.

  **Namespace:**  [Aml.Engine.Services.Interfaces][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
CAEXDocument Split(
	CAEXDocument document,
	string alias,
	string filePath
)
```

#### Parameters

##### *document*
Type: [Aml.Engine.CAEX.CAEXDocument][2]  
The document.

##### *alias*
Type: [System.String][3]  
The alias name used to define the ExternalReference.

##### *filePath*
Type: [System.String][3]  
The file path to the saved Split parts.

#### Return Value
Type: [CAEXDocument][2]  
The CAEX document containing the split parts. 

See Also
--------

#### Reference
[ISplit Interface][4]  
[Aml.Engine.Services.Interfaces Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXDocument/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png