SystemUnitClassTypeExtensions Class
===================================
AutomationML 2.1 APIExtension methods for the [SystemUnitClassType][1].


Inheritance Hierarchy
---------------------
[System.Object][2]  
  **Aml.Engine.CAEX.Extensions.SystemUnitClassTypeExtensions**  

  **Namespace:**  [Aml.Engine.CAEX.Extensions][3]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static class SystemUnitClassTypeExtensions
```

The **SystemUnitClassTypeExtensions** type exposes the following members.


Methods
-------

                                 | Name                                                                               | Description                                                                                                                                                                                                                                                                                                                                                          
-------------------------------- | ---------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method]![Static member] | [AddInstance][4]                                                                   | Inserts a new class instance to the InternalElement collection of the parentInternalElement. If there are existing instances of the same Type, the Element is inserted after the last Element of that Type. Before Insertion, the Uniqueness of the Name among the siblings of that Type is checked.                                                                 
![Public method]![Static member] | [AddNewInternalElement][5]                                                         | Creates a new InternalElement and inserts it after the last InternalElement of the parent if the elementName is unique among the child's. The ChangeMode is set to the Value 'Create'                                                                                                                                                                                
![Public method]![Static member] | [Ancestors][6]                                                                     | Returns all SystemUnit Classes which are ancestors of this. This SystemUnit Class is included in the enumeration as the first Element, The farthest is the last Element in the enumeration.                                                                                                                                                                          
![Public method]![Static member] | [Append_InternalElement][7]                                                        | **Obsolete.**Inserts the InternalElement object after the defined Predecessor in the InternalElement collection of the SystemUnitClass. If the Predecessor is null, the InternalElement object is inserted at the first position of the InternalElement collection.                                                                                                  
![Public method]![Static member] | [Insert_Attribute][8]                                                              | **Obsolete.**Inserts an Attribute object in the Attribute collection of the *objectWithAttributes*.                                                                                                                                                                                                                                                                  
![Public method]![Static member] | [Insert_ExternalInterface][9]                                                      | **Obsolete.**Inserting an ExternalInterface to the ExternalInterface-Collection of the *objectWithExternalInterface*. The Element is inserted at the first Element of any existing ExternalInterfaces if no other position is defined.                                                                                                                               
![Public method]![Static member] | [Insert_InternalElement][10]                                                       | **Obsolete.**Inserting an InternalElement to the InternalElement-Collection of the *objectWithInternalElements*.                                                                                                                                                                                                                                                     
![Public method]![Static member] | [Insert_InternalLink][11]                                                          | **Obsolete.**Inserts the specified InternalLink as the first InternalLink if nothing else if explicit defined.                                                                                                                                                                                                                                                       
![Public method]![Static member] | [Insert_SupportedRoleClass][12]                                                    | **Obsolete.**Inserts the SupportedRoleClass as the first SupportedRoleClass if nothing else if explicit defined.                                                                                                                                                                                                                                                     
![Public method]![Static member] | [New_ExternalInterface(IObjectWithExternalInterface, String, Boolean)][13]         | Adding a new ExternalInterface instance to the ExternalInterface-Collection of the *objectWithExternalInterface*. The New ExternalInterface is inserted as the first ExternalInterface of any existing Interfaces if nothing else is explicit defined.                                                                                                               
![Public method]![Static member] | [New_ExternalInterface(IObjectWithExternalInterface, String, String, Boolean)][14] | Adding a new ExternalInterface instance to the ExternalInterface-Collection of the *objectWithExternalInterface* referencing a specific InterfaceClass. The New ExternalInterface is inserted as the first ExternalInterface of any existing Interfaces if nothing else is explicit defined. The provided *interfaceClassPath* is set as the RefBaseClassPath value. 
![Public method]![Static member] | [New_InternalElement][15]                                                          | Adding a new InternalElement instance to the InternalElement-Collection of the *elementWithInternalElements*. The New InternalElement is inserted as the first InternalElement of any existing InternalElement objects if nothing else is explicit defined.                                                                                                          
![Public method]![Static member] | [New_InternalLink][16]                                                             | Inserts a new InternalLink as the first InternalLink if nothing else if explicit defined.                                                                                                                                                                                                                                                                            
![Public method]![Static member] | [New_SupportedRoleClass][17]                                                       | Inserts a new SupportedRoleClass as the first SupportedRoleClass if nothing else if explicit defined.                                                                                                                                                                                                                                                                


See Also
--------

#### Reference
[Aml.Engine.CAEX.Extensions Namespace][3]  

[1]: ../../Aml.Engine.CAEX/SystemUnitClassType/README.md
[2]: https://docs.microsoft.com/dotnet/api/system.object
[3]: ../README.md
[4]: AddInstance.md
[5]: AddNewInternalElement.md
[6]: Ancestors.md
[7]: Append_InternalElement.md
[8]: Insert_Attribute.md
[9]: Insert_ExternalInterface.md
[10]: Insert_InternalElement.md
[11]: Insert_InternalLink.md
[12]: Insert_SupportedRoleClass.md
[13]: New_ExternalInterface.md
[14]: New_ExternalInterface_1.md
[15]: New_InternalElement.md
[16]: New_InternalLink.md
[17]: New_SupportedRoleClass.md
[18]: https://www.automationml.org
[19]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Static member]: ../../icons/static.gif "Static member"