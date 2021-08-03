ServiceLocator Class
====================
AutomationML 2.1 APIThis class provides methods to register and locate services which can support the processing of AML documents. There can always exist only one service of the same type at one time. The available service types are recognized to be assignable to the [IAMLService][1] interface.


Inheritance Hierarchy
---------------------
[System.Object][2]  
  **Aml.Engine.Services.ServiceLocator**  

  **Namespace:**  [Aml.Engine.Services][3]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static class ServiceLocator
```

The **ServiceLocator** type exposes the following members.


Properties
----------

                                   | Name                   | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                            
---------------------------------- | ---------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public property]![Static member] | [AutoUpdateService][4] | Gets the automatic update service.                                                                                                                                                                                                                                                                                                                                                                                                                                     
![Public property]![Static member] | [QueryService][5]      | Gets the registered Query-Service. If no Query-Service is registered, a default Query-Service - which is based on LinqToXml - is returned. As an alternative, a Query-Service based on Dictionaries for keyed access is available. The dictionary based service has to be registered to be used. If no such service has been registered, the default query service is returned. The actual registered Query-Service is located by the engine and used for all queries. 
![Public property]![Static member] | [UndoRedoService][6]   | Gets the registered UndoRedo-Service. The actual registered UndoRedo-Service is located by the engine and used to push executed commands on the undo stack. If no UndoRedo-Service is registered executed commands are not pushed and cannot be undone.                                                                                                                                                                                                                
![Public property]![Static member] | [UniqueNameService][7] | Gets the registered UniqueName-Service.The actual registered UniqueName-Service is located by the engine to automatically assign unique names to CAEXObjects if they are inserted into a sequence. If no UniqueName-Service is registered no names are generated.                                                                                                                                                                                                      


Methods
-------

                                 | Name                   | Description                                                                
-------------------------------- | ---------------------- | -------------------------------------------------------------------------- 
![Public method]![Static member] | [GetService&lt;T>][8]  | Gets a service for the provided service interface                          
![Public method]![Static member] | [Register&lt;T>][9]    | Registers a service which will be locatable                                
![Public method]![Static member] | [UnRegister&lt;T>][10] | Unregisters a service of this type which will afterwards no more locatable 


See Also
--------

#### Reference
[Aml.Engine.Services Namespace][3]  

[1]: ../../Aml.Engine.Services.Interfaces/IAMLService/README.md
[2]: https://docs.microsoft.com/dotnet/api/system.object
[3]: ../README.md
[4]: AutoUpdateService.md
[5]: QueryService.md
[6]: UndoRedoService.md
[7]: UniqueNameService.md
[8]: GetService__1.md
[9]: Register__1.md
[10]: UnRegister__1.md
[11]: https://www.automationml.org
[12]: ../../icons/logoShade.png
[Public property]: ../../icons/pubproperty.gif "Public property"
[Static member]: ../../icons/static.gif "Static member"
[Public method]: ../../icons/pubmethod.gif "Public method"