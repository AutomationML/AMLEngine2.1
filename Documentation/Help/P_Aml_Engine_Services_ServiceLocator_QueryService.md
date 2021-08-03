# ServiceLocator.QueryService Property 
AutomationML 2.1 API 

Gets the registered Query-Service. If no Query-Service is registered, a default Query-Service - which is based on LinqToXml - is returned. As an alternative, a Query-Service based on Dictionaries for keyed access is available. The dictionary based service has to be registered to be used. If no such service has been registered, the default query service is returned. The actual registered Query-Service is located by the engine and used for all queries.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static IQuery QueryService { get; }
```

**VB**<br />
``` VB
Public Shared ReadOnly Property QueryService As IQuery
	Get
```

**C++**<br />
``` C++
public:
static property IQuery^ QueryService {
	IQuery^ get ();
}
```


#### Property Value
Type: <a href="T_Aml_Engine_Services_Interfaces_IQuery">IQuery</a>

## See Also


#### Reference
<a href="T_Aml_Engine_Services_ServiceLocator">ServiceLocator Class</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />