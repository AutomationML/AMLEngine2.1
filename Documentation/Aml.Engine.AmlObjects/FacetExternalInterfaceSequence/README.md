FacetExternalInterfaceSequence Class
====================================
AutomationML 2.1 APIThis class defines a sequence of ExternalInterfaces which belong to an [AMLFacet][1]. A Facet interface shall be related to an existing interface of the parent object, the identifier is the same name. Facet interfaces which are not part of the parent object are not permitted. [IEC 62714-1:2014 8.3 (p.43)]


Inheritance Hierarchy
---------------------
[System.Object][2]  
  [Aml.Engine.CAEX.NamedElementSequence][3]&lt;[ExternalInterfaceType][4]>  
    [Aml.Engine.CAEX.CAEXSequence][5]&lt;[ExternalInterfaceType][4]>  
      [Aml.Engine.CAEX.CAEXSequenceOfCAEXObjects][6]&lt;[ExternalInterfaceType][4]>  
        [Aml.Engine.CAEX.ExternalInterfaceSequence][7]  
          **Aml.Engine.AmlObjects.FacetExternalInterfaceSequence**  

  **Namespace:**  [Aml.Engine.AmlObjects][8]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public class FacetExternalInterfaceSequence : ExternalInterfaceSequence
```

The **FacetExternalInterfaceSequence** type exposes the following members.


Constructors
------------

                 | Name                                | Description                                                                 
---------------- | ----------------------------------- | --------------------------------------------------------------------------- 
![Public method] | [FacetExternalInterfaceSequence][9] | Initializes a new instance of the **FacetExternalInterfaceSequence** class. 


Properties
----------

                   | Name                                      | Description                                                                                                                                                                            
------------------ | ----------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public property] | [CAEXOwner][10]                           | Gets the CAEX owner of this sequence (Inherited from [NamedElementSequence&lt;T>][3].)                                                                                                 
![Public property] | [Count][11]                               | Gets the number of elements in this sequence (Inherited from [NamedElementSequence&lt;T>][3].)                                                                                         
![Public property] | [ElementName][12]                         | Gets the name of the elements in this sequence (Inherited from [NamedElementSequence&lt;T>][3].)                                                                                       
![Public property] | [Elements][13]                            | Gets a list of unwrapped CAEX elements (XElements) of this sequence (Inherited from [NamedElementSequence&lt;T>][3].)                                                                  
![Public property] | [Exists][14]                              | Determines, if the sequence contains any element (Inherited from [NamedElementSequence&lt;T>][3].)                                                                                     
![Public property] | [First][15]                               | Gets a wrapper for the first CAEX element in this sequence, if the sequence contains no elements `null` is returned. (Inherited from [CAEXSequence&lt;T>][5].)                         
![Public property] | [Item[Int32]][16]                         | Gets a wrapper for the CAEX element in this sequence at the given position (Inherited from [CAEXSequence&lt;T>][5].)                                                                   
![Public property] | [Item[ValueTuple&lt;String, String>]][17] | Gets the first CAEX object with a specific attribute value from the sequence of elements (Inherited from [CAEXSequence&lt;T>][5].)                                                     
![Public property] | [Item[String]][18]                        | Gets the first CAEX object with this name from the sequence of elements. (Inherited from [CAEXSequenceOfCAEXObjects&lt;T>][6].)                                                        
![Public property] | [Item[String[]]][19]                      | Gets the CAEX object which can be identified with a CAEX path, where the path parts are defined in the provided array of names. (Inherited from [CAEXSequenceOfCAEXObjects&lt;T>][6].) 
![Public property] | [Last][20]                                | Gets a wrapper for the last CAEX element in this sequence, if the sequence contains no elements `null` is returned. (Inherited from [CAEXSequence&lt;T>][5].)                          
![Public property] | [Owner][21]                               | Gets the owner of this sequence (Inherited from [NamedElementSequence&lt;T>][3].)                                                                                                      


Methods
-------

                                | Name                                           | Description                                                                                                                                                                                                                                                                               
------------------------------- | ---------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method]                | [Append()][22]                                 | This method is not applicable for ExternalInterfaces, if the owner is an AMLFacet. (Overrides [CAEXSequence&lt;T>.Append()][23].)                                                                                                                                                         
![Public method]                | [Append(String)][24]                           | Appends a new element with the provided name to this sequence. Before the ExternalInterface is appended, it is checked, if the ExternalInterface name is already used for any ExternalInterface of the AMLFacet parent. (Overrides [CAEXSequenceOfCAEXObjects&lt;T>.Append(String)][25].) 
![Public method]![Code example] | [Append(ValueTuple&lt;String, Object>[])][26]  | Creates a new CAEX object and appends it to already existing elements. The content of the new element can be optionally defined using an array of tuples defining attribute names and their values. (Inherited from [CAEXSequence&lt;T>][5].)                                             
![Public method]                | [At][27]                                       | Gets the CAEX object at the specified index. (Inherited from [CAEXSequence&lt;T>][5].)                                                                                                                                                                                                    
![Public method]                | [ExternalInterfaceDescandantsAndSelf][28]      | Gets all external interfaces and the external interface descendants (The external interface tree). (Inherited from [ExternalInterfaceSequence][7].)                                                                                                                                       
![Public method]                | [GetEnumerator][29]                            | Gets the enumerator for this sequence. (Inherited from [CAEXSequence&lt;T>][5].)                                                                                                                                                                                                          
![Public method]                | [IndexOf][30]                                  | Gets the Index of the specified CAEX object in this sequence of elements. (Inherited from [CAEXSequence&lt;T>][5].)                                                                                                                                                                       
![Public method]                | [Insert][31]                                   | Inserts the specified ExternalInterface into this sequence. Before the ExternalInterface is inserted, it is checked, if it is a valid Facet-ExternalInterface. (Overrides [CAEXSequenceOfCAEXObjects&lt;T>.Insert(T, Boolean)][32].)                                                      
![Public method]                | [InsertAt][33]                                 | Inserts the specified CAEX object into this sequence at the defined index. (Inherited from [CAEXSequence&lt;T>][5].)                                                                                                                                                                      
![Public method]                | [Move][34]                                     | Moves the CAEX object at the specified index to a new location in the collection. (Inherited from [CAEXSequence&lt;T>][5].)                                                                                                                                                               
![Public method]                | [Prepend()][35]                                | This method is not applicable for ExternalInterfaces, if the owner is an AMLFacet. (Overrides [CAEXSequence&lt;T>.Prepend()][36].)                                                                                                                                                        
![Public method]                | [Prepend(ValueTuple&lt;String, Object>[])][37] | Creates a new CAEX object and prepends it to already existing elements. The content of the new element can be defined using an array of tuples defining attribute names and their values. (Inherited from [CAEXSequence&lt;T>][5].)                                                       
![Public method]                | [Prepend(String)][38]                          | Creates a new CAEX object with the specified name and prepends it to the sequence. (Inherited from [CAEXSequenceOfCAEXObjects&lt;T>][6].)                                                                                                                                                 
![Public method]                | [Remove][39]                                   | Removes all CAEX objects from this sequence. (Inherited from [NamedElementSequence&lt;T>][3].)                                                                                                                                                                                            
![Public method]                | [RemoveAt][40]                                 | Removes the element at the given index. (Inherited from [NamedElementSequence&lt;T>][3].)                                                                                                                                                                                                 
![Public method]                | [RemoveElement][41]                            | Removes the provided CAEX object from this sequence. (Inherited from [CAEXSequence&lt;T>][5].)                                                                                                                                                                                            


Extension Methods
-----------------

                           | Name                   | Description                                                                                                                                         
-------------------------- | ---------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public Extension Method] | [OfInterfaceClass][42] | Gets all ExternalInterfaces from the specified sequence, which are instances of a specific InterfaceClass (Defined by [CAEXSequenceExtension][43].) 


Explicit Interface Implementations
----------------------------------

                                                                     | Name                                                         | Description                                                                                                                                                                                                                                   
-------------------------------------------------------------------- | ------------------------------------------------------------ | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Explicit interface implementation]![Private method]                | [IEnumerable.GetEnumerator][44]                              | (Inherited from [NamedElementSequence&lt;T>][3].)                                                                                                                                                                                             
![Explicit interface implementation]![Private method]                | [ICAEXSequence.Append()][45]                                 | Creates a new CAEX object and appends it to already existing elements in this sequence. (Inherited from [CAEXSequence&lt;T>][5].)                                                                                                             
![Explicit interface implementation]![Private method]![Code example] | [ICAEXSequence.Append(ValueTuple&lt;String, Object>[])][46]  | Creates a new CAEX object and appends it to already existing elements. The content of the new element can be optionally defined using an array of tuples defining attribute names and their values. (Inherited from [CAEXSequence&lt;T>][5].) 
![Explicit interface implementation]![Private method]                | [ICAEXSequence.At][47]                                       | Gets the CAEX object at the specified index. (Inherited from [CAEXSequence&lt;T>][5].)                                                                                                                                                        
![Explicit interface implementation]![Private property]              | [ICAEXSequence.First][48]                                    | Gets a wrapper for the first CAEX element in this sequence, if the sequence contains no elements `null` is returned. (Inherited from [CAEXSequence&lt;T>][5].)                                                                                
![Explicit interface implementation]![Private method]                | [ICAEXSequence.GetEnumerator][49]                            | Gets the enumerator for this sequence. (Inherited from [CAEXSequence&lt;T>][5].)                                                                                                                                                              
![Explicit interface implementation]![Private method]                | [ICAEXSequence.IndexOf][50]                                  | Gets the Index of the specified CAEX object in this sequence of elements. (Inherited from [CAEXSequence&lt;T>][5].)                                                                                                                           
![Explicit interface implementation]![Private method]                | [ICAEXSequence.Insert][51]                                   | Inserts the specified CAEX object into this sequence. If no position is specified the element is appended. If 'asFirst' is set to `true`, the element is prepended to already existing ones. (Inherited from [CAEXSequence&lt;T>][5].)        
![Explicit interface implementation]![Private method]                | [ICAEXSequence.InsertAt][52]                                 | Inserts the specified CAEX object into this sequence at the defined index. (Inherited from [CAEXSequence&lt;T>][5].)                                                                                                                          
![Explicit interface implementation]![Private property]              | [ICAEXSequence.Item[Int32]][53]                              | Gets a wrapper for the CAEX element in this sequence at the given position (Inherited from [CAEXSequence&lt;T>][5].)                                                                                                                          
![Explicit interface implementation]![Private property]              | [ICAEXSequence.Item[ValueTuple&lt;String, String>]][54]      | Gets the first CAEX object with a specific attribute value from the sequence of elements (Inherited from [CAEXSequence&lt;T>][5].)                                                                                                            
![Explicit interface implementation]![Private property]              | [ICAEXSequence.Last][55]                                     | Gets a wrapper for the last CAEX element in this sequence, if the sequence contains no elements `null` is returned. (Inherited from [CAEXSequence&lt;T>][5].)                                                                                 
![Explicit interface implementation]![Private method]                | [ICAEXSequence.Prepend()][56]                                | Creates a new CAEX object and prepends it to already existing elements. (Inherited from [CAEXSequence&lt;T>][5].)                                                                                                                             
![Explicit interface implementation]![Private method]                | [ICAEXSequence.Prepend(ValueTuple&lt;String, Object>[])][57] | Creates a new CAEX object and prepends it to already existing elements. The content of the new element can be defined using an array of tuples defining attribute names and their values. (Inherited from [CAEXSequence&lt;T>][5].)           
![Explicit interface implementation]![Private method]                | [ICAEXSequence.RemoveElement][58]                            | Removes the provided CAEX object from this sequence. (Inherited from [CAEXSequence&lt;T>][5].)                                                                                                                                                


See Also
--------

#### Reference
[Aml.Engine.AmlObjects Namespace][8]  
[Aml.Engine.CAEX.ExternalInterfaceSequence][7]  

[1]: ../AMLFacet/README.md
[2]: https://docs.microsoft.com/dotnet/api/system.object
[3]: ../../Aml.Engine.CAEX/NamedElementSequence_1/README.md
[4]: ../../Aml.Engine.CAEX/ExternalInterfaceType/README.md
[5]: ../../Aml.Engine.CAEX/CAEXSequence_1/README.md
[6]: ../../Aml.Engine.CAEX/CAEXSequenceOfCAEXObjects_1/README.md
[7]: ../../Aml.Engine.CAEX/ExternalInterfaceSequence/README.md
[8]: ../README.md
[9]: _ctor.md
[10]: ../../Aml.Engine.CAEX/NamedElementSequence_1/CAEXOwner.md
[11]: ../../Aml.Engine.CAEX/NamedElementSequence_1/Count.md
[12]: ../../Aml.Engine.CAEX/NamedElementSequence_1/ElementName.md
[13]: ../../Aml.Engine.CAEX/NamedElementSequence_1/Elements.md
[14]: ../../Aml.Engine.CAEX/NamedElementSequence_1/Exists.md
[15]: ../../Aml.Engine.CAEX/CAEXSequence_1/First.md
[16]: ../../Aml.Engine.CAEX/CAEXSequence_1/Item.md
[17]: ../../Aml.Engine.CAEX/CAEXSequence_1/Item_1.md
[18]: ../../Aml.Engine.CAEX/CAEXSequenceOfCAEXObjects_1/Item.md
[19]: ../../Aml.Engine.CAEX/CAEXSequenceOfCAEXObjects_1/Item_1.md
[20]: ../../Aml.Engine.CAEX/CAEXSequence_1/Last.md
[21]: ../../Aml.Engine.CAEX/NamedElementSequence_1/Owner.md
[22]: Append.md
[23]: ../../Aml.Engine.CAEX/CAEXSequence_1/Append.md
[24]: Append_1.md
[25]: ../../Aml.Engine.CAEX/CAEXSequenceOfCAEXObjects_1/Append.md
[26]: ../../Aml.Engine.CAEX/CAEXSequence_1/Append_1.md
[27]: ../../Aml.Engine.CAEX/CAEXSequence_1/At.md
[28]: ../../Aml.Engine.CAEX/ExternalInterfaceSequence/ExternalInterfaceDescandantsAndSelf.md
[29]: ../../Aml.Engine.CAEX/CAEXSequence_1/GetEnumerator.md
[30]: ../../Aml.Engine.CAEX/CAEXSequence_1/IndexOf.md
[31]: Insert.md
[32]: ../../Aml.Engine.CAEX/CAEXSequenceOfCAEXObjects_1/Insert.md
[33]: ../../Aml.Engine.CAEX/CAEXSequence_1/InsertAt.md
[34]: ../../Aml.Engine.CAEX/CAEXSequence_1/Move.md
[35]: Prepend.md
[36]: ../../Aml.Engine.CAEX/CAEXSequence_1/Prepend.md
[37]: ../../Aml.Engine.CAEX/CAEXSequence_1/Prepend_1.md
[38]: ../../Aml.Engine.CAEX/CAEXSequenceOfCAEXObjects_1/Prepend.md
[39]: ../../Aml.Engine.CAEX/NamedElementSequence_1/Remove.md
[40]: ../../Aml.Engine.CAEX/NamedElementSequence_1/RemoveAt.md
[41]: ../../Aml.Engine.CAEX/CAEXSequence_1/RemoveElement.md
[42]: ../../Aml.Engine.CAEX.Linq/CAEXSequenceExtension/OfInterfaceClass.md
[43]: ../../Aml.Engine.CAEX.Linq/CAEXSequenceExtension/README.md
[44]: ../../Aml.Engine.CAEX/NamedElementSequence_1/System_Collections_IEnumerable_GetEnumerator.md
[45]: ../../Aml.Engine.CAEX/CAEXSequence_1/Aml_Engine_CAEX_ICAEXSequence_Append.md
[46]: ../../Aml.Engine.CAEX/CAEXSequence_1/Aml_Engine_CAEX_ICAEXSequence_Append_1.md
[47]: ../../Aml.Engine.CAEX/CAEXSequence_1/Aml_Engine_CAEX_ICAEXSequence_At.md
[48]: ../../Aml.Engine.CAEX/CAEXSequence_1/Aml_Engine_CAEX_ICAEXSequence_First.md
[49]: ../../Aml.Engine.CAEX/CAEXSequence_1/Aml_Engine_CAEX_ICAEXSequence_GetEnumerator.md
[50]: ../../Aml.Engine.CAEX/CAEXSequence_1/Aml_Engine_CAEX_ICAEXSequence_IndexOf.md
[51]: ../../Aml.Engine.CAEX/CAEXSequence_1/Aml_Engine_CAEX_ICAEXSequence_Insert.md
[52]: ../../Aml.Engine.CAEX/CAEXSequence_1/Aml_Engine_CAEX_ICAEXSequence_InsertAt.md
[53]: ../../Aml.Engine.CAEX/CAEXSequence_1/Aml_Engine_CAEX_ICAEXSequence_Item.md
[54]: ../../Aml.Engine.CAEX/CAEXSequence_1/Aml_Engine_CAEX_ICAEXSequence_Item_1.md
[55]: ../../Aml.Engine.CAEX/CAEXSequence_1/Aml_Engine_CAEX_ICAEXSequence_Last.md
[56]: ../../Aml.Engine.CAEX/CAEXSequence_1/Aml_Engine_CAEX_ICAEXSequence_Prepend.md
[57]: ../../Aml.Engine.CAEX/CAEXSequence_1/Aml_Engine_CAEX_ICAEXSequence_Prepend_1.md
[58]: ../../Aml.Engine.CAEX/CAEXSequence_1/Aml_Engine_CAEX_ICAEXSequence_RemoveElement.md
[59]: https://www.automationml.org
[60]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public property]: ../../icons/pubproperty.gif "Public property"
[Code example]: ../../icons/CodeExample.png "Code example"
[Public Extension Method]: ../../icons/pubextension.gif "Public Extension Method"
[Explicit interface implementation]: ../../icons/pubinterface.gif "Explicit interface implementation"
[Private method]: ../../icons/privmethod.gif "Private method"
[Private property]: ../../icons/privproperty.gif "Private property"