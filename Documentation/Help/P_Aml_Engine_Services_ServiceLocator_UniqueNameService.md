# ServiceLocator.UniqueNameService Property 
AutomationML 2.1 API 

Gets the registered UniqueName-Service.The actual registered UniqueName-Service is located by the engine to automatically assign unique names to CAEXObjects if they are inserted into a sequence. If no UniqueName-Service is registered no names are generated.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static IUniqueName UniqueNameService { get; }
```

**VB**<br />
``` VB
Public Shared ReadOnly Property UniqueNameService As IUniqueName
	Get
```

**C++**<br />
``` C++
public:
static property IUniqueName^ UniqueNameService {
	IUniqueName^ get ();
}
```


#### Property Value
Type: <a href="T_Aml_Engine_Services_Interfaces_IUniqueName">IUniqueName</a>

## See Also


#### Reference
<a href="T_Aml_Engine_Services_ServiceLocator">ServiceLocator Class</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />