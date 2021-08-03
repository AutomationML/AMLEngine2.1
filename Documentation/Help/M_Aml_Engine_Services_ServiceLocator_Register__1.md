# ServiceLocator.Register(*T*) Method 
AutomationML 2.1 API 

Registers a service which will be locatable

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static void Register<T>(
	T service
)
where T : IAMLService

```

**VB**<br />
``` VB
Public Shared Sub Register(Of T As IAMLService) ( 
	service As T
)
```

**C++**<br />
``` C++
public:
generic<typename T>
where T : IAMLService
static void Register(
	T service
)
```


#### Parameters
&nbsp;<dl><dt>service</dt><dd>Type: *T*<br />The service.</dd></dl>

#### Type Parameters
&nbsp;<dl><dt>T</dt><dd>The service type.</dd></dl>

## See Also


#### Reference
<a href="T_Aml_Engine_Services_ServiceLocator">ServiceLocator Class</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />