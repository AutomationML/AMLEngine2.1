IAutoUpdate Interface
=====================
Interface defined for services, which support automatic updates of cross references between AutomationML objects. Updates are executed, when a referenced object changes its identification (its Name or its ID).

  **Namespace:**  [Aml.Engine.Services.Interfaces][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public interface IAutoUpdate : IAMLService
```

The **IAutoUpdate** type exposes the following members.


Properties
----------

                   | Name                     | Description                                                                                                                    
------------------ | ------------------------ | ------------------------------------------------------------------------------------------------------------------------------ 
![Public property] | [IsAutoUpdateEnabled][2] | Gets or sets a value indicating whether this instance will automatically update cross references between AutomationML objects. 


Events
------

                | Name                  | Description                                 
--------------- | --------------------- | ------------------------------------------- 
![Public event] | [ReferenceUpdated][3] | Occurs when any reference has been updated. 


See Also
--------

#### Reference
[Aml.Engine.Services.Interfaces Namespace][1]  

[1]: ../README.md
[2]: IsAutoUpdateEnabled.md
[3]: ReferenceUpdated.md
[4]: https://www.automationml.org
[5]: ../../icons/logoShade.png
[Public property]: ../../icons/pubproperty.gif "Public property"
[Public event]: ../../icons/pubevent.gif "Public event"