ExternalInterfaceTypeExtensions Class
=====================================
Extension methods for the CAEX element "ExternalInterface"


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
-------------------------------- | ---------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method]![Static member] | [IsMaster][3]                                  | Determines whether the specified ExternalInterface is referenced by other ExternalInterface objects called 'Mirrors'.                                                                                                                                                                                               
![Public method]![Static member] | [IsOverridden][4]                              | Determines whether this instance is overridden.                                                                                                                                                                                                                                                                     
![Public method]![Static member] | [IsOverriddenDeleted][5]                       | Determines whether this instance is overridden and deleted.                                                                                                                                                                                                                                                         
![Public method]![Static member] | [IsRelated][6]                                 | Determines whether the specified ExternalInterface is related to other ExternalInterfaces using InternalLinks.                                                                                                                                                                                                      
![Public method]![Static member] | [OfInterfaceClass][7]                          | Gets all ExternalInterface objects from the specified *objectWithExternalInterface*, which are derived from an InterfaceClass, identified with the given *interfaceClassPath*.                                                                                                                                      
![Public method]![Static member] | [RelatedExternalInterfaces][8]                 | Gets the related external interfaces of the specified ExternalInterface connected with InternalLinks. Either the [AInterface][9] or the [BInterface][10] of the InternalLink is equal to the specified ExternalInterface.                                                                                           
![Public method]![Static member] | [RelatedInstances][11]                         | Gets the related instances (SystemUnitClass or InternalElement) of the specified ExternalInterface connected with InternalLinks. Either the [AInterface][9] or the [BInterface][10] of the InternalLink is equal to the specified ExternalInterface.                                                                
![Public method]![Static member] | [RelatedInternalElementsWithRoleReference][12] | Gets the related InternalElements of the specified ExternalInterface connected with InternalLinks, which have a role reference to the provided *roleClassPath*. Inheritance is considered here. Either the [AInterface][9] or the [BInterface][10] of the InternalLink is equal to the specified ExternalInterface. 


See Also
--------

#### Reference
[Aml.Engine.CAEX.Extensions Namespace][2]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../README.md
[3]: IsMaster.md
[4]: IsOverridden.md
[5]: IsOverriddenDeleted.md
[6]: IsRelated.md
[7]: OfInterfaceClass.md
[8]: RelatedExternalInterfaces.md
[9]: ../../Aml.Engine.CAEX/InternalLinkType/AInterface.md
[10]: ../../Aml.Engine.CAEX/InternalLinkType/BInterface.md
[11]: RelatedInstances.md
[12]: RelatedInternalElementsWithRoleReference.md
[13]: https://www.automationml.org
[14]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Static member]: ../../icons/static.gif "Static member"