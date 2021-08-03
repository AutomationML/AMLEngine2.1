SplitService.SplitPoints Method
===============================
AutomationML 2.1 APIGets a collection of all split points for the provided document.

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine.Services (in AML.Engine.Services.dll)

Syntax
------

```csharp
public IEnumerable<ISplitPoint> SplitPoints(
	CAEXDocument document
)
```

#### Parameters

##### *document*
Type: [Aml.Engine.CAEX.CAEXDocument][2]  
The document.

#### Return Value
Type: [IEnumerable][3]&lt;[ISplitPoint][4]>  
 all split points for this document. 
#### Implements
[ISplit.SplitPoints(CAEXDocument)][5]  


See Also
--------

#### Reference
[SplitService Class][6]  
[Aml.Engine.Services Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXDocument/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[4]: ../../Aml.Engine.Services.Interfaces/ISplitPoint/README.md
[5]: ../../Aml.Engine.Services.Interfaces/ISplit/SplitPoints.md
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png