CAEXFileStatisticService.NumberOfAllObjects Method
==================================================
AutomationML 2.1 APICounts all objects (sum of all others with specific counts) and returns the result.

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine.Services (in AML.Engine.Services.dll)

Syntax
------

```csharp
public int NumberOfAllObjects(
	CAEXFileType caexFile
)
```

#### Parameters

##### *caexFile*
Type: [Aml.Engine.CAEX.CAEXFileType][2]  
The CAEX file.

#### Return Value
Type: [Int32][3]  
Total number of all countable objects.
#### Implements
[IStatistic.NumberOfAllObjects(CAEXFileType)][4]  


See Also
--------

#### Reference
[CAEXFileStatisticService Class][5]  
[Aml.Engine.Services Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXFileType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.int32
[4]: ../../Aml.Engine.Services.Interfaces/IStatistic/NumberOfAllObjects.md
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png