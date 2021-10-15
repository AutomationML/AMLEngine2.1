RefTypeAttributeType Class
==========================
RefType attribute is an Attribute of a ColladaInterface


Inheritance Hierarchy
---------------------
[System.Object][1]  
  [Aml.Engine.CAEX.CAEXWrapper][2]  
    [Aml.Engine.CAEX.CAEXBasicObject][3]  
      [Aml.Engine.CAEX.CAEXObject][4]  
        [Aml.Engine.CAEX.AttributeTypeType][5]  
          [Aml.Engine.CAEX.AttributeType][6]  
            **Aml.Engine.AmlObjects.RefTypeAttributeType**  

  **Namespace:**  [Aml.Engine.AmlObjects][7]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public class RefTypeAttributeType : AttributeType
```

The **RefTypeAttributeType** type exposes the following members.


Constructors
------------

                 | Name                      | Description                                                       
---------------- | ------------------------- | ----------------------------------------------------------------- 
![Public method] | [RefTypeAttributeType][8] | Initializes a new instance of the **RefTypeAttributeType** class. 


Properties
----------

                                  | Name                                 | Description                                                                                                                                                                                                                                                     
--------------------------------- | ------------------------------------ | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public property]                | [AdditionalInformation][9]           | Gets the collection of AdditionalInformation values contained in this instance. (Inherited from [CAEXBasicObject][3].)                                                                                                                                          
![Public property]                | [Attribute][10]                      | Gets a collection of Attributes contained in this instance. (Inherited from [AttributeTypeType][5].)                                                                                                                                                            
![Public property]                | [AttributeAndDescendants][11]        | Gets the attributes and all nested attributes. (Inherited from [AttributeTypeType][5].)                                                                                                                                                                         
![Public property]                | [AttributeDataType][12]              | Gets and sets the AttributeDataType attribute of this Attribute object. If the referenced attribute type does not base on an XML standard base type, the AttributeDataType may remain empty or not present. (Inherited from [AttributeTypeType][5].)            
![Public property]                | [AttributePath][13]                  | returns the attribute path, which is equal to the attribute name for any attribute, which is not a nested attribute or a concatenation of attribute names separated by the attribute path delimiter for nested attributes. (Inherited from [AttributeType][6].) 
![Public property]                | [AttributeTreeOwner][14]             | Gets the owner of the Attribute Tree. This is the first ancestor, which is not an AttributeType object. (Inherited from [AttributeType][6].)                                                                                                                    
![Public property]                | [AttributeTypeDefiningAttribute][15] | Gets the Attribute datatype which is valid for values of all [ValueAttributes][16] of this element. For this class, it is the instance itself. (Inherited from [AttributeTypeType][5].)                                                                         
![Public property]                | [AttributeTypeReference][17]         | Gets and sets the AttributeType of an Attribute object, defining a new instance to class relation, using the CAEX attribute [RefAttributeType][18]. (Inherited from [AttributeType][6].)                                                                        
![Public property]                | [AttributeValue][19]                 | Gets and set the encoded/decoded attribute value according to the defined AttributeDataType. (Inherited from [AttributeTypeType][5].)                                                                                                                           
![Public property]                | [CAEXDocument][20]                   | Gets the CAEX document of this CAEX object. If the CAEX object has not been inserted into a document or has been removed from the document, the value is `null`. (Inherited from [CAEXWrapper][2].)                                                             
![Public property]                | [CAEXParent][21]                     | Gets the CAEXParent of this instance if it exists. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                           
![Public property]                | [CAEXSequenceOfCAEXObject][22]       | Gets the CAEXSequence containing this CAEX object (Inherited from [CAEXWrapper][2].)                                                                                                                                                                            
![Public property]                | [ChangeMode][23]                     | Gets and sets the change mode for a CAEX element (Optional in CAEX). (Inherited from [CAEXBasicObject][3].)                                                                                                                                                     
![Public property]                | [Constraint][24]                     | Gets the collection of AttributeValueRequirement objects contained in this instance. (Inherited from [AttributeTypeType][5].)                                                                                                                                   
![Public property]                | [Copyright][25]                      | Gets and sets the Copyright for this object. (Inherited from [CAEXBasicObject][3].)                                                                                                                                                                             
![Public property]                | [CopyrightElement][26]               | Gets the wrapper for the Copyright element. (Inherited from [CAEXBasicObject][3].)                                                                                                                                                                              
![Public property]                | [DefaultAttributeValue][27]          | Gets and set the encoded/decoded default attribute value according to the defined AttributeDataType. (Inherited from [AttributeTypeType][5].)                                                                                                                   
![Public property]                | [DefaultValue][28]                   | Gets and sets the DefaultValue element of this Attribute object. Use the property [DefaultAttributeValue][27], to get or set the type encoded default value according to the Attribute Data Type. (Inherited from [AttributeTypeType][5].)                      
![Public property]                | [Description][29]                    | Gets and sets the Description for this object. (Inherited from [CAEXBasicObject][3].)                                                                                                                                                                           
![Public property]                | [DescriptionElement][30]             | Gets the wrapper for the Description element. (Inherited from [CAEXBasicObject][3].)                                                                                                                                                                            
![Public property]                | [Document][31]                       | Gets the XDocument of the wrapped XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                
![Public property]                | [Exists][32]                         | Determines if this is a wrapper around an existing XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                                                                               
![Public property]                | [ID][33]                             | Gets and sets a unique identifier of the CAEX object (optional in CAEX). AutomationML requires IDs for some Elements. These IDs are automatically set when such elements are created. (Inherited from [CAEXObject][4].)                                         
![Public property]                | [IsMirror][34]                       | Gets a value indicating whether this instance is a mirror of another Attribute object. (Inherited from [AttributeType][6].)                                                                                                                                     
![Public property]                | [IsRefTypeAttribute][35]             | Gets a value indicating whether this instance is a RefURI attribute.                                                                                                                                                                                            
![Public property]                | [Item][36]                           | Gets the type-decoded value and sets the type-encoded value for the value attribute with the defined name. The allowed Names as [ATTRIBUTE_VALUE_STRING][37] and [ATTRIBUTE_DEFAULTVALUE_STRING][38]. (Inherited from [AttributeTypeType][5].)                  
![Public property]                | [Master][39]                         | Gets the master Attribute object if this is a mirror and the master can be found in this CAEX document. (Inherited from [AttributeType][6].)                                                                                                                    
![Public property]                | [MasterID][40]                       | Gets the identifier of the master Attribute if this is a Mirror. The identifier contains the ID of the attribute owner followed by the Attribute path. (Inherited from [AttributeType][6].)                                                                     
![Public property]                | [MasterParentID][41]                 | Gets the ID of the master attributes parent instance, if this is a mirror Attribute object. If it is not a mirror, `null` is returned. (Inherited from [AttributeType][6].)                                                                                     
![Public property]                | [Name][42]                           | Gets and sets the name of the CAEX object (required in CAEX). (Inherited from [CAEXObject][4].)                                                                                                                                                                 
![Public property]                | [Node][43]                           | Gets the wrapped XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                 
![Public property]                | [Owner][44]                          | Gets the wrapped Xml-Element's parent (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                        
![Public property]                | [RefAttributeType][18]               | Gets and sets the RefAttributeType CAEX attribute of the Attribute object. This property is used to create instance to class relations between Attributes (instances) and AttributeType objects (classes). (Inherited from [AttributeTypeType][5].)             
![Public property]                | [RefSemantic][45]                    | Gets the collection of RefSemantic objects contained in this instance (Inherited from [AttributeTypeType][5].)                                                                                                                                                  
![Public property]                | [Revision][46]                       | Gets the collection of Revision objects contained in this instance. (Inherited from [CAEXBasicObject][3].)                                                                                                                                                      
![Public property]                | [SourceObjectInformation][47]        | Gets the collection of SourceObjectInformation objects contained in this instance. (Inherited from [CAEXBasicObject][3].)                                                                                                                                       
![Public property]                | [TagName][48]                        | Gets the name of the CAEX tag for this CAEX object. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                          
![Public property]                | [Unit][49]                           | Gets and sets the Unit attribute for this Attribute object. (Inherited from [AttributeTypeType][5].)                                                                                                                                                            
![Public property]![Code example] | [Value][50]                          | Gets and sets the Value for this Attribute object. The correct XML-String representation for the defined [AttributeDataType][12] has to be ensured by the caller. (Inherited from [AttributeTypeType][5].)                                                      
![Public property]                | [ValueAttributes][16]                | Gets all the CAEXValue objects for the defined value attributes of this instance. Recognized value attributes are [ATTRIBUTE_DEFAULTVALUE_STRING][38] and [ATTRIBUTE_VALUE_STRING][37]. (Inherited from [AttributeTypeType][5].)                                
![Public property]                | [Version][51]                        | Gets and sets the Version for this object. (Inherited from [CAEXBasicObject][3].)                                                                                                                                                                               
![Public property]                | [VersionElement][52]                 | Gets the wrapper for the Version element. (Inherited from [CAEXBasicObject][3].)                                                                                                                                                                                


Methods
-------

                                 | Name                               | Description                                                                                                                                                                                                                                                                                                                                                                                                                                      
-------------------------------- | ---------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ 
![Public method]                 | [AssignNewGuidAsID][53]            | Assigns the new unique identifier as a new ID to this CAEX object. (Inherited from [CAEXObject][4].)                                                                                                                                                                                                                                                                                                                                             
![Public method]                 | [CAEXChild][54]                    | Gets the first child of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                                                      
![Public method]                 | [CAEXChildren][55]                 | Gets all children of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                                                         
![Public method]                 | [CAEXPath][56]                     | Gets the CAEX path for this object. A path can be used to uniquely reference an object, for example in inheritances and instances. The path syntax for an object is defined differently in CAEX 2.15 and CAEX 3.0. The engine uses the [CAEXPathBuilder][57] to generate the CAEX path of an object according to the documents CAEX version. (Inherited from [CAEXObject][4].)                                                                   
![Public method]                 | [CAEXSequence][58]                 | Gets the CAEXSequence owned by this CAEX object, which contains the specified CAEX object. (Inherited from [AttributeTypeType][5].)                                                                                                                                                                                                                                                                                                              
![Public method]                 | [Container&lt;T>][59]              | Gets the CAEX Container for elements of type T, which is owned by this CAEX object (Inherited from [AttributeTypeType][5].)                                                                                                                                                                                                                                                                                                                      
![Public method]                 | [Copy][60]                         | Creates a copy of this CAEX object, containing all child elements. The created copy will have replaced unique IDs and updated references, if the *assignNewIDs* is set to true (default). When a CAEX class is copied, the nested classes that can exist for AttributeType, RoleClass, SystemUnitClass, and InterfaceClass could be included in the created copy, if the *includeSubClasses* is set to `true`. (Inherited from [CAEXObject][4].) 
![Public method]![Static member] | [Create][61]                       | Creates a new RefURIAttribute using the specified document.                                                                                                                                                                                                                                                                                                                                                                                      
![Public method]                 | [CreateAttributeType][62]          | Creates an AttriuteType from this Attribute instance. (Inherited from [AttributeType][6].)                                                                                                                                                                                                                                                                                                                                                       
![Public method]                 | [CreateMirror][63]                 | Creates a new mirror element from this AttributeType (Inherited from [AttributeType][6].)                                                                                                                                                                                                                                                                                                                                                        
![Public method]                 | [Equals][64]                       | Equality of CAEX wrapper instances is defined on the equality of the wrapped XML elements. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                                    
![Public method]                 | [GetCaexValue][65]                 | Gets the [CaexValue][66] for the value attribute with the defined attribute name. The allowed Names as [ATTRIBUTE_VALUE_STRING][37] and [ATTRIBUTE_DEFAULTVALUE_STRING][38]. (Inherited from [AttributeTypeType][5].)                                                                                                                                                                                                                            
![Public method]                 | [GetDateTime][67]                  | Parse the Attribute Value string as dateTime. If the string can not be parsed, a format exception is returned. This method uses the XmlConvert [ToDateTime(String, XmlDateTimeSerializationMode)][68] method. (Inherited from [AttributeTypeType][5].)                                                                                                                                                                                           
![Public method]                 | [GetDouble][69]                    | Parse the Attribute Value string as double. If the string can not be parsed, a format exception is returned. This method uses the XmlConvert [ToDouble(String)][70] method and a fall back conversion, if the first conversion fails. (Inherited from [AttributeTypeType][5].)                                                                                                                                                                   
![Public method]                 | [GetHashCode][71]                  | Gets the Hash code for this instance, using the wrapped XML element. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                                                          
![Public method]                 | [GetXAttributeValue][72]           | Gets the value of the Xml-Attribute with the specified attribute name of the wrapped Xml-Element. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                             
![Public method]                 | [Insert(Int32, CAEXWrapper)][73]   | Inserts the specified CAEX object in it's associated sequence at the defined position. The AttributeType defines additional sequences for [Attribute][10], [Constraint][24] and [RefSemantic][45]. (Inherited from [AttributeTypeType][5].)                                                                                                                                                                                                      
![Public method]                 | [Insert(CAEXWrapper, Boolean)][74] | Inserts the specified CAEX object in it's associated sequence. The AttributeType defines additional sequences for [Attribute][10], [Constraint][24] and [RefSemantic][45]. (Inherited from [AttributeTypeType][5].)                                                                                                                                                                                                                              
![Public method]                 | [InsertAfter][75]                  | Inserts the provided CAEX object as a new sibling after this CAEX object. (Inherited from [AttributeTypeType][5].)                                                                                                                                                                                                                                                                                                                               
![Public method]                 | [InsertBefore][76]                 | Inserts the provided CAEX object as a new sibling before this CAEX object. (Inherited from [AttributeTypeType][5].)                                                                                                                                                                                                                                                                                                                              
![Public method]                 | [InsertNew][77]                    | This method can be used to create an XML node, if this CAEX wrapper was instantiated without an XML node. This method can only be applied, if an [Owner][44] is defined. The new created CAEX object is inserted as a new child of the owner. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                 
![Public method]                 | [IsExplicit][78]                   | Determines whether this is an 'explicit' RefType                                                                                                                                                                                                                                                                                                                                                                                                 
![Public method]                 | [IsImplicit][79]                   | Determines whether this is an 'implicit' RefType                                                                                                                                                                                                                                                                                                                                                                                                 
![Public method]                 | [New_Revision][80]                 | Creates a new Revision object and inserts it to the collection of Revision objects [Revision][46] either at the beginning or at the end of the sequence, according to the specified optional value. The Revision object is initialized with the provided values. (Inherited from [CAEXBasicObject][3].)                                                                                                                                          
![Public method]                 | [RecreateAttributeInstance][81]    | Replaces the content of this Attribute object with the specified attribute type. This Attribute object is changed to an instance of the provided Attribute Type. (Inherited from [AttributeType][6].)                                                                                                                                                                                                                                            
![Public method]                 | [Remove][82]                       | Removes this element. After that it is no longer assigned to a document and has no owner anymore. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                             
![Public method]                 | [SetDateTime][83]                  | Sets the specified dateTime value as the attribute value. The AttributeDataType is set to xs:dateTime (Inherited from [AttributeTypeType][5].)                                                                                                                                                                                                                                                                                                   
![Public method]                 | [SetDouble][84]                    | Sets the specified double value as the attribute value. The AttributeDataType is set to xs:double (Inherited from [AttributeTypeType][5].)                                                                                                                                                                                                                                                                                                       
![Public method]                 | [SetXAttributeValue][85]           | Sets the value of an attribute, adds an attribute, or removes an attribute (if the value is null). (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                            
![Public method]                 | [ToString][86]                     | Returns the value of the 'Name' attribute of this CAEX object as the string representation of the object. (Inherited from [CAEXObject][4].)                                                                                                                                                                                                                                                                                                      
![Public method]                 | [TryGetDateTime][87]               | Tries to parse the Attribute Value string as dateTime. This method uses the XmlConvert [ToDateTime(String, XmlDateTimeSerializationMode)][68] method. (Inherited from [AttributeTypeType][5].)                                                                                                                                                                                                                                                   
![Public method]                 | [TryGetDouble][88]                 | Tries to parse the Attribute Value string as double. This method uses the XmlConvert [ToDouble(String)][70] method and a fall back conversion, if the first conversion fails. (Inherited from [AttributeTypeType][5].)                                                                                                                                                                                                                           


Events
------

                | Name                  | Description                                                                               
--------------- | --------------------- | ----------------------------------------------------------------------------------------- 
![Public event] | [PropertyChanged][89] | The Change event raised when any property is modified. (Inherited from [CAEXWrapper][2].) 


Fields
------

                                | Name                     | Description            
------------------------------- | ------------------------ | ---------------------- 
![Public field]![Static member] | [REF_TYPE_ATTRIBUTE][90] | The ref type attribute 


Extension Methods
-----------------

                           | Name                                  | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            
-------------------------- | ------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public Extension Method] | [AddListItem][91]                     | Adds an additional list item attribute to the list attribute. If the List attribute already contains some items, the new item will have the same item type as the already existing items. If this is the first item, the specified itemType is used as the attribute data type. If no itemType is defined, the default data type for the list item is "xs:string". The Item name is automatically set to the Index if the List attribute is an ordered list, otherwise the defined itemName is used. (Defined by [ListAttribute][92].) 
![Public Extension Method] | [clone][93]                           | [Copy(Boolean, Boolean, Boolean)][94] (Defined by [AMLEngineAdapter][95].)                                                                                                                                                                                                                                                                                                                                                                                                                                                             
![Public Extension Method] | [CloneNode][96]                       | Clones the node. (Defined by [AMLEngineAdapter][95].)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  
![Public Extension Method] | [ConsistencyCheck_ClassReference][97] | Check if the given classPath is a valid path to an existent class in the AML file. (Defined by [AMLEngineAdapter][95].)                                                                                                                                                                                                                                                                                                                                                                                                                
![Public Extension Method] | [ConvertToListAttribute][98]          | Changes the semantic of the specified attribute and converts to a list attribute. A first item is added to the List attribute which is initialized with valued from the converted attribute. If the Attribute is already a list attribute or the attribute contains child attributes it will not be converted. (Defined by [ListAttribute][92].)                                                                                                                                                                                       
![Public Extension Method] | [Copy][99]                            | Copies the CAEX object and assigns the name to the created copy. (Defined by [CAEXObjectExtensions][100].)                                                                                                                                                                                                                                                                                                                                                                                                                             
![Public Extension Method] | [Descendants(Type)][101]              | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][102].)                                                                                                                                                                                                                                                                                                                                                                                              
![Public Extension Method] | [Descendants&lt;T>()][103]            | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][102].)                                                                                                                                                                                                                                                                                                                                                                                              
![Public Extension Method] | [findInternalElement][104]            | Resolve a reference to an InternalElement and return the referenced element if found. (Defined by [AMLEngineAdapter][95].)                                                                                                                                                                                                                                                                                                                                                                                                             
![Public Extension Method] | [getReferencedClass][105]             | Getting the XML Node for a class path. (Defined by [AMLEngineAdapter][95].)                                                                                                                                                                                                                                                                                                                                                                                                                                                            
![Public Extension Method] | [getReferencedGUID][106]              | Parsing a string of form GUID:Interface and returning the GUID (Defined by [AMLEngineAdapter][95].)                                                                                                                                                                                                                                                                                                                                                                                                                                    
![Public Extension Method] | [getReferencedInterfaceClass][107]    | Getting a referenced InterfaceClass. Use FindFastByPath for speed optimizations. (Defined by [AMLEngineAdapter][95].)                                                                                                                                                                                                                                                                                                                                                                                                                  
![Public Extension Method] | [getReferencedInterfaceName][108]     | Getting the name of the referenced Interface. (Defined by [AMLEngineAdapter][95].)                                                                                                                                                                                                                                                                                                                                                                                                                                                     
![Public Extension Method] | [Insert_Element][109]                 | Inserting an element of base type TypeBase to this object. The Element is inserted at the first Element of any existing Elements of the same Type if nothing else is explicit defined. (Defined by [AMLEngineAdapter][95].)                                                                                                                                                                                                                                                                                                            
![Public Extension Method] | [Insert_NewInstance][110]             | Inserting a new class instance to this object. This method can be overridden in derived classes. The Instance is inserted as the first instance of any other element with the same type if nothing else is explicit defined. (Defined by [AMLEngineAdapter][95].)                                                                                                                                                                                                                                                                      
![Public Extension Method] | [Insert_TypeBaseElement][111]         | [Insert(CAEXWrapper, Boolean)][112] (Defined by [AMLEngineAdapter][95].)                                                                                                                                                                                                                                                                                                                                                                                                                                                               
![Public Extension Method] | [IsAssociatedExternalValue][113]      | The standard attribute type AssociatedExternalValue has been renamed to AssociatedValue (Defined by [AutomationMLBaseAttributeTypeLib][114].)                                                                                                                                                                                                                                                                                                                                                                                          
![Public Extension Method] | [IsAssociatedFacet][115]              | Determines whether the specified attribute reference defines an inheritance relation from the AssociatedFacet AttributeType (Defined by [AutomationMLBaseAttributeTypeLib][114].)                                                                                                                                                                                                                                                                                                                                                      
![Public Extension Method] | [IsAssociatedValue][116]              | Determines whether the specified attribute reference defines an inheritance relation from the AssociatedValue AttributeType (Defined by [AutomationMLBaseAttributeTypeLib][114].)                                                                                                                                                                                                                                                                                                                                                      
![Public Extension Method] | [IsCardinality][117]                  | Determines whether the specified attribute reference defines an inheritance relation from the Cardinality AttributeType (Defined by [AutomationMLBaseAttributeTypeLib][114].)                                                                                                                                                                                                                                                                                                                                                          
![Public Extension Method] | [IsCategory][118]                     | Determines whether the specified attribute reference defines an inheritance relation from the Category AttributeType (Defined by [AutomationMLBaseAttributeTypeLib][114].)                                                                                                                                                                                                                                                                                                                                                             
![Public Extension Method] | [IsDerivedFromAttributeType][119]     | Determines whether the specified attribute defines an inheritance relation from the attribute, uniquely identifiable by the given attribute type path. The attribute type path may contain an alias. (Defined by [InheritanceExtensions][120].)                                                                                                                                                                                                                                                                                        
![Public Extension Method] | [IsDirection][121]                    | Determines whether the specified attribute reference defines an inheritance relation from the Direction AttributeType (Defined by [AutomationMLBaseAttributeTypeLib][114].)                                                                                                                                                                                                                                                                                                                                                            
![Public Extension Method] | [IsDocLang][122]                      | Determines whether the specified attribute reference defines an inheritance relation from the DocLang AttributeType (Defined by [AutomationMLBaseAttributeTypeLib][114].)                                                                                                                                                                                                                                                                                                                                                              
![Public Extension Method] | [IsFacetAttribute][123]               | Determines, if the attribute is an attribute of an AMLFacet. (Defined by [AmlObjectsExtensions][124].)                                                                                                                                                                                                                                                                                                                                                                                                                                 
![Public Extension Method] | [IsFrame][125]                        | Determines whether the specified attribute reference defines an inheritance relation from the Frame AttributeType (Defined by [AutomationMLBaseAttributeTypeLib][114].)                                                                                                                                                                                                                                                                                                                                                                
![Public Extension Method] | [IsListAttribute][126]                | Determines whether the specified attribute is a list attribute. This can be ordered or unordered. (Defined by [ListAttribute][92].)                                                                                                                                                                                                                                                                                                                                                                                                    
![Public Extension Method] | [IsListType][127]                     | Determines whether the specified attribute reference defines an inheritance relation from the ListType AttributeType (Defined by [AutomationMLBaseAttributeTypeLib][114].)                                                                                                                                                                                                                                                                                                                                                             
![Public Extension Method] | [IsLocalizedAttribute][128]           | Determines whether the specified attribute reference defines an inheritance relation from the LocalizedAttribute AttributeType (Defined by [AutomationMLBaseAttributeTypeLib][114].)                                                                                                                                                                                                                                                                                                                                                   
![Public Extension Method] | [IsMaster][129]                       | Determines whether the specified Attribute is referenced by other Attribute objects called 'Mirrors'. (Defined by [AttributeTypeTypeExtensions][130].)                                                                                                                                                                                                                                                                                                                                                                                 
![Public Extension Method] | [IsMIMEType][131]                     | Determines whether the specified attribute reference defines an inheritance relation from the MIMEType AttributeType (Defined by [AutomationMLBaseAttributeTypeLib][114].)                                                                                                                                                                                                                                                                                                                                                             
![Public Extension Method] | [IsOrderedListAttribute][132]         | Determines whether the specified attribute is an ordered list attribute. (Defined by [ListAttribute][92].)                                                                                                                                                                                                                                                                                                                                                                                                                             
![Public Extension Method] | [IsOrderedListType][133]              | Determines whether the specified attribute reference defines an inheritance relation from the OrderedListType AttributeType (Defined by [AutomationMLBaseAttributeTypeLib][114].)                                                                                                                                                                                                                                                                                                                                                      
![Public Extension Method] | [IsOverridden][134]                   | Determines whether this instance is overridden. (Defined by [AttributeTypeTypeExtensions][130].)                                                                                                                                                                                                                                                                                                                                                                                                                                       
![Public Extension Method] | [IsOverriddenDeleted][135]            | Determines whether this instance is overridden and deleted. (Defined by [AttributeTypeTypeExtensions][130].)                                                                                                                                                                                                                                                                                                                                                                                                                           
![Public Extension Method] | [IsRefTypeAttribute][136]             | Gets a value indicating whether this instance is a RefType attribute. (Defined by [AmlObjectsExtensions][124].)                                                                                                                                                                                                                                                                                                                                                                                                                        
![Public Extension Method] | [IsRefUri][137]                       | Determines whether the specified attribute reference defines an inheritance relation from the RefURI AttributeType (Defined by [AutomationMLBaseAttributeTypeLib][114].)                                                                                                                                                                                                                                                                                                                                                               
![Public Extension Method] | [IsRefURIAttribute][138]              | Gets a value indicating whether this instance is a RefURI attribute. (Defined by [AmlObjectsExtensions][124].)                                                                                                                                                                                                                                                                                                                                                                                                                         
![Public Extension Method] | [IsUnOrderedListAttribute][139]       | Determines whether the specified attribute is an unordered list attribute. (Defined by [ListAttribute][92].)                                                                                                                                                                                                                                                                                                                                                                                                                           
![Public Extension Method] | [ListItems][140]                      | Gets the values of all items in the list attribute (Defined by [ListAttribute][92].)                                                                                                                                                                                                                                                                                                                                                                                                                                                   
![Public Extension Method] | [ListItemValues][141]                 | Gets the values of all items in the list attribute (Defined by [ListAttribute][92].)                                                                                                                                                                                                                                                                                                                                                                                                                                                   
![Public Extension Method] | [MakeListAttribute][142]              | Changes the semantic of the specified attribute and converts it to a list attribute. If the Attribute is already a list attribute or the attribute contains child attributes it will not be converted. (Defined by [ListAttribute][92].)                                                                                                                                                                                                                                                                                               
![Public Extension Method] | [Name()][143]                         | Overloaded. Get the Name of the specified object. (Defined by [AMLEngineAdapter][95].)                                                                                                                                                                                                                                                                                                                                                                                                                                                 
![Public Extension Method] | [Name()][144]                         | Overloaded. Gets a names for the specified CAEX wrapper object. If the specified object is a [CAEXObject][4], the Name is returned; otherwise the TagName of the CAEX item. (Defined by [CAEXBasicObjectExtensions][102].)                                                                                                                                                                                                                                                                                                             
![Public Extension Method] | [New_Description][145]                | Adds an new Description node to this object if it doesn't exists. (Defined by [CAEXBasicObjectExtensions][102].)                                                                                                                                                                                                                                                                                                                                                                                                                       
![Public Extension Method] | [New_RefSemantic][146]                | Appends a new RefSemantic object with the defined semantics to the specified CAEX object. (Defined by [AttributeTypeTypeExtensions][130].)                                                                                                                                                                                                                                                                                                                                                                                             
![Public Extension Method] | [ToRefTypeAttribute][147]             | Converts an AttributeType to a RefTypeAttribute. (Defined by [AmlObjectsExtensions][124].)                                                                                                                                                                                                                                                                                                                                                                                                                                             
![Public Extension Method] | [ToRefURIAttribute][148]              | Converts an AttributeType to a RefUriAttribute. (Defined by [AmlObjectsExtensions][124].)                                                                                                                                                                                                                                                                                                                                                                                                                                              


Explicit Interface Implementations
----------------------------------

                                                        | Name                        | Description                                                                                                                               
------------------------------------------------------- | --------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------- 
![Explicit interface implementation]![Private method]   | [IMirror.CreateMirror][149] | Creates a mirror. (Inherited from [AttributeType][6].)                                                                                    
![Explicit interface implementation]![Private property] | [IMirror.IsMaster][150]     | Gets a value indicating whether this instance is a master attribute referenced by mirror attributes. (Inherited from [AttributeType][6].) 
![Explicit interface implementation]![Private property] | [IMirror.Master][151]       | Gets the master, if this is a mirror attribute (Inherited from [AttributeType][6].)                                                       


Remarks
-------
 Since CAEX Version 3.0 an Attribute element can be instantiated from an AttributeType element [AttributeFamilyType][152]. The Attribute element and the AttributeType element share the same base class [AttributeTypeType][5]. 

See Also
--------

#### Reference
[Aml.Engine.AmlObjects Namespace][7]  
[Aml.Engine.CAEX.AttributeTypeType][5]  
[Aml.Engine.CAEX.CAEXObject][4]  
[Aml.Engine.CAEX.IMultipleOccurrences&lt;T>][153]  
[Aml.Engine.CAEX.IObjectWithAttributes][154]  
[Aml.Engine.CAEX.IAttributeValueType][155]  
[Aml.Engine.CAEX.CAEXBasicObject][3]  
[Aml.Engine.CAEX.CAEXWrapper][2]  
[System.ComponentModel.INotifyPropertyChanged][156]  
[Aml.Engine.CAEX.ICAEXWrapper][157]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../../Aml.Engine.CAEX/CAEXWrapper/README.md
[3]: ../../Aml.Engine.CAEX/CAEXBasicObject/README.md
[4]: ../../Aml.Engine.CAEX/CAEXObject/README.md
[5]: ../../Aml.Engine.CAEX/AttributeTypeType/README.md
[6]: ../../Aml.Engine.CAEX/AttributeType/README.md
[7]: ../README.md
[8]: _ctor.md
[9]: ../../Aml.Engine.CAEX/CAEXBasicObject/AdditionalInformation.md
[10]: ../../Aml.Engine.CAEX/AttributeTypeType/Attribute.md
[11]: ../../Aml.Engine.CAEX/AttributeTypeType/AttributeAndDescendants.md
[12]: ../../Aml.Engine.CAEX/AttributeTypeType/AttributeDataType.md
[13]: ../../Aml.Engine.CAEX/AttributeType/AttributePath.md
[14]: ../../Aml.Engine.CAEX/AttributeType/AttributeTreeOwner.md
[15]: ../../Aml.Engine.CAEX/AttributeTypeType/AttributeTypeDefiningAttribute.md
[16]: ../../Aml.Engine.CAEX/AttributeTypeType/ValueAttributes.md
[17]: ../../Aml.Engine.CAEX/AttributeType/AttributeTypeReference.md
[18]: ../../Aml.Engine.CAEX/AttributeTypeType/RefAttributeType.md
[19]: ../../Aml.Engine.CAEX/AttributeTypeType/AttributeValue.md
[20]: ../../Aml.Engine.CAEX/CAEXWrapper/CAEXDocument.md
[21]: ../../Aml.Engine.CAEX/CAEXWrapper/CAEXParent.md
[22]: ../../Aml.Engine.CAEX/CAEXWrapper/CAEXSequenceOfCAEXObject.md
[23]: ../../Aml.Engine.CAEX/CAEXBasicObject/ChangeMode.md
[24]: ../../Aml.Engine.CAEX/AttributeTypeType/Constraint.md
[25]: ../../Aml.Engine.CAEX/CAEXBasicObject/Copyright.md
[26]: ../../Aml.Engine.CAEX/CAEXBasicObject/CopyrightElement.md
[27]: ../../Aml.Engine.CAEX/AttributeTypeType/DefaultAttributeValue.md
[28]: ../../Aml.Engine.CAEX/AttributeTypeType/DefaultValue.md
[29]: ../../Aml.Engine.CAEX/CAEXBasicObject/Description.md
[30]: ../../Aml.Engine.CAEX/CAEXBasicObject/DescriptionElement.md
[31]: ../../Aml.Engine.CAEX/CAEXWrapper/Document.md
[32]: ../../Aml.Engine.CAEX/CAEXWrapper/Exists.md
[33]: ../../Aml.Engine.CAEX/CAEXObject/ID.md
[34]: ../../Aml.Engine.CAEX/AttributeType/IsMirror.md
[35]: IsRefTypeAttribute.md
[36]: ../../Aml.Engine.CAEX/AttributeTypeType/Item.md
[37]: ../../Aml.Engine.CAEX/CAEX_CLASSModel_TagNames/ATTRIBUTE_VALUE_STRING.md
[38]: ../../Aml.Engine.CAEX/CAEX_CLASSModel_TagNames/ATTRIBUTE_DEFAULTVALUE_STRING.md
[39]: ../../Aml.Engine.CAEX/AttributeType/Master.md
[40]: ../../Aml.Engine.CAEX/AttributeType/MasterID.md
[41]: ../../Aml.Engine.CAEX/AttributeType/MasterParentID.md
[42]: ../../Aml.Engine.CAEX/CAEXObject/Name.md
[43]: ../../Aml.Engine.CAEX/CAEXWrapper/Node.md
[44]: ../../Aml.Engine.CAEX/CAEXWrapper/Owner.md
[45]: ../../Aml.Engine.CAEX/AttributeTypeType/RefSemantic.md
[46]: ../../Aml.Engine.CAEX/CAEXBasicObject/Revision.md
[47]: ../../Aml.Engine.CAEX/CAEXBasicObject/SourceObjectInformation.md
[48]: ../../Aml.Engine.CAEX/CAEXWrapper/TagName.md
[49]: ../../Aml.Engine.CAEX/AttributeTypeType/Unit.md
[50]: ../../Aml.Engine.CAEX/AttributeTypeType/Value.md
[51]: ../../Aml.Engine.CAEX/CAEXBasicObject/Version.md
[52]: ../../Aml.Engine.CAEX/CAEXBasicObject/VersionElement.md
[53]: ../../Aml.Engine.CAEX/CAEXObject/AssignNewGuidAsID.md
[54]: ../../Aml.Engine.CAEX/CAEXWrapper/CAEXChild.md
[55]: ../../Aml.Engine.CAEX/CAEXWrapper/CAEXChildren.md
[56]: ../../Aml.Engine.CAEX/CAEXObject/CAEXPath.md
[57]: ../../Aml.Engine.CAEX.Extensions/CAEXPathBuilder/README.md
[58]: ../../Aml.Engine.CAEX/AttributeTypeType/CAEXSequence.md
[59]: ../../Aml.Engine.CAEX/AttributeTypeType/Container__1.md
[60]: ../../Aml.Engine.CAEX/CAEXObject/Copy.md
[61]: Create.md
[62]: ../../Aml.Engine.CAEX/AttributeType/CreateAttributeType.md
[63]: ../../Aml.Engine.CAEX/AttributeType/CreateMirror.md
[64]: ../../Aml.Engine.CAEX/CAEXWrapper/Equals.md
[65]: ../../Aml.Engine.CAEX/AttributeTypeType/GetCaexValue.md
[66]: ../../Aml.Engine.CAEX.Extensions/CaexValue/README.md
[67]: ../../Aml.Engine.CAEX/AttributeTypeType/GetDateTime.md
[68]: https://docs.microsoft.com/dotnet/api/system.xml.xmlconvert.todatetime#System_Xml_XmlConvert_ToDateTime_System_String_System_Xml_XmlDateTimeSerializationMode_
[69]: ../../Aml.Engine.CAEX/AttributeTypeType/GetDouble.md
[70]: https://docs.microsoft.com/dotnet/api/system.xml.xmlconvert.todouble#System_Xml_XmlConvert_ToDouble_System_String_
[71]: ../../Aml.Engine.CAEX/CAEXWrapper/GetHashCode.md
[72]: ../../Aml.Engine.CAEX/CAEXWrapper/GetXAttributeValue.md
[73]: ../../Aml.Engine.CAEX/AttributeTypeType/Insert_1.md
[74]: ../../Aml.Engine.CAEX/AttributeTypeType/Insert.md
[75]: ../../Aml.Engine.CAEX/AttributeTypeType/InsertAfter.md
[76]: ../../Aml.Engine.CAEX/AttributeTypeType/InsertBefore.md
[77]: ../../Aml.Engine.CAEX/CAEXWrapper/InsertNew.md
[78]: IsExplicit.md
[79]: IsImplicit.md
[80]: ../../Aml.Engine.CAEX/CAEXBasicObject/New_Revision.md
[81]: ../../Aml.Engine.CAEX/AttributeType/RecreateAttributeInstance.md
[82]: ../../Aml.Engine.CAEX/CAEXWrapper/Remove.md
[83]: ../../Aml.Engine.CAEX/AttributeTypeType/SetDateTime.md
[84]: ../../Aml.Engine.CAEX/AttributeTypeType/SetDouble.md
[85]: ../../Aml.Engine.CAEX/CAEXWrapper/SetXAttributeValue.md
[86]: ../../Aml.Engine.CAEX/CAEXObject/ToString.md
[87]: ../../Aml.Engine.CAEX/AttributeTypeType/TryGetDateTime.md
[88]: ../../Aml.Engine.CAEX/AttributeTypeType/TryGetDouble.md
[89]: ../../Aml.Engine.CAEX/CAEXWrapper/PropertyChanged.md
[90]: REF_TYPE_ATTRIBUTE.md
[91]: ../ListAttribute/AddListItem.md
[92]: ../ListAttribute/README.md
[93]: ../../Aml.Engine.Adapter/AMLEngineAdapter/clone.md
[94]: ../../Aml.Engine.CAEX/CAEXWrapper/Copy.md
[95]: ../../Aml.Engine.Adapter/AMLEngineAdapter/README.md
[96]: ../../Aml.Engine.Adapter/AMLEngineAdapter/CloneNode.md
[97]: ../../Aml.Engine.Adapter/AMLEngineAdapter/ConsistencyCheck_ClassReference.md
[98]: ../ListAttribute/ConvertToListAttribute.md
[99]: ../../Aml.Engine.CAEX.Extensions/CAEXObjectExtensions/Copy.md
[100]: ../../Aml.Engine.CAEX.Extensions/CAEXObjectExtensions/README.md
[101]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants.md
[102]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/README.md
[103]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants__1.md
[104]: ../../Aml.Engine.Adapter/AMLEngineAdapter/findInternalElement.md
[105]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedClass.md
[106]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedGUID.md
[107]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedInterfaceClass.md
[108]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedInterfaceName.md
[109]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_Element.md
[110]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_NewInstance.md
[111]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_TypeBaseElement.md
[112]: ../../Aml.Engine.CAEX/CAEXBasicObject/Insert.md
[113]: ../AutomationMLBaseAttributeTypeLib/IsAssociatedExternalValue.md
[114]: ../AutomationMLBaseAttributeTypeLib/README.md
[115]: ../AutomationMLBaseAttributeTypeLib/IsAssociatedFacet.md
[116]: ../AutomationMLBaseAttributeTypeLib/IsAssociatedValue.md
[117]: ../AutomationMLBaseAttributeTypeLib/IsCardinality.md
[118]: ../AutomationMLBaseAttributeTypeLib/IsCategory.md
[119]: ../../Aml.Engine.CAEX.Extensions/InheritanceExtensions/IsDerivedFromAttributeType.md
[120]: ../../Aml.Engine.CAEX.Extensions/InheritanceExtensions/README.md
[121]: ../AutomationMLBaseAttributeTypeLib/IsDirection.md
[122]: ../AutomationMLBaseAttributeTypeLib/IsDocLang.md
[123]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/IsFacetAttribute.md
[124]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/README.md
[125]: ../AutomationMLBaseAttributeTypeLib/IsFrame.md
[126]: ../ListAttribute/IsListAttribute.md
[127]: ../AutomationMLBaseAttributeTypeLib/IsListType.md
[128]: ../AutomationMLBaseAttributeTypeLib/IsLocalizedAttribute.md
[129]: ../../Aml.Engine.CAEX.Extensions/AttributeTypeTypeExtensions/IsMaster.md
[130]: ../../Aml.Engine.CAEX.Extensions/AttributeTypeTypeExtensions/README.md
[131]: ../AutomationMLBaseAttributeTypeLib/IsMIMEType.md
[132]: ../ListAttribute/IsOrderedListAttribute.md
[133]: ../AutomationMLBaseAttributeTypeLib/IsOrderedListType.md
[134]: ../../Aml.Engine.CAEX.Extensions/AttributeTypeTypeExtensions/IsOverridden.md
[135]: ../../Aml.Engine.CAEX.Extensions/AttributeTypeTypeExtensions/IsOverriddenDeleted.md
[136]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/IsRefTypeAttribute.md
[137]: ../AutomationMLBaseAttributeTypeLib/IsRefUri.md
[138]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/IsRefURIAttribute.md
[139]: ../ListAttribute/IsUnOrderedListAttribute.md
[140]: ../ListAttribute/ListItems.md
[141]: ../ListAttribute/ListItemValues.md
[142]: ../ListAttribute/MakeListAttribute.md
[143]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Name.md
[144]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Name.md
[145]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/New_Description.md
[146]: ../../Aml.Engine.CAEX.Extensions/AttributeTypeTypeExtensions/New_RefSemantic.md
[147]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/ToRefTypeAttribute.md
[148]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/ToRefURIAttribute.md
[149]: ../../Aml.Engine.CAEX/AttributeType/Aml_Engine_CAEX_IMirror_CreateMirror.md
[150]: ../../Aml.Engine.CAEX/AttributeType/Aml_Engine_CAEX_IMirror_IsMaster.md
[151]: ../../Aml.Engine.CAEX/AttributeType/Aml_Engine_CAEX_IMirror_Master.md
[152]: ../../Aml.Engine.CAEX/AttributeFamilyType/README.md
[153]: ../../Aml.Engine.CAEX/IMultipleOccurrences_1/README.md
[154]: ../../Aml.Engine.CAEX/IObjectWithAttributes/README.md
[155]: ../../Aml.Engine.CAEX/IAttributeValueType/README.md
[156]: https://docs.microsoft.com/dotnet/api/system.componentmodel.inotifypropertychanged
[157]: ../../Aml.Engine.CAEX/ICAEXWrapper/README.md
[158]: https://www.automationml.org
[159]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public property]: ../../icons/pubproperty.gif "Public property"
[Code example]: ../../icons/CodeExample.png "Code example"
[Static member]: ../../icons/static.gif "Static member"
[Public event]: ../../icons/pubevent.gif "Public event"
[Public field]: ../../icons/pubfield.gif "Public field"
[Public Extension Method]: ../../icons/pubextension.gif "Public Extension Method"
[Explicit interface implementation]: ../../icons/pubinterface.gif "Explicit interface implementation"
[Private method]: ../../icons/privmethod.gif "Private method"
[Private property]: ../../icons/privproperty.gif "Private property"