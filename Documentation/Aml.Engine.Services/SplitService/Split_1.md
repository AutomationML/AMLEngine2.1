SplitService.Split Method (CAEXDocument, String, String)
========================================================
AutomationML 2.1 APISplits the specified document on all currently defined split points. The created libraries are saved in an AutomationML document and an ExternalReference is created, using the specified alias. All remaining references to the external source are renamed using the provided alias. After splitting, the document doesn't contain any SplitPoints any more.

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine.Services (in AML.Engine.Services.dll)

Syntax
------

```csharp
public CAEXDocument Split(
	CAEXDocument sourceDocument,
	string alias,
	string filePath
)
```

#### Parameters

##### *sourceDocument*
Type: [Aml.Engine.CAEX.CAEXDocument][2]  
The document.

##### *alias*
Type: [System.String][3]  
The alias.

##### *filePath*
Type: [System.String][3]  
The file path.

#### Return Value
Type: [CAEXDocument][2]  
The Split document
#### Implements
[ISplit.Split(CAEXDocument, String, String)][4]  


Exceptions
----------

Exception                  | Condition                             
-------------------------- | ------------------------------------- 
[ArgumentNullException][5] | document or alias or filePath         
[ArgumentException][6]     | File path is equal to source document 


See Also
--------

#### Reference
[SplitService Class][7]  
[Aml.Engine.Services Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXDocument/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: ../../Aml.Engine.Services.Interfaces/ISplit/Split_1.md
[5]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[6]: https://docs.microsoft.com/dotnet/api/system.argumentexception
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png