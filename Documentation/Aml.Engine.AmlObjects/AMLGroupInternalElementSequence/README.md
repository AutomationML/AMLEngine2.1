AMLGroupInternalElementSequence Class
=====================================
This class is used to support the AMLGroup concept. An AMLGroup object shall only contain InternalElements which are AMLMirrorObjects and/or further AMLGroup objects.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  [Aml.Engine.CAEX.NamedElementSequence][2]&lt;[InternalElementType][3]>  
    [Aml.Engine.CAEX.CAEXSequence][4]&lt;[InternalElementType][3]>  
      [Aml.Engine.CAEX.CAEXSequenceOfCAEXObjects][5]&lt;[InternalElementType][3]>  
        [Aml.Engine.CAEX.InternalElementSequence][6]  
          **Aml.Engine.AmlObjects.AMLGroupInternalElementSequence**  

  **Namespace:**  [Aml.Engine.AmlObjects][7]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public class AMLGroupInternalElementSequence : InternalElementSequence
```

The **AMLGroupInternalElementSequence** type exposes the following members.


Constructors
------------

                 | Name                                 | Description                                                                  
---------------- | ------------------------------------ | ---------------------------------------------------------------------------- 
![Public method] | [AMLGroupInternalElementSequence][8] | Initializes a new instance of the **AMLGroupInternalElementSequence** class. 


Properties
----------

                   | Name                                      | Description                                                                                                                                                                            
------------------ | ----------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public property] | [CAEXOwner][9]                            | Gets the CAEX owner of this sequence (Inherited from [NamedElementSequence&lt;T>][2].)                                                                                                 
![Public property] | [Count][10]                               | Gets the number of elements in this sequence (Inherited from [NamedElementSequence&lt;T>][2].)                                                                                         
![Public property] | [ElementName][11]                         | Gets the name of the elements in this sequence (Inherited from [NamedElementSequence&lt;T>][2].)                                                                                       
![Public property] | [Elements][12]                            | Gets a list of unwrapped CAEX elements (XElements) of this sequence (Inherited from [NamedElementSequence&lt;T>][2].)                                                                  
![Public property] | [Exists][13]                              | Determines, if the sequence contains any element (Inherited from [NamedElementSequence&lt;T>][2].)                                                                                     
![Public property] | [First][14]                               | Gets a wrapper for the first CAEX element in this sequence, if the sequence contains no elements `null` is returned. (Inherited from [CAEXSequence&lt;T>][4].)                         
![Public property] | [Item[Int32]][15]                         | Gets a wrapper for the CAEX element in this sequence at the given position (Inherited from [CAEXSequence&lt;T>][4].)                                                                   
![Public property] | [Item[ValueTuple&lt;String, String>]][16] | Gets the first CAEX object with a specific attribute value from the sequence of elements (Inherited from [CAEXSequence&lt;T>][4].)                                                     
![Public property] | [Item[String]][17]                        | Gets the first CAEX object with this name from the sequence of elements. (Inherited from [CAEXSequenceOfCAEXObjects&lt;T>][5].)                                                        
![Public property] | [Item[String[]]][18]                      | Gets the CAEX object which can be identified with a CAEX path, where the path parts are defined in the provided array of names. (Inherited from [CAEXSequenceOfCAEXObjects&lt;T>][5].) 
![Public property] | [Last][19]                                | Gets a wrapper for the last CAEX element in this sequence, if the sequence contains no elements `null` is returned. (Inherited from [CAEXSequence&lt;T>][4].)                          
![Public property] | [Owner][20]                               | Gets the owner of this sequence (Inherited from [NamedElementSequence&lt;T>][2].)                                                                                                      


Methods
-------

                                | Name                                           | Description                                                                                                                                                                                                                                   
------------------------------- | ---------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method]                | [AddNewMirror][21]                             | Adds a new mirror InternalElement to this sequence. (Inherited from [InternalElementSequence][6].)                                                                                                                                            
![Public method]                | [Append()][22]                                 | Creates a new CAEX object and appends it to already existing elements in this sequence. (Inherited from [CAEXSequence&lt;T>][4].)                                                                                                             
![Public method]![Code example] | [Append(ValueTuple&lt;String, Object>[])][23]  | Creates a new CAEX object and appends it to already existing elements. The content of the new element can be optionally defined using an array of tuples defining attribute names and their values. (Inherited from [CAEXSequence&lt;T>][4].) 
![Public method]                | [Append(String)][24]                           | Creates a new CAEX object with the specified name and appends it to the sequence. (Inherited from [CAEXSequenceOfCAEXObjects&lt;T>][5].)                                                                                                      
![Public method]                | [At][25]                                       | Gets the CAEX object at the specified index. (Inherited from [CAEXSequence&lt;T>][4].)                                                                                                                                                        
![Public method]                | [GetEnumerator][26]                            | Gets the enumerator for this sequence. (Inherited from [CAEXSequence&lt;T>][4].)                                                                                                                                                              
![Public method]                | [IndexOf][27]                                  | Gets the Index of the specified CAEX object in this sequence of elements. (Inherited from [CAEXSequence&lt;T>][4].)                                                                                                                           
![Public method]                | [Insert][28]                                   | Inserts the specified InternalElement into this sequence. Before the InternalElement is inserted, it is checked, if it is a valid Group-InternalElement. (Overrides [CAEXSequenceOfCAEXObjects&lt;T>.Insert(T, Boolean)][29].)                
![Public method]                | [InsertAt][30]                                 | Inserts the specified CAEX object into this sequence at the defined index. (Inherited from [CAEXSequence&lt;T>][4].)                                                                                                                          
![Public method]                | [InternalElementDescendantsAndSelf][31]        | Gets all InternalElements and the InternalElement descendants (the InternalElement tree) (Inherited from [InternalElementSequence][6].)                                                                                                       
![Public method]                | [Move][32]                                     | Moves the CAEX object at the specified index to a new location in the collection. (Inherited from [CAEXSequence&lt;T>][4].)                                                                                                                   
![Public method]                | [Prepend()][33]                                | Creates a new CAEX object and prepends it to already existing elements. (Inherited from [CAEXSequence&lt;T>][4].)                                                                                                                             
![Public method]                | [Prepend(ValueTuple&lt;String, Object>[])][34] | Creates a new CAEX object and prepends it to already existing elements. The content of the new element can be defined using an array of tuples defining attribute names and their values. (Inherited from [CAEXSequence&lt;T>][4].)           
![Public method]                | [Prepend(String)][35]                          | Creates a new CAEX object with the specified name and prepends it to the sequence. (Inherited from [CAEXSequenceOfCAEXObjects&lt;T>][5].)                                                                                                     
![Public method]                | [Remove][36]                                   | Removes all CAEX objects from this sequence. (Inherited from [NamedElementSequence&lt;T>][2].)                                                                                                                                                
![Public method]                | [RemoveAt][37]                                 | Removes the element at the given index. (Inherited from [NamedElementSequence&lt;T>][2].)                                                                                                                                                     
![Public method]                | [RemoveElement][38]                            | Removes the provided CAEX object from this sequence. (Inherited from [CAEXSequence&lt;T>][4].)                                                                                                                                                


Explicit Interface Implementations
----------------------------------

                                                                     | Name                                                         | Description                                                                                                                                                                                                                                   
-------------------------------------------------------------------- | ------------------------------------------------------------ | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Explicit interface implementation]![Private method]                | [IEnumerable.GetEnumerator][39]                              | (Inherited from [NamedElementSequence&lt;T>][2].)                                                                                                                                                                                             
![Explicit interface implementation]![Private method]                | [ICAEXSequence.Append()][40]                                 | Creates a new CAEX object and appends it to already existing elements in this sequence. (Inherited from [CAEXSequence&lt;T>][4].)                                                                                                             
![Explicit interface implementation]![Private method]![Code example] | [ICAEXSequence.Append(ValueTuple&lt;String, Object>[])][41]  | Creates a new CAEX object and appends it to already existing elements. The content of the new element can be optionally defined using an array of tuples defining attribute names and their values. (Inherited from [CAEXSequence&lt;T>][4].) 
![Explicit interface implementation]![Private method]                | [ICAEXSequence.At][42]                                       | Gets the CAEX object at the specified index. (Inherited from [CAEXSequence&lt;T>][4].)                                                                                                                                                        
![Explicit interface implementation]![Private property]              | [ICAEXSequence.First][43]                                    | Gets a wrapper for the first CAEX element in this sequence, if the sequence contains no elements `null` is returned. (Inherited from [CAEXSequence&lt;T>][4].)                                                                                
![Explicit interface implementation]![Private method]                | [ICAEXSequence.GetEnumerator][44]                            | Gets the enumerator for this sequence. (Inherited from [CAEXSequence&lt;T>][4].)                                                                                                                                                              
![Explicit interface implementation]![Private method]                | [ICAEXSequence.IndexOf][45]                                  | Gets the Index of the specified CAEX object in this sequence of elements. (Inherited from [CAEXSequence&lt;T>][4].)                                                                                                                           
![Explicit interface implementation]![Private method]                | [ICAEXSequence.Insert][46]                                   | Inserts the specified CAEX object into this sequence. If no position is specified the element is appended. If 'asFirst' is set to `true`, the element is prepended to already existing ones. (Inherited from [CAEXSequence&lt;T>][4].)        
![Explicit interface implementation]![Private method]                | [ICAEXSequence.InsertAt][47]                                 | Inserts the specified CAEX object into this sequence at the defined index. (Inherited from [CAEXSequence&lt;T>][4].)                                                                                                                          
![Explicit interface implementation]![Private property]              | [ICAEXSequence.Item[Int32]][48]                              | Gets a wrapper for the CAEX element in this sequence at the given position (Inherited from [CAEXSequence&lt;T>][4].)                                                                                                                          
![Explicit interface implementation]![Private property]              | [ICAEXSequence.Item[ValueTuple&lt;String, String>]][49]      | Gets the first CAEX object with a specific attribute value from the sequence of elements (Inherited from [CAEXSequence&lt;T>][4].)                                                                                                            
![Explicit interface implementation]![Private property]              | [ICAEXSequence.Last][50]                                     | Gets a wrapper for the last CAEX element in this sequence, if the sequence contains no elements `null` is returned. (Inherited from [CAEXSequence&lt;T>][4].)                                                                                 
![Explicit interface implementation]![Private method]                | [ICAEXSequence.Prepend()][51]                                | Creates a new CAEX object and prepends it to already existing elements. (Inherited from [CAEXSequence&lt;T>][4].)                                                                                                                             
![Explicit interface implementation]![Private method]                | [ICAEXSequence.Prepend(ValueTuple&lt;String, Object>[])][52] | Creates a new CAEX object and prepends it to already existing elements. The content of the new element can be defined using an array of tuples defining attribute names and their values. (Inherited from [CAEXSequence&lt;T>][4].)           
![Explicit interface implementation]![Private method]                | [ICAEXSequence.RemoveElement][53]                            | Removes the provided CAEX object from this sequence. (Inherited from [CAEXSequence&lt;T>][4].)                                                                                                                                                


See Also
--------

#### Reference
[Aml.Engine.AmlObjects Namespace][7]  
[Aml.Engine.CAEX.InternalElementSequence][6]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../../Aml.Engine.CAEX/NamedElementSequence_1/README.md
[3]: ../../Aml.Engine.CAEX/InternalElementType/README.md
[4]: ../../Aml.Engine.CAEX/CAEXSequence_1/README.md
[5]: ../../Aml.Engine.CAEX/CAEXSequenceOfCAEXObjects_1/README.md
[6]: ../../Aml.Engine.CAEX/InternalElementSequence/README.md
[7]: ../README.md
[8]: _ctor.md
[9]: ../../Aml.Engine.CAEX/NamedElementSequence_1/CAEXOwner.md
[10]: ../../Aml.Engine.CAEX/NamedElementSequence_1/Count.md
[11]: ../../Aml.Engine.CAEX/NamedElementSequence_1/ElementName.md
[12]: ../../Aml.Engine.CAEX/NamedElementSequence_1/Elements.md
[13]: ../../Aml.Engine.CAEX/NamedElementSequence_1/Exists.md
[14]: ../../Aml.Engine.CAEX/CAEXSequence_1/First.md
[15]: ../../Aml.Engine.CAEX/CAEXSequence_1/Item.md
[16]: ../../Aml.Engine.CAEX/CAEXSequence_1/Item_1.md
[17]: ../../Aml.Engine.CAEX/CAEXSequenceOfCAEXObjects_1/Item.md
[18]: ../../Aml.Engine.CAEX/CAEXSequenceOfCAEXObjects_1/Item_1.md
[19]: ../../Aml.Engine.CAEX/CAEXSequence_1/Last.md
[20]: ../../Aml.Engine.CAEX/NamedElementSequence_1/Owner.md
[21]: ../../Aml.Engine.CAEX/InternalElementSequence/AddNewMirror.md
[22]: ../../Aml.Engine.CAEX/CAEXSequence_1/Append.md
[23]: ../../Aml.Engine.CAEX/CAEXSequence_1/Append_1.md
[24]: ../../Aml.Engine.CAEX/CAEXSequenceOfCAEXObjects_1/Append.md
[25]: ../../Aml.Engine.CAEX/CAEXSequence_1/At.md
[26]: ../../Aml.Engine.CAEX/CAEXSequence_1/GetEnumerator.md
[27]: ../../Aml.Engine.CAEX/CAEXSequence_1/IndexOf.md
[28]: Insert.md
[29]: ../../Aml.Engine.CAEX/CAEXSequenceOfCAEXObjects_1/Insert.md
[30]: ../../Aml.Engine.CAEX/CAEXSequence_1/InsertAt.md
[31]: ../../Aml.Engine.CAEX/InternalElementSequence/InternalElementDescendantsAndSelf.md
[32]: ../../Aml.Engine.CAEX/CAEXSequence_1/Move.md
[33]: ../../Aml.Engine.CAEX/CAEXSequence_1/Prepend.md
[34]: ../../Aml.Engine.CAEX/CAEXSequence_1/Prepend_1.md
[35]: ../../Aml.Engine.CAEX/CAEXSequenceOfCAEXObjects_1/Prepend.md
[36]: ../../Aml.Engine.CAEX/NamedElementSequence_1/Remove.md
[37]: ../../Aml.Engine.CAEX/NamedElementSequence_1/RemoveAt.md
[38]: ../../Aml.Engine.CAEX/CAEXSequence_1/RemoveElement.md
[39]: ../../Aml.Engine.CAEX/NamedElementSequence_1/System_Collections_IEnumerable_GetEnumerator.md
[40]: ../../Aml.Engine.CAEX/CAEXSequence_1/Aml_Engine_CAEX_ICAEXSequence_Append.md
[41]: ../../Aml.Engine.CAEX/CAEXSequence_1/Aml_Engine_CAEX_ICAEXSequence_Append_1.md
[42]: ../../Aml.Engine.CAEX/CAEXSequence_1/Aml_Engine_CAEX_ICAEXSequence_At.md
[43]: ../../Aml.Engine.CAEX/CAEXSequence_1/Aml_Engine_CAEX_ICAEXSequence_First.md
[44]: ../../Aml.Engine.CAEX/CAEXSequence_1/Aml_Engine_CAEX_ICAEXSequence_GetEnumerator.md
[45]: ../../Aml.Engine.CAEX/CAEXSequence_1/Aml_Engine_CAEX_ICAEXSequence_IndexOf.md
[46]: ../../Aml.Engine.CAEX/CAEXSequence_1/Aml_Engine_CAEX_ICAEXSequence_Insert.md
[47]: ../../Aml.Engine.CAEX/CAEXSequence_1/Aml_Engine_CAEX_ICAEXSequence_InsertAt.md
[48]: ../../Aml.Engine.CAEX/CAEXSequence_1/Aml_Engine_CAEX_ICAEXSequence_Item.md
[49]: ../../Aml.Engine.CAEX/CAEXSequence_1/Aml_Engine_CAEX_ICAEXSequence_Item_1.md
[50]: ../../Aml.Engine.CAEX/CAEXSequence_1/Aml_Engine_CAEX_ICAEXSequence_Last.md
[51]: ../../Aml.Engine.CAEX/CAEXSequence_1/Aml_Engine_CAEX_ICAEXSequence_Prepend.md
[52]: ../../Aml.Engine.CAEX/CAEXSequence_1/Aml_Engine_CAEX_ICAEXSequence_Prepend_1.md
[53]: ../../Aml.Engine.CAEX/CAEXSequence_1/Aml_Engine_CAEX_ICAEXSequence_RemoveElement.md
[54]: https://www.automationml.org
[55]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public property]: ../../icons/pubproperty.gif "Public property"
[Code example]: ../../icons/CodeExample.png "Code example"
[Explicit interface implementation]: ../../icons/pubinterface.gif "Explicit interface implementation"
[Private method]: ../../icons/privmethod.gif "Private method"
[Private property]: ../../icons/privproperty.gif "Private property"