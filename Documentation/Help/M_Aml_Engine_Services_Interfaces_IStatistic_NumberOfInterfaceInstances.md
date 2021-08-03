# IStatistic.NumberOfInterfaceInstances Method 
AutomationML 2.1 API 

Counts all ExternalInterface objects and returns the result.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
int NumberOfInterfaceInstances(
	CAEXFileType caexFile
)
```

**VB**<br />
``` VB
Function NumberOfInterfaceInstances ( 
	caexFile As CAEXFileType
) As Integer
```

**C++**<br />
``` C++
int NumberOfInterfaceInstances(
	CAEXFileType^ caexFile
)
```


#### Parameters
&nbsp;<dl><dt>caexFile</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXFileType">Aml.Engine.CAEX.CAEXFileType</a><br />The CAEX file.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.int32" target="_parent" rel="noopener noreferrer">Int32</a><br />Total number of all ExternalInterfaces

## See Also


#### Reference
<a href="T_Aml_Engine_Services_Interfaces_IStatistic">IStatistic Interface</a><br /><a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces Namespace</a><br />