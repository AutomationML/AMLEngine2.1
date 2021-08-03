SplitService.Split Method (CAEXDocument, ISplitPoint, String, String)
=====================================================================
AutomationML 2.1 APISplits the specified source document.

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine.Services (in AML.Engine.Services.dll)

Syntax
------

```csharp
public CAEXDocument Split(
	CAEXDocument sourceDocument,
	ISplitPoint splitPoint,
	string alias,
	string filePath
)
```

#### Parameters

##### *sourceDocument*
Type: [Aml.Engine.CAEX.CAEXDocument][2]  
The source document.

##### *splitPoint*
Type: [Aml.Engine.Services.Interfaces.ISplitPoint][3]  
The split point.

##### *alias*
Type: [System.String][4]  
The alias.

##### *filePath*
Type: [System.String][4]  
The file path.

#### Return Value
Type: [CAEXDocument][2]  

[Missing &lt;returns> documentation for "M:Aml.Engine.Services.SplitService.Split(Aml.Engine.CAEX.CAEXDocument,Aml.Engine.Services.Interfaces.ISplitPoint,System.String,System.String)"]

#### Implements
[ISplit.Split(CAEXDocument, ISplitPoint, String, String)][5]  


Exceptions
----------

Exception                  | Condition                             
-------------------------- | ------------------------------------- 
[ArgumentNullException][6] | sourceDocument or alias or filePath   
[ArgumentException][7]     | File path is equal to source document 


See Also
--------

#### Reference
[SplitService Class][8]  
[Aml.Engine.Services Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXDocument/README.md
[3]: ../../Aml.Engine.Services.Interfaces/ISplitPoint/README.md
[4]: https://docs.microsoft.com/dotnet/api/system.string
[5]: ../../Aml.Engine.Services.Interfaces/ISplit/Split.md
[6]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[7]: https://docs.microsoft.com/dotnet/api/system.argumentexception
[8]: README.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png