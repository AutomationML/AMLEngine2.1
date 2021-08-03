ISplit.Split Method (CAEXDocument, ISplitPoint, String, String)
===============================================================
Splits the specified document on only the specified split point. The created library is saved in an AutomationML document and an ExternalReference is created, using the specified alias. All remaining references to the external source are renamed using the provided alias. After splitting, the document doesn't contain this SplitPoints any more.

  **Namespace:**  [Aml.Engine.Services.Interfaces][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
CAEXDocument Split(
	CAEXDocument document,
	ISplitPoint splitPoint,
	string alias,
	string filePath
)
```

#### Parameters

##### *document*
Type: [Aml.Engine.CAEX.CAEXDocument][2]  
The document.

##### *splitPoint*
Type: [Aml.Engine.Services.Interfaces.ISplitPoint][3]  
The split point defining the split content.

##### *alias*
Type: [System.String][4]  
The alias name used to define the ExternalReference.

##### *filePath*
Type: [System.String][4]  
The file path to the saved Split parts.

#### Return Value
Type: [CAEXDocument][2]  
The CAEX document containing the splitted part. 

See Also
--------

#### Reference
[ISplit Interface][5]  
[Aml.Engine.Services.Interfaces Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXDocument/README.md
[3]: ../ISplitPoint/README.md
[4]: https://docs.microsoft.com/dotnet/api/system.string
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png