IStatistic Interface
====================
This service interface is used to get statistic data from a CAEX document.

  **Namespace:**  [Aml.Engine.Services.Interfaces][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public interface IStatistic : IAMLService
```

The **IStatistic** type exposes the following members.


Methods
-------

                 | Name                                    | Description                                                                         
---------------- | --------------------------------------- | ----------------------------------------------------------------------------------- 
![Public method] | [NumberOfAllObjects][2]                 | Counts all objects (sum of all others with specific counts) and returns the result. 
![Public method] | [NumberOfAttributes][3]                 | Counts all Attribute objects and returns the result.                                
![Public method] | [NumberOfAttributeTypeReferences][4]    | Counts all AttributeType reference objects and returns the result.                  
![Public method] | [NumberOfAttributeTypes][5]             | Counts all AttributeType objects and returns the result.                            
![Public method] | [NumberOfInterfaceClasses][6]           | Counts all InterfaceClass objects and returns the result.                           
![Public method] | [NumberOfInterfaceInstances][7]         | Counts all ExternalInterface objects and returns the result.                        
![Public method] | [NumberOfInternalElements][8]           | Counts all InternalElement objects and returns the result.                          
![Public method] | [NumberOfLinks][9]                      | Counts all InternalLink objects and returns the result.                             
![Public method] | [NumberOfRoleClasses][10]               | Counts all RoleClass objects and returns the result.                                
![Public method] | [NumberOfRoleClassReferences][11]       | Counts all RoleClass reference objects and returns the result.                      
![Public method] | [NumberOfSystemUnitClasses][12]         | Counts all SystemUnitClass objects and returns the result.                          
![Public method] | [NumberOfSystemUnitClassReferences][13] | Counts all SystemUnitClass reference objects and returns the result.                


See Also
--------

#### Reference
[Aml.Engine.Services.Interfaces Namespace][1]  
[Aml.Engine.Services.Interfaces.IAMLService][14]  

[1]: ../README.md
[2]: NumberOfAllObjects.md
[3]: NumberOfAttributes.md
[4]: NumberOfAttributeTypeReferences.md
[5]: NumberOfAttributeTypes.md
[6]: NumberOfInterfaceClasses.md
[7]: NumberOfInterfaceInstances.md
[8]: NumberOfInternalElements.md
[9]: NumberOfLinks.md
[10]: NumberOfRoleClasses.md
[11]: NumberOfRoleClassReferences.md
[12]: NumberOfSystemUnitClasses.md
[13]: NumberOfSystemUnitClassReferences.md
[14]: ../IAMLService/README.md
[15]: https://www.automationml.org
[16]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"