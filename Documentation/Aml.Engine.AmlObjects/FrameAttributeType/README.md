FrameAttributeType Class
========================
This class is a wrapper for the AutomationML Attribute 'Frame'. To get access to instances of this type, use the [ObjectWithAMLAttributes][1] implicit type conversion operator, defined for all CAEX objects which are allowed to contain Attribute objects.


Inheritance Hierarchy
---------------------
[System.Object][2]  
  [Aml.Engine.CAEX.CAEXWrapper][3]  
    [Aml.Engine.CAEX.CAEXBasicObject][4]  
      [Aml.Engine.CAEX.CAEXObject][5]  
        [Aml.Engine.CAEX.AttributeTypeType][6]  
          [Aml.Engine.CAEX.AttributeType][7]  
            **Aml.Engine.AmlObjects.FrameAttributeType**  

  **Namespace:**  [Aml.Engine.AmlObjects][8]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public class FrameAttributeType : AttributeType
```

The **FrameAttributeType** type exposes the following members.


Constructors
------------

                 | Name                                            | Description                                                                                                                                                                                                                             
---------------- | ----------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method] | [FrameAttributeType(XElement)][9]               | Creates a wrapper for the specified Frame Attribute. It is not checked, if the provided attribute Node represents a valid Frame attribute.                                                                                              
![Public method] | [FrameAttributeType(XElement, FrameValues)][10] | Initializes a new instance of the **FrameAttributeType** class. It is not checked, if the provided attribute Node represents a valid Frame attribute. If Frame attributes exist, they are initialized using the specified frame values. 


Properties
----------

                                  | Name                                 | Description                                                                                                                                                                                                                                                     
--------------------------------- | ------------------------------------ | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public property]                | [AdditionalInformation][11]          | Gets the collection of AdditionalInformation values contained in this instance. (Inherited from [CAEXBasicObject][4].)                                                                                                                                          
![Public property]                | [Attribute][12]                      | Gets a collection of Attributes contained in this instance. (Inherited from [AttributeTypeType][6].)                                                                                                                                                            
![Public property]                | [AttributeAndDescendants][13]        | Gets the attributes and all nested attributes. (Inherited from [AttributeTypeType][6].)                                                                                                                                                                         
![Public property]                | [AttributeDataType][14]              | Gets and sets the AttributeDataType attribute of this Attribute object. If the referenced attribute type does not base on an XML standard base type, the AttributeDataType may remain empty or not present. (Inherited from [AttributeTypeType][6].)            
![Public property]                | [AttributePath][15]                  | returns the attribute path, which is equal to the attribute name for any attribute, which is not a nested attribute or a concatenation of attribute names separated by the attribute path delimiter for nested attributes. (Inherited from [AttributeType][7].) 
![Public property]                | [AttributeTreeOwner][16]             | Gets the owner of the Attribute Tree. This is the first ancestor, which is not an AttributeType object. (Inherited from [AttributeType][7].)                                                                                                                    
![Public property]                | [AttributeTypeDefiningAttribute][17] | Gets the Attribute datatype which is valid for values of all [ValueAttributes][18] of this element. For this class, it is the instance itself. (Inherited from [AttributeTypeType][6].)                                                                         
![Public property]                | [AttributeTypeReference][19]         | Gets and sets the AttributeType of an Attribute object, defining a new instance to class relation, using the CAEX attribute [RefAttributeType][20]. (Inherited from [AttributeType][7].)                                                                        
![Public property]                | [AttributeValue][21]                 | Gets and set the encoded/decoded attribute value according to the defined AttributeDataType. (Inherited from [AttributeTypeType][6].)                                                                                                                           
![Public property]                | [CAEXDocument][22]                   | Gets the CAEX document of this CAEX object. If the CAEX object has not been inserted into a document or has been removed from the document, the value is `null`. (Inherited from [CAEXWrapper][3].)                                                             
![Public property]                | [CAEXParent][23]                     | Gets the CAEXParent of this instance if it exists. (Inherited from [CAEXWrapper][3].)                                                                                                                                                                           
![Public property]                | [CAEXSequenceOfCAEXObject][24]       | Gets the CAEXSequence containing this CAEX object (Inherited from [CAEXWrapper][3].)                                                                                                                                                                            
![Public property]                | [ChangeMode][25]                     | Gets and sets the change mode for a CAEX element (Optional in CAEX). (Inherited from [CAEXBasicObject][4].)                                                                                                                                                     
![Public property]                | [Constraint][26]                     | Gets the collection of AttributeValueRequirement objects contained in this instance. (Inherited from [AttributeTypeType][6].)                                                                                                                                   
![Public property]                | [Copyright][27]                      | Gets and sets the Copyright for this object. (Inherited from [CAEXBasicObject][4].)                                                                                                                                                                             
![Public property]                | [CopyrightElement][28]               | Gets the wrapper for the Copyright element. (Inherited from [CAEXBasicObject][4].)                                                                                                                                                                              
![Public property]                | [DefaultAttributeValue][29]          | Gets and set the encoded/decoded default attribute value according to the defined AttributeDataType. (Inherited from [AttributeTypeType][6].)                                                                                                                   
![Public property]                | [DefaultValue][30]                   | Gets and sets the DefaultValue element of this Attribute object. Use the property [DefaultAttributeValue][29], to get or set the type encoded default value according to the Attribute Data Type. (Inherited from [AttributeTypeType][6].)                      
![Public property]                | [Description][31]                    | Gets and sets the Description for this object. (Inherited from [CAEXBasicObject][4].)                                                                                                                                                                           
![Public property]                | [DescriptionElement][32]             | Gets the wrapper for the Description element. (Inherited from [CAEXBasicObject][4].)                                                                                                                                                                            
![Public property]                | [Document][33]                       | Gets the XDocument of the wrapped XML-Element (Inherited from [CAEXWrapper][3].)                                                                                                                                                                                
![Public property]                | [Exists][34]                         | Determines if this is a wrapper around an existing XML-Element (Inherited from [CAEXWrapper][3].)                                                                                                                                                               
![Public property]                | [Frame][35]                          | Gets and sets the frame values for this FrameAttribute                                                                                                                                                                                                          
![Public property]                | [ID][36]                             | Gets and sets a unique identifier of the CAEX object (optional in CAEX). AutomationML requires IDs for some Elements. These IDs are automatically set when such elements are created. (Inherited from [CAEXObject][5].)                                         
![Public property]                | [IsMirror][37]                       | Gets a value indicating whether this instance is a mirror of another Attribute object. (Inherited from [AttributeType][7].)                                                                                                                                     
![Public property]                | [Item][38]                           | Gets the type-decoded value and sets the type-encoded value for the value attribute with the defined name. The allowed Names as [ATTRIBUTE_VALUE_STRING][39] and [ATTRIBUTE_DEFAULTVALUE_STRING][40]. (Inherited from [AttributeTypeType][6].)                  
![Public property]                | [Master][41]                         | Gets the master Attribute object if this is a mirror and the master can be found in this CAEX document. (Inherited from [AttributeType][7].)                                                                                                                    
![Public property]                | [MasterID][42]                       | Gets the identifier of the master Attribute if this is a Mirror. The identifier contains the ID of the attribute owner followed by the Attribute path. (Inherited from [AttributeType][7].)                                                                     
![Public property]                | [MasterParentID][43]                 | Gets the ID of the master attributes parent instance, if this is a mirror Attribute object. If it is not a mirror, `null` is returned. (Inherited from [AttributeType][7].)                                                                                     
![Public property]                | [Name][44]                           | Gets and sets the name of the CAEX object (required in CAEX). (Inherited from [CAEXObject][5].)                                                                                                                                                                 
![Public property]                | [Node][45]                           | Gets the wrapped XML-Element (Inherited from [CAEXWrapper][3].)                                                                                                                                                                                                 
![Public property]                | [Owner][46]                          | Gets the wrapped Xml-Element's parent (Inherited from [CAEXWrapper][3].)                                                                                                                                                                                        
![Public property]                | [RefAttributeType][20]               | Gets and sets the RefAttributeType CAEX attribute of the Attribute object. This property is used to create instance to class relations between Attributes (instances) and AttributeType objects (classes). (Inherited from [AttributeTypeType][6].)             
![Public property]                | [RefSemantic][47]                    | Gets the collection of RefSemantic objects contained in this instance (Inherited from [AttributeTypeType][6].)                                                                                                                                                  
![Public property]                | [Revision][48]                       | Gets the collection of Revision objects contained in this instance. (Inherited from [CAEXBasicObject][4].)                                                                                                                                                      
![Public property]                | [RxAttribute][49]                    | The Rx-attribute                                                                                                                                                                                                                                                
![Public property]                | [RyAttribute][50]                    | The Ry-attribute                                                                                                                                                                                                                                                
![Public property]                | [RzAttribute][51]                    | The Rz-attribute                                                                                                                                                                                                                                                
![Public property]                | [SourceObjectInformation][52]        | Gets the collection of SourceObjectInformation objects contained in this instance. (Inherited from [CAEXBasicObject][4].)                                                                                                                                       
![Public property]                | [TagName][53]                        | Gets the name of the CAEX tag for this CAEX object. (Inherited from [CAEXWrapper][3].)                                                                                                                                                                          
![Public property]                | [Unit][54]                           | Gets and sets the Unit attribute for this Attribute object. (Inherited from [AttributeTypeType][6].)                                                                                                                                                            
![Public property]![Code example] | [Value][55]                          | Gets and sets the Value for this Attribute object. The correct XML-String representation for the defined [AttributeDataType][14] has to be ensured by the caller. (Inherited from [AttributeTypeType][6].)                                                      
![Public property]                | [ValueAttributes][18]                | Gets all the CAEXValue objects for the defined value attributes of this instance. Recognized value attributes are [ATTRIBUTE_DEFAULTVALUE_STRING][40] and [ATTRIBUTE_VALUE_STRING][39]. (Inherited from [AttributeTypeType][6].)                                
![Public property]                | [Version][56]                        | Gets and sets the Version for this object. (Inherited from [CAEXBasicObject][4].)                                                                                                                                                                               
![Public property]                | [VersionElement][57]                 | Gets the wrapper for the Version element. (Inherited from [CAEXBasicObject][4].)                                                                                                                                                                                
![Public property]                | [XAttribute][58]                     | The X-attribute                                                                                                                                                                                                                                                 
![Public property]                | [YAttribute][59]                     | The Y-attribute                                                                                                                                                                                                                                                 
![Public property]                | [ZAttribute][60]                     | The Z-attribute                                                                                                                                                                                                                                                 


Methods
-------

                                 | Name                                  | Description                                                                                                                                                                                                                                                                                                                                                                                             
-------------------------------- | ------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method]                 | [AssignNewGuidAsID][61]               | Assigns the new unique identifier as a new ID to this CAEX object. (Inherited from [CAEXObject][5].)                                                                                                                                                                                                                                                                                                    
![Public method]                 | [CAEXChild][62]                       | Gets the first child of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][3].)                                                                                                                                                                                                                                                                                             
![Public method]                 | [CAEXChildren][63]                    | Gets all children of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][3].)                                                                                                                                                                                                                                                                                                
![Public method]                 | [CAEXPath][64]                        | Gets the CAEX path for this object. A path can be used to uniquely reference an object, for example in inheritances and instances. The path syntax for an object is defined differently in CAEX 2.15 and CAEX 3.0. The engine uses the [CAEXPathBuilder][65] to generate the CAEX path of an object according to the documents CAEX version. (Inherited from [CAEXObject][5].)                          
![Public method]                 | [CAEXSequence][66]                    | Gets the CAEXSequence owned by this CAEX object, which contains the specified CAEX object. (Inherited from [AttributeTypeType][6].)                                                                                                                                                                                                                                                                     
![Public method]                 | [Container&lt;T>][67]                 | Gets the CAEX Container for elements of type T, which is owned by this CAEX object (Inherited from [AttributeTypeType][6].)                                                                                                                                                                                                                                                                             
![Public method]                 | [Copy][68]                            | Creates a deep copy of this CAEX object, containing all child elements. The created copy will have replaced unique IDs and updated references, if the *assignNewIDs* is set to true (default). When a CAEX class is copied, the nested classes that can exist for AttributeType, RoleClass, SystemUnitClass, and InterfaceClass are not included in the created copy. (Inherited from [CAEXObject][5].) 
![Public method]![Static member] | [Create][69]                          | Creates a new FrameAttribute using the specified document.                                                                                                                                                                                                                                                                                                                                              
![Public method]                 | [CreateAttributeType][70]             | Creates an AttriuteType from this Attribute instance. (Inherited from [AttributeType][7].)                                                                                                                                                                                                                                                                                                              
![Public method]                 | [CreateMirror][71]                    | Creates a new mirror element from this AttributeType (Inherited from [AttributeType][7].)                                                                                                                                                                                                                                                                                                               
![Public method]                 | [Equals][72]                          | Equality of CAEX wrapper instances is defined on the equality of the wrapped XML elements. (Inherited from [CAEXWrapper][3].)                                                                                                                                                                                                                                                                           
![Public method]                 | [GetCaexValue][73]                    | Gets the [CaexValue][74] for the value attribute with the defined attribute name. The allowed Names as [ATTRIBUTE_VALUE_STRING][39] and [ATTRIBUTE_DEFAULTVALUE_STRING][40]. (Inherited from [AttributeTypeType][6].)                                                                                                                                                                                   
![Public method]                 | [GetDateTime][75]                     | Parse the Attribute Value string as dateTime. If the string can not be parsed, a format exception is returned. This method uses the XmlConvert [ToDateTime(String, XmlDateTimeSerializationMode)][76] method. (Inherited from [AttributeTypeType][6].)                                                                                                                                                  
![Public method]                 | [GetDouble][77]                       | Parse the Attribute Value string as double. If the string can not be parsed, a format exception is returned. This method uses the XmlConvert [ToDouble(String)][78] method and a fall back conversion, if the first conversion fails. (Inherited from [AttributeTypeType][6].)                                                                                                                          
![Public method]                 | [GetHashCode][79]                     | Gets the Hash code for this instance, using the wrapped XML element. (Inherited from [CAEXWrapper][3].)                                                                                                                                                                                                                                                                                                 
![Public method]                 | [GetXAttributeValue][80]              | Gets the value of the Xml-Attribute with the specified attribute name of the wrapped Xml-Element. (Inherited from [CAEXWrapper][3].)                                                                                                                                                                                                                                                                    
![Public method]                 | [Insert(Int32, CAEXWrapper)][81]      | Inserts the specified CAEX object in it's associated sequence at the defined position. The AttributeType defines additional sequences for [Attribute][12], [Constraint][26] and [RefSemantic][47]. (Inherited from [AttributeTypeType][6].)                                                                                                                                                             
![Public method]                 | [Insert(CAEXWrapper, Boolean)][82]    | Inserts the specified CAEX object in it's associated sequence. The AttributeType defines additional sequences for [Attribute][12], [Constraint][26] and [RefSemantic][47]. (Inherited from [AttributeTypeType][6].)                                                                                                                                                                                     
![Public method]                 | [InsertAfter][83]                     | Inserts the provided CAEX object as a new sibling after this CAEX object. (Inherited from [AttributeTypeType][6].)                                                                                                                                                                                                                                                                                      
![Public method]                 | [InsertBefore][84]                    | Inserts the provided CAEX object as a new sibling before this CAEX object. (Inherited from [AttributeTypeType][6].)                                                                                                                                                                                                                                                                                     
![Public method]                 | [InsertNew][85]                       | This method can be used to create an XML node, if this CAEX wrapper was instantiated without an XML node. This method can only be applied, if an [Owner][46] is defined. The new created CAEX object is inserted as a new child of the owner. (Inherited from [CAEXWrapper][3].)                                                                                                                        
![Public method]![Static member] | [IsFrame][86]                         | Determines whether the specified node models an AutomationML Frame-Attribute.                                                                                                                                                                                                                                                                                                                           
![Public method]![Static member] | [IsFrameAttribute][87]                | Gets a value indicating whether the attribute is a Frame attribute.                                                                                                                                                                                                                                                                                                                                     
![Public method]                 | [New_Revision][88]                    | Creates a new Revision object and inserts it to the collection of Revision objects [Revision][48] either at the beginning or at the end of the sequence, according to the specified optional value. The Revision object is initialized with the provided values. (Inherited from [CAEXBasicObject][4].)                                                                                                 
![Public method]                 | [RecreateAttributeInstance][89]       | Replaces the content of this Attribute object with the specified attribute type. This Attribute object is changed to an instance of the provided Attribute Type. (Inherited from [AttributeType][7].)                                                                                                                                                                                                   
![Public method]                 | [Remove][90]                          | Removes this element. After that it is no longer assigned to a document and has no owner anymore. (Inherited from [CAEXWrapper][3].)                                                                                                                                                                                                                                                                    
![Public method]                 | [SetDateTime][91]                     | Sets the specified dateTime value as the attribute value. The AttributeDataType is set to xs:dateTime (Inherited from [AttributeTypeType][6].)                                                                                                                                                                                                                                                          
![Public method]                 | [SetDouble][92]                       | Sets the specified double value as the attribute value. The AttributeDataType is set to xs:double (Inherited from [AttributeTypeType][6].)                                                                                                                                                                                                                                                              
![Public method]                 | [SetXAttributeValue][93]              | Sets the value of an attribute, adds an attribute, or removes an attribute (if the value is null). (Inherited from [CAEXWrapper][3].)                                                                                                                                                                                                                                                                   
![Public method]                 | [ToString][94]                        | Returns the value of the 'Name' attribute of this CAEX object as the string representation of the object. (Inherited from [CAEXObject][5].)                                                                                                                                                                                                                                                             
![Public method]                 | [TryGetDateTime][95]                  | Tries to parse the Attribute Value string as dateTime. This method uses the XmlConvert [ToDateTime(String, XmlDateTimeSerializationMode)][76] method. (Inherited from [AttributeTypeType][6].)                                                                                                                                                                                                          
![Public method]                 | [TryGetDouble][96]                    | Tries to parse the Attribute Value string as double. This method uses the XmlConvert [ToDouble(String)][78] method and a fall back conversion, if the first conversion fails. (Inherited from [AttributeTypeType][6].)                                                                                                                                                                                  
![Public method]![Static member] | [ValidateAndRepairFrameDatatypes][97] | Validates and repairs the frame data types if the data type is not defined or not of type 'xs:double'                                                                                                                                                                                                                                                                                                   


Events
------

                | Name                  | Description                                                                               
--------------- | --------------------- | ----------------------------------------------------------------------------------------- 
![Public event] | [PropertyChanged][98] | The Change event raised when any property is modified. (Inherited from [CAEXWrapper][3].) 


Fields
------

                                | Name              | Description                                                                                                                                                                                                                                
------------------------------- | ----------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ 
![Public field]![Static member] | [FormatInfo][99]  | **Obsolete.**The format information for the Frame attribute (don't use this, because all frame values have to be saved as xs:double with standard format) If you want to save values with specific number format, do the string conversion 
![Public field]![Static member] | [FRAME_NAME][100] | The frame name                                                                                                                                                                                                                             
![Public field]![Static member] | [RX_Name][101]    | The rx name                                                                                                                                                                                                                                
![Public field]![Static member] | [RY_Name][102]    | The ry name                                                                                                                                                                                                                                
![Public field]![Static member] | [RZ_Name][103]    | The rz name                                                                                                                                                                                                                                
![Public field]![Static member] | [X_Name][104]     | The x name                                                                                                                                                                                                                                 
![Public field]![Static member] | [Y_Name][105]     | The y name                                                                                                                                                                                                                                 
![Public field]![Static member] | [Z_Name][106]     | The z name                                                                                                                                                                                                                                 


Extension Methods
-----------------

                           | Name                                   | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             
-------------------------- | -------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public Extension Method] | [AddListItem][107]                     | Adds an additional list item attribute to the list attribute. If the List attribute already contains some items, the new item will have the same item type as the already existing items. If this is the first item, the specified itemType is used as the attribute data type. If no itemType is defined, the default data type for the list item is "xs:string". The Item name is automatically set to the Index if the List attribute is an ordered list, otherwise the defined itemName is used. (Defined by [ListAttribute][108].) 
![Public Extension Method] | [clone][109]                           | [Copy(Boolean, Boolean, Boolean)][110] (Defined by [AMLEngineAdapter][111].)                                                                                                                                                                                                                                                                                                                                                                                                                                                            
![Public Extension Method] | [CloneNode][112]                       | Clones the node. (Defined by [AMLEngineAdapter][111].)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  
![Public Extension Method] | [ConsistencyCheck_ClassReference][113] | Check if the given classPath is a valid path to an existent class in the AML file. (Defined by [AMLEngineAdapter][111].)                                                                                                                                                                                                                                                                                                                                                                                                                
![Public Extension Method] | [ConvertToListAttribute][114]          | Changes the semantic of the specified attribute and converts to a list attribute. A first item is added to the List attribute which is initialized with valued from the converted attribute. If the Attribute is already a list attribute or the attribute contains child attributes it will not be converted. (Defined by [ListAttribute][108].)                                                                                                                                                                                       
![Public Extension Method] | [Descendants(Type)][115]               | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][116].)                                                                                                                                                                                                                                                                                                                                                                                               
![Public Extension Method] | [Descendants&lt;T>()][117]             | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][116].)                                                                                                                                                                                                                                                                                                                                                                                               
![Public Extension Method] | [findInternalElement][118]             | Resolve a reference to an InternalElement and return the referenced element if found. (Defined by [AMLEngineAdapter][111].)                                                                                                                                                                                                                                                                                                                                                                                                             
![Public Extension Method] | [getReferencedClass][119]              | Getting the XML Node for a class path. (Defined by [AMLEngineAdapter][111].)                                                                                                                                                                                                                                                                                                                                                                                                                                                            
![Public Extension Method] | [getReferencedGUID][120]               | Parsing a string of form GUID:Interface and returning the GUID (Defined by [AMLEngineAdapter][111].)                                                                                                                                                                                                                                                                                                                                                                                                                                    
![Public Extension Method] | [getReferencedInterfaceClass][121]     | Getting a referenced InterfaceClass. Use FindFastByPath for speed optimizations. (Defined by [AMLEngineAdapter][111].)                                                                                                                                                                                                                                                                                                                                                                                                                  
![Public Extension Method] | [getReferencedInterfaceName][122]      | Getting the name of the referenced Interface. (Defined by [AMLEngineAdapter][111].)                                                                                                                                                                                                                                                                                                                                                                                                                                                     
![Public Extension Method] | [Insert_Element][123]                  | Inserting an element of base type TypeBase to this object. The Element is inserted at the first Element of any existing Elements of the same Type if nothing else is explicit defined. (Defined by [AMLEngineAdapter][111].)                                                                                                                                                                                                                                                                                                            
![Public Extension Method] | [Insert_NewInstance][124]              | Inserting a new class instance to this object. This method can be overridden in derived classes. The Instance is inserted as the first instance of any other element with the same type if nothing else is explicit defined. (Defined by [AMLEngineAdapter][111].)                                                                                                                                                                                                                                                                      
![Public Extension Method] | [Insert_TypeBaseElement][125]          | [Insert(CAEXWrapper, Boolean)][126] (Defined by [AMLEngineAdapter][111].)                                                                                                                                                                                                                                                                                                                                                                                                                                                               
![Public Extension Method] | [IsAssociatedExternalValue][127]       | (Defined by [AutomationMLBaseAttributeTypeLib][128].)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   
![Public Extension Method] | [IsAssociatedFacet][129]               | Determines whether the specified attribute reference defines an inheritance relation from the AssociatedFacet AttributeType (Defined by [AutomationMLBaseAttributeTypeLib][128].)                                                                                                                                                                                                                                                                                                                                                       
![Public Extension Method] | [IsAssociatedValue][130]               | Determines whether the specified attribute reference defines an inheritance relation from the AssociatedValue AttributeType (Defined by [AutomationMLBaseAttributeTypeLib][128].)                                                                                                                                                                                                                                                                                                                                                       
![Public Extension Method] | [IsCardinality][131]                   | Determines whether the specified attribute reference defines an inheritance relation from the Cardinality AttributeType (Defined by [AutomationMLBaseAttributeTypeLib][128].)                                                                                                                                                                                                                                                                                                                                                           
![Public Extension Method] | [IsCategory][132]                      | Determines whether the specified attribute reference defines an inheritance relation from the Category AttributeType (Defined by [AutomationMLBaseAttributeTypeLib][128].)                                                                                                                                                                                                                                                                                                                                                              
![Public Extension Method] | [IsDerivedFromAttributeType][133]      | Determines whether the specified attribute defines an inheritance relation from the attribute, uniquely identifiable by the given attribute type path. The attribute type path may contain an alias. (Defined by [InheritanceExtensions][134].)                                                                                                                                                                                                                                                                                         
![Public Extension Method] | [IsDirection][135]                     | Determines whether the specified attribute reference defines an inheritance relation from the Direction AttributeType (Defined by [AutomationMLBaseAttributeTypeLib][128].)                                                                                                                                                                                                                                                                                                                                                             
![Public Extension Method] | [IsDocLang][136]                       | Determines whether the specified attribute reference defines an inheritance relation from the DocLang AttributeType (Defined by [AutomationMLBaseAttributeTypeLib][128].)                                                                                                                                                                                                                                                                                                                                                               
![Public Extension Method] | [IsFacetAttribute][137]                | Determines, if the attribute is an attribute of an AMLFacet. (Defined by [AmlObjectsExtensions][138].)                                                                                                                                                                                                                                                                                                                                                                                                                                  
![Public Extension Method] | [IsFrame][139]                         | Determines whether the specified attribute reference defines an inheritance relation from the Frame AttributeType (Defined by [AutomationMLBaseAttributeTypeLib][128].)                                                                                                                                                                                                                                                                                                                                                                 
![Public Extension Method] | [IsListAttribute][140]                 | Determines whether the specified attribute is a list attribute. This can be ordered or unordered. (Defined by [ListAttribute][108].)                                                                                                                                                                                                                                                                                                                                                                                                    
![Public Extension Method] | [IsListType][141]                      | Determines whether the specified attribute reference defines an inheritance relation from the ListType AttributeType (Defined by [AutomationMLBaseAttributeTypeLib][128].)                                                                                                                                                                                                                                                                                                                                                              
![Public Extension Method] | [IsLocalizedAttribute][142]            | Determines whether the specified attribute reference defines an inheritance relation from the LocalizedAttribute AttributeType (Defined by [AutomationMLBaseAttributeTypeLib][128].)                                                                                                                                                                                                                                                                                                                                                    
![Public Extension Method] | [IsMaster][143]                        | Determines whether the specified Attribute is referenced by other Attribute objects called 'Mirrors'. (Defined by [AttributeTypeTypeExtensions][144].)                                                                                                                                                                                                                                                                                                                                                                                  
![Public Extension Method] | [IsMIMEType][145]                      | Determines whether the specified attribute reference defines an inheritance relation from the MIMEType AttributeType (Defined by [AutomationMLBaseAttributeTypeLib][128].)                                                                                                                                                                                                                                                                                                                                                              
![Public Extension Method] | [IsOrderedListAttribute][146]          | Determines whether the specified attribute is an ordered list attribute. (Defined by [ListAttribute][108].)                                                                                                                                                                                                                                                                                                                                                                                                                             
![Public Extension Method] | [IsOrderedListType][147]               | Determines whether the specified attribute reference defines an inheritance relation from the OrderedListType AttributeType (Defined by [AutomationMLBaseAttributeTypeLib][128].)                                                                                                                                                                                                                                                                                                                                                       
![Public Extension Method] | [IsRefTypeAttribute][148]              | Gets a value indicating whether this instance is a RefType attribute. (Defined by [AmlObjectsExtensions][138].)                                                                                                                                                                                                                                                                                                                                                                                                                         
![Public Extension Method] | [IsRefUri][149]                        | Determines whether the specified attribute reference defines an inheritance relation from the RefURI AttributeType (Defined by [AutomationMLBaseAttributeTypeLib][128].)                                                                                                                                                                                                                                                                                                                                                                
![Public Extension Method] | [IsRefURIAttribute][150]               | Gets a value indicating whether this instance is a RefURI attribute. (Defined by [AmlObjectsExtensions][138].)                                                                                                                                                                                                                                                                                                                                                                                                                          
![Public Extension Method] | [IsUnOrderedListAttribute][151]        | Determines whether the specified attribute is an unordered list attribute. (Defined by [ListAttribute][108].)                                                                                                                                                                                                                                                                                                                                                                                                                           
![Public Extension Method] | [ListItems][152]                       | Gets the values of all items in the list attribute (Defined by [ListAttribute][108].)                                                                                                                                                                                                                                                                                                                                                                                                                                                   
![Public Extension Method] | [ListItemValues][153]                  | Gets the values of all items in the list attribute (Defined by [ListAttribute][108].)                                                                                                                                                                                                                                                                                                                                                                                                                                                   
![Public Extension Method] | [MakeListAttribute][154]               | Changes the semantic of the specified attribute and converts it to a list attribute. If the Attribute is already a list attribute or the attribute contains child attributes it will not be converted. (Defined by [ListAttribute][108].)                                                                                                                                                                                                                                                                                               
![Public Extension Method] | [Name()][155]                          | Overloaded. Get the Name of the specified object. (Defined by [AMLEngineAdapter][111].)                                                                                                                                                                                                                                                                                                                                                                                                                                                 
![Public Extension Method] | [Name()][156]                          | Overloaded. Gets a names for the specified caex wrapper object. If the specified object is a [CAEXObject][5], the Name is returned; otherwise the TagName of the CAEX item. (Defined by [CAEXBasicObjectExtensions][116].)                                                                                                                                                                                                                                                                                                              
![Public Extension Method] | [New_Description][157]                 | Adds an new Description node to this object if it doesn't exists. (Defined by [CAEXBasicObjectExtensions][116].)                                                                                                                                                                                                                                                                                                                                                                                                                        
![Public Extension Method] | [New_RefSemantic][158]                 | Appends a new RefSemantic object with the defined semantics to the specified CAEX object. (Defined by [AttributeTypeTypeExtensions][144].)                                                                                                                                                                                                                                                                                                                                                                                              
![Public Extension Method] | [ToRefTypeAttribute][159]              | Converts an AttributeType to a RefTypeAttribute. (Defined by [AmlObjectsExtensions][138].)                                                                                                                                                                                                                                                                                                                                                                                                                                              
![Public Extension Method] | [ToRefURIAttribute][160]               | Converts an AttributeType to a RefUriAttribute. (Defined by [AmlObjectsExtensions][138].)                                                                                                                                                                                                                                                                                                                                                                                                                                               


Explicit Interface Implementations
----------------------------------

                                                        | Name                        | Description                                                                                                                               
------------------------------------------------------- | --------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------- 
![Explicit interface implementation]![Private method]   | [IMirror.CreateMirror][161] | Creates a mirror. (Inherited from [AttributeType][7].)                                                                                    
![Explicit interface implementation]![Private property] | [IMirror.IsMaster][162]     | Gets a value indicating whether this instance is a master attribute referenced by mirror attributes. (Inherited from [AttributeType][7].) 
![Explicit interface implementation]![Private property] | [IMirror.Master][163]       | Gets the master, if this is a mirror attribute (Inherited from [AttributeType][7].)                                                       


See Also
--------

#### Reference
[Aml.Engine.AmlObjects Namespace][8]  
[Aml.Engine.CAEX.AttributeType][7]  

[1]: ../ObjectWithAMLAttributes/README.md
[2]: https://docs.microsoft.com/dotnet/api/system.object
[3]: ../../Aml.Engine.CAEX/CAEXWrapper/README.md
[4]: ../../Aml.Engine.CAEX/CAEXBasicObject/README.md
[5]: ../../Aml.Engine.CAEX/CAEXObject/README.md
[6]: ../../Aml.Engine.CAEX/AttributeTypeType/README.md
[7]: ../../Aml.Engine.CAEX/AttributeType/README.md
[8]: ../README.md
[9]: _ctor.md
[10]: _ctor_1.md
[11]: ../../Aml.Engine.CAEX/CAEXBasicObject/AdditionalInformation.md
[12]: ../../Aml.Engine.CAEX/AttributeTypeType/Attribute.md
[13]: ../../Aml.Engine.CAEX/AttributeTypeType/AttributeAndDescendants.md
[14]: ../../Aml.Engine.CAEX/AttributeTypeType/AttributeDataType.md
[15]: ../../Aml.Engine.CAEX/AttributeType/AttributePath.md
[16]: ../../Aml.Engine.CAEX/AttributeType/AttributeTreeOwner.md
[17]: ../../Aml.Engine.CAEX/AttributeTypeType/AttributeTypeDefiningAttribute.md
[18]: ../../Aml.Engine.CAEX/AttributeTypeType/ValueAttributes.md
[19]: ../../Aml.Engine.CAEX/AttributeType/AttributeTypeReference.md
[20]: ../../Aml.Engine.CAEX/AttributeTypeType/RefAttributeType.md
[21]: ../../Aml.Engine.CAEX/AttributeTypeType/AttributeValue.md
[22]: ../../Aml.Engine.CAEX/CAEXWrapper/CAEXDocument.md
[23]: ../../Aml.Engine.CAEX/CAEXWrapper/CAEXParent.md
[24]: ../../Aml.Engine.CAEX/CAEXWrapper/CAEXSequenceOfCAEXObject.md
[25]: ../../Aml.Engine.CAEX/CAEXBasicObject/ChangeMode.md
[26]: ../../Aml.Engine.CAEX/AttributeTypeType/Constraint.md
[27]: ../../Aml.Engine.CAEX/CAEXBasicObject/Copyright.md
[28]: ../../Aml.Engine.CAEX/CAEXBasicObject/CopyrightElement.md
[29]: ../../Aml.Engine.CAEX/AttributeTypeType/DefaultAttributeValue.md
[30]: ../../Aml.Engine.CAEX/AttributeTypeType/DefaultValue.md
[31]: ../../Aml.Engine.CAEX/CAEXBasicObject/Description.md
[32]: ../../Aml.Engine.CAEX/CAEXBasicObject/DescriptionElement.md
[33]: ../../Aml.Engine.CAEX/CAEXWrapper/Document.md
[34]: ../../Aml.Engine.CAEX/CAEXWrapper/Exists.md
[35]: Frame.md
[36]: ../../Aml.Engine.CAEX/CAEXObject/ID.md
[37]: ../../Aml.Engine.CAEX/AttributeType/IsMirror.md
[38]: ../../Aml.Engine.CAEX/AttributeTypeType/Item.md
[39]: ../../Aml.Engine.CAEX/CAEX_CLASSModel_TagNames/ATTRIBUTE_VALUE_STRING.md
[40]: ../../Aml.Engine.CAEX/CAEX_CLASSModel_TagNames/ATTRIBUTE_DEFAULTVALUE_STRING.md
[41]: ../../Aml.Engine.CAEX/AttributeType/Master.md
[42]: ../../Aml.Engine.CAEX/AttributeType/MasterID.md
[43]: ../../Aml.Engine.CAEX/AttributeType/MasterParentID.md
[44]: ../../Aml.Engine.CAEX/CAEXObject/Name.md
[45]: ../../Aml.Engine.CAEX/CAEXWrapper/Node.md
[46]: ../../Aml.Engine.CAEX/CAEXWrapper/Owner.md
[47]: ../../Aml.Engine.CAEX/AttributeTypeType/RefSemantic.md
[48]: ../../Aml.Engine.CAEX/CAEXBasicObject/Revision.md
[49]: RxAttribute.md
[50]: RyAttribute.md
[51]: RzAttribute.md
[52]: ../../Aml.Engine.CAEX/CAEXBasicObject/SourceObjectInformation.md
[53]: ../../Aml.Engine.CAEX/CAEXWrapper/TagName.md
[54]: ../../Aml.Engine.CAEX/AttributeTypeType/Unit.md
[55]: ../../Aml.Engine.CAEX/AttributeTypeType/Value.md
[56]: ../../Aml.Engine.CAEX/CAEXBasicObject/Version.md
[57]: ../../Aml.Engine.CAEX/CAEXBasicObject/VersionElement.md
[58]: XAttribute.md
[59]: YAttribute.md
[60]: ZAttribute.md
[61]: ../../Aml.Engine.CAEX/CAEXObject/AssignNewGuidAsID.md
[62]: ../../Aml.Engine.CAEX/CAEXWrapper/CAEXChild.md
[63]: ../../Aml.Engine.CAEX/CAEXWrapper/CAEXChildren.md
[64]: ../../Aml.Engine.CAEX/CAEXObject/CAEXPath.md
[65]: ../../Aml.Engine.CAEX.Extensions/CAEXPathBuilder/README.md
[66]: ../../Aml.Engine.CAEX/AttributeTypeType/CAEXSequence.md
[67]: ../../Aml.Engine.CAEX/AttributeTypeType/Container__1.md
[68]: ../../Aml.Engine.CAEX/CAEXObject/Copy.md
[69]: Create.md
[70]: ../../Aml.Engine.CAEX/AttributeType/CreateAttributeType.md
[71]: ../../Aml.Engine.CAEX/AttributeType/CreateMirror.md
[72]: ../../Aml.Engine.CAEX/CAEXWrapper/Equals.md
[73]: ../../Aml.Engine.CAEX/AttributeTypeType/GetCaexValue.md
[74]: ../../Aml.Engine.CAEX.Extensions/CaexValue/README.md
[75]: ../../Aml.Engine.CAEX/AttributeTypeType/GetDateTime.md
[76]: https://docs.microsoft.com/dotnet/api/system.xml.xmlconvert.todatetime#System_Xml_XmlConvert_ToDateTime_System_String_System_Xml_XmlDateTimeSerializationMode_
[77]: ../../Aml.Engine.CAEX/AttributeTypeType/GetDouble.md
[78]: https://docs.microsoft.com/dotnet/api/system.xml.xmlconvert.todouble#System_Xml_XmlConvert_ToDouble_System_String_
[79]: ../../Aml.Engine.CAEX/CAEXWrapper/GetHashCode.md
[80]: ../../Aml.Engine.CAEX/CAEXWrapper/GetXAttributeValue.md
[81]: ../../Aml.Engine.CAEX/AttributeTypeType/Insert_1.md
[82]: ../../Aml.Engine.CAEX/AttributeTypeType/Insert.md
[83]: ../../Aml.Engine.CAEX/AttributeTypeType/InsertAfter.md
[84]: ../../Aml.Engine.CAEX/AttributeTypeType/InsertBefore.md
[85]: ../../Aml.Engine.CAEX/CAEXWrapper/InsertNew.md
[86]: IsFrame.md
[87]: IsFrameAttribute.md
[88]: ../../Aml.Engine.CAEX/CAEXBasicObject/New_Revision.md
[89]: ../../Aml.Engine.CAEX/AttributeType/RecreateAttributeInstance.md
[90]: ../../Aml.Engine.CAEX/CAEXWrapper/Remove.md
[91]: ../../Aml.Engine.CAEX/AttributeTypeType/SetDateTime.md
[92]: ../../Aml.Engine.CAEX/AttributeTypeType/SetDouble.md
[93]: ../../Aml.Engine.CAEX/CAEXWrapper/SetXAttributeValue.md
[94]: ../../Aml.Engine.CAEX/CAEXObject/ToString.md
[95]: ../../Aml.Engine.CAEX/AttributeTypeType/TryGetDateTime.md
[96]: ../../Aml.Engine.CAEX/AttributeTypeType/TryGetDouble.md
[97]: ValidateAndRepairFrameDatatypes.md
[98]: ../../Aml.Engine.CAEX/CAEXWrapper/PropertyChanged.md
[99]: FormatInfo.md
[100]: FRAME_NAME.md
[101]: RX_Name.md
[102]: RY_Name.md
[103]: RZ_Name.md
[104]: X_Name.md
[105]: Y_Name.md
[106]: Z_Name.md
[107]: ../ListAttribute/AddListItem.md
[108]: ../ListAttribute/README.md
[109]: ../../Aml.Engine.Adapter/AMLEngineAdapter/clone.md
[110]: ../../Aml.Engine.CAEX/CAEXWrapper/Copy.md
[111]: ../../Aml.Engine.Adapter/AMLEngineAdapter/README.md
[112]: ../../Aml.Engine.Adapter/AMLEngineAdapter/CloneNode.md
[113]: ../../Aml.Engine.Adapter/AMLEngineAdapter/ConsistencyCheck_ClassReference.md
[114]: ../ListAttribute/ConvertToListAttribute.md
[115]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants.md
[116]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/README.md
[117]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants__1.md
[118]: ../../Aml.Engine.Adapter/AMLEngineAdapter/findInternalElement.md
[119]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedClass.md
[120]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedGUID.md
[121]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedInterfaceClass.md
[122]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedInterfaceName.md
[123]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_Element.md
[124]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_NewInstance.md
[125]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_TypeBaseElement.md
[126]: ../../Aml.Engine.CAEX/CAEXBasicObject/Insert.md
[127]: ../AutomationMLBaseAttributeTypeLib/IsAssociatedExternalValue.md
[128]: ../AutomationMLBaseAttributeTypeLib/README.md
[129]: ../AutomationMLBaseAttributeTypeLib/IsAssociatedFacet.md
[130]: ../AutomationMLBaseAttributeTypeLib/IsAssociatedValue.md
[131]: ../AutomationMLBaseAttributeTypeLib/IsCardinality.md
[132]: ../AutomationMLBaseAttributeTypeLib/IsCategory.md
[133]: ../../Aml.Engine.CAEX.Extensions/InheritanceExtensions/IsDerivedFromAttributeType.md
[134]: ../../Aml.Engine.CAEX.Extensions/InheritanceExtensions/README.md
[135]: ../AutomationMLBaseAttributeTypeLib/IsDirection.md
[136]: ../AutomationMLBaseAttributeTypeLib/IsDocLang.md
[137]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/IsFacetAttribute.md
[138]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/README.md
[139]: ../AutomationMLBaseAttributeTypeLib/IsFrame.md
[140]: ../ListAttribute/IsListAttribute.md
[141]: ../AutomationMLBaseAttributeTypeLib/IsListType.md
[142]: ../AutomationMLBaseAttributeTypeLib/IsLocalizedAttribute.md
[143]: ../../Aml.Engine.CAEX.Extensions/AttributeTypeTypeExtensions/IsMaster.md
[144]: ../../Aml.Engine.CAEX.Extensions/AttributeTypeTypeExtensions/README.md
[145]: ../AutomationMLBaseAttributeTypeLib/IsMIMEType.md
[146]: ../ListAttribute/IsOrderedListAttribute.md
[147]: ../AutomationMLBaseAttributeTypeLib/IsOrderedListType.md
[148]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/IsRefTypeAttribute.md
[149]: ../AutomationMLBaseAttributeTypeLib/IsRefUri.md
[150]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/IsRefURIAttribute.md
[151]: ../ListAttribute/IsUnOrderedListAttribute.md
[152]: ../ListAttribute/ListItems.md
[153]: ../ListAttribute/ListItemValues.md
[154]: ../ListAttribute/MakeListAttribute.md
[155]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Name.md
[156]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Name.md
[157]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/New_Description.md
[158]: ../../Aml.Engine.CAEX.Extensions/AttributeTypeTypeExtensions/New_RefSemantic.md
[159]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/ToRefTypeAttribute.md
[160]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/ToRefURIAttribute.md
[161]: ../../Aml.Engine.CAEX/AttributeType/Aml_Engine_CAEX_IMirror_CreateMirror.md
[162]: ../../Aml.Engine.CAEX/AttributeType/Aml_Engine_CAEX_IMirror_IsMaster.md
[163]: ../../Aml.Engine.CAEX/AttributeType/Aml_Engine_CAEX_IMirror_Master.md
[164]: https://www.automationml.org
[165]: ../../icons/logoShade.png
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