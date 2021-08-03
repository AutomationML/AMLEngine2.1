# CAEXFileStatisticService.NumberOfAllObjects Method 
AutomationML 2.1 API 

Counts all objects (sum of all others with specific counts) and returns the result.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine.Services (in AML.Engine.Services.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public int NumberOfAllObjects(
	CAEXFileType caexFile
)
```

**VB**<br />
``` VB
Public Function NumberOfAllObjects ( 
	caexFile As CAEXFileType
) As Integer
```

**C++**<br />
``` C++
public:
virtual int NumberOfAllObjects(
	CAEXFileType^ caexFile
) sealed
```


#### Parameters
&nbsp;<dl><dt>caexFile</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXFileType">Aml.Engine.CAEX.CAEXFileType</a><br />The CAEX file.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.int32" target="_parent" rel="noopener noreferrer">Int32</a><br />Total number of all countable objects.

#### Implements
<a href="M_Aml_Engine_Services_Interfaces_IStatistic_NumberOfAllObjects">IStatistic.NumberOfAllObjects(CAEXFileType)</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_Services_CAEXFileStatisticService">CAEXFileStatisticService Class</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />