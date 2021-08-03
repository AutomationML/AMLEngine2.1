UpdateEventArgs Class
=====================
Event arguments used to inform about update events in the [IAutoUpdate][1] service.


Inheritance Hierarchy
---------------------
[System.Object][2]  
  [System.EventArgs][3]  
    **Aml.Engine.Services.Interfaces.UpdateEventArgs**  

  **Namespace:**  [Aml.Engine.Services.Interfaces][4]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public class UpdateEventArgs : EventArgs
```

The **UpdateEventArgs** type exposes the following members.


Constructors
------------

                 | Name                                               | Description                                                  
---------------- | -------------------------------------------------- | ------------------------------------------------------------ 
![Public method] | [UpdateEventArgs(XElement, XAttribute)][5]         | Initializes a new instance of the **UpdateEventArgs** class. 
![Public method] | [UpdateEventArgs(XElement, XAttribute, String)][6] | Initializes a new instance of the **UpdateEventArgs** class. 


Properties
----------

                   | Name                   | Description                                                                                          
------------------ | ---------------------- | ---------------------------------------------------------------------------------------------------- 
![Public property] | [Reference][7]         | Gets the updated reference.                                                                          
![Public property] | [ReferencedElement][8] | Gets the referenced element which is triggered by the update                                         
![Public property] | [UpdateValue][9]       | Gets the updated new value (used in changing event notifications, if the reference has not updated). 


See Also
--------

#### Reference
[Aml.Engine.Services.Interfaces Namespace][4]  
[System.EventArgs][3]  

[1]: ../IAutoUpdate/README.md
[2]: https://docs.microsoft.com/dotnet/api/system.object
[3]: https://docs.microsoft.com/dotnet/api/system.eventargs
[4]: ../README.md
[5]: _ctor.md
[6]: _ctor_1.md
[7]: Reference.md
[8]: ReferencedElement.md
[9]: UpdateValue.md
[10]: https://www.automationml.org
[11]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public property]: ../../icons/pubproperty.gif "Public property"