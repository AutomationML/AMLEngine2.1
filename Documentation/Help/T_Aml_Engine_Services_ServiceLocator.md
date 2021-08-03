# ServiceLocator Class
AutomationML 2.1 API 

This class provides methods to register and locate services which can support the processing of AML documents. There can always exist only one service of the same type at one time. The available service types are recognized to be assignable to the <a href="T_Aml_Engine_Services_Interfaces_IAMLService">IAMLService</a> interface.


## Inheritance Hierarchy
<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_parent" rel="noopener noreferrer">System.Object</a><br />&nbsp;&nbsp;Aml.Engine.Services.ServiceLocator<br />
**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static class ServiceLocator
```

**VB**<br />
``` VB
Public NotInheritable Class ServiceLocator
```

**C++**<br />
``` C++
public ref class ServiceLocator abstract sealed
```

The ServiceLocator type exposes the following members.


## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Static member](media/static.gif "Static member")</td><td><a href="P_Aml_Engine_Services_ServiceLocator_AutoUpdateService">AutoUpdateService</a></td><td>
Gets the automatic update service.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Static member](media/static.gif "Static member")</td><td><a href="P_Aml_Engine_Services_ServiceLocator_QueryService">QueryService</a></td><td>
Gets the registered Query-Service. If no Query-Service is registered, a default Query-Service - which is based on LinqToXml - is returned. As an alternative, a Query-Service based on Dictionaries for keyed access is available. The dictionary based service has to be registered to be used. If no such service has been registered, the default query service is returned. The actual registered Query-Service is located by the engine and used for all queries.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Static member](media/static.gif "Static member")</td><td><a href="P_Aml_Engine_Services_ServiceLocator_UndoRedoService">UndoRedoService</a></td><td>
Gets the registered UndoRedo-Service. The actual registered UndoRedo-Service is located by the engine and used to push executed commands on the undo stack. If no UndoRedo-Service is registered executed commands are not pushed and cannot be undone.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Static member](media/static.gif "Static member")</td><td><a href="P_Aml_Engine_Services_ServiceLocator_UniqueNameService">UniqueNameService</a></td><td>
Gets the registered UniqueName-Service.The actual registered UniqueName-Service is located by the engine to automatically assign unique names to CAEXObjects if they are inserted into a sequence. If no UniqueName-Service is registered no names are generated.</td></tr></table>&nbsp;
<a href="#servicelocator-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_ServiceLocator_GetService__1">GetService(T)</a></td><td>
Gets a service for the provided service interface</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_ServiceLocator_Register__1">Register(T)</a></td><td>
Registers a service which will be locatable</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_ServiceLocator_UnRegister__1">UnRegister(T)</a></td><td>
Unregisters a service of this type which will afterwards no more locatable</td></tr></table>&nbsp;
<a href="#servicelocator-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />