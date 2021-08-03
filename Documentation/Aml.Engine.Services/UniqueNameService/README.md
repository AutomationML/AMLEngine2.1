UniqueNameService Class
=======================
AutomationML 2.1 APIThis class defines methods for a unique name service. The names of CAEX-Objects in a Sequence of Elements should all be unique. If a unique name service is registered, the AMLEngine will automatically call this service for a unique name generation whenever a new element is added to a sequence which requires a unique name for its members. This services uses a generation pattern which consists of the specified default name followed by a generated ordinal number of the elements in a sequence.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  **Aml.Engine.Services.UniqueNameService**  

  **Namespace:**  [Aml.Engine.Services][2]  
  **Assembly:**  AML.Engine.Services (in AML.Engine.Services.dll)

Syntax
------

```csharp
public class UniqueNameService : IUniqueName, 
	IAMLService
```

The **UniqueNameService** type exposes the following members.


Methods
-------

                                 | Name                                           | Description                                                                                                                        
-------------------------------- | ---------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------- 
![Public method]                 | [IsUniqueCAEXName][3]                          | Determines whether the specified element has a unique CAEX name in the sequence of equal elements of its parent.                   
![Public method]![Static member] | [Register][4]                                  | Registers a new instance of a UniqueNameService with the [ServiceLocator][5] of the AMLEngine.                                     
![Public method]                 | [RegisterDefault][6]                           | Registers the default name for all CAEX objects with the provided element name.                                                    
![Public method]                 | [Resume][7]                                    | Resumes activities of the unique name service.                                                                                     
![Public method]                 | [Suspend][8]                                   | Suspends activities of the unique name service.                                                                                    
![Public method]                 | [UniqueCAEXName(XElement, String)][9]          | Creates a unique CAEX Name for a child with the specified elementTagName in the specified sequence                                 
![Public method]                 | [UniqueCAEXName(XElement, String, String)][10] | Creates a unique CAEX Name for a child with the specified elementTagName in the specified sequence using the specified defaultName 
![Public method]![Static member] | [UnRegister][11]                               | Unregisters the current instance of the UniqueNameService with the [ServiceLocator][5] of the AMLEngine.                           


See Also
--------

#### Reference
[Aml.Engine.Services Namespace][2]  
[Aml.Engine.Services.Interfaces.IUniqueName][12]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../README.md
[3]: IsUniqueCAEXName.md
[4]: Register.md
[5]: ../ServiceLocator/README.md
[6]: RegisterDefault.md
[7]: Resume.md
[8]: Suspend.md
[9]: UniqueCAEXName.md
[10]: UniqueCAEXName_1.md
[11]: UnRegister.md
[12]: ../../Aml.Engine.Services.Interfaces/IUniqueName/README.md
[13]: https://www.automationml.org
[14]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Static member]: ../../icons/static.gif "Static member"