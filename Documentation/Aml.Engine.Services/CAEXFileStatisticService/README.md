CAEXFileStatisticService Class
==============================
AutomationML 2.1 APIThis service calculates statistics for a CAEX document.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  **Aml.Engine.Services.CAEXFileStatisticService**  

  **Namespace:**  [Aml.Engine.Services][2]  
  **Assembly:**  AML.Engine.Services (in AML.Engine.Services.dll)

Syntax
------

```csharp
public class CAEXFileStatisticService : IStatistic, 
	IAMLService
```

The **CAEXFileStatisticService** type exposes the following members.


Constructors
------------

                 | Name                          | Description                                                          
---------------- | ----------------------------- | -------------------------------------------------------------------- 
![Public method] | [CAEXFileStatisticService][3] | Initializes a new instance of the **CAEXFileStatisticService** class 


Methods
-------

                                 | Name                                    | Description                                                                                              
-------------------------------- | --------------------------------------- | -------------------------------------------------------------------------------------------------------- 
![Public method]                 | [NumberOfAllObjects][4]                 | Counts all objects (sum of all others with specific counts) and returns the result.                      
![Public method]                 | [NumberOfAttributes][5]                 | Counts all Attribute objects and returns the result.                                                     
![Public method]                 | [NumberOfAttributeTypeReferences][6]    | Counts all Attribute type reference objects and returns the result.                                      
![Public method]                 | [NumberOfAttributeTypes][7]             | Counts all AttributeType objects and returns the result.                                                 
![Public method]                 | [NumberOfInterfaceClasses][8]           | Counts all InterfaceClass objects and returns the result.                                                
![Public method]                 | [NumberOfInterfaceInstances][9]         | Counts all ExternalInterface objects and returns the result.                                             
![Public method]                 | [NumberOfInternalElements][10]          | Counts all InternalElement objects and returns the result.                                               
![Public method]                 | [NumberOfLinks][11]                     | Counts all InternalLink objects and returns the result.                                                  
![Public method]                 | [NumberOfRoleClasses][12]               | Counts all RoleClass objects and returns the result.                                                     
![Public method]                 | [NumberOfRoleClassReferences][13]       | Counts all RoleClass reference (RoleRequirements and SupportedRoleClass) objects and returns the result. 
![Public method]                 | [NumberOfSystemUnitClasses][14]         | Counts all SystemUnitClass objects and returns the result.                                               
![Public method]                 | [NumberOfSystemUnitClassReferences][15] | Counts all SystemUnitClass reference objects and returns the result.                                     
![Public method]![Static member] | [Register][16]                          | Registers a new instance of a CAEXFileStatisticService with the [ServiceLocator][17] of the AMLEngine.   
![Public method]![Static member] | [UnRegister][18]                        | Unregisters this service                                                                                 


See Also
--------

#### Reference
[Aml.Engine.Services Namespace][2]  
[Aml.Engine.Services.Interfaces.IStatistic][19]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../README.md
[3]: _ctor.md
[4]: NumberOfAllObjects.md
[5]: NumberOfAttributes.md
[6]: NumberOfAttributeTypeReferences.md
[7]: NumberOfAttributeTypes.md
[8]: NumberOfInterfaceClasses.md
[9]: NumberOfInterfaceInstances.md
[10]: NumberOfInternalElements.md
[11]: NumberOfLinks.md
[12]: NumberOfRoleClasses.md
[13]: NumberOfRoleClassReferences.md
[14]: NumberOfSystemUnitClasses.md
[15]: NumberOfSystemUnitClassReferences.md
[16]: Register.md
[17]: ../ServiceLocator/README.md
[18]: UnRegister.md
[19]: ../../Aml.Engine.Services.Interfaces/IStatistic/README.md
[20]: https://www.automationml.org
[21]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Static member]: ../../icons/static.gif "Static member"