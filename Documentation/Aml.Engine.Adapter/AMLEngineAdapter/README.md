AMLEngineAdapter Class
======================
AutomationML 2.1 APIThis class provides methods, which exists in the old AMLEngine_v3.x.x and are no longer supported. These methods are provided to support the migration of legacy code.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  **Aml.Engine.Adapter.AMLEngineAdapter**  

  **Namespace:**  [Aml.Engine.Adapter][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static class AMLEngineAdapter
```

The **AMLEngineAdapter** type exposes the following members.


Methods
-------

                                 | Name                                                                | Description                                                                                                                                                                                                                                                                                                   
-------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method]![Static member] | [AllElementsWithInternalLinks][3]                                   | **Obsolete.**Getting an enumerable of all Elements with InternalLinks of all InstanceHierarchies and SystemUnitClassLibraries in the CAEXFile. The enumeration may return InternalElements or SystemUnitClass elements.                                                                                       
![Public method]![Static member] | [AllInternalElementsWithInternalLinks][4]                           | **Obsolete.**Getting an enumerable of InternalElements with InternalLinks of all InstanceHierarchies and SystemUnitClassLibraries in the CAEXFile.                                                                                                                                                            
![Public method]![Static member] | [Ancestors][5]                                                      | **Obsolete.**Returns all SystemUnit Classes which are ancestors of this. This SystemUnit Class is included in the enumeration as the first Element, The farthest is the last Element in the enumeration.                                                                                                      
![Public method]![Static member] | [AssignNewGUIDs][6]                                                 | **Obsolete.**Assigns new GUIDs to this InternalElement and all of its child InternalElements                                                                                                                                                                                                                  
![Public method]![Static member] | [AssignNewGUIDsAndRedirectExistingInternalLinks][7]                 | **Obsolete.**Assigns the new GUIds and redirect existing internal links.                                                                                                                                                                                                                                      
![Public method]![Static member] | [AssignNewGUIDsAndRedirectExistingInternalLinksAndMirrorObjects][8] | **Obsolete.**This Method assigns new GUIds to the SystemUnitClass and its subordinate Children, which have an ID. The References to the old IDs in Mirrors and InternalLinks are redirected to the new ID. If a Reference is not found in any of the subordinate Elements, the Reference will not be changed. 
![Public method]![Static member] | [Attributes][9]                                                     | **Obsolete.**Enumeration Method for direct Children of Type [AttributeType][10]                                                                                                                                                                                                                               
![Public method]![Static member] | [clone][11]                                                         | **Obsolete.**[Copy(Boolean, Boolean, Boolean)][12]                                                                                                                                                                                                                                                            
![Public method]![Static member] | [CloneNode][13]                                                     | **Obsolete.**Clones the node.                                                                                                                                                                                                                                                                                 
![Public method]![Static member] | [ConsistencyCheck_ClassReference][14]                               | **Obsolete.**Check if the given classPath is a valid path to an existent class in the AML file.                                                                                                                                                                                                               
![Public method]![Static member] | [Create_UniqueCopy][15]                                             | **Obsolete.**Creates a copy with a unique ID.                                                                                                                                                                                                                                                                 
![Public method]![Static member] | [ExternalInterfaces][16]                                            | **Obsolete.**Enumeration Method for direct Children of Type [InterfaceClassType][17]                                                                                                                                                                                                                          
![Public method]![Static member] | [ExternalReferences][18]                                            | **Obsolete.**Enumeration Method for all ExternalReferences of the CAEXFile.                                                                                                                                                                                                                                   
![Public method]![Static member] | [findExternalInterface][19]                                         | **Obsolete.**Searches for an ExternalInterface in this InternalElement                                                                                                                                                                                                                                        
![Public method]![Static member] | [findInternalElement][20]                                           | **Obsolete.**Resolve a reference to an InternalElement and return the referenced element if found.                                                                                                                                                                                                            
![Public method]![Static member] | [GetAllElementsWithInternalLinks][21]                               | **Obsolete.**Getting a List of all Elements with InternalLinks of all InstanceHierarchies and SystemUnitClassLibraries in the CAEXFile. The List may contain InternalElements and SystemUnitClass elements.                                                                                                   
![Public method]![Static member] | [getAttributeField][22]                                             | **Obsolete.**Get the whole attribute field containing a collection of all attributes of this object.                                                                                                                                                                                                          
![Public method]![Static member] | [GetAttributeValue][23]                                             | **Obsolete.**Returns an attribute value of a given attribute name.                                                                                                                                                                                                                                            
![Public method]![Static member] | [GetClassName(InterfaceClassType)][24]                              | **Obsolete.**Gets the name of the referenced InterfaceClass.                                                                                                                                                                                                                                                  
![Public method]![Static member] | [GetClassName(InternalElementType)][25]                             | **Obsolete.**Gets the name of the referenced SystemUnit class.                                                                                                                                                                                                                                                
![Public method]![Static member] | [GetExternalInterfaces][26]                                         | **Obsolete.**Gets the external interfaces.                                                                                                                                                                                                                                                                    
![Public method]![Static member] | [getLinkedObjects][27]                                              | **Obsolete.**Getting a List of LinkedObjects object of this SystemUnitClass containing references to the concrete referenced InternalElements via an InternalLink.                                                                                                                                            
![Public method]![Static member] | [GetParent][28]                                                     | **Obsolete.**This method returns the parent CAEXBasicObject of the current CAEXBasicObject.                                                                                                                                                                                                                   
![Public method]![Static member] | [getReferencedClass][29]                                            | **Obsolete.**Getting the XML Node for a class path.                                                                                                                                                                                                                                                           
![Public method]![Static member] | [getReferencedGUID][30]                                             | **Obsolete.**Parsing a string of form GUID:Interface and returning the GUID                                                                                                                                                                                                                                   
![Public method]![Static member] | [getReferencedInterfaceClass][31]                                   | **Obsolete.**Getting a referenced InterfaceClass. Use FindFastByPath for speed optimizations.                                                                                                                                                                                                                 
![Public method]![Static member] | [getReferencedInterfaceName][32]                                    | **Obsolete.**Getting the name of the referenced Interface.                                                                                                                                                                                                                                                    
![Public method]![Static member] | [getReferencedSystemUnitClass][33]                                  | **Obsolete.**Gets the referenced SystemUnitClass using the [RefBaseSystemUnitPath][34].                                                                                                                                                                                                                       
![Public method]![Static member] | [Insert_Element][35]                                                | **Obsolete.**Inserting an element of base type TypeBase to this object. The Element is inserted at the first Element of any existing Elements of the same Type if nothing else is explicit defined.                                                                                                           
![Public method]![Static member] | [Insert_MappingObject(InternalElementType, MappingType)][36]        | **Obsolete.**Adding a MappingObject element to this InternalElement. It is only allowed to add one MappingObject node.                                                                                                                                                                                        
![Public method]![Static member] | [Insert_MappingObject(SupportedRoleClassType, MappingType)][37]     | **Obsolete.**Adding a MappingObject element to this Supported Role.                                                                                                                                                                                                                                           
![Public method]![Static member] | [Insert_NewInstance][38]                                            | **Obsolete.**Inserting a new class instance to this object. This method can be overridden in derived classes. The Instance is inserted as the first instance of any other element with the same type if nothing else is explicit defined.                                                                     
![Public method]![Static member] | [Insert_RoleRequirements][39]                                       | **Obsolete.**Inserting a RoleRequirement to this InternalElement. An exception is thrown if a RoleRequirements is already existent.                                                                                                                                                                           
![Public method]![Static member] | [Insert_SystemUnitFamilyType][40]                                   | **Obsolete.**Appending the *systemUnitFamilyType* object into this object.                                                                                                                                                                                                                                    
![Public method]![Static member] | [Insert_TypeBaseElement][41]                                        | **Obsolete.**[Insert(CAEXWrapper, Boolean)][42]                                                                                                                                                                                                                                                               
![Public method]![Static member] | [InstanceHierarchies][43]                                           | **Obsolete.**Enumeration Method for all InstanceHierarchies of the CAEXFile.                                                                                                                                                                                                                                  
![Public method]![Static member] | [InterfaceClassLibraries][44]                                       | **Obsolete.**Enumeration Method for all InterfaceClass Libraries of the CAEXFile.                                                                                                                                                                                                                             
![Public method]![Static member] | [InternalElementChildren][45]                                       | **Obsolete.**Enumeration Method for direct Children of Type [InternalElementType][46]                                                                                                                                                                                                                         
![Public method]![Static member] | [IsFacet][47]                                                       | **Obsolete.**Determines whether the InternalElement instance is an AMLFacet.                                                                                                                                                                                                                                  
![Public method]![Static member] | [IsGroup][48]                                                       | **Obsolete.**Determines whether the InternalElement instance is an AMLGroup.                                                                                                                                                                                                                                  
![Public method]![Static member] | [IsPort][49]                                                        | **Obsolete.**Determines whether the InternalElement instance is an AMLPort.                                                                                                                                                                                                                                   
![Public method]![Static member] | [Name][50]                                                          | **Obsolete.**Get the Name of the specified object.                                                                                                                                                                                                                                                            
![Public method]![Static member] | [New_Comment][51]                                                   | **Obsolete.**Adding a new Comment node to this revision.                                                                                                                                                                                                                                                      
![Public method]![Static member] | [New_NewVersion][52]                                                | **Obsolete.**Adding a new NewVersion node to this revision.                                                                                                                                                                                                                                                   
![Public method]![Static member] | [New_OldVersion][53]                                                | **Obsolete.**Adding a new OldVersion node to this revision.                                                                                                                                                                                                                                                   
![Public method]![Static member] | [New_RequiredMaxValue][54]                                          | **Obsolete.**Adding a new RequiredMaxValue to this ordinal scaled constraint                                                                                                                                                                                                                                  
![Public method]![Static member] | [New_RequiredMinValue][55]                                          | **Obsolete.**Adding a new RequiredMinValue to this ordinal scaled constraint                                                                                                                                                                                                                                  
![Public method]![Static member] | [New_RequiredValue(NominalScaledTypeType, String)][56]              | **Obsolete.**Adds a new required value to the NominalScaledType Constraint.                                                                                                                                                                                                                                   
![Public method]![Static member] | [New_RequiredValue(OrdinalScaledTypeType, String)][57]              | **Obsolete.**Adding a new RequiredValue to this ordinal scaled constraint                                                                                                                                                                                                                                     
![Public method]![Static member] | [New_RoleRequirements(InternalElementType)][58]                     | **Obsolete.**Adding a new RoleRequirements element to this InternalElement. It is only allowed to add one RoleRequirements node in CAEX 2.15.                                                                                                                                                                 
![Public method]![Static member] | [New_RoleRequirements(InternalElementType, String)][59]             | **Obsolete.**Adding a new RoleRequirements element to this InternalElement using the defined roleClassPath. It is only allowed to add one RoleRequirements node in CAEX 2.15.                                                                                                                                 
![Public method]![Static member] | [RoleClassLibraries][60]                                            | **Obsolete.**Enumeration Method for all RoleClass Libraries of the CAEXFile.                                                                                                                                                                                                                                  
![Public method]![Static member] | [SystemUnitClassChildren][61]                                       | **Obsolete.**Gets all Children [SystemUnitFamilyType][62] Objects of this SystemUnitClass.                                                                                                                                                                                                                    
![Public method]![Static member] | [SystemUnitClassLibraries][63]                                      | **Obsolete.**Enumeration Method for all SystemUnitClass Libraries of the CAEXFile.                                                                                                                                                                                                                            


See Also
--------

#### Reference
[Aml.Engine.Adapter Namespace][2]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../README.md
[3]: AllElementsWithInternalLinks.md
[4]: AllInternalElementsWithInternalLinks.md
[5]: Ancestors.md
[6]: AssignNewGUIDs.md
[7]: AssignNewGUIDsAndRedirectExistingInternalLinks.md
[8]: AssignNewGUIDsAndRedirectExistingInternalLinksAndMirrorObjects.md
[9]: Attributes.md
[10]: ../../Aml.Engine.CAEX/AttributeType/README.md
[11]: clone.md
[12]: ../../Aml.Engine.CAEX/CAEXWrapper/Copy.md
[13]: CloneNode.md
[14]: ConsistencyCheck_ClassReference.md
[15]: Create_UniqueCopy.md
[16]: ExternalInterfaces.md
[17]: ../../Aml.Engine.CAEX/InterfaceClassType/README.md
[18]: ExternalReferences.md
[19]: findExternalInterface.md
[20]: findInternalElement.md
[21]: GetAllElementsWithInternalLinks.md
[22]: getAttributeField.md
[23]: GetAttributeValue.md
[24]: GetClassName.md
[25]: GetClassName_1.md
[26]: GetExternalInterfaces.md
[27]: getLinkedObjects.md
[28]: GetParent.md
[29]: getReferencedClass.md
[30]: getReferencedGUID.md
[31]: getReferencedInterfaceClass.md
[32]: getReferencedInterfaceName.md
[33]: getReferencedSystemUnitClass.md
[34]: ../../Aml.Engine.CAEX/InternalElementType/RefBaseSystemUnitPath.md
[35]: Insert_Element.md
[36]: Insert_MappingObject.md
[37]: Insert_MappingObject_1.md
[38]: Insert_NewInstance.md
[39]: Insert_RoleRequirements.md
[40]: Insert_SystemUnitFamilyType.md
[41]: Insert_TypeBaseElement.md
[42]: ../../Aml.Engine.CAEX/CAEXBasicObject/Insert.md
[43]: InstanceHierarchies.md
[44]: InterfaceClassLibraries.md
[45]: InternalElementChildren.md
[46]: ../../Aml.Engine.CAEX/InternalElementType/README.md
[47]: IsFacet.md
[48]: IsGroup.md
[49]: IsPort.md
[50]: Name.md
[51]: New_Comment.md
[52]: New_NewVersion.md
[53]: New_OldVersion.md
[54]: New_RequiredMaxValue.md
[55]: New_RequiredMinValue.md
[56]: New_RequiredValue.md
[57]: New_RequiredValue_1.md
[58]: New_RoleRequirements.md
[59]: New_RoleRequirements_1.md
[60]: RoleClassLibraries.md
[61]: SystemUnitClassChildren.md
[62]: ../../Aml.Engine.CAEX/SystemUnitFamilyType/README.md
[63]: SystemUnitClassLibraries.md
[64]: https://www.automationml.org
[65]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Static member]: ../../icons/static.gif "Static member"