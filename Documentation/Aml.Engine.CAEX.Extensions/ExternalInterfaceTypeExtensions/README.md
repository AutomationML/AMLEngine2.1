ExternalInterfaceTypeExtensions Class
=====================================
AutomationML 2.1 APIExtension methods for the CAEX element "ExternalInterface"


Inheritance Hierarchy
---------------------
[System.Object][1]  
  **Aml.Engine.CAEX.Extensions.ExternalInterfaceTypeExtensions**  

  **Namespace:**  [Aml.Engine.CAEX.Extensions][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static class ExternalInterfaceTypeExtensions
```

The **ExternalInterfaceTypeExtensions** type exposes the following members.


Methods
-------

                                 | Name                                           | Description                                                                                                                                                                                                                                                                                                        
-------------------------------- | ---------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ 
![Public method]![Static member] | [IsMaster][3]                                  | Determines whether the specified ExternalInterface is referenced by other ExternalInterface objects called 'Mirrors'.                                                                                                                                                                                              
![Public method]![Static member] | [IsRelated][4]                                 | Determines whether the specified ExternalInterface is related to other ExternalInterfaces using InternalLinks.                                                                                                                                                                                                     
![Public method]![Static member] | [OfInterfaceClass][5]                          | Gets all ExternalInterface objects from the specified *objectWithExternalInterface*, which are derived from an InterfaceClass, identified with the given *interfaceClassPath*.                                                                                                                                     
![Public method]![Static member] | [RelatedExternalInterfaces][6]                 | Gets the related external interfaces of the specified ExternalInterface connected with InternalLinks. Either the [AInterface][7] or the [BInterface][8] of the InternalLink is equal to the specified ExternalInterface.                                                                                           
![Public method]![Static member] | [RelatedInstances][9]                          | Gets the related instances (SystemUnitClass or InternalElement) of the specified ExternalInterface connected with InternalLinks. Either the [AInterface][7] or the [BInterface][8] of the InternalLink is equal to the specified ExternalInterface.                                                                
![Public method]![Static member] | [RelatedInternalElementsWithRoleReference][10] | Gets the related InternalElements of the specified ExternalInterface connected with InternalLinks, which have a role reference to the provided *roleClassPath*. Inheritance is considered here. Either the [AInterface][7] or the [BInterface][8] of the InternalLink is equal to the specified ExternalInterface. 


See Also
--------

#### Reference
[Aml.Engine.CAEX.Extensions Namespace][2]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../README.md
[3]: IsMaster.md
[4]: IsRelated.md
[5]: OfInterfaceClass.md
[6]: RelatedExternalInterfaces.md
[7]: ../../Aml.Engine.CAEX/InternalLinkType/AInterface.md
[8]: ../../Aml.Engine.CAEX/InternalLinkType/BInterface.md
[9]: RelatedInstances.md
[10]: RelatedInternalElementsWithRoleReference.md
[11]: https://www.automationml.org
[12]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Static member]: ../../icons/static.gif "Static member"