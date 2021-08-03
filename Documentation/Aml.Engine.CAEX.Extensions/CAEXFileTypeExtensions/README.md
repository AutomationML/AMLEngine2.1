CAEXFileTypeExtensions Class
============================
This class defines extension methods for the CAEXFile Element


Inheritance Hierarchy
---------------------
[System.Object][1]  
  **Aml.Engine.CAEX.Extensions.CAEXFileTypeExtensions**  

  **Namespace:**  [Aml.Engine.CAEX.Extensions][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static class CAEXFileTypeExtensions
```

The **CAEXFileTypeExtensions** type exposes the following members.


Methods
-------

                                 | Name                                                     | Description                                                                                                                                                                                     
-------------------------------- | -------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method]![Static member] | [FindFastByID(CAEXFileType, String, Boolean)][3]         | **Obsolete.**Performs a document wide fast search and returns a CAEXObject given by its ID.                                                                                                     
![Public method]![Static member] | [FindFastByID&lt;T>(CAEXFileType, String, Boolean)][4]   | **Obsolete.**Performs a document wide fast search and returns an object of type 'T' given by its ID.                                                                                            
![Public method]![Static member] | [FindFastByPath(CAEXFileType, String, Boolean)][5]       | **Obsolete.**Performs a document wide fast search and returns a CAEXObject given by its Path, e.g. "plant/unit" or -in case the document is based on CAEX 2.15 - "GUID:Interface".              
![Public method]![Static member] | [FindFastByPath&lt;T>(CAEXFileType, String, Boolean)][6] | **Obsolete.**Performs a document wide fast search and returns an object of type 'T' given by its Path, e.g. "plant/unit" or -in case the document is based on CAEX 2.15 - "GUID:Interface".     
![Public method]![Static member] | [Import_AttributeTypeLib][7]                             | Imports the provided library into the AttributeTypeLib collection of this CAEX file.                                                                                                            
![Public method]![Static member] | [Import_InstanceHierarchy][8]                            | Imports the provided source instance hierarchy into the InstanceHierarchy collection of this CAEX file.                                                                                         
![Public method]![Static member] | [Import_InterfaceClassLibHierarchy][9]                   | Imports the provided library into the InterfaceClassLib collection of this CAEX file.                                                                                                           
![Public method]![Static member] | [Import_RoleClassLibHierarchy][10]                       | Imports the provided library into the RoleClassLib collection of this CAEX file.                                                                                                                
![Public method]![Static member] | [Import_SystemUnitClassLibHierarchy][11]                 | Imports the provided library into the SystemUnitClassLib collection of this CAEX file.                                                                                                          
![Public method]![Static member] | [Insert_ExternalReference][12]                           | **Obsolete.**Inserts the ExternalReference into the CAEX file.                                                                                                                                  
![Public method]![Static member] | [Insert_InstanceHierarchy][13]                           | **Obsolete.**Insert an existing InstanceHierarchy to this CAEX file as the last InstanceHierarchy.                                                                                              
![Public method]![Static member] | [Insert_InterfaceClassLibHierarchy][14]                  | **Obsolete.**Insert an existing InterfaceClassLib to this CAEX file as the last InterfaceClassLib.                                                                                              
![Public method]![Static member] | [Insert_RoleClassLibHierarchy][15]                       | **Obsolete.**Insert a RoleClassLib to this CAEX file as the last RoleClassLib.                                                                                                                  
![Public method]![Static member] | [Insert_SystemUnitClassLibHierarchy][16]                 | **Obsolete.**Append a SystemUnitClassLib to this CAEX file as the last SystemUnitClassLib.                                                                                                      
![Public method]![Static member] | [New_ExternalReference][17]                              | A new ExternalReference node is added to the CAEX file.                                                                                                                                         
![Public method]![Static member] | [New_InstanceHierarchy][18]                              | Adding a new InstanceHierarchy with the given name to this CAEX file. The Instance Hierarchy is always added as the last Instance Hierarchy.                                                    
![Public method]![Static member] | [New_InterfaceClassLibHierarchy][19]                     | Adding a new InterfaceClassLib to this CAEX file.                                                                                                                                               
![Public method]![Static member] | [New_RoleClassLibHierarchy][20]                          | Adding a new RoleClassLib to this CAEX file.                                                                                                                                                    
![Public method]![Static member] | [New_SystemUnitClassLibHierarchy][21]                    | Adding a new SystemUnitClassLib to this CAEX file.                                                                                                                                              
![Public method]![Static member] | [PreorderTraversal][22]                                  | Traversal method for a hierarchical tree, with identical childSelector for all tree nodes. The method uses a pre-order algorithm without recursion for the deep traversal of the complete tree. 


See Also
--------

#### Reference
[Aml.Engine.CAEX.Extensions Namespace][2]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../README.md
[3]: FindFastByID.md
[4]: FindFastByID__1.md
[5]: FindFastByPath.md
[6]: FindFastByPath__1.md
[7]: Import_AttributeTypeLib.md
[8]: Import_InstanceHierarchy.md
[9]: Import_InterfaceClassLibHierarchy.md
[10]: Import_RoleClassLibHierarchy.md
[11]: Import_SystemUnitClassLibHierarchy.md
[12]: Insert_ExternalReference.md
[13]: Insert_InstanceHierarchy.md
[14]: Insert_InterfaceClassLibHierarchy.md
[15]: Insert_RoleClassLibHierarchy.md
[16]: Insert_SystemUnitClassLibHierarchy.md
[17]: New_ExternalReference.md
[18]: New_InstanceHierarchy.md
[19]: New_InterfaceClassLibHierarchy.md
[20]: New_RoleClassLibHierarchy.md
[21]: New_SystemUnitClassLibHierarchy.md
[22]: PreorderTraversal.md
[23]: https://www.automationml.org
[24]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Static member]: ../../icons/static.gif "Static member"