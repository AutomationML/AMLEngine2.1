ExternalInterfaceType Class
===========================
This Class is a wrapper for the CAEXElement 'ExternalInterface'


Inheritance Hierarchy
---------------------
[System.Object][1]  
  [Aml.Engine.CAEX.CAEXWrapper][2]  
    [Aml.Engine.CAEX.CAEXBasicObject][3]  
      [Aml.Engine.CAEX.CAEXObject][4]  
        [Aml.Engine.CAEX.CaexObjectWithReference][5]&lt;[InterfaceClassType][6]>  
          [Aml.Engine.CAEX.InterfaceClassType][6]  
            **Aml.Engine.CAEX.ExternalInterfaceType**  

  **Namespace:**  [Aml.Engine.CAEX][7]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public class ExternalInterfaceType : InterfaceClassType, 
	IMirror, ICAEXObject, ICAEXBasicObject, ICAEXWrapper, IXMLWrapper
```

The **ExternalInterfaceType** type exposes the following members.


Constructors
------------

                 | Name                       | Description                                                        
---------------- | -------------------------- | ------------------------------------------------------------------ 
![Public method] | [ExternalInterfaceType][8] | Initializes a new instance of the **ExternalInterfaceType** class. 


Properties
----------

                   | Name                                  | Description                                                                                                                                                                                                                    
------------------ | ------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ 
![Public property] | [AdditionalInformation][9]            | Gets the collection of AdditionalInformation values contained in this instance. (Inherited from [CAEXBasicObject][3].)                                                                                                         
![Public property] | [AssociatedObject][10]                | Determines, if this external interface is associated to a SystemUnitClass, InternalElement, InterfaceClass, RoleClass or RoleRequirement and returns the Wrapper for this associated object. Also works for nested Interfaces. 
![Public property] | [Attribute][11]                       | Gets the collection of Attributes for this Instance (Inherited from [InterfaceClassType][6].)                                                                                                                                  
![Public property] | [AttributeAndDescendants][12]         | Gets the attributes and all nested attributes. (Inherited from [InterfaceClassType][6].)                                                                                                                                       
![Public property] | [BaseClass][13]                       | Gets and sets the ReferencedBaseClass for this instance. (Inherited from [InterfaceClassType][6].)                                                                                                                             
![Public property] | [CAEXDocument][14]                    | Gets the CAEX document of this CAEX object. If the CAEX object has not been inserted into a document or has been removed from the document, the value is `null`. (Inherited from [CAEXWrapper][2].)                            
![Public property] | [CAEXParent][15]                      | Gets the CAEXParent of this instance if it exists. (Inherited from [CAEXWrapper][2].)                                                                                                                                          
![Public property] | [CAEXSequenceOfCAEXObject][16]        | Gets the CAEXSequence containing this CAEX object (Inherited from [CAEXWrapper][2].)                                                                                                                                           
![Public property] | [ChangeMode][17]                      | Gets and sets the change mode for a CAEX element (Optional in CAEX). (Inherited from [CAEXBasicObject][3].)                                                                                                                    
![Public property] | [Copyright][18]                       | Gets and sets the Copyright for this object. (Inherited from [CAEXBasicObject][3].)                                                                                                                                            
![Public property] | [CopyrightElement][19]                | Gets the wrapper for the Copyright element. (Inherited from [CAEXBasicObject][3].)                                                                                                                                             
![Public property] | [Description][20]                     | Gets and sets the Description for this object. (Inherited from [CAEXBasicObject][3].)                                                                                                                                          
![Public property] | [DescriptionElement][21]              | Gets the wrapper for the Description element. (Inherited from [CAEXBasicObject][3].)                                                                                                                                           
![Public property] | [Document][22]                        | Gets the XDocument of the wrapped XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                                                               
![Public property] | [Exists][23]                          | Determines if this is a wrapper around an existing XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                                              
![Public property] | [ExternalInterface][24]               | Gets the collection of ExternalInterfaces for this Instance. (Inherited from [InterfaceClassType][6].)                                                                                                                         
![Public property] | [ExternalInterfaceAndDescendants][25] | Gets the collection of ExternalInterface objects including all nested descendant interfaces (Inherited from [InterfaceClassType][6].)                                                                                          
![Public property] | [ID][26]                              | Gets and sets a unique identifier of the CAEX object (optional in CAEX). AutomationML requires IDs for some Elements. These IDs are automatically set when such elements are created. (Inherited from [CAEXObject][4].)        
![Public property] | [InterfaceClass][27]                  | Gets or sets the references interface class.                                                                                                                                                                                   
![Public property] | [IsMirror][28]                        | Determines, if this instance is a Mirror                                                                                                                                                                                       
![Public property] | [Master][29]                          | Gets and sets the Master. A Master is only defined, if this instance is a [IsMirror][28]. Setting a master will transform this instance into a mirror.                                                                         
![Public property] | [MasterID][30]                        | Gets the master identifier, if this ExternalInterface is a mirror .                                                                                                                                                            
![Public property] | [Name][31]                            | Gets and sets the name of the CAEX object (required in CAEX). (Inherited from [CAEXObject][4].)                                                                                                                                
![Public property] | [Node][32]                            | Gets the wrapped XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                                                                                
![Public property] | [Owner][33]                           | Gets the wrapped Xml-Element's parent (Inherited from [CAEXWrapper][2].)                                                                                                                                                       
![Public property] | [RefBaseClassPath][34]                | Gets and sets the path which references a base class (Inherited from [InterfaceClassType][6].)                                                                                                                                 
![Public property] | [ReferenceAttributeName][35]          | Gets the Name of the attribute of the wrapped Xml-Element, which is used to define the reference to the base class. (Inherited from [CaexObjectWithReference&lt;T>][5].)                                                       
![Public property] | [Revision][36]                        | Gets the collection of Revision objects contained in this instance. (Inherited from [CAEXBasicObject][3].)                                                                                                                     
![Public property] | [SourceObjectInformation][37]         | Gets the collection of SourceObjectInformation objects contained in this instance. (Inherited from [CAEXBasicObject][3].)                                                                                                      
![Public property] | [TagName][38]                         | Gets the name of the CAEX tag for this CAEX object. (Inherited from [CAEXWrapper][2].)                                                                                                                                         
![Public property] | [Version][39]                         | Gets and sets the Version for this object. (Inherited from [CAEXBasicObject][3].)                                                                                                                                              
![Public property] | [VersionElement][40]                  | Gets the wrapper for the Version element. (Inherited from [CAEXBasicObject][3].)                                                                                                                                               


Methods
-------

                 | Name                               | Description                                                                                                                                                                                                                                                                                                                                                                                                                                      
---------------- | ---------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ 
![Public method] | [AssignNewGuidAsID][41]            | Assigns the new unique identifier as a new ID to this CAEX object. (Inherited from [CAEXObject][4].)                                                                                                                                                                                                                                                                                                                                             
![Public method] | [CAEXChild][42]                    | Gets the first child of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                                                      
![Public method] | [CAEXChildren][43]                 | Gets all children of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                                                         
![Public method] | [CAEXPath][44]                     | Gets the CAEX path for this object. A path can be used to uniquely reference an object, for example in inheritances and instances. The path syntax for an object is defined differently in CAEX 2.15 and CAEX 3.0. The engine uses the [CAEXPathBuilder][45] to generate the CAEX path of an object according to the documents CAEX version. (Inherited from [CAEXObject][4].)                                                                   
![Public method] | [CAEXSequence][46]                 | Gets the CAEXSequence owned by this CAEX object, which contains the specified CAEX object. (Inherited from [InterfaceClassType][6].)                                                                                                                                                                                                                                                                                                             
![Public method] | [Container&lt;T>][47]              | Gets the CAEX Container for elements of type T, which is owned by this CAEX object (Inherited from [InterfaceClassType][6].)                                                                                                                                                                                                                                                                                                                     
![Public method] | [Copy][48]                         | Creates a copy of this CAEX object, containing all child elements. The created copy will have replaced unique IDs and updated references, if the *assignNewIDs* is set to true (default). When a CAEX class is copied, the nested classes that can exist for AttributeType, RoleClass, SystemUnitClass, and InterfaceClass could be included in the created copy, if the *includeSubClasses* is set to `true`. (Inherited from [CAEXObject][4].) 
![Public method] | [CreateMirror][49]                 | Creates a new Mirror of this ExternalInterface, using this instance as the new master of the created mirror.                                                                                                                                                                                                                                                                                                                                     
![Public method] | [Equals][50]                       | Equality of CAEX wrapper instances is defined on the equality of the wrapped XML elements. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                                    
![Public method] | [GetHashCode][51]                  | Gets the Hash code for this instance, using the wrapped XML element. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                                                          
![Public method] | [GetXAttributeValue][52]           | Gets the value of the Xml-Attribute with the specified attribute name of the wrapped Xml-Element. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                             
![Public method] | [HasInterfaceClassReference][53]   | Determines whether this ExternalInterface object has an associated reference to the specified InterfaceClass. If inheritance relations between InterfaceClasses should be regarded, the optional parameter 'regardInheritance' should be set. In this case the specified InterfaceClass is either identical to a referenced InterfaceClass or a referenced InterfaceClass is derived from the specified InterfaceClass.                          
![Public method] | [Insert(Int32, CAEXWrapper)][54]   | Inserts the specified CAEX object in it's associated sequence at the given position. The InterfaceClass defines the [Attribute][11] and [ExternalInterface][24] sequence. (Inherited from [InterfaceClassType][6].)                                                                                                                                                                                                                              
![Public method] | [Insert(CAEXWrapper, Boolean)][55] | Inserts the specified CAEX object in it's associated sequence. The InterfaceClass defines the [Attribute][11] and [ExternalInterface][24] sequence. (Inherited from [InterfaceClassType][6].)                                                                                                                                                                                                                                                    
![Public method] | [InsertAfter][56]                  | Inserts the provided CAEX object as a new sibling after this CAEX object. (Inherited from [CaexObjectWithReference&lt;T>][5].)                                                                                                                                                                                                                                                                                                                   
![Public method] | [InsertBefore][57]                 | Inserts the provided CAEX object as a new sibling before this CAEX object. (Inherited from [CaexObjectWithReference&lt;T>][5].)                                                                                                                                                                                                                                                                                                                  
![Public method] | [InsertNew][58]                    | This method can be used to create an XML node, if this CAEX wrapper was instantiated without an XML node. This method can only be applied, if an [Owner][33] is defined. The new created CAEX object is inserted as a new child of the owner. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                 
![Public method] | [New_Revision][59]                 | Creates a new Revision object and inserts it to the collection of Revision objects [Revision][36] either at the beginning or at the end of the sequence, according to the specified optional value. The Revision object is initialized with the provided values. (Inherited from [CAEXBasicObject][3].)                                                                                                                                          
![Public method] | [Remove][60]                       | Removes this ExternalInterface. After that it is no longer assigned to a document and has no owner anymore. If this ExternalInterfaces has InternalLink relations, the InternalLink relations are removed too. (Overrides [CAEXWrapper.Remove(Boolean)][61].)                                                                                                                                                                                    
![Public method] | [SetXAttributeValue][62]           | Sets the value of an attribute, adds an attribute, or removes an attribute (if the value is null). (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                            
![Public method] | [ToString][63]                     | Returns the value of the 'Name' attribute of this CAEX object as the string representation of the object. (Inherited from [CAEXObject][4].)                                                                                                                                                                                                                                                                                                      


Events
------

                | Name                  | Description                                                                               
--------------- | --------------------- | ----------------------------------------------------------------------------------------- 
![Public event] | [PropertyChanged][64] | The Change event raised when any property is modified. (Inherited from [CAEXWrapper][2].) 


Operators
---------

                                   | Name                                                             | Description                                                                                                                
---------------------------------- | ---------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------- 
![Public operator]![Static member] | [Implicit(ExternalInterfaceType to ObjectWithAMLAttributes)][65] | Conversion to get access to specific AutomationML defined Attributes, assigned to the specified External Interface object. 


Extension Methods
-----------------

                           | Name                                            | Description                                                                                                                                                                                                                                                                                                                                                                               
-------------------------- | ----------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public Extension Method] | [AMLSchemaManager][66]                          | Gets the associated CAEX schema manager of the CAEX object. (Defined by [CAEXBasicObjectExtensions][67].)                                                                                                                                                                                                                                                                                 
![Public Extension Method] | [Ancestors&lt;T>][68]                           | Finds the ancestors of the provided CAEX object which have the given type. (Defined by [CAEXBasicObjectExtensions][67].)                                                                                                                                                                                                                                                                  
![Public Extension Method] | [CAEXDocument][69]                              | Gets the CAEX document which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][67].)                                                                                                                                                                                                                                                                                     
![Public Extension Method] | [CAEXFile][70]                                  | Gets the CAEX file which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][67].)                                                                                                                                                                                                                                                                                         
![Public Extension Method] | [CAEXSchema][71]                                | Gets the associated CAEX schema of the CAEX object. (Defined by [CAEXBasicObjectExtensions][67].)                                                                                                                                                                                                                                                                                         
![Public Extension Method] | [clone][72]                                     | [Copy(Boolean, Boolean, Boolean)][73] (Defined by [AMLEngineAdapter][74].)                                                                                                                                                                                                                                                                                                                
![Public Extension Method] | [CloneNode][75]                                 | Clones the node. (Defined by [AMLEngineAdapter][74].)                                                                                                                                                                                                                                                                                                                                     
![Public Extension Method] | [ConsistencyCheck_ClassReference][76]           | Check if the given classPath is a valid path to an existent class in the AML file. (Defined by [AMLEngineAdapter][74].)                                                                                                                                                                                                                                                                   
![Public Extension Method] | [Copy][77]                                      | Copies the CAEX object and assigns the name to the created copy. (Defined by [CAEXObjectExtensions][78].)                                                                                                                                                                                                                                                                                 
![Public Extension Method] | [CreateInterfaceFamilyClass][79]                | Create an InterfaceClass from this interface (e.g. ExternalInterface). An InterfaceClass is of type InterfaceFamilyType and may contain InterfaceFamilyTypes as child elements. (Defined by [InterfaceFamilyTypeExtensions][80].)                                                                                                                                                         
![Public Extension Method] | [Descendants(Type)][81]                         | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][67].)                                                                                                                                                                                                                                                  
![Public Extension Method] | [Descendants&lt;T>()][82]                       | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][67].)                                                                                                                                                                                                                                                  
![Public Extension Method] | [Descendants&lt;T>(Boolean)][83]                | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][67].)                                                                                                                                                                                                                                                  
![Public Extension Method] | [FindCaexObjectFromId&lt;T>][84]                | Finds the CAEX object with the specified id and the specified Type. (Defined by [CAEXBasicObjectExtensions][67].)                                                                                                                                                                                                                                                                         
![Public Extension Method] | [findInternalElement][85]                       | Resolve a reference to an InternalElement and return the referenced element if found. (Defined by [AMLEngineAdapter][74].)                                                                                                                                                                                                                                                                
![Public Extension Method] | [FindReferencedClass&lt;T>][86]                 | Finds the CAEX object with the specified CAEX path and the specified Type. (Defined by [CAEXBasicObjectExtensions][67].)                                                                                                                                                                                                                                                                  
![Public Extension Method] | [FirstAncestor(String)][87]                     | Overloaded. Finds the first ancestor of the specified CAEX object with the given Tag name (Defined by [CAEXBasicObjectExtensions][67].)                                                                                                                                                                                                                                                   
![Public Extension Method] | [FirstAncestor(Predicate&lt;ICAEXWrapper>)][88] | Overloaded. Finds the first ancestor of the specified CAEX object which fulfils the specified predicate (Defined by [CAEXBasicObjectExtensions][67].)                                                                                                                                                                                                                                     
![Public Extension Method] | [FirstAncestor&lt;T>()][89]                     | Overloaded. Finds the first ancestor of the specified CAEX object in the given Type. (Defined by [CAEXBasicObjectExtensions][67].)                                                                                                                                                                                                                                                        
![Public Extension Method] | [GetClassName][90]                              | Gets the name of the referenced InterfaceClass. (Defined by [AMLEngineAdapter][74].)                                                                                                                                                                                                                                                                                                      
![Public Extension Method] | [GetFullNodePath][91]                           | Gets the full node path of the provided CAEX object, which includes the object names of all ancestor hierarchy levels and the name of the object itself. (Defined by [CAEXObjectExtensions][78].)                                                                                                                                                                                         
![Public Extension Method] | [GetParent&lt;T>][92]                           | Tries to get a CAEX parent with the specified Type of the provided caexObject. If the parent is not assignable to the provided type, the result is `null`. (Defined by [CAEXBasicObjectExtensions][67].)                                                                                                                                                                                  
![Public Extension Method] | [getReferencedClass][93]                        | Getting the XML Node for a class path. (Defined by [AMLEngineAdapter][74].)                                                                                                                                                                                                                                                                                                               
![Public Extension Method] | [getReferencedGUID][94]                         | Parsing a string of form GUID:Interface and returning the GUID (Defined by [AMLEngineAdapter][74].)                                                                                                                                                                                                                                                                                       
![Public Extension Method] | [getReferencedInterfaceClass][95]               | Getting a referenced InterfaceClass. Use FindFastByPath for speed optimizations. (Defined by [AMLEngineAdapter][74].)                                                                                                                                                                                                                                                                     
![Public Extension Method] | [getReferencedInterfaceName][96]                | Getting the name of the referenced Interface. (Defined by [AMLEngineAdapter][74].)                                                                                                                                                                                                                                                                                                        
![Public Extension Method] | [Insert_Element][97]                            | Inserting an element of base type TypeBase to this object. The Element is inserted at the first Element of any existing Elements of the same Type if nothing else is explicit defined. (Defined by [AMLEngineAdapter][74].)                                                                                                                                                               
![Public Extension Method] | [Insert_NewInstance][98]                        | Inserting a new class instance to this object. This method can be overridden in derived classes. The Instance is inserted as the first instance of any other element with the same type if nothing else is explicit defined. (Defined by [AMLEngineAdapter][74].)                                                                                                                         
![Public Extension Method] | [Insert_TypeBaseElement][99]                    | [Insert(CAEXWrapper, Boolean)][100] (Defined by [AMLEngineAdapter][74].)                                                                                                                                                                                                                                                                                                                  
![Public Extension Method] | [InternalLinksToInterface][101]                 | Gets all InternalLinks that reference the specified ExternalInterface. (Defined by [QueryResult][102].)                                                                                                                                                                                                                                                                                   
![Public Extension Method] | [IsAMLObject][103]                              | Determines whether the CAEX object is an AutomationML object. If the CAEX object is a SystemUnitClass or InternalElement, it is checked, if there exists a role reference to the AutomationMLBaseRole. If the CAEX object is an ExternalInterface, it is checked, if there exists an InterfaceClass reference to an AutomationMLBase Interface. (Defined by [AmlObjectsExtensions][104].) 
![Public Extension Method] | [IsAutomationMLBaseInterface][105]              | Determines whether the specified interface class is derived from the AutomationMLBase interface class. The method can resolve alias references anywhere in the inheritance hierarchy. (Defined by [AutomationMLInterfaceClassLib][106].)                                                                                                                                                  
![Public Extension Method] | [IsBehaviourLogicInterface][107]                | Determines whether the specified interface class is derived from the BehaviourLogicInterface interface class. The method can resolve alias references anywhere in the inheritance hierarchy. (Defined by [AutomationMLInterfaceClassLib][106].)                                                                                                                                           
![Public Extension Method] | [IsCOLLADAInterface][108]                       | Determines whether the specified interface class is derived from the COLLADAInterface interface class. The method can resolve alias references anywhere in the inheritance hierarchy. (Defined by [AutomationMLInterfaceClassLib][106].)                                                                                                                                                  
![Public Extension Method] | [IsCommunicationInterface][109]                 | Determines whether the specified interface class is derived from the Communication interface class. The method can resolve alias references anywhere in the inheritance hierarchy. (Defined by [AutomationMLInterfaceClassLib][106].)                                                                                                                                                     
![Public Extension Method] | [IsDerivedFromInterfaceClass][110]              | Determines whether the specified interface class has an inheritance relation from the interface class, uniquely identifiable by the given interface class path. The interface class path may contain an alias. (Defined by [InheritanceExtensions][111].)                                                                                                                                 
![Public Extension Method] | [IsExternalDataConnector][112]                  | Determines whether the specified interface class is derived from the ExternalDataConnector interface class. The method can resolve alias references anywhere in the inheritance hierarchy. (Defined by [AutomationMLInterfaceClassLib][106].)                                                                                                                                             
![Public Extension Method] | [IsFacetInterface][113]                         | Determines, if the ExternalInterface object is an ExternalInterface of an AMLFacet. (Defined by [AmlObjectsExtensions][104].)                                                                                                                                                                                                                                                             
![Public Extension Method] | [IsInterlockingConnector][114]                  | Determines whether the specified interface class is derived from the InterlockingConnector interface class. The method can resolve alias references anywhere in the inheritance hierarchy. (Defined by [AutomationMLInterfaceClassLib][106].)                                                                                                                                             
![Public Extension Method] | [IsInterlockingLogicInterface][115]             | Determines whether the specified interface class is derived from the InterlockingLogicInterface interface class. The method can resolve alias references anywhere in the inheritance hierarchy. (Defined by [AutomationMLInterfaceClassLib][106].)                                                                                                                                        
![Public Extension Method] | [IsInterlockingVariableInterface][116]          | Determines whether the specified interface class is derived from the InterlockingVariableInterface interface class. The method can resolve alias references anywhere in the inheritance hierarchy. (Defined by [AutomationMLInterfaceClassLib][106].)                                                                                                                                     
![Public Extension Method] | [IsLogicElementInterface][117]                  | Determines whether the specified interface class is derived from the LogicElementInterface interface class. The method can resolve alias references anywhere in the inheritance hierarchy. (Defined by [AutomationMLInterfaceClassLib][106].)                                                                                                                                             
![Public Extension Method] | [IsLogicInterface][118]                         | Determines whether the specified interface class is derived from the LogicInterface interface class. The method can resolve alias references anywhere in the inheritance hierarchy. (Defined by [AutomationMLInterfaceClassLib][106].)                                                                                                                                                    
![Public Extension Method] | [IsMaster][119]                                 | Determines whether the specified ExternalInterface is referenced by other ExternalInterface objects called 'Mirrors'. (Defined by [ExternalInterfaceTypeExtensions][120].)                                                                                                                                                                                                                
![Public Extension Method] | [IsOrderInterface][121]                         | Determines whether the specified interface class is derived from the Order interface class. The method can resolve alias references anywhere in the inheritance hierarchy. (Defined by [AutomationMLInterfaceClassLib][106].)                                                                                                                                                             
![Public Extension Method] | [IsOverridden][122]                             | Determines whether this instance is overridden. (Defined by [ExternalInterfaceTypeExtensions][120].)                                                                                                                                                                                                                                                                                      
![Public Extension Method] | [IsOverriddenDeleted][123]                      | Determines whether this instance is overridden and deleted. (Defined by [ExternalInterfaceTypeExtensions][120].)                                                                                                                                                                                                                                                                          
![Public Extension Method] | [IsPLCopenXMLInterface][124]                    | Determines whether the specified interface class is derived from the PLCopenXMLInterface interface class. The method can resolve alias references anywhere in the inheritance hierarchy. (Defined by [AutomationMLInterfaceClassLib][106].)                                                                                                                                               
![Public Extension Method] | [IsPortConnector][125]                          | Determines whether the specified interface class is derived from the PortConnector interface class. The method can resolve alias references anywhere in the inheritance hierarchy. (Defined by [AutomationMLInterfaceClassLib][106].)                                                                                                                                                     
![Public Extension Method] | [IsPPRConnector][126]                           | Determines whether the specified interface class is derived from the PPRConnector interface class. The method can resolve alias references anywhere in the inheritance hierarchy. (Defined by [AutomationMLInterfaceClassLib][106].)                                                                                                                                                      
![Public Extension Method] | [IsRelated][127]                                | Determines whether the specified ExternalInterface is related to other ExternalInterfaces using InternalLinks. (Defined by [ExternalInterfaceTypeExtensions][120].)                                                                                                                                                                                                                       
![Public Extension Method] | [IsSequencingBehaviourLogicInterface][128]      | Determines whether the specified interface class is derived from the SequencingBehaviourLogicInterface interface class. The method can resolve alias references anywhere in the inheritance hierarchy. (Defined by [AutomationMLInterfaceClassLib][106].)                                                                                                                                 
![Public Extension Method] | [IsSequencingLogicInterface][129]               | Determines whether the specified interface class is derived from the SequencingLogicInterface interface class. The method can resolve alias references anywhere in the inheritance hierarchy. (Defined by [AutomationMLInterfaceClassLib][106].)                                                                                                                                          
![Public Extension Method] | [IsSignalInterface][130]                        | Determines whether the specified interface class is derived from the SignalInterface interface class. The method can resolve alias references anywhere in the inheritance hierarchy. (Defined by [AutomationMLInterfaceClassLib][106].)                                                                                                                                                   
![Public Extension Method] | [IsVariableInterface][131]                      | Determines whether the specified interface class is derived from the VariableInterface interface class. The method can resolve alias references anywhere in the inheritance hierarchy. (Defined by [AutomationMLInterfaceClassLib][106].)                                                                                                                                                 
![Public Extension Method] | [Library][132]                                  | Gets the Library which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][67].)                                                                                                                                                                                                                                                                                           
![Public Extension Method] | [MakeAutomationMLBaseInterface][133]            | Makes the AutomationML base interface. (Defined by [AutomationMLInterfaceClassLib][106].)                                                                                                                                                                                                                                                                                                 
![Public Extension Method] | [MakeCOLLADAInterface][134]                     | Makes the COLLADA interface. (Defined by [AutomationMLInterfaceClassLib][106].)                                                                                                                                                                                                                                                                                                           
![Public Extension Method] | [MakeCommunicationInterface][135]               | Makes the communication interface. (Defined by [AutomationMLInterfaceClassLib][106].)                                                                                                                                                                                                                                                                                                     
![Public Extension Method] | [MakeExternalDataConnector][136]                | Makes the external data connector. (Defined by [AutomationMLInterfaceClassLib][106].)                                                                                                                                                                                                                                                                                                     
![Public Extension Method] | [MakeInterlockingConnector][137]                | Makes the interlocking connector. (Defined by [AutomationMLInterfaceClassLib][106].)                                                                                                                                                                                                                                                                                                      
![Public Extension Method] | [MakeOrderInterface][138]                       | Makes the order interface. (Defined by [AutomationMLInterfaceClassLib][106].)                                                                                                                                                                                                                                                                                                             
![Public Extension Method] | [MakePLCopenXMLInterface][139]                  | Makes the PLCopen XML interface. (Defined by [AutomationMLInterfaceClassLib][106].)                                                                                                                                                                                                                                                                                                       
![Public Extension Method] | [MakePortConnector][140]                        | Makes the port connector. (Defined by [AutomationMLInterfaceClassLib][106].)                                                                                                                                                                                                                                                                                                              
![Public Extension Method] | [MakePPRConnector][141]                         | Makes the PPR connector. (Defined by [AutomationMLInterfaceClassLib][106].)                                                                                                                                                                                                                                                                                                               
![Public Extension Method] | [MakeSignalInterface][142]                      | Makes the signal interface. (Defined by [AutomationMLInterfaceClassLib][106].)                                                                                                                                                                                                                                                                                                            
![Public Extension Method] | [Name()][143]                                   | Overloaded. Get the Name of the specified object. (Defined by [AMLEngineAdapter][74].)                                                                                                                                                                                                                                                                                                    
![Public Extension Method] | [Name()][144]                                   | Overloaded. Gets a names for the specified CAEX wrapper object. If the specified object is a [CAEXObject][4], the Name is returned; otherwise the TagName of the CAEX item. (Defined by [CAEXBasicObjectExtensions][67].)                                                                                                                                                                 
![Public Extension Method] | [New_Copyright][145]                            | Adds an new Copyright node to this object if it doesn't exists. (Defined by [CAEXBasicObjectExtensions][67].)                                                                                                                                                                                                                                                                             
![Public Extension Method] | [New_Description][146]                          | Adds an new Description node to this object if it doesn't exists. (Defined by [CAEXBasicObjectExtensions][67].)                                                                                                                                                                                                                                                                           
![Public Extension Method] | [New_Version][147]                              | Adds an new Version node to this object if it doesn't exists. (Defined by [CAEXBasicObjectExtensions][67].)                                                                                                                                                                                                                                                                               
![Public Extension Method] | [ReferencedClassName][148]                      | Name of the referenced InterfaceClass without path information. (Defined by [ObjectWithBaseClass][149].)                                                                                                                                                                                                                                                                                  
![Public Extension Method] | [RelatedExternalInterfaces][150]                | Gets the related external interfaces of the specified ExternalInterface connected with InternalLinks. Either the [AInterface][151] or the [BInterface][152] of the InternalLink is equal to the specified ExternalInterface. (Defined by [ExternalInterfaceTypeExtensions][120].)                                                                                                         
![Public Extension Method] | [RelatedInstances][153]                         | Gets the related instances (SystemUnitClass or InternalElement) of the specified ExternalInterface connected with InternalLinks. Either the [AInterface][151] or the [BInterface][152] of the InternalLink is equal to the specified ExternalInterface. (Defined by [ExternalInterfaceTypeExtensions][120].)                                                                              
![Public Extension Method] | [RelatedInternalElementsWithRoleReference][154] | Gets the related InternalElements of the specified ExternalInterface connected with InternalLinks, which have a role reference to the provided *roleClassPath*. Inheritance is considered here. Either the [AInterface][151] or the [BInterface][152] of the InternalLink is equal to the specified ExternalInterface. (Defined by [ExternalInterfaceTypeExtensions][120].)               
![Public Extension Method] | [SetDescription][155]                           | This method sets a description. If no description exists, it is created. (Defined by [CAEXObjectExtensions][78].)                                                                                                                                                                                                                                                                         


Explicit Interface Implementations
----------------------------------

                                                        | Name                        | Description                                                
------------------------------------------------------- | --------------------------- | ---------------------------------------------------------- 
![Explicit interface implementation]![Private method]   | [IMirror.CreateMirror][156] | Creates a mirror.                                          
![Explicit interface implementation]![Private property] | [IMirror.IsMaster][157]     | Gets a value indicating whether this instance is a master. 
![Explicit interface implementation]![Private property] | [IMirror.Master][158]       | Gets the master, if this is a mirror object.               


See Also
--------

#### Reference
[Aml.Engine.CAEX Namespace][7]  
[Aml.Engine.CAEX.InterfaceClassType][6]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../CAEXWrapper/README.md
[3]: ../CAEXBasicObject/README.md
[4]: ../CAEXObject/README.md
[5]: ../CaexObjectWithReference_1/README.md
[6]: ../InterfaceClassType/README.md
[7]: ../README.md
[8]: _ctor.md
[9]: ../CAEXBasicObject/AdditionalInformation.md
[10]: AssociatedObject.md
[11]: ../InterfaceClassType/Attribute.md
[12]: ../InterfaceClassType/AttributeAndDescendants.md
[13]: ../InterfaceClassType/BaseClass.md
[14]: ../CAEXWrapper/CAEXDocument.md
[15]: ../CAEXWrapper/CAEXParent.md
[16]: ../CAEXWrapper/CAEXSequenceOfCAEXObject.md
[17]: ../CAEXBasicObject/ChangeMode.md
[18]: ../CAEXBasicObject/Copyright.md
[19]: ../CAEXBasicObject/CopyrightElement.md
[20]: ../CAEXBasicObject/Description.md
[21]: ../CAEXBasicObject/DescriptionElement.md
[22]: ../CAEXWrapper/Document.md
[23]: ../CAEXWrapper/Exists.md
[24]: ../InterfaceClassType/ExternalInterface.md
[25]: ../InterfaceClassType/ExternalInterfaceAndDescendants.md
[26]: ../CAEXObject/ID.md
[27]: InterfaceClass.md
[28]: IsMirror.md
[29]: Master.md
[30]: MasterID.md
[31]: ../CAEXObject/Name.md
[32]: ../CAEXWrapper/Node.md
[33]: ../CAEXWrapper/Owner.md
[34]: ../InterfaceClassType/RefBaseClassPath.md
[35]: ../CaexObjectWithReference_1/ReferenceAttributeName.md
[36]: ../CAEXBasicObject/Revision.md
[37]: ../CAEXBasicObject/SourceObjectInformation.md
[38]: ../CAEXWrapper/TagName.md
[39]: ../CAEXBasicObject/Version.md
[40]: ../CAEXBasicObject/VersionElement.md
[41]: ../CAEXObject/AssignNewGuidAsID.md
[42]: ../CAEXWrapper/CAEXChild.md
[43]: ../CAEXWrapper/CAEXChildren.md
[44]: ../CAEXObject/CAEXPath.md
[45]: ../../Aml.Engine.CAEX.Extensions/CAEXPathBuilder/README.md
[46]: ../InterfaceClassType/CAEXSequence.md
[47]: ../InterfaceClassType/Container__1.md
[48]: ../CAEXObject/Copy.md
[49]: CreateMirror.md
[50]: ../CAEXWrapper/Equals.md
[51]: ../CAEXWrapper/GetHashCode.md
[52]: ../CAEXWrapper/GetXAttributeValue.md
[53]: HasInterfaceClassReference.md
[54]: ../InterfaceClassType/Insert_1.md
[55]: ../InterfaceClassType/Insert.md
[56]: ../CaexObjectWithReference_1/InsertAfter.md
[57]: ../CaexObjectWithReference_1/InsertBefore.md
[58]: ../CAEXWrapper/InsertNew.md
[59]: ../CAEXBasicObject/New_Revision.md
[60]: Remove.md
[61]: ../CAEXWrapper/Remove.md
[62]: ../CAEXWrapper/SetXAttributeValue.md
[63]: ../CAEXObject/ToString.md
[64]: ../CAEXWrapper/PropertyChanged.md
[65]: op_Implicit.md
[66]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/AMLSchemaManager.md
[67]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/README.md
[68]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Ancestors__1.md
[69]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXDocument.md
[70]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXFile.md
[71]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXSchema.md
[72]: ../../Aml.Engine.Adapter/AMLEngineAdapter/clone.md
[73]: ../CAEXWrapper/Copy.md
[74]: ../../Aml.Engine.Adapter/AMLEngineAdapter/README.md
[75]: ../../Aml.Engine.Adapter/AMLEngineAdapter/CloneNode.md
[76]: ../../Aml.Engine.Adapter/AMLEngineAdapter/ConsistencyCheck_ClassReference.md
[77]: ../../Aml.Engine.CAEX.Extensions/CAEXObjectExtensions/Copy.md
[78]: ../../Aml.Engine.CAEX.Extensions/CAEXObjectExtensions/README.md
[79]: ../../Aml.Engine.CAEX.Extensions/InterfaceFamilyTypeExtensions/CreateInterfaceFamilyClass.md
[80]: ../../Aml.Engine.CAEX.Extensions/InterfaceFamilyTypeExtensions/README.md
[81]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants.md
[82]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants__1.md
[83]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants__1_1.md
[84]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FindCaexObjectFromId__1.md
[85]: ../../Aml.Engine.Adapter/AMLEngineAdapter/findInternalElement.md
[86]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FindReferencedClass__1.md
[87]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor_1.md
[88]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor.md
[89]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor__1.md
[90]: ../../Aml.Engine.Adapter/AMLEngineAdapter/GetClassName.md
[91]: ../../Aml.Engine.CAEX.Extensions/CAEXObjectExtensions/GetFullNodePath.md
[92]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/GetParent__1.md
[93]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedClass.md
[94]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedGUID.md
[95]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedInterfaceClass.md
[96]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedInterfaceName.md
[97]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_Element.md
[98]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_NewInstance.md
[99]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_TypeBaseElement.md
[100]: ../CAEXBasicObject/Insert.md
[101]: ../../Aml.Engine.Services/QueryResult/InternalLinksToInterface.md
[102]: ../../Aml.Engine.Services/QueryResult/README.md
[103]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/IsAMLObject.md
[104]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/README.md
[105]: ../../Aml.Engine.AmlObjects/AutomationMLInterfaceClassLib/IsAutomationMLBaseInterface.md
[106]: ../../Aml.Engine.AmlObjects/AutomationMLInterfaceClassLib/README.md
[107]: ../../Aml.Engine.AmlObjects/AutomationMLInterfaceClassLib/IsBehaviourLogicInterface.md
[108]: ../../Aml.Engine.AmlObjects/AutomationMLInterfaceClassLib/IsCOLLADAInterface.md
[109]: ../../Aml.Engine.AmlObjects/AutomationMLInterfaceClassLib/IsCommunicationInterface.md
[110]: ../../Aml.Engine.CAEX.Extensions/InheritanceExtensions/IsDerivedFromInterfaceClass.md
[111]: ../../Aml.Engine.CAEX.Extensions/InheritanceExtensions/README.md
[112]: ../../Aml.Engine.AmlObjects/AutomationMLInterfaceClassLib/IsExternalDataConnector.md
[113]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/IsFacetInterface.md
[114]: ../../Aml.Engine.AmlObjects/AutomationMLInterfaceClassLib/IsInterlockingConnector.md
[115]: ../../Aml.Engine.AmlObjects/AutomationMLInterfaceClassLib/IsInterlockingLogicInterface.md
[116]: ../../Aml.Engine.AmlObjects/AutomationMLInterfaceClassLib/IsInterlockingVariableInterface.md
[117]: ../../Aml.Engine.AmlObjects/AutomationMLInterfaceClassLib/IsLogicElementInterface.md
[118]: ../../Aml.Engine.AmlObjects/AutomationMLInterfaceClassLib/IsLogicInterface.md
[119]: ../../Aml.Engine.CAEX.Extensions/ExternalInterfaceTypeExtensions/IsMaster.md
[120]: ../../Aml.Engine.CAEX.Extensions/ExternalInterfaceTypeExtensions/README.md
[121]: ../../Aml.Engine.AmlObjects/AutomationMLInterfaceClassLib/IsOrderInterface.md
[122]: ../../Aml.Engine.CAEX.Extensions/ExternalInterfaceTypeExtensions/IsOverridden.md
[123]: ../../Aml.Engine.CAEX.Extensions/ExternalInterfaceTypeExtensions/IsOverriddenDeleted.md
[124]: ../../Aml.Engine.AmlObjects/AutomationMLInterfaceClassLib/IsPLCopenXMLInterface.md
[125]: ../../Aml.Engine.AmlObjects/AutomationMLInterfaceClassLib/IsPortConnector.md
[126]: ../../Aml.Engine.AmlObjects/AutomationMLInterfaceClassLib/IsPPRConnector.md
[127]: ../../Aml.Engine.CAEX.Extensions/ExternalInterfaceTypeExtensions/IsRelated.md
[128]: ../../Aml.Engine.AmlObjects/AutomationMLInterfaceClassLib/IsSequencingBehaviourLogicInterface.md
[129]: ../../Aml.Engine.AmlObjects/AutomationMLInterfaceClassLib/IsSequencingLogicInterface.md
[130]: ../../Aml.Engine.AmlObjects/AutomationMLInterfaceClassLib/IsSignalInterface.md
[131]: ../../Aml.Engine.AmlObjects/AutomationMLInterfaceClassLib/IsVariableInterface.md
[132]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Library.md
[133]: ../../Aml.Engine.AmlObjects/AutomationMLInterfaceClassLib/MakeAutomationMLBaseInterface.md
[134]: ../../Aml.Engine.AmlObjects/AutomationMLInterfaceClassLib/MakeCOLLADAInterface.md
[135]: ../../Aml.Engine.AmlObjects/AutomationMLInterfaceClassLib/MakeCommunicationInterface.md
[136]: ../../Aml.Engine.AmlObjects/AutomationMLInterfaceClassLib/MakeExternalDataConnector.md
[137]: ../../Aml.Engine.AmlObjects/AutomationMLInterfaceClassLib/MakeInterlockingConnector.md
[138]: ../../Aml.Engine.AmlObjects/AutomationMLInterfaceClassLib/MakeOrderInterface.md
[139]: ../../Aml.Engine.AmlObjects/AutomationMLInterfaceClassLib/MakePLCopenXMLInterface.md
[140]: ../../Aml.Engine.AmlObjects/AutomationMLInterfaceClassLib/MakePortConnector.md
[141]: ../../Aml.Engine.AmlObjects/AutomationMLInterfaceClassLib/MakePPRConnector.md
[142]: ../../Aml.Engine.AmlObjects/AutomationMLInterfaceClassLib/MakeSignalInterface.md
[143]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Name.md
[144]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Name.md
[145]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/New_Copyright.md
[146]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/New_Description.md
[147]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/New_Version.md
[148]: ../../Aml.Engine.CAEX.Extensions/ObjectWithBaseClass/ReferencedClassName_1.md
[149]: ../../Aml.Engine.CAEX.Extensions/ObjectWithBaseClass/README.md
[150]: ../../Aml.Engine.CAEX.Extensions/ExternalInterfaceTypeExtensions/RelatedExternalInterfaces.md
[151]: ../InternalLinkType/AInterface.md
[152]: ../InternalLinkType/BInterface.md
[153]: ../../Aml.Engine.CAEX.Extensions/ExternalInterfaceTypeExtensions/RelatedInstances.md
[154]: ../../Aml.Engine.CAEX.Extensions/ExternalInterfaceTypeExtensions/RelatedInternalElementsWithRoleReference.md
[155]: ../../Aml.Engine.CAEX.Extensions/CAEXObjectExtensions/SetDescription.md
[156]: Aml_Engine_CAEX_IMirror_CreateMirror.md
[157]: Aml_Engine_CAEX_IMirror_IsMaster.md
[158]: Aml_Engine_CAEX_IMirror_Master.md
[159]: https://www.automationml.org
[160]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public property]: ../../icons/pubproperty.gif "Public property"
[Public event]: ../../icons/pubevent.gif "Public event"
[Public operator]: ../../icons/puboperator.gif "Public operator"
[Static member]: ../../icons/static.gif "Static member"
[Public Extension Method]: ../../icons/pubextension.gif "Public Extension Method"
[Explicit interface implementation]: ../../icons/pubinterface.gif "Explicit interface implementation"
[Private method]: ../../icons/privmethod.gif "Private method"
[Private property]: ../../icons/privproperty.gif "Private property"