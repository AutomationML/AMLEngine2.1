IUniqueName Interface
=====================
AutomationML 2.1 APIThis interface defines methods for a unique name service. The names of CAEX objects in a sequence of elements should all be unique. If a unique name service is registered, the AML Engine will automatically call this service for a unique name generation whenever a new element is added to the sequence which requires a unique name for its members.

  **Namespace:**  [Aml.Engine.Services.Interfaces][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public interface IUniqueName : IAMLService
```

The **IUniqueName** type exposes the following members.


Methods
-------

                 | Name                                          | Description                                                                                                                        
---------------- | --------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------- 
![Public method] | [IsUniqueCAEXName][2]                         | Determines whether the specified element has a unique CAEX name in the sequence of equal elements of its parent.                   
![Public method] | [RegisterDefault][3]                          | Registers a new default name for the generation of unique names for the specified element.                                         
![Public method] | [Resume][4]                                   | Resumes activities of the unique name service.                                                                                     
![Public method] | [Suspend][5]                                  | Suspends activities of the unique name service.                                                                                    
![Public method] | [UniqueCAEXName(XElement, String)][6]         | Creates a unique CAEX Name for a child with the specified elementTagName in the specified sequence                                 
![Public method] | [UniqueCAEXName(XElement, String, String)][7] | Creates a unique CAEX Name for a child with the specified elementTagName in the specified sequence using the specified defaultName 


See Also
--------

#### Reference
[Aml.Engine.Services.Interfaces Namespace][1]  
[Aml.Engine.Services.Interfaces.IAMLService][8]  

[1]: ../README.md
[2]: IsUniqueCAEXName.md
[3]: RegisterDefault.md
[4]: Resume.md
[5]: Suspend.md
[6]: UniqueCAEXName.md
[7]: UniqueCAEXName_1.md
[8]: ../IAMLService/README.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"