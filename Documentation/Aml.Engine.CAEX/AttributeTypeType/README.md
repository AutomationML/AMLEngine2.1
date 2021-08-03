AttributeTypeType Class
=======================
This Class is the generic base class for 'Attribute' and 'AttributeType' elements and defines base structures for Attribute- and AttributeType definitions.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  [Aml.Engine.CAEX.CAEXWrapper][2]  
    [Aml.Engine.CAEX.CAEXBasicObject][3]  
      [Aml.Engine.CAEX.CAEXObject][4]  
        **Aml.Engine.CAEX.AttributeTypeType**  
          [Aml.Engine.CAEX.AttributeFamilyType][5]  
          [Aml.Engine.CAEX.AttributeType][6]  

  **Namespace:**  [Aml.Engine.CAEX][7]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public class AttributeTypeType : CAEXObject, 
	IAttributeValueType, ICAEXWrapper, IXMLWrapper, IMultipleOccurrences<AttributeTypeType>, 
	ICAEXBasicObject, IObjectWithAttributes
```

The **AttributeTypeType** type exposes the following members.


Constructors
------------

                 | Name                   | Description                                                    
---------------- | ---------------------- | -------------------------------------------------------------- 
![Public method] | [AttributeTypeType][8] | Initializes a new instance of the **AttributeTypeType** class. 


Properties
----------

                                   | Name                                 | Description                                                                                                                                                                                                             
---------------------------------- | ------------------------------------ | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public property]                 | [AdditionalInformation][9]           | Gets the collection of AdditionalInformation values contained in this instance. (Inherited from [CAEXBasicObject][3].)                                                                                                  
![Public property]                 | [Attribute][10]                      | Gets a collection of Attributes contained in this instance.                                                                                                                                                             
![Public property]                 | [AttributeAndDescendants][11]        | Gets the attributes and all nested attributes.                                                                                                                                                                          
![Public property]                 | [AttributeDataType][12]              | Gets and sets the AttributeDataType attribute of this Attribute object. If the referenced attribute type does not base on an XML standard base type, the AttributeDataType may remain empty or not present.             
![Public property]                 | [AttributeTypeDefiningAttribute][13] | Gets the Attribute datatype which is valid for values of all [ValueAttributes][14] of this element. For this class, it is the instance itself.                                                                          
![Public property]                 | [AttributeValue][15]                 | Gets and set the encoded/decoded attribute value according to the defined AttributeDataType.                                                                                                                            
![Public property]                 | [CAEXDocument][16]                   | Gets the CAEX document of this CAEX object. If the CAEX object has not been inserted into a document or has been removed from the document, the value is `null`. (Inherited from [CAEXWrapper][2].)                     
![Public property]                 | [CAEXParent][17]                     | Gets the CAEXParent of this instance if it exists. (Inherited from [CAEXWrapper][2].)                                                                                                                                   
![Public property]                 | [CAEXSequenceOfCAEXObject][18]       | Gets the CAEXSequence containing this CAEX object (Inherited from [CAEXWrapper][2].)                                                                                                                                    
![Public property]                 | [ChangeMode][19]                     | Gets and sets the change mode for a CAEX element (Optional in CAEX). (Inherited from [CAEXBasicObject][3].)                                                                                                             
![Public property]                 | [Constraint][20]                     | Gets the collection of AttributeValueRequirement objects contained in this instance.                                                                                                                                    
![Public property]                 | [Copyright][21]                      | Gets and sets the Copyright for this object. (Inherited from [CAEXBasicObject][3].)                                                                                                                                     
![Public property]                 | [CopyrightElement][22]               | Gets the wrapper for the Copyright element. (Inherited from [CAEXBasicObject][3].)                                                                                                                                      
![Public property]                 | [DefaultAttributeValue][23]          | Gets and set the encoded/decoded default attribute value according to the defined AttributeDataType.                                                                                                                    
![Public property]                 | [DefaultValue][24]                   | Gets and sets the DefaultValue element of this Attribute object. Use the property [DefaultAttributeValue][23], to get or set the type encoded default value according to the Attribute Data Type.                       
![Public property]                 | [Description][25]                    | Gets and sets the Description for this object. (Inherited from [CAEXBasicObject][3].)                                                                                                                                   
![Public property]                 | [DescriptionElement][26]             | Gets the wrapper for the Description element. (Inherited from [CAEXBasicObject][3].)                                                                                                                                    
![Public property]                 | [Document][27]                       | Gets the XDocument of the wrapped XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                                                        
![Public property]                 | [Exists][28]                         | Determines if this is a wrapper around an existing XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                                       
![Public property]                 | [ID][29]                             | Gets and sets a unique identifier of the CAEX object (optional in CAEX). AutomationML requires IDs for some Elements. These IDs are automatically set when such elements are created. (Inherited from [CAEXObject][4].) 
![Public property]                 | [Item][30]                           | Gets the type-decoded value and sets the type-encoded value for the value attribute with the defined name. The allowed Names as [ATTRIBUTE_VALUE_STRING][31] and [ATTRIBUTE_DEFAULTVALUE_STRING][32].                   
![Public property]                 | [Name][33]                           | Gets and sets the name of the CAEX object (required in CAEX). (Inherited from [CAEXObject][4].)                                                                                                                         
![Public property]                 | [Node][34]                           | Gets the wrapped XML-Element (Inherited from [CAEXWrapper][2].)                                                                                                                                                         
![Public property]                 | [Owner][35]                          | Gets the wrapped Xml-Element's parent (Inherited from [CAEXWrapper][2].)                                                                                                                                                
![Public property]                 | [RefAttributeType][36]               | Gets and sets the RefAttributeType CAEX attribute of the Attribute object. This property is used to create instance to class relations between Attributes (instances) and AttributeType objects (classes).              
![Public property]                 | [RefSemantic][37]                    | Gets the collection of RefSemantic objects contained in this instance                                                                                                                                                   
![Public property]                 | [Revision][38]                       | Gets the collection of Revision objects contained in this instance. (Inherited from [CAEXBasicObject][3].)                                                                                                              
![Public property]                 | [SourceObjectInformation][39]        | Gets the collection of SourceObjectInformation objects contained in this instance. (Inherited from [CAEXBasicObject][3].)                                                                                               
![Public property]                 | [TagName][40]                        | Gets the name of the CAEX tag for this CAEX object. (Inherited from [CAEXWrapper][2].)                                                                                                                                  
![Public property]                 | [Unit][41]                           | Gets and sets the Unit attribute for this Attribute object.                                                                                                                                                             
![Public property]![Code example]  | [Value][42]                          | Gets and sets the Value for this Attribute object. The correct XML-String representation for the defined [AttributeDataType][12] has to be ensured by the caller.                                                       
![Public property]                 | [ValueAttributes][14]                | Gets all the CAEXValue objects for the defined value attributes of this instance. Recognized value attributes are [ATTRIBUTE_DEFAULTVALUE_STRING][32] and [ATTRIBUTE_VALUE_STRING][31].                                 
![Public property]                 | [Version][43]                        | Gets and sets the Version for this object. (Inherited from [CAEXBasicObject][3].)                                                                                                                                       
![Public property]                 | [VersionElement][44]                 | Gets the wrapper for the Version element. (Inherited from [CAEXBasicObject][3].)                                                                                                                                        
![Public property]![Static member] | [XsdDataTypes][45]                   | The XSD data types which are supported.                                                                                                                                                                                 


Methods
-------

                                 | Name                               | Description                                                                                                                                                                                                                                                                                                                                                                                             
-------------------------------- | ---------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method]                 | [AssignNewGuidAsID][46]            | Assigns the new unique identifier as a new ID to this CAEX object. (Inherited from [CAEXObject][4].)                                                                                                                                                                                                                                                                                                    
![Public method]                 | [CAEXChild][47]                    | Gets the first child of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                             
![Public method]                 | [CAEXChildren][48]                 | Gets all children of this CAEX object with the defined CAEX tag name. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                
![Public method]                 | [CAEXPath][49]                     | Gets the CAEX path for this object. A path can be used to uniquely reference an object, for example in inheritances and instances. The path syntax for an object is defined differently in CAEX 2.15 and CAEX 3.0. The engine uses the [CAEXPathBuilder][50] to generate the CAEX path of an object according to the documents CAEX version. (Inherited from [CAEXObject][4].)                          
![Public method]                 | [CAEXSequence][51]                 | Gets the CAEXSequence owned by this CAEX object, which contains the specified CAEX object. (Overrides [CAEXBasicObject.CAEXSequence(ICAEXWrapper)][52].)                                                                                                                                                                                                                                                
![Public method]![Static member] | [ClrToXmlType][53]                 | Gets the xmlType type for the specified CLR type. The Mapping is done according to [Mapping XML Data Types to CLR Types.][54] This reverse mapping is not unambiguous. If more than one mapping is possible, the most common used description is generated. If No mapping is defined the 'xs:string' is used.                                                                                           
![Public method]                 | [Container&lt;T>][55]              | Gets the CAEX Container for elements of type T, which is owned by this CAEX object (Overrides [CAEXBasicObject.Container&lt;T>()][56].)                                                                                                                                                                                                                                                                 
![Public method]                 | [Copy][57]                         | Creates a deep copy of this CAEX object, containing all child elements. The created copy will have replaced unique IDs and updated references, if the *assignNewIDs* is set to true (default). When a CAEX class is copied, the nested classes that can exist for AttributeType, RoleClass, SystemUnitClass, and InterfaceClass are not included in the created copy. (Inherited from [CAEXObject][4].) 
![Public method]                 | [Equals][58]                       | Equality of CAEX wrapper instances is defined on the equality of the wrapped XML elements. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                           
![Public method]                 | [GetCaexValue][59]                 | Gets the [CaexValue][60] for the value attribute with the defined attribute name. The allowed Names as [ATTRIBUTE_VALUE_STRING][31] and [ATTRIBUTE_DEFAULTVALUE_STRING][32].                                                                                                                                                                                                                            
![Public method]                 | [GetDateTime][61]                  | Parse the Attribute Value string as dateTime. If the string can not be parsed, a format exception is returned. This method uses the XmlConvert [ToDateTime(String, XmlDateTimeSerializationMode)][62] method.                                                                                                                                                                                           
![Public method]                 | [GetDouble][63]                    | Parse the Attribute Value string as double. If the string can not be parsed, a format exception is returned. This method uses the XmlConvert [ToDouble(String)][64] method and a fall back conversion, if the first conversion fails.                                                                                                                                                                   
![Public method]                 | [GetHashCode][65]                  | Gets the Hash code for this instance, using the wrapped XML element. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                                                 
![Public method]                 | [GetXAttributeValue][66]           | Gets the value of the Xml-Attribute with the specified attribute name of the wrapped Xml-Element. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                    
![Public method]                 | [Insert(Int32, CAEXWrapper)][67]   | Inserts the specified CAEX object in it's associated sequence at the defined position. The AttributeType defines additional sequences for [Attribute][10], [Constraint][20] and [RefSemantic][37]. (Overrides [CAEXBasicObject.Insert(Int32, CAEXWrapper)][68].)                                                                                                                                        
![Public method]                 | [Insert(CAEXWrapper, Boolean)][69] | Inserts the specified CAEX object in it's associated sequence. The AttributeType defines additional sequences for [Attribute][10], [Constraint][20] and [RefSemantic][37]. (Overrides [CAEXBasicObject.Insert(CAEXWrapper, Boolean)][70].)                                                                                                                                                              
![Public method]                 | [InsertAfter][71]                  | Inserts the provided CAEX object as a new sibling after this CAEX object.                                                                                                                                                                                                                                                                                                                               
![Public method]                 | [InsertBefore][72]                 | Inserts the provided CAEX object as a new sibling before this CAEX object.                                                                                                                                                                                                                                                                                                                              
![Public method]                 | [InsertNew][73]                    | This method can be used to create an XML node, if this CAEX wrapper was instantiated without an XML node. This method can only be applied, if an [Owner][35] is defined. The new created CAEX object is inserted as a new child of the owner. (Inherited from [CAEXWrapper][2].)                                                                                                                        
![Public method]                 | [New_Revision][74]                 | Creates a new Revision object and inserts it to the collection of Revision objects [Revision][38] either at the beginning or at the end of the sequence, according to the specified optional value. The Revision object is initialized with the provided values. (Inherited from [CAEXBasicObject][3].)                                                                                                 
![Public method]                 | [Remove][75]                       | Removes this element. After that it is no longer assigned to a document and has no owner anymore. (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                    
![Public method]                 | [SetDateTime][76]                  | Sets the specified dateTime value as the attribute value. The AttributeDataType is set to xs:dateTime                                                                                                                                                                                                                                                                                                   
![Public method]                 | [SetDouble][77]                    | Sets the specified double value as the attribute value. The AttributeDataType is set to xs:double                                                                                                                                                                                                                                                                                                       
![Public method]                 | [SetXAttributeValue][78]           | Sets the value of an attribute, adds an attribute, or removes an attribute (if the value is null). (Inherited from [CAEXWrapper][2].)                                                                                                                                                                                                                                                                   
![Public method]                 | [ToString][79]                     | Returns the value of the 'Name' attribute of this CAEX object as the string representation of the object. (Inherited from [CAEXObject][4].)                                                                                                                                                                                                                                                             
![Public method]                 | [TryGetDateTime][80]               | Tries to parse the Attribute Value string as dateTime. This method uses the XmlConvert [ToDateTime(String, XmlDateTimeSerializationMode)][62] method.                                                                                                                                                                                                                                                   
![Public method]                 | [TryGetDouble][81]                 | Tries to parse the Attribute Value string as double. This method uses the XmlConvert [ToDouble(String)][64] method and a fall back conversion, if the first conversion fails.                                                                                                                                                                                                                           
![Public method]![Static member] | [XmlTypeToClrType][82]             | Gets the CLR type for the specified xmlType. The Mapping is done according to [Mapping XML Data Types to CLR Types.][54]                                                                                                                                                                                                                                                                                


Events
------

                | Name                  | Description                                                                               
--------------- | --------------------- | ----------------------------------------------------------------------------------------- 
![Public event] | [PropertyChanged][83] | The Change event raised when any property is modified. (Inherited from [CAEXWrapper][2].) 


Operators
---------

                                   | Name                                                         | Description                                                          
---------------------------------- | ------------------------------------------------------------ | -------------------------------------------------------------------- 
![Public operator]![Static member] | [Implicit(AttributeTypeType to ObjectWithAMLAttributes)][84] | Conversion to get access to specific AutomationML defined Attributes 


Extension Methods
-----------------

                                          | Name                                                                           | Description                                                                                                                                                                                                                                                                                                                                                                              
----------------------------------------- | ------------------------------------------------------------------------------ | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public Extension Method]![Code example] | [AddAttributeTypeReference(String, Boolean, Boolean, String)][85]              | Overloaded. Adds an AttributeType reference to this ObjectWithAttribute using the provided CAEX path, referencing an AttributeType object. The AttributeType reference is added as a [AttributeType][6] object. (Defined by [ObjectWithAttributes][86].)                                                                                                                                 
![Public Extension Method]![Code example] | [AddAttributeTypeReference(AttributeFamilyType, Boolean, Boolean, String)][87] | Overloaded. Adds an AttributeType reference to this ObjectWithAttribute using the provided AttributeType object. The AttributeType reference is added as a [AttributeType][6] object. (Defined by [ObjectWithAttributes][86].)                                                                                                                                                           
![Public Extension Method]                | [AMLAttributes][88]                                                            | Conversion of any object which has an attribute collection to get access to specific AutomationML defined attributes. (Defined by [AmlObjectsExtensions][89].)                                                                                                                                                                                                                           
![Public Extension Method]                | [AMLSchemaManager][90]                                                         | Gets the associated CAEX schema manager of the CAEX object. (Defined by [CAEXBasicObjectExtensions][91].)                                                                                                                                                                                                                                                                                
![Public Extension Method]                | [Ancestors&lt;T>][92]                                                          | Finds the ancestors of the provided CAEX object which have the given type. (Defined by [CAEXBasicObjectExtensions][91].)                                                                                                                                                                                                                                                                 
![Public Extension Method]                | [Attributes][93]                                                               | Enumeration Method for direct Children of Type [AttributeType][6] (Defined by [AMLEngineAdapter][94].)                                                                                                                                                                                                                                                                                   
![Public Extension Method]                | [CAEXDocument][95]                                                             | Gets the CAEX document which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][91].)                                                                                                                                                                                                                                                                                    
![Public Extension Method]                | [CAEXFile][96]                                                                 | Gets the CAEX file which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][91].)                                                                                                                                                                                                                                                                                        
![Public Extension Method]                | [CAEXSchema][97]                                                               | Gets the associated CAEX schema of the CAEX object. (Defined by [CAEXBasicObjectExtensions][91].)                                                                                                                                                                                                                                                                                        
![Public Extension Method]                | [clone][98]                                                                    | [Copy(Boolean, Boolean, Boolean)][99] (Defined by [AMLEngineAdapter][94].)                                                                                                                                                                                                                                                                                                               
![Public Extension Method]                | [CloneNode][100]                                                               | Clones the node. (Defined by [AMLEngineAdapter][94].)                                                                                                                                                                                                                                                                                                                                    
![Public Extension Method]                | [ConsistencyCheck_ClassReference][101]                                         | Check if the given classPath is a valid path to an existent class in the AML file. (Defined by [AMLEngineAdapter][94].)                                                                                                                                                                                                                                                                  
![Public Extension Method]                | [CopyAttributesFrom][102]                                                      | Copies all attribute of the source object with attributes to the target object including children (Defined by [ObjectWithAttributes][86].)                                                                                                                                                                                                                                               
![Public Extension Method]                | [CreateListAttribute][103]                                                     | Creates a new list attribute for an element which can have attributes. (Defined by [ListAttribute][104].)                                                                                                                                                                                                                                                                                
![Public Extension Method]                | [Descendants(Type)][105]                                                       | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][91].)                                                                                                                                                                                                                                                 
![Public Extension Method]                | [Descendants&lt;T>()][106]                                                     | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][91].)                                                                                                                                                                                                                                                 
![Public Extension Method]                | [Descendants&lt;T>(Boolean)][107]                                              | Overloaded. Finds the descendants of the provided CAEX object which are of the given type. (Defined by [CAEXBasicObjectExtensions][91].)                                                                                                                                                                                                                                                 
![Public Extension Method]                | [FindCaexObjectFromId&lt;T>][108]                                              | Finds the CAEX object with the specified id and the specified Type. (Defined by [CAEXBasicObjectExtensions][91].)                                                                                                                                                                                                                                                                        
![Public Extension Method]                | [findInternalElement][109]                                                     | Resolve a reference to an InternalElement and return the referenced element if found. (Defined by [AMLEngineAdapter][94].)                                                                                                                                                                                                                                                               
![Public Extension Method]                | [FindReferencedClass&lt;T>][110]                                               | Finds the CAEX object with the specified CAEX path and the specified Type. (Defined by [CAEXBasicObjectExtensions][91].)                                                                                                                                                                                                                                                                 
![Public Extension Method]                | [FirstAncestor(String)][111]                                                   | Overloaded. Finds the first ancestor of the specified CAEX object with the given Tag name (Defined by [CAEXBasicObjectExtensions][91].)                                                                                                                                                                                                                                                  
![Public Extension Method]                | [FirstAncestor(Predicate&lt;ICAEXWrapper>)][112]                               | Overloaded. Finds the first ancestor of the specified CAEX object which fulfils the specified predicate (Defined by [CAEXBasicObjectExtensions][91].)                                                                                                                                                                                                                                    
![Public Extension Method]                | [FirstAncestor&lt;T>()][113]                                                   | Overloaded. Finds the first ancestor of the specified CAEX object in the given Type. (Defined by [CAEXBasicObjectExtensions][91].)                                                                                                                                                                                                                                                       
![Public Extension Method]                | [FrameAttribute][114]                                                          | Gets a defined FrameAttribute from the [Attribute][115] collection of the [IObjectWithAttributes][116]. If no such attribute exists, `null` is returned. (Defined by [AmlObjectsExtensions][89].)                                                                                                                                                                                        
![Public Extension Method]                | [GetAttribute][117]                                                            | Gets the first attribute with the specified name from the attribute collection of the CAEX object. (Defined by [ObjectWithAttributes][86].)                                                                                                                                                                                                                                              
![Public Extension Method]                | [getAttributeField][118]                                                       | Get the whole attribute field containing a collection of all attributes of this object. (Defined by [AMLEngineAdapter][94].)                                                                                                                                                                                                                                                             
![Public Extension Method]                | [GetAttributeValue][119]                                                       | Returns an attribute value of a given attribute name. (Defined by [AMLEngineAdapter][94].)                                                                                                                                                                                                                                                                                               
![Public Extension Method]                | [GetParent&lt;T>][120]                                                         | Tries to get a CAEX parent with the specified Type of the provided caexObject. If the parent is not assignable to the provided type, the result is `null`. (Defined by [CAEXBasicObjectExtensions][91].)                                                                                                                                                                                 
![Public Extension Method]                | [getReferencedClass][121]                                                      | Getting the XML Node for a class path. (Defined by [AMLEngineAdapter][94].)                                                                                                                                                                                                                                                                                                              
![Public Extension Method]                | [getReferencedGUID][122]                                                       | Parsing a string of form GUID:Interface and returning the GUID (Defined by [AMLEngineAdapter][94].)                                                                                                                                                                                                                                                                                      
![Public Extension Method]                | [getReferencedInterfaceClass][123]                                             | Getting a referenced InterfaceClass. Use FindFastByPath for speed optimizations. (Defined by [AMLEngineAdapter][94].)                                                                                                                                                                                                                                                                    
![Public Extension Method]                | [getReferencedInterfaceName][124]                                              | Getting the name of the referenced Interface. (Defined by [AMLEngineAdapter][94].)                                                                                                                                                                                                                                                                                                       
![Public Extension Method]                | [Insert_Attribute][125]                                                        | Inserts an Attribute object in the Attribute collection of the *objectWithAttributes*. (Defined by [SystemUnitClassTypeExtensions][126].)                                                                                                                                                                                                                                                
![Public Extension Method]                | [Insert_Element][127]                                                          | Inserting an element of base type TypeBase to this object. The Element is inserted at the first Element of any existing Elements of the same Type if nothing else is explicit defined. (Defined by [AMLEngineAdapter][94].)                                                                                                                                                              
![Public Extension Method]                | [Insert_NewInstance][128]                                                      | Inserting a new class instance to this object. This method can be overridden in derived classes. The Instance is inserted as the first instance of any other element with the same type if nothing else is explicit defined. (Defined by [AMLEngineAdapter][94].)                                                                                                                        
![Public Extension Method]                | [Insert_TypeBaseElement][129]                                                  | [Insert(CAEXWrapper, Boolean)][70] (Defined by [AMLEngineAdapter][94].)                                                                                                                                                                                                                                                                                                                  
![Public Extension Method]                | [IsAMLObject][130]                                                             | Determines whether the CAEX object is an AutomationML object. If the CAEX object is a SystemUnitClass or InternalElement, it is checked, if there exists a role reference to the AutomationMLBaseRole. If the CAEX object is an ExternalInterface, it is checked, if there exists an InterfaceClass reference to an AutomationMLBase Interface. (Defined by [AmlObjectsExtensions][89].) 
![Public Extension Method]                | [IsAssociatedExternalValue][131]                                               | (Defined by [AutomationMLBaseAttributeTypeLib][132].)                                                                                                                                                                                                                                                                                                                                    
![Public Extension Method]                | [IsAssociatedFacet][133]                                                       | Determines whether the specified attribute reference defines an inheritance relation from the AssociatedFacet AttributeType (Defined by [AutomationMLBaseAttributeTypeLib][132].)                                                                                                                                                                                                        
![Public Extension Method]                | [IsAssociatedValue][134]                                                       | Determines whether the specified attribute reference defines an inheritance relation from the AssociatedValue AttributeType (Defined by [AutomationMLBaseAttributeTypeLib][132].)                                                                                                                                                                                                        
![Public Extension Method]                | [IsCardinality][135]                                                           | Determines whether the specified attribute reference defines an inheritance relation from the Cardinality AttributeType (Defined by [AutomationMLBaseAttributeTypeLib][132].)                                                                                                                                                                                                            
![Public Extension Method]                | [IsCategory][136]                                                              | Determines whether the specified attribute reference defines an inheritance relation from the Category AttributeType (Defined by [AutomationMLBaseAttributeTypeLib][132].)                                                                                                                                                                                                               
![Public Extension Method]                | [IsDerivedFromAttributeType][137]                                              | Determines whether the specified attribute defines an inheritance relation from the attribute, uniquely identifiable by the given attribute type path. The attribute type path may contain an alias. (Defined by [InheritanceExtensions][138].)                                                                                                                                          
![Public Extension Method]                | [IsDirection][139]                                                             | Determines whether the specified attribute reference defines an inheritance relation from the Direction AttributeType (Defined by [AutomationMLBaseAttributeTypeLib][132].)                                                                                                                                                                                                              
![Public Extension Method]                | [IsDocLang][140]                                                               | Determines whether the specified attribute reference defines an inheritance relation from the DocLang AttributeType (Defined by [AutomationMLBaseAttributeTypeLib][132].)                                                                                                                                                                                                                
![Public Extension Method]                | [IsFrame][141]                                                                 | Determines whether the specified attribute reference defines an inheritance relation from the Frame AttributeType (Defined by [AutomationMLBaseAttributeTypeLib][132].)                                                                                                                                                                                                                  
![Public Extension Method]                | [IsListType][142]                                                              | Determines whether the specified attribute reference defines an inheritance relation from the ListType AttributeType (Defined by [AutomationMLBaseAttributeTypeLib][132].)                                                                                                                                                                                                               
![Public Extension Method]                | [IsLocalizedAttribute][143]                                                    | Determines whether the specified attribute reference defines an inheritance relation from the LocalizedAttribute AttributeType (Defined by [AutomationMLBaseAttributeTypeLib][132].)                                                                                                                                                                                                     
![Public Extension Method]                | [IsMIMEType][144]                                                              | Determines whether the specified attribute reference defines an inheritance relation from the MIMEType AttributeType (Defined by [AutomationMLBaseAttributeTypeLib][132].)                                                                                                                                                                                                               
![Public Extension Method]                | [IsOrderedListType][145]                                                       | Determines whether the specified attribute reference defines an inheritance relation from the OrderedListType AttributeType (Defined by [AutomationMLBaseAttributeTypeLib][132].)                                                                                                                                                                                                        
![Public Extension Method]                | [IsRefUri][146]                                                                | Determines whether the specified attribute reference defines an inheritance relation from the RefURI AttributeType (Defined by [AutomationMLBaseAttributeTypeLib][132].)                                                                                                                                                                                                                 
![Public Extension Method]                | [Library][147]                                                                 | Gets the Library which contains this CAEX object. (Defined by [CAEXBasicObjectExtensions][91].)                                                                                                                                                                                                                                                                                          
![Public Extension Method]                | [Name()][148]                                                                  | Overloaded. Get the Name of the specified object. (Defined by [AMLEngineAdapter][94].)                                                                                                                                                                                                                                                                                                   
![Public Extension Method]                | [Name()][149]                                                                  | Overloaded. Gets a names for the specified caex wrapper object. If the specified object is a [CAEXObject][4], the Name is returned; otherwise the TagName of the CAEX item. (Defined by [CAEXBasicObjectExtensions][91].)                                                                                                                                                                
![Public Extension Method]                | [New_Attribute][150]                                                           | Appends a new Attribute object with the defined name to the specified CAEX object. (Defined by [ObjectWithAttributes][86].)                                                                                                                                                                                                                                                              
![Public Extension Method]                | [New_Copyright][151]                                                           | Adds an new Copyright node to this object if it doesn't exists. (Defined by [CAEXBasicObjectExtensions][91].)                                                                                                                                                                                                                                                                            
![Public Extension Method]                | [New_Description][152]                                                         | Adds an new Description node to this object if it doesn't exists. (Defined by [CAEXBasicObjectExtensions][91].)                                                                                                                                                                                                                                                                          
![Public Extension Method]                | [New_FrameAttribute][153]                                                      | Creates a new Frame attribute for the [IObjectWithAttributes][116] if no Frame attribute exists. The provided values are used to initialize the Frame attribute values. (Defined by [AmlObjectsExtensions][89].)                                                                                                                                                                         
![Public Extension Method]                | [New_RefSemantic][154]                                                         | Appends a new RefSemantic object with the defined semantics to the specified CAEX object. (Defined by [AttributeTypeTypeExtensions][155].)                                                                                                                                                                                                                                               
![Public Extension Method]                | [New_Version][156]                                                             | Adds an new Version node to this object if it doesn't exists. (Defined by [CAEXBasicObjectExtensions][91].)                                                                                                                                                                                                                                                                              
![Public Extension Method]                | [RefTypeAttribute][157]                                                        | Gets the RefTypeAttribute from the *objectWithAttributes* if one exists. (Defined by [AmlObjectsExtensions][89].)                                                                                                                                                                                                                                                                        
![Public Extension Method]                | [RefURIAttribute][158]                                                         | Gets the RefURIAttribute from the *objectWithAttributes* if one exists. (Defined by [AmlObjectsExtensions][89].)                                                                                                                                                                                                                                                                         
![Public Extension Method]                | [SetAttributeValue(String, String)][159]                                       | Overloaded. Sets the value for the attribute with the specified name from the attribute collection of the CAEX object. If no attribute with that name exists, it is created. (Defined by [ObjectWithAttributes][86].)                                                                                                                                                                    
![Public Extension Method]                | [SetAttributeValue(String, Double)][160]                                       | Overloaded. Modifies the attribute with the specified name from the attribute collection of the CAEX object, using the provided values. If no attribute with that name exists, it is created. Sets the AttributeDataType to xs:double (Defined by [ObjectWithAttributes][86].)                                                                                                           
![Public Extension Method]                | [SetAttributeValue(String, String, String, String)][161]                       | Overloaded. Modifies the attribute with the specified name from the attribute collection of the CAEX object, using the provided values. If no attribute with that name exists, it is created. (Defined by [ObjectWithAttributes][86].)                                                                                                                                                   
![Public Extension Method]                | [SetAttributeValue(String, Double, Double, String, String)][162]               | Overloaded. Modifies the attribute with the specified name from the attribute collection of the CAEX object, using the provided values. If no attribute with that name exists, it is created. Sets the AttributeDataType to xs:double (Defined by [ObjectWithAttributes][86].)                                                                                                           
![Public Extension Method]                | [SetAttributeValue(String, String, String, String, String, String)][163]       | Overloaded. Modifies the attribute with the specified name from the attribute collection of the CAEX object, using the provided values. If no attribute with that name exists, it is created. (Defined by [ObjectWithAttributes][86].)                                                                                                                                                   


See Also
--------

#### Reference
[Aml.Engine.CAEX Namespace][7]  
[Aml.Engine.CAEX.CAEXObject][4]  
[Aml.Engine.CAEX.IMultipleOccurrences&lt;T>][164]  
[Aml.Engine.CAEX.IObjectWithAttributes][116]  
[Aml.Engine.CAEX.IAttributeValueType][165]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../CAEXWrapper/README.md
[3]: ../CAEXBasicObject/README.md
[4]: ../CAEXObject/README.md
[5]: ../AttributeFamilyType/README.md
[6]: ../AttributeType/README.md
[7]: ../README.md
[8]: _ctor.md
[9]: ../CAEXBasicObject/AdditionalInformation.md
[10]: Attribute.md
[11]: AttributeAndDescendants.md
[12]: AttributeDataType.md
[13]: AttributeTypeDefiningAttribute.md
[14]: ValueAttributes.md
[15]: AttributeValue.md
[16]: ../CAEXWrapper/CAEXDocument.md
[17]: ../CAEXWrapper/CAEXParent.md
[18]: ../CAEXWrapper/CAEXSequenceOfCAEXObject.md
[19]: ../CAEXBasicObject/ChangeMode.md
[20]: Constraint.md
[21]: ../CAEXBasicObject/Copyright.md
[22]: ../CAEXBasicObject/CopyrightElement.md
[23]: DefaultAttributeValue.md
[24]: DefaultValue.md
[25]: ../CAEXBasicObject/Description.md
[26]: ../CAEXBasicObject/DescriptionElement.md
[27]: ../CAEXWrapper/Document.md
[28]: ../CAEXWrapper/Exists.md
[29]: ../CAEXObject/ID.md
[30]: Item.md
[31]: ../CAEX_CLASSModel_TagNames/ATTRIBUTE_VALUE_STRING.md
[32]: ../CAEX_CLASSModel_TagNames/ATTRIBUTE_DEFAULTVALUE_STRING.md
[33]: ../CAEXObject/Name.md
[34]: ../CAEXWrapper/Node.md
[35]: ../CAEXWrapper/Owner.md
[36]: RefAttributeType.md
[37]: RefSemantic.md
[38]: ../CAEXBasicObject/Revision.md
[39]: ../CAEXBasicObject/SourceObjectInformation.md
[40]: ../CAEXWrapper/TagName.md
[41]: Unit.md
[42]: Value.md
[43]: ../CAEXBasicObject/Version.md
[44]: ../CAEXBasicObject/VersionElement.md
[45]: XsdDataTypes.md
[46]: ../CAEXObject/AssignNewGuidAsID.md
[47]: ../CAEXWrapper/CAEXChild.md
[48]: ../CAEXWrapper/CAEXChildren.md
[49]: ../CAEXObject/CAEXPath.md
[50]: ../../Aml.Engine.CAEX.Extensions/CAEXPathBuilder/README.md
[51]: CAEXSequence.md
[52]: ../CAEXBasicObject/CAEXSequence.md
[53]: ClrToXmlType.md
[54]: https://msdn.microsoft.com/en-us/library/xa669bew(v=vs.110).aspx
[55]: Container__1.md
[56]: ../CAEXBasicObject/Container__1.md
[57]: ../CAEXObject/Copy.md
[58]: ../CAEXWrapper/Equals.md
[59]: GetCaexValue.md
[60]: ../../Aml.Engine.CAEX.Extensions/CaexValue/README.md
[61]: GetDateTime.md
[62]: https://docs.microsoft.com/dotnet/api/system.xml.xmlconvert.todatetime#System_Xml_XmlConvert_ToDateTime_System_String_System_Xml_XmlDateTimeSerializationMode_
[63]: GetDouble.md
[64]: https://docs.microsoft.com/dotnet/api/system.xml.xmlconvert.todouble#System_Xml_XmlConvert_ToDouble_System_String_
[65]: ../CAEXWrapper/GetHashCode.md
[66]: ../CAEXWrapper/GetXAttributeValue.md
[67]: Insert_1.md
[68]: ../CAEXBasicObject/Insert_1.md
[69]: Insert.md
[70]: ../CAEXBasicObject/Insert.md
[71]: InsertAfter.md
[72]: InsertBefore.md
[73]: ../CAEXWrapper/InsertNew.md
[74]: ../CAEXBasicObject/New_Revision.md
[75]: ../CAEXWrapper/Remove.md
[76]: SetDateTime.md
[77]: SetDouble.md
[78]: ../CAEXWrapper/SetXAttributeValue.md
[79]: ../CAEXObject/ToString.md
[80]: TryGetDateTime.md
[81]: TryGetDouble.md
[82]: XmlTypeToClrType.md
[83]: ../CAEXWrapper/PropertyChanged.md
[84]: op_Implicit.md
[85]: ../../Aml.Engine.CAEX.Extensions/ObjectWithAttributes/AddAttributeTypeReference_1.md
[86]: ../../Aml.Engine.CAEX.Extensions/ObjectWithAttributes/README.md
[87]: ../../Aml.Engine.CAEX.Extensions/ObjectWithAttributes/AddAttributeTypeReference.md
[88]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/AMLAttributes.md
[89]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/README.md
[90]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/AMLSchemaManager.md
[91]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/README.md
[92]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Ancestors__1.md
[93]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Attributes.md
[94]: ../../Aml.Engine.Adapter/AMLEngineAdapter/README.md
[95]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXDocument.md
[96]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXFile.md
[97]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/CAEXSchema.md
[98]: ../../Aml.Engine.Adapter/AMLEngineAdapter/clone.md
[99]: ../CAEXWrapper/Copy.md
[100]: ../../Aml.Engine.Adapter/AMLEngineAdapter/CloneNode.md
[101]: ../../Aml.Engine.Adapter/AMLEngineAdapter/ConsistencyCheck_ClassReference.md
[102]: ../../Aml.Engine.CAEX.Extensions/ObjectWithAttributes/CopyAttributesFrom.md
[103]: ../../Aml.Engine.AmlObjects/ListAttribute/CreateListAttribute.md
[104]: ../../Aml.Engine.AmlObjects/ListAttribute/README.md
[105]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants.md
[106]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants__1.md
[107]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Descendants__1_1.md
[108]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FindCaexObjectFromId__1.md
[109]: ../../Aml.Engine.Adapter/AMLEngineAdapter/findInternalElement.md
[110]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FindReferencedClass__1.md
[111]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor_1.md
[112]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor.md
[113]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/FirstAncestor__1.md
[114]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/FrameAttribute.md
[115]: ../IObjectWithAttributes/Attribute.md
[116]: ../IObjectWithAttributes/README.md
[117]: ../../Aml.Engine.CAEX.Extensions/ObjectWithAttributes/GetAttribute.md
[118]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getAttributeField.md
[119]: ../../Aml.Engine.Adapter/AMLEngineAdapter/GetAttributeValue.md
[120]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/GetParent__1.md
[121]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedClass.md
[122]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedGUID.md
[123]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedInterfaceClass.md
[124]: ../../Aml.Engine.Adapter/AMLEngineAdapter/getReferencedInterfaceName.md
[125]: ../../Aml.Engine.CAEX.Extensions/SystemUnitClassTypeExtensions/Insert_Attribute.md
[126]: ../../Aml.Engine.CAEX.Extensions/SystemUnitClassTypeExtensions/README.md
[127]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_Element.md
[128]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_NewInstance.md
[129]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Insert_TypeBaseElement.md
[130]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/IsAMLObject.md
[131]: ../../Aml.Engine.AmlObjects/AutomationMLBaseAttributeTypeLib/IsAssociatedExternalValue.md
[132]: ../../Aml.Engine.AmlObjects/AutomationMLBaseAttributeTypeLib/README.md
[133]: ../../Aml.Engine.AmlObjects/AutomationMLBaseAttributeTypeLib/IsAssociatedFacet.md
[134]: ../../Aml.Engine.AmlObjects/AutomationMLBaseAttributeTypeLib/IsAssociatedValue.md
[135]: ../../Aml.Engine.AmlObjects/AutomationMLBaseAttributeTypeLib/IsCardinality.md
[136]: ../../Aml.Engine.AmlObjects/AutomationMLBaseAttributeTypeLib/IsCategory.md
[137]: ../../Aml.Engine.CAEX.Extensions/InheritanceExtensions/IsDerivedFromAttributeType.md
[138]: ../../Aml.Engine.CAEX.Extensions/InheritanceExtensions/README.md
[139]: ../../Aml.Engine.AmlObjects/AutomationMLBaseAttributeTypeLib/IsDirection.md
[140]: ../../Aml.Engine.AmlObjects/AutomationMLBaseAttributeTypeLib/IsDocLang.md
[141]: ../../Aml.Engine.AmlObjects/AutomationMLBaseAttributeTypeLib/IsFrame.md
[142]: ../../Aml.Engine.AmlObjects/AutomationMLBaseAttributeTypeLib/IsListType.md
[143]: ../../Aml.Engine.AmlObjects/AutomationMLBaseAttributeTypeLib/IsLocalizedAttribute.md
[144]: ../../Aml.Engine.AmlObjects/AutomationMLBaseAttributeTypeLib/IsMIMEType.md
[145]: ../../Aml.Engine.AmlObjects/AutomationMLBaseAttributeTypeLib/IsOrderedListType.md
[146]: ../../Aml.Engine.AmlObjects/AutomationMLBaseAttributeTypeLib/IsRefUri.md
[147]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Library.md
[148]: ../../Aml.Engine.Adapter/AMLEngineAdapter/Name.md
[149]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/Name.md
[150]: ../../Aml.Engine.CAEX.Extensions/ObjectWithAttributes/New_Attribute.md
[151]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/New_Copyright.md
[152]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/New_Description.md
[153]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/New_FrameAttribute.md
[154]: ../../Aml.Engine.CAEX.Extensions/AttributeTypeTypeExtensions/New_RefSemantic.md
[155]: ../../Aml.Engine.CAEX.Extensions/AttributeTypeTypeExtensions/README.md
[156]: ../../Aml.Engine.CAEX.Extensions/CAEXBasicObjectExtensions/New_Version.md
[157]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/RefTypeAttribute.md
[158]: ../../Aml.Engine.AmlObjects.Extensions/AmlObjectsExtensions/RefURIAttribute.md
[159]: ../../Aml.Engine.CAEX.Extensions/ObjectWithAttributes/SetAttributeValue_2.md
[160]: ../../Aml.Engine.CAEX.Extensions/ObjectWithAttributes/SetAttributeValue.md
[161]: ../../Aml.Engine.CAEX.Extensions/ObjectWithAttributes/SetAttributeValue_3.md
[162]: ../../Aml.Engine.CAEX.Extensions/ObjectWithAttributes/SetAttributeValue_1.md
[163]: ../../Aml.Engine.CAEX.Extensions/ObjectWithAttributes/SetAttributeValue_4.md
[164]: ../IMultipleOccurrences_1/README.md
[165]: ../IAttributeValueType/README.md
[166]: https://www.automationml.org
[167]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public property]: ../../icons/pubproperty.gif "Public property"
[Code example]: ../../icons/CodeExample.png "Code example"
[Static member]: ../../icons/static.gif "Static member"
[Public event]: ../../icons/pubevent.gif "Public event"
[Public operator]: ../../icons/puboperator.gif "Public operator"
[Public Extension Method]: ../../icons/pubextension.gif "Public Extension Method"