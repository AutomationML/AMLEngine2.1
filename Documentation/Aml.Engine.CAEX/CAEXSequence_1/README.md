CAEXSequence&lt;T> Class
========================
AutomationML 2.1 APIThis class implements methods to work with any sequence of CAEX elements. The class will wrap all elements of a filtered sequence of an owner element to the denoted wrapper type which is given as the type-argument.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  [Aml.Engine.CAEX.NamedElementSequence][2]&lt;**T**>  
    **Aml.Engine.CAEX.CAEXSequence&lt;T>**  
      [Aml.Engine.CAEX.CAEXSequenceOfCAEXObjects&lt;T>][3]  

  **Namespace:**  [Aml.Engine.CAEX][4]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public class CAEXSequence<T> : NamedElementSequence<T>, 
	ICAEXSequence
where T : CAEXWrapper

```

#### Type Parameters

##### *T*
this is any CAEXWrapper type

The **CAEXSequence&lt;T>** type exposes the following members.


Constructors
------------

                 | Name                    | Description                                                                                                                                                                                        
---------------- | ----------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method] | [CAEXSequence&lt;T>][5] | Creates a new instance of the CAEXSequencce for the specified owner and the specified name which has to be a valid name for child elements, which can be filtered out from the owner by this name. 


Properties
----------

                   | Name                                      | Description                                                                                                                          
------------------ | ----------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------ 
![Public property] | [CAEXOwner][6]                            | Gets the CAEX owner of this sequence (Inherited from [NamedElementSequence&lt;T>][2].)                                               
![Public property] | [Count][7]                                | Gets the number of elements in this sequence (Inherited from [NamedElementSequence&lt;T>][2].)                                       
![Public property] | [ElementName][8]                          | Gets the name of the elements in this sequence (Inherited from [NamedElementSequence&lt;T>][2].)                                     
![Public property] | [Elements][9]                             | Gets a list of unwrapped CAEX elements (XElements) of this sequence (Inherited from [NamedElementSequence&lt;T>][2].)                
![Public property] | [Exists][10]                              | Determines, if the sequence contains any element (Inherited from [NamedElementSequence&lt;T>][2].)                                   
![Public property] | [First][11]                               | Gets a wrapper for the first CAEX element in this sequence, if the sequence contains no elements `null` is returned.                 
![Public property] | [Item[Int32]][12]                         | Gets a wrapper for the CAEX element in this sequence at the given position (Overrides [NamedElementSequence&lt;T>.Item[Int32]][13].) 
![Public property] | [Item[ValueTuple&lt;String, String>]][14] | Gets the first CAEX object with a specific attribute value from the sequence of elements                                             
![Public property] | [Last][15]                                | Gets a wrapper for the last CAEX element in this sequence, if the sequence contains no elements `null` is returned.                  
![Public property] | [Owner][16]                               | Gets the owner of this sequence (Inherited from [NamedElementSequence&lt;T>][2].)                                                    


Methods
-------

                                | Name                                           | Description                                                                                                                                                                                         
------------------------------- | ---------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method]                | [Append()][17]                                 | Creates a new CAEX object and appends it to already existing elements in this sequence.                                                                                                             
![Public method]![Code example] | [Append(ValueTuple&lt;String, Object>[])][18]  | Creates a new CAEX object and appends it to already existing elements. The content of the new element can be optionally defined using an array of tuples defining attribute names and their values. 
![Public method]                | [At][19]                                       | Gets the CAEX object at the specified index.                                                                                                                                                        
![Public method]                | [GetEnumerator][20]                            | Gets the enumerator for this sequence. (Overrides [NamedElementSequence&lt;T>.GetEnumerator()][21].)                                                                                                
![Public method]                | [IndexOf][22]                                  | Gets the Index of the specified CAEX object in this sequence of elements.                                                                                                                           
![Public method]                | [Insert][23]                                   | Inserts the specified CAEX object into this sequence. If no position is specified the element is appended. If 'asFirst' is set to `true`, the element is prepended to already existing ones.        
![Public method]                | [InsertAt][24]                                 | Inserts the specified CAEX object into this sequence at the defined index.                                                                                                                          
![Public method]                | [Move][25]                                     | Moves the CAEX object at the specified index to a new location in the collection.                                                                                                                   
![Public method]                | [Prepend()][26]                                | Creates a new CAEX object and prepends it to already existing elements.                                                                                                                             
![Public method]                | [Prepend(ValueTuple&lt;String, Object>[])][27] | Creates a new CAEX object and prepends it to already existing elements. The content of the new element can be defined using an array of tuples defining attribute names and their values.           
![Public method]                | [Remove][28]                                   | Removes all CAEX objects from this sequence. (Inherited from [NamedElementSequence&lt;T>][2].)                                                                                                      
![Public method]                | [RemoveAt][29]                                 | Removes the element at the given index. (Inherited from [NamedElementSequence&lt;T>][2].)                                                                                                           
![Public method]                | [RemoveElement][30]                            | Removes the provided CAEX object from this sequence.                                                                                                                                                


Explicit Interface Implementations
----------------------------------

                                                                     | Name                                                         | Description                                                                                                                                                                                         
-------------------------------------------------------------------- | ------------------------------------------------------------ | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Explicit interface implementation]![Private method]                | [IEnumerable.GetEnumerator][31]                              | (Inherited from [NamedElementSequence&lt;T>][2].)                                                                                                                                                   
![Explicit interface implementation]![Private method]                | [ICAEXSequence.Append()][32]                                 | Creates a new CAEX object and appends it to already existing elements in this sequence.                                                                                                             
![Explicit interface implementation]![Private method]![Code example] | [ICAEXSequence.Append(ValueTuple&lt;String, Object>[])][33]  | Creates a new CAEX object and appends it to already existing elements. The content of the new element can be optionally defined using an array of tuples defining attribute names and their values. 
![Explicit interface implementation]![Private method]                | [ICAEXSequence.At][34]                                       | Gets the CAEX object at the specified index.                                                                                                                                                        
![Explicit interface implementation]![Private property]              | [ICAEXSequence.First][35]                                    | Gets a wrapper for the first CAEX element in this sequence, if the sequence contains no elements `null` is returned.                                                                                
![Explicit interface implementation]![Private method]                | [ICAEXSequence.GetEnumerator][36]                            | Gets the enumerator for this sequence.                                                                                                                                                              
![Explicit interface implementation]![Private method]                | [ICAEXSequence.IndexOf][37]                                  | Gets the Index of the specified CAEX object in this sequence of elements.                                                                                                                           
![Explicit interface implementation]![Private method]                | [ICAEXSequence.Insert][38]                                   | Inserts the specified CAEX object into this sequence. If no position is specified the element is appended. If 'asFirst' is set to `true`, the element is prepended to already existing ones.        
![Explicit interface implementation]![Private method]                | [ICAEXSequence.InsertAt][39]                                 | Inserts the specified CAEX object into this sequence at the defined index.                                                                                                                          
![Explicit interface implementation]![Private property]              | [ICAEXSequence.Item[Int32]][40]                              | Gets a wrapper for the CAEX element in this sequence at the given position                                                                                                                          
![Explicit interface implementation]![Private property]              | [ICAEXSequence.Item[ValueTuple&lt;String, String>]][41]      | Gets the first CAEX object with a specific attribute value from the sequence of elements                                                                                                            
![Explicit interface implementation]![Private property]              | [ICAEXSequence.Last][42]                                     | Gets a wrapper for the last CAEX element in this sequence, if the sequence contains no elements `null` is returned.                                                                                 
![Explicit interface implementation]![Private method]                | [ICAEXSequence.Prepend()][43]                                | Creates a new CAEX object and prepends it to already existing elements.                                                                                                                             
![Explicit interface implementation]![Private method]                | [ICAEXSequence.Prepend(ValueTuple&lt;String, Object>[])][44] | Creates a new CAEX object and prepends it to already existing elements. The content of the new element can be defined using an array of tuples defining attribute names and their values.           
![Explicit interface implementation]![Private method]                | [ICAEXSequence.RemoveElement][45]                            | Removes the provided CAEX object from this sequence.                                                                                                                                                


See Also
--------

#### Reference
[Aml.Engine.CAEX Namespace][4]  
[System.Collections.Generic.IEnumerable&lt;T>][46]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../NamedElementSequence_1/README.md
[3]: ../CAEXSequenceOfCAEXObjects_1/README.md
[4]: ../README.md
[5]: _ctor.md
[6]: ../NamedElementSequence_1/CAEXOwner.md
[7]: ../NamedElementSequence_1/Count.md
[8]: ../NamedElementSequence_1/ElementName.md
[9]: ../NamedElementSequence_1/Elements.md
[10]: ../NamedElementSequence_1/Exists.md
[11]: First.md
[12]: Item.md
[13]: ../NamedElementSequence_1/Item.md
[14]: Item_1.md
[15]: Last.md
[16]: ../NamedElementSequence_1/Owner.md
[17]: Append.md
[18]: Append_1.md
[19]: At.md
[20]: GetEnumerator.md
[21]: ../NamedElementSequence_1/GetEnumerator.md
[22]: IndexOf.md
[23]: Insert.md
[24]: InsertAt.md
[25]: Move.md
[26]: Prepend.md
[27]: Prepend_1.md
[28]: ../NamedElementSequence_1/Remove.md
[29]: ../NamedElementSequence_1/RemoveAt.md
[30]: RemoveElement.md
[31]: ../NamedElementSequence_1/System_Collections_IEnumerable_GetEnumerator.md
[32]: Aml_Engine_CAEX_ICAEXSequence_Append.md
[33]: Aml_Engine_CAEX_ICAEXSequence_Append_1.md
[34]: Aml_Engine_CAEX_ICAEXSequence_At.md
[35]: Aml_Engine_CAEX_ICAEXSequence_First.md
[36]: Aml_Engine_CAEX_ICAEXSequence_GetEnumerator.md
[37]: Aml_Engine_CAEX_ICAEXSequence_IndexOf.md
[38]: Aml_Engine_CAEX_ICAEXSequence_Insert.md
[39]: Aml_Engine_CAEX_ICAEXSequence_InsertAt.md
[40]: Aml_Engine_CAEX_ICAEXSequence_Item.md
[41]: Aml_Engine_CAEX_ICAEXSequence_Item_1.md
[42]: Aml_Engine_CAEX_ICAEXSequence_Last.md
[43]: Aml_Engine_CAEX_ICAEXSequence_Prepend.md
[44]: Aml_Engine_CAEX_ICAEXSequence_Prepend_1.md
[45]: Aml_Engine_CAEX_ICAEXSequence_RemoveElement.md
[46]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[47]: https://www.automationml.org
[48]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public property]: ../../icons/pubproperty.gif "Public property"
[Code example]: ../../icons/CodeExample.png "Code example"
[Explicit interface implementation]: ../../icons/pubinterface.gif "Explicit interface implementation"
[Private method]: ../../icons/privmethod.gif "Private method"
[Private property]: ../../icons/privproperty.gif "Private property"