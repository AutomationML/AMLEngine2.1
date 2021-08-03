ValueSequence&lt;TDataType> Class
=================================
AutomationML 2.1 APIThis class implements methods to work with a sequence of CAEX elements and indexed access to their values.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  [Aml.Engine.CAEX.NamedElementSequence][2]&lt;**TDataType**>  
    **Aml.Engine.CAEX.ValueSequence&lt;TDataType>**  

  **Namespace:**  [Aml.Engine.CAEX][3]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public class ValueSequence<TDataType> : NamedElementSequence<TDataType>

```

#### Type Parameters

##### *TDataType*
The Value type

The **ValueSequence&lt;TDataType>** type exposes the following members.


Constructors
------------

                 | Name                                                                       | Description                                                                                                                                                                                                                                                          
---------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method] | [ValueSequence&lt;TDataType>(XElement, String)][4]                         | Creates a new instance of the ValueSequence for the specified owner and the specified name which has to be a valid name for child elements, which can be filtered out from the owner by this name.                                                                   
![Public method] | [ValueSequence&lt;TDataType>(XElement, String, Predicate&lt;XElement>)][5] | Creates a new instance of the ValueSequence for the specified owner and the specified name which has to be a valid name for child elements, which can be filtered out from the owner by this name. The specified condition is used as an additional filter criteria. 


Properties
----------

                   | Name                  | Description                                                                                                                        
------------------ | --------------------- | ---------------------------------------------------------------------------------------------------------------------------------- 
![Public property] | [CAEXOwner][6]        | Gets the CAEX owner of this sequence (Inherited from [NamedElementSequence&lt;T>][2].)                                             
![Public property] | [Count][7]            | Gets the number of elements in this sequence (Inherited from [NamedElementSequence&lt;T>][2].)                                     
![Public property] | [ElementAndValues][8] | Gets the collection of Xml-Elements and their associated Values in this ValueSequence.                                             
![Public property] | [ElementName][9]      | Gets the name of the elements in this sequence (Inherited from [NamedElementSequence&lt;T>][2].)                                   
![Public property] | [Elements][10]        | Gets a list of unwrapped CAEX elements (XElements) of this sequence (Inherited from [NamedElementSequence&lt;T>][2].)              
![Public property] | [Exists][11]          | Determines, if the sequence contains any element (Inherited from [NamedElementSequence&lt;T>][2].)                                 
![Public property] | [Item][12]            | Gets the value of the CAEX object in this sequence at the given position (Overrides [NamedElementSequence&lt;T>.Item[Int32]][13].) 
![Public property] | [Owner][14]           | Gets the owner of this sequence (Inherited from [NamedElementSequence&lt;T>][2].)                                                  
![Public property] | [ValueConverter][15]  | The value converter                                                                                                                
![Public property] | [Values][16]          | Gets a collection of values of the CAEX elements of this sequence                                                                  


Methods
-------

                 | Name                | Description                                                                                                                            
---------------- | ------------------- | -------------------------------------------------------------------------------------------------------------------------------------- 
![Public method] | [Append][17]        | Creates a new CAEX object and appends it to the value sequence. The value of the appended object is set to the provided value.         
![Public method] | [At][18]            | Gets the value from the element at the specified index.                                                                                
![Public method] | [GetEnumerator][19] | Gets the enumerator for this sequence which enumerates the [Values][16]. (Overrides [NamedElementSequence&lt;T>.GetEnumerator()][20].) 
![Public method] | [IndexOf][21]       | Gets the Index of the specified element in the sequence of elements with the same name                                                 
![Public method] | [Prepend][22]       | Creates a new CAEX object with the provided value and prepends it to already existing elements.                                        
![Public method] | [Remove][23]        | Removes all CAEX objects from this sequence. (Inherited from [NamedElementSequence&lt;T>][2].)                                         
![Public method] | [RemoveAt][24]      | Removes the element at the given index. (Inherited from [NamedElementSequence&lt;T>][2].)                                              


Explicit Interface Implementations
----------------------------------

                                                      | Name                            | Description                                       
----------------------------------------------------- | ------------------------------- | ------------------------------------------------- 
![Explicit interface implementation]![Private method] | [IEnumerable.GetEnumerator][25] | (Inherited from [NamedElementSequence&lt;T>][2].) 


See Also
--------

#### Reference
[Aml.Engine.CAEX Namespace][3]  
[System.Collections.Generic.IEnumerable&lt;T>][26]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../NamedElementSequence_1/README.md
[3]: ../README.md
[4]: _ctor.md
[5]: _ctor_1.md
[6]: ../NamedElementSequence_1/CAEXOwner.md
[7]: ../NamedElementSequence_1/Count.md
[8]: ElementAndValues.md
[9]: ../NamedElementSequence_1/ElementName.md
[10]: ../NamedElementSequence_1/Elements.md
[11]: ../NamedElementSequence_1/Exists.md
[12]: Item.md
[13]: ../NamedElementSequence_1/Item.md
[14]: ../NamedElementSequence_1/Owner.md
[15]: ValueConverter.md
[16]: Values.md
[17]: Append.md
[18]: At.md
[19]: GetEnumerator.md
[20]: ../NamedElementSequence_1/GetEnumerator.md
[21]: IndexOf.md
[22]: Prepend.md
[23]: ../NamedElementSequence_1/Remove.md
[24]: ../NamedElementSequence_1/RemoveAt.md
[25]: ../NamedElementSequence_1/System_Collections_IEnumerable_GetEnumerator.md
[26]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[27]: https://www.automationml.org
[28]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public property]: ../../icons/pubproperty.gif "Public property"
[Explicit interface implementation]: ../../icons/pubinterface.gif "Explicit interface implementation"
[Private method]: ../../icons/privmethod.gif "Private method"