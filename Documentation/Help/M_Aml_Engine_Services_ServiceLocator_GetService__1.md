# ServiceLocator.GetService(*T*) Method 
AutomationML 2.1 API 

Gets a service for the provided service interface

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static T GetService<T>()
where T : IAMLService

```

**VB**<br />
``` VB
Public Shared Function GetService(Of T As IAMLService) As T
```

**C++**<br />
``` C++
public:
generic<typename T>
where T : IAMLService
static T GetService()
```


#### Type Parameters
&nbsp;<dl><dt>T</dt><dd /></dl>

#### Return Value
Type: *T*<br />The located service.

## See Also


#### Reference
<a href="T_Aml_Engine_Services_ServiceLocator">ServiceLocator Class</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />