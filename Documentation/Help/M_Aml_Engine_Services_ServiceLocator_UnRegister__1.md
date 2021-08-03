# ServiceLocator.UnRegister(*T*) Method 
AutomationML 2.1 API 

Unregisters a service of this type which will afterwards no more locatable

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static IAMLService UnRegister<T>()
where T : IAMLService

```

**VB**<br />
``` VB
Public Shared Function UnRegister(Of T As IAMLService) As IAMLService
```

**C++**<br />
``` C++
public:
generic<typename T>
where T : IAMLService
static IAMLService^ UnRegister()
```


#### Type Parameters
&nbsp;<dl><dt>T</dt><dd /></dl>

#### Return Value
Type: <a href="T_Aml_Engine_Services_Interfaces_IAMLService">IAMLService</a><br />\[Missing <returns> documentation for "M:Aml.Engine.Services.ServiceLocator.UnRegister``1"\]

## See Also


#### Reference
<a href="T_Aml_Engine_Services_ServiceLocator">ServiceLocator Class</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />