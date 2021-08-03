IObjectWithRoleReference Interface
==================================
This Interface is implemented by [RoleRequirementsType][1] and [SupportedRoleClassType][2].

  **Namespace:**  [Aml.Engine.CAEX][3]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public interface IObjectWithRoleReference : ICAEXWrapper, 
	IXMLWrapper
```

The **IObjectWithRoleReference** type exposes the following members.


Properties
----------

                   | Name                | Description                                                                                                                                                                                                                                               
------------------ | ------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public property] | [CAEXParent][4]     | Gets the CAEXParent of this CAEX object (Inherited from [ICAEXWrapper][5].)                                                                                                                                                                               
![Public property] | [Document][6]       | Gets the XDocument containing the XML node of this object. If the object has not been inserted into a document, the XDocument is `null`. Direct manipulations of the XML document are not monitored by the AML engine. (Inherited from [IXMLWrapper][7].) 
![Public property] | [Exists][8]         | Determines, if this instance is wrapped around an existing XML node (Inherited from [IXMLWrapper][7].)                                                                                                                                                    
![Public property] | [Node][9]           | Get the XML node of this instance. Direct manipulations of the XML node are not monitored by the AML engine. (Inherited from [IXMLWrapper][7].)                                                                                                           
![Public property] | [Owner][10]         | Gets the XML parent node of this instance. Direct manipulations of the XML node are not monitored by the AML engine. (Inherited from [IXMLWrapper][7].)                                                                                                   
![Public property] | [RoleClass][11]     | Gets and sets the referenced role class                                                                                                                                                                                                                   
![Public property] | [RoleReference][12] | Gets and sets the role reference attribute                                                                                                                                                                                                                
![Public property] | [TagName][13]       | Gets the Schema Tag name of this instance. (Inherited from [IXMLWrapper][7].)                                                                                                                                                                             


Methods
-------

                 | Name               | Description                                                                                                  
---------------- | ------------------ | ------------------------------------------------------------------------------------------------------------ 
![Public method] | [CAEXChild][14]    | Gets the first child of this CAEX object with the defined CAEX tag name. (Inherited from [ICAEXWrapper][5].) 
![Public method] | [CAEXChildren][15] | Gets all children of this CAEX object with the defined CAEX tag name. (Inherited from [ICAEXWrapper][5].)    
![Public method] | [Remove][16]       | Removes this object (Inherited from [ICAEXWrapper][5].)                                                      


Extension Methods
-----------------

                           | Name                                            | Description                                                                                                                                                                                                                                                                                                                                                                              
-------------------------- | ----------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public Extension Method] | [AMLSchemaManager][17]                          | Gets the associated CAEX schema manager of the CAEX object. (Defined by [CAEXBasicObjectExtensions][18].)                                                                                                                                                                                                                                                                                
![Public Extension Method] | [Ancestors&lt;T>][19]                           | Finds the ancestors of the provided CAEX object which have the given type. (Defined by [CAEXBasicObjectExtensions][18].)                                                                                                                                                                                                                                                                 
![Public Extension Method] | [CAEXDocument][20]                              | Gets the CAEX document which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][18].)                                                                                                                                                                                                                                                                                    
![Public Extension Method] | [CAEXFile][21]                                  | Gets the CAEX file which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][18].)                                                                                                                                                                                                                                                                                        
![Public Extension Method] | [CAEXSchema][22]                                | Gets the associated CAEX schema of the CAEX object. (Defined by [CAEXBasicObjectExtensions][18].)                                                                                                                                                                                                                                                                                        
![Public Extension Method] | [Descendants&lt;T>][23]                         | Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][18].)                                                                                                                                                                                                                                                             
![Public Extension Method] | [FindCaexObjectFromId&lt;T>][24]                | Finds the CAEX object with the specified id and the specified Type. (Defined by [CAEXBasicObjectExtensions][18].)                                                                                                                                                                                                                                                                        
![Public Extension Method] | [FindReferencedClass&lt;T>][25]                 | Finds the CAEX object with the specified CAEX path and the specified Type. (Defined by [CAEXBasicObjectExtensions][18].)                                                                                                                                                                                                                                                                 
![Public Extension Method] | [FirstAncestor(String)][26]                     | Overloaded. Finds the first ancestor of the specified CAEX object with the given Tag name (Defined by [CAEXBasicObjectExtensions][18].)                                                                                                                                                                                                                                                  
![Public Extension Method] | [FirstAncestor(Predicate&lt;ICAEXWrapper>)][27] | Overloaded. Finds the first ancestor of the specified CAEX object which fulfils the specified predicate (Defined by [CAEXBasicObjectExtensions][18].)                                                                                                                                                                                                                                    
![Public Extension Method] | [FirstAncestor&lt;T>()][28]                     | Overloaded. Finds the first ancestor of the specified CAEX object in the given Type. (Defined by [CAEXBasicObjectExtensions][18].)                                                                                                                                                                                                                                                       
![Public Extension Method] | [GetParent&lt;T>][29]                           | Tries to get a CAEX parent with the specified Type of the provided caexObject. If the parent is not assignable to the provided type, the result is `null`. (Defined by [CAEXBasicObjectExtensions][18].)                                                                                                                                                                                 
![Public Extension Method] | [IsAMLObject][30]                               | Determines whether the CAEX object is an AutomationML object. If the CAEX object is a SystemUnitClass or InternalElement, it is checked, if there exists a role reference to the AutomationMLBaseRole. If the CAEX object is an ExternalInterface, it is checked, if there exists an InterfaceClass reference to an AutomationMLBase Interface. (Defined by [AmlObjectsExtensions][31].) 
![Public Extension Method] | [IsAutomationMLBaseRole][32]                    | Determines whether the specified role reference defines an inheritance relation from the AutomationMLBaseRole RoleClass (Defined by [AutomationMLBaseRoleClassLib][33].)                                                                                                                                                                                                                 
![Public Extension Method] | [IsDerivedFromRoleClass][34]                    | Determines whether the specified role reference defines an inheritance relation from the role, uniquely identifiable by the given role class path. The role class path may contain an alias. (Defined by [InheritanceExtensions][35].)                                                                                                                                                   
![Public Extension Method] | [IsFacet][36]                                   | Determines whether the specified role reference defines an inheritance relation from the Facet RoleClass (Defined by [AutomationMLBaseRoleClassLib][33].)                                                                                                                                                                                                                                
![Public Extension Method] | [IsFrame][37]                                   | Determines whether the specified role reference defines an inheritance relation from the Frame RoleClass (Defined by [AutomationMLBaseRoleClassLib][33].)                                                                                                                                                                                                                                
![Public Extension Method] | [IsGroup][38]                                   | Determines whether the specified role reference defines an inheritance relation from the Group RoleClass (Defined by [AutomationMLBaseRoleClassLib][33].)                                                                                                                                                                                                                                
![Public Extension Method] | [IsInterlockingSourceGroup][39]                 | Determines whether the specified role reference defines an inheritance relation from the InterlockingSourceGroup RoleClass (Defined by [AutomationMLBaseRoleClassLib][33].)                                                                                                                                                                                                              
![Public Extension Method] | [IsInterlockingTargetGroup][40]                 | Determines whether the specified role reference defines an inheritance relation from the InterlockingTargetGroup RoleClass (Defined by [AutomationMLBaseRoleClassLib][33].)                                                                                                                                                                                                              
![Public Extension Method] | [IsLogicObject][41]                             | Determines whether the specified role reference defines an inheritance relation from the LogicObject RoleClass (Defined by [AutomationMLBaseRoleClassLib][33].)                                                                                                                                                                                                                          
![Public Extension Method] | [IsPort][42]                                    | Determines whether the specified role reference defines an inheritance relation from the Port RoleClass (Defined by [AutomationMLBaseRoleClassLib][33].)                                                                                                                                                                                                                                 
![Public Extension Method] | [IsProcess][43]                                 | Determines whether the specified role reference defines an inheritance relation from the Process RoleClass (Defined by [AutomationMLBaseRoleClassLib][33].)                                                                                                                                                                                                                              
![Public Extension Method] | [IsProcessStructure][44]                        | Determines whether the specified role reference defines an inheritance relation from the ProcessStructure RoleClass (Defined by [AutomationMLBaseRoleClassLib][33].)                                                                                                                                                                                                                     
![Public Extension Method] | [IsProduct][45]                                 | Determines whether the specified role reference defines an inheritance relation from the Product RoleClass (Defined by [AutomationMLBaseRoleClassLib][33].)                                                                                                                                                                                                                              
![Public Extension Method] | [IsProductStructure][46]                        | Determines whether the specified role reference defines an inheritance relation from the ProductStructure RoleClass (Defined by [AutomationMLBaseRoleClassLib][33].)                                                                                                                                                                                                                     
![Public Extension Method] | [IsPropertySet][47]                             | Determines whether the specified role reference defines an inheritance relation from the PropertySet RoleClass (Defined by [AutomationMLBaseRoleClassLib][33].)                                                                                                                                                                                                                          
![Public Extension Method] | [IsResource][48]                                | Determines whether the specified role reference defines an inheritance relation from the Resource RoleClass (Defined by [AutomationMLBaseRoleClassLib][33].)                                                                                                                                                                                                                             
![Public Extension Method] | [IsResourceStructure][49]                       | Determines whether the specified role reference defines an inheritance relation from the ResourceStructure RoleClass (Defined by [AutomationMLBaseRoleClassLib][33].)                                                                                                                                                                                                                    
![Public Extension Method] | [IsStructure][50]                               | Determines whether the specified role reference defines an inheritance relation from the Structure RoleClass (Defined by [AutomationMLBaseRoleClassLib][33].)                                                                                                                                                                                                                            
![Public Extension Method] | [Library][51]                                   | Gets the Library which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][18].)                                                                                                                                                                                                                                                                                          
![Public Extension Method] | [MakeAutomationMLBaseRole][52]                  | Makes the AutomationML base role. (Defined by [AutomationMLBaseRoleClassLib][33].)                                                                                                                                                                                                                                                                                                       
![Public Extension Method] | [MakeFacet][53]                                 | Makes the facet. (Defined by [AutomationMLBaseRoleClassLib][33].)                                                                                                                                                                                                                                                                                                                        
![Public Extension Method] | [MakeGroup][54]                                 | Makes the group. (Defined by [AutomationMLBaseRoleClassLib][33].)                                                                                                                                                                                                                                                                                                                        
![Public Extension Method] | [MakePort][55]                                  | Makes the port. (Defined by [AutomationMLBaseRoleClassLib][33].)                                                                                                                                                                                                                                                                                                                         
![Public Extension Method] | [MakeProcess][56]                               | Makes the process. (Defined by [AutomationMLBaseRoleClassLib][33].)                                                                                                                                                                                                                                                                                                                      
![Public Extension Method] | [MakeProcessStructure][57]                      | Makes the process structure. (Defined by [AutomationMLBaseRoleClassLib][33].)                                                                                                                                                                                                                                                                                                            
![Public Extension Method] | [MakeProduct][58]                               | Makes the Product. (Defined by [AutomationMLBaseRoleClassLib][33].)                                                                                                                                                                                                                                                                                                                      
![Public Extension Method] | [MakeProductStructure][59]                      | Makes the product structure. (Defined by [AutomationMLBaseRoleClassLib][33].)                                                                                                                                                                                                                                                                                                            
![Public Extension Method] | [MakePropertySet][60]                           | Makes the property set. (Defined by [AutomationMLBaseRoleClassLib][33].)                                                                                                                                                                                                                                                                                                                 
![Public Extension Method] | [MakeResource][61]                              | Makes the resource. (Defined by [AutomationMLBaseRoleClassLib][33].)                                                                                                                                                                                                                                                                                                                     
![Public Extension Method] | [MakeResourceStructure][62]                     | Makes the resource structure. (Defined by [AutomationMLBaseRoleClassLib][33].)                                                                                                                                                                                                                                                                                                           
![Public Extension Method] | [MakeStructure][63]                             | Makes the structure. (Defined by [AutomationMLBaseRoleClassLib][33].)                                                                                                                                                                                                                                                                                                                    


See Also
--------

#### Reference
[Aml.Engine.CAEX Namespace][3]  
[Aml.Engine.CAEX.ICAEXWrapper][5]  

[1]: ../RoleRequirementsType/README.md
[2]: ../SupportedRoleClassType/README.md
[3]: ../README.md
[4]: ../ICAEXWrapper/CAEXParent.md
[5]: ../ICAEXWrapper/README.md
[6]: ../../Aml.Engine.XML/IXMLWrapper/Document.md
[7]: ../../Aml.Engine.XML/IXMLWrapper/README.md
[8]: ../../Aml.Engine.XML/IXMLWrapper/Exists.md
[9]: ../../Aml.Engine.XML/IXMLWrapper/Node.md
[10]: ../../Aml.Engine.XML/IXMLWrapper/Owner.md
[11]: RoleClass.md
[12]: RoleReference.md
[13]: ../../Aml.Engine.XML/IXMLWrapper/TagName.md
[14]: ../ICAEXWrapper/CAEXChild.md
[15]: ../ICAEXWrapper/CAEXChildren.md
[16]: ../ICAEXWrapper/Remove.md
[17]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/AMLSchemaManager.md
[18]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/README.md
[19]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Ancestors__1.md
[20]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXDocument.md
[21]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXFile.md
[22]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXSchema.md
[23]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants__1_1.md
[24]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FindCaexObjectFromId__1.md
[25]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FindReferencedClass__1.md
[26]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor_1.md
[27]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor.md
[28]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor__1.md
[29]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/GetParent__1.md
[30]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/IsAMLObject.md
[31]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/README.md
[32]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLib/IsAutomationMLBaseRole.md
[33]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLib/README.md
[34]: ../../Aml.Engine.CAEX.Extensions/InheritanceExtensions/IsDerivedFromRoleClass.md
[35]: ../../Aml.Engine.CAEX.Extensions/InheritanceExtensions/README.md
[36]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLib/IsFacet.md
[37]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLib/IsFrame.md
[38]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLib/IsGroup.md
[39]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLib/IsInterlockingSourceGroup.md
[40]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLib/IsInterlockingTargetGroup.md
[41]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLib/IsLogicObject.md
[42]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLib/IsPort.md
[43]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLib/IsProcess.md
[44]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLib/IsProcessStructure.md
[45]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLib/IsProduct.md
[46]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLib/IsProductStructure.md
[47]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLib/IsPropertySet.md
[48]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLib/IsResource.md
[49]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLib/IsResourceStructure.md
[50]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLib/IsStructure.md
[51]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Library.md
[52]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLib/MakeAutomationMLBaseRole.md
[53]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLib/MakeFacet.md
[54]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLib/MakeGroup.md
[55]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLib/MakePort.md
[56]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLib/MakeProcess.md
[57]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLib/MakeProcessStructure.md
[58]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLib/MakeProduct.md
[59]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLib/MakeProductStructure.md
[60]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLib/MakePropertySet.md
[61]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLib/MakeResource.md
[62]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLib/MakeResourceStructure.md
[63]: ../../Aml.Engine.AmlObjects/AutomationMLBaseRoleClassLib/MakeStructure.md
[64]: https://www.automationml.org
[65]: ../../icons/logoShade.png
[Public property]: ../../icons/pubproperty.gif "Public property"
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public Extension Method]: ../../icons/pubextension.gif "Public Extension Method"