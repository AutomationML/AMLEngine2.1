InternalElementSequence Class
=============================
This class defines a sequence of CAEX 'InternalElement' elements. A sequence of InternalElements can be associated with each class which implements the [IInternalElementContainer][1] interface.


Inheritance Hierarchy
---------------------
[System.Object][2]  
  [Aml.Engine.CAEX.NamedElementSequence][3]&lt;[InternalElementType][4]>  
    [Aml.Engine.CAEX.CAEXSequence][5]&lt;[InternalElementType][4]>  
      [Aml.Engine.CAEX.CAEXSequenceOfCAEXObjects][6]&lt;[InternalElementType][4]>  
        **Aml.Engine.CAEX.InternalElementSequence**  
          [Aml.Engine.AmlObjects.AMLGroupInternalElementSequence][7]  

  **Namespace:**  [Aml.Engine.CAEX][8]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public class InternalElementSequence : CAEXSequenceOfCAEXObjects<InternalElementType>
```

The **InternalElementSequence** type exposes the following members.


Constructors
------------

                 | Name                         | Description                                                          
---------------- | ---------------------------- | -------------------------------------------------------------------- 
![Public method] | [InternalElementSequence][9] | Initializes a new instance of the **InternalElementSequence** class. 


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
------------------------------- | ---------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method]                | [AddNewMirror][22]                             | Adds a new mirror InternalElement to this sequence.                                                                                                                                                                                                                                                                                         
![Public method]                | [Append()][23]                                 | Creates a new CAEX object and appends it to already existing elements in this sequence. (Inherited from [CAEXSequence&lt;T>][5].)                                                                                                                                                                                                           
![Public method]![Code example] | [Append(ValueTuple&lt;String, Object>[])][24]  | Creates a new CAEX object and appends it to already existing elements. The content of the new element can be optionally defined using an array of tuples defining attribute names and their values. (Inherited from [CAEXSequence&lt;T>][5].)                                                                                               
![Public method]                | [Append(String)][25]                           | Creates a new CAEX object with the specified name and appends it to the sequence. (Inherited from [CAEXSequenceOfCAEXObjects&lt;T>][6].)                                                                                                                                                                                                    
![Public method]                | [At][26]                                       | Gets the CAEX object at the specified index. (Inherited from [CAEXSequence&lt;T>][5].)                                                                                                                                                                                                                                                      
![Public method]                | [GetEnumerator][27]                            | Gets the enumerator for this sequence. (Inherited from [CAEXSequence&lt;T>][5].)                                                                                                                                                                                                                                                            
![Public method]                | [IndexOf][28]                                  | Gets the Index of the specified CAEX object in this sequence of elements. (Inherited from [CAEXSequence&lt;T>][5].)                                                                                                                                                                                                                         
![Public method]                | [Insert][29]                                   | Inserts the specified element into this sequence. If nothing is specified the element is added. If the asFirst is set to `true`, the element is prepended to already existing ones. If a UniqueNameService can be located, the name of the inserted element is changed to be unique. (Inherited from [CAEXSequenceOfCAEXObjects&lt;T>][6].) 
![Public method]                | [InsertAt][30]                                 | Inserts the specified CAEX object into this sequence at the defined index. (Inherited from [CAEXSequence&lt;T>][5].)                                                                                                                                                                                                                        
![Public method]                | [InternalElementDescendantsAndSelf][31]        | Gets all InternalElements and the InternalElement descendants (the InternalElement tree)                                                                                                                                                                                                                                                    
![Public method]                | [Move][32]                                     | Moves the CAEX object at the specified index to a new location in the collection. (Inherited from [CAEXSequence&lt;T>][5].)                                                                                                                                                                                                                 
![Public method]                | [Prepend()][33]                                | Creates a new CAEX object and prepends it to already existing elements. (Inherited from [CAEXSequence&lt;T>][5].)                                                                                                                                                                                                                           
![Public method]                | [Prepend(ValueTuple&lt;String, Object>[])][34] | Creates a new CAEX object and prepends it to already existing elements. The content of the new element can be defined using an array of tuples defining attribute names and their values. (Inherited from [CAEXSequence&lt;T>][5].)                                                                                                         
![Public method]                | [Prepend(String)][35]                          | Creates a new CAEX object with the specified name and prepends it to the sequence. (Inherited from [CAEXSequenceOfCAEXObjects&lt;T>][6].)                                                                                                                                                                                                   
![Public method]                | [Remove][36]                                   | Removes all CAEX objects from this sequence. (Inherited from [NamedElementSequence&lt;T>][3].)                                                                                                                                                                                                                                              
![Public method]                | [RemoveAt][37]                                 | Removes the element at the given index. (Inherited from [NamedElementSequence&lt;T>][3].)                                                                                                                                                                                                                                                   
![Public method]                | [RemoveElement][38]                            | Removes the provided CAEX object from this sequence. (Inherited from [CAEXSequence&lt;T>][5].)                                                                                                                                                                                                                                              


Explicit Interface Implementations
----------------------------------

                                                                     | Name                                                         | Description                                                                                                                                                                                                                                   
-------------------------------------------------------------------- | ------------------------------------------------------------ | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Explicit interface implementation]![Private method]                | [IEnumerable.GetEnumerator][39]                              | Returns an enumerator that runs through a collection. (Inherited from [NamedElementSequence&lt;T>][3].)                                                                                                                                       
![Explicit interface implementation]![Private method]                | [ICAEXSequence.Append()][40]                                 | Creates a new CAEX object and appends it to already existing elements in this sequence. (Inherited from [CAEXSequence&lt;T>][5].)                                                                                                             
![Explicit interface implementation]![Private method]![Code example] | [ICAEXSequence.Append(ValueTuple&lt;String, Object>[])][41]  | Creates a new CAEX object and appends it to already existing elements. The content of the new element can be optionally defined using an array of tuples defining attribute names and their values. (Inherited from [CAEXSequence&lt;T>][5].) 
![Explicit interface implementation]![Private method]                | [ICAEXSequence.At][42]                                       | Gets the CAEX object at the specified index. (Inherited from [CAEXSequence&lt;T>][5].)                                                                                                                                                        
![Explicit interface implementation]![Private property]              | [ICAEXSequence.First][43]                                    | Gets a wrapper for the first CAEX element in this sequence, if the sequence contains no elements `null` is returned. (Inherited from [CAEXSequence&lt;T>][5].)                                                                                
![Explicit interface implementation]![Private method]                | [ICAEXSequence.GetEnumerator][44]                            | Gets the enumerator for this sequence. (Inherited from [CAEXSequence&lt;T>][5].)                                                                                                                                                              
![Explicit interface implementation]![Private method]                | [ICAEXSequence.IndexOf][45]                                  | Gets the Index of the specified CAEX object in this sequence of elements. (Inherited from [CAEXSequence&lt;T>][5].)                                                                                                                           
![Explicit interface implementation]![Private method]                | [ICAEXSequence.Insert][46]                                   | Inserts the specified CAEX object into this sequence. If no position is specified the element is appended. If 'asFirst' is set to `true`, the element is prepended to already existing ones. (Inherited from [CAEXSequence&lt;T>][5].)        
![Explicit interface implementation]![Private method]                | [ICAEXSequence.InsertAt][47]                                 | Inserts the specified CAEX object into this sequence at the defined index. (Inherited from [CAEXSequence&lt;T>][5].)                                                                                                                          
![Explicit interface implementation]![Private property]              | [ICAEXSequence.Item[Int32]][48]                              | Gets a wrapper for the CAEX element in this sequence at the given position (Inherited from [CAEXSequence&lt;T>][5].)                                                                                                                          
![Explicit interface implementation]![Private property]              | [ICAEXSequence.Item[ValueTuple&lt;String, String>]][49]      | Gets the first CAEX object with a specific attribute value from the sequence of elements (Inherited from [CAEXSequence&lt;T>][5].)                                                                                                            
![Explicit interface implementation]![Private property]              | [ICAEXSequence.Last][50]                                     | Gets a wrapper for the last CAEX element in this sequence, if the sequence contains no elements `null` is returned. (Inherited from [CAEXSequence&lt;T>][5].)                                                                                 
![Explicit interface implementation]![Private method]                | [ICAEXSequence.Prepend()][51]                                | Creates a new CAEX object and prepends it to already existing elements. (Inherited from [CAEXSequence&lt;T>][5].)                                                                                                                             
![Explicit interface implementation]![Private method]                | [ICAEXSequence.Prepend(ValueTuple&lt;String, Object>[])][52] | Creates a new CAEX object and prepends it to already existing elements. The content of the new element can be defined using an array of tuples defining attribute names and their values. (Inherited from [CAEXSequence&lt;T>][5].)           
![Explicit interface implementation]![Private method]                | [ICAEXSequence.RemoveElement][53]                            | Removes the provided CAEX object from this sequence. (Inherited from [CAEXSequence&lt;T>][5].)                                                                                                                                                


See Also
--------

#### Reference
[Aml.Engine.CAEX Namespace][8]  
[Aml.Engine.CAEX.CAEXSequenceOfCAEXObjects&lt;T>][6]  

[1]: ../IInternalElementContainer/README.md
[2]: https://docs.microsoft.com/dotnet/api/system.object
[3]: ../NamedElementSequence_1/README.md
[4]: ../InternalElementType/README.md
[5]: ../CAEXSequence_1/README.md
[6]: ../CAEXSequenceOfCAEXObjects_1/README.md
[7]: ../../Aml.Engine.AmlObjects/AMLGroupInternalElementSequence/README.md
[8]: ../README.md
[9]: _ctor.md
[10]: ../NamedElementSequence_1/CAEXOwner.md
[11]: ../NamedElementSequence_1/Count.md
[12]: ../NamedElementSequence_1/ElementName.md
[13]: ../NamedElementSequence_1/Elements.md
[14]: ../NamedElementSequence_1/Exists.md
[15]: ../CAEXSequence_1/First.md
[16]: ../CAEXSequence_1/Item.md
[17]: ../CAEXSequence_1/Item_1.md
[18]: ../CAEXSequenceOfCAEXObjects_1/Item.md
[19]: ../CAEXSequenceOfCAEXObjects_1/Item_1.md
[20]: ../CAEXSequence_1/Last.md
[21]: ../NamedElementSequence_1/Owner.md
[22]: AddNewMirror.md
[23]: ../CAEXSequence_1/Append.md
[24]: ../CAEXSequence_1/Append_1.md
[25]: ../CAEXSequenceOfCAEXObjects_1/Append.md
[26]: ../CAEXSequence_1/At.md
[27]: ../CAEXSequence_1/GetEnumerator.md
[28]: ../CAEXSequence_1/IndexOf.md
[29]: ../CAEXSequenceOfCAEXObjects_1/Insert.md
[30]: ../CAEXSequence_1/InsertAt.md
[31]: InternalElementDescendantsAndSelf.md
[32]: ../CAEXSequence_1/Move.md
[33]: ../CAEXSequence_1/Prepend.md
[34]: ../CAEXSequence_1/Prepend_1.md
[35]: ../CAEXSequenceOfCAEXObjects_1/Prepend.md
[36]: ../NamedElementSequence_1/Remove.md
[37]: ../NamedElementSequence_1/RemoveAt.md
[38]: ../CAEXSequence_1/RemoveElement.md
[39]: ../NamedElementSequence_1/System_Collections_IEnumerable_GetEnumerator.md
[40]: ../CAEXSequence_1/Aml_Engine_CAEX_ICAEXSequence_Append.md
[41]: ../CAEXSequence_1/Aml_Engine_CAEX_ICAEXSequence_Append_1.md
[42]: ../CAEXSequence_1/Aml_Engine_CAEX_ICAEXSequence_At.md
[43]: ../CAEXSequence_1/Aml_Engine_CAEX_ICAEXSequence_First.md
[44]: ../CAEXSequence_1/Aml_Engine_CAEX_ICAEXSequence_GetEnumerator.md
[45]: ../CAEXSequence_1/Aml_Engine_CAEX_ICAEXSequence_IndexOf.md
[46]: ../CAEXSequence_1/Aml_Engine_CAEX_ICAEXSequence_Insert.md
[47]: ../CAEXSequence_1/Aml_Engine_CAEX_ICAEXSequence_InsertAt.md
[48]: ../CAEXSequence_1/Aml_Engine_CAEX_ICAEXSequence_Item.md
[49]: ../CAEXSequence_1/Aml_Engine_CAEX_ICAEXSequence_Item_1.md
[50]: ../CAEXSequence_1/Aml_Engine_CAEX_ICAEXSequence_Last.md
[51]: ../CAEXSequence_1/Aml_Engine_CAEX_ICAEXSequence_Prepend.md
[52]: ../CAEXSequence_1/Aml_Engine_CAEX_ICAEXSequence_Prepend_1.md
[53]: ../CAEXSequence_1/Aml_Engine_CAEX_ICAEXSequence_RemoveElement.md
[54]: https://www.automationml.org
[55]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public property]: ../../icons/pubproperty.gif "Public property"
[Code example]: ../../icons/CodeExample.png "Code example"
[Explicit interface implementation]: ../../icons/pubinterface.gif "Explicit interface implementation"
[Private method]: ../../icons/privmethod.gif "Private method"
[Private property]: ../../icons/privproperty.gif "Private property"