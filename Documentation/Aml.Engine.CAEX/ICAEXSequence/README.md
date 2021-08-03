ICAEXSequence Interface
=======================
This interface defines a sequence of CAEX elements.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public interface ICAEXSequence
```

The **ICAEXSequence** type exposes the following members.


Properties
----------

                   | Name                                     | Description                                                                                                          
------------------ | ---------------------------------------- | -------------------------------------------------------------------------------------------------------------------- 
![Public property] | [First][2]                               | Gets a wrapper for the first CAEX element in this sequence, if the sequence contains no elements `null` is returned. 
![Public property] | [Item[Int32]][3]                         | Gets a wrapper for the CAEX element in this sequence at the given position                                           
![Public property] | [Item[ValueTuple&lt;String, String>]][4] | Gets the first CAEX object with a specific attribute value from the sequence of elements                             
![Public property] | [Last][5]                                | Gets a wrapper for the last CAEX element in this sequence, if the sequence contains no elements `null` is returned.  


Methods
-------

                                | Name                                           | Description                                                                                                                                                                                         
------------------------------- | ---------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method]                | [Append()][6]                                  | Creates a new CAEX object and appends it to already existing elements in this sequence.                                                                                                             
![Public method]![Code example] | [Append(ValueTuple&lt;String, Object>[])][7]   | Creates a new CAEX object and appends it to already existing elements. The content of the new element can be optionally defined using an array of tuples defining attribute names and their values. 
![Public method]                | [At][8]                                        | Gets the CAEX object at the specified index.                                                                                                                                                        
![Public method]                | [GetEnumerator][9]                             | Gets the enumerator for this sequence.                                                                                                                                                              
![Public method]                | [IndexOf][10]                                  | Gets the Index of the specified CAEX object in this sequence of elements.                                                                                                                           
![Public method]                | [Insert][11]                                   | Inserts the specified CAEX object into this sequence. If no position is specified the element is appended. If 'asFirst' is set to `true`, the element is prepended to already existing ones.        
![Public method]                | [InsertAt][12]                                 | Inserts the specified CAEX object into this sequence at the defined index.                                                                                                                          
![Public method]                | [Move][13]                                     | Moves the CAEX object at the specified index to a new location in the collection.                                                                                                                   
![Public method]                | [Prepend()][14]                                | Creates a new CAEX object and prepends it to already existing elements.                                                                                                                             
![Public method]                | [Prepend(ValueTuple&lt;String, Object>[])][15] | Creates a new CAEX object and prepends it to already existing elements. The content of the new element can be defined using an array of tuples defining attribute names and their values.           
![Public method]                | [RemoveElement][16]                            | Removes the provided CAEX object from this sequence.                                                                                                                                                


See Also
--------

#### Reference
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: First.md
[3]: Item.md
[4]: Item_1.md
[5]: Last.md
[6]: Append.md
[7]: Append_1.md
[8]: At.md
[9]: GetEnumerator.md
[10]: IndexOf.md
[11]: Insert.md
[12]: InsertAt.md
[13]: Move.md
[14]: Prepend.md
[15]: Prepend_1.md
[16]: RemoveElement.md
[17]: https://www.automationml.org
[18]: ../../icons/logoShade.png
[Public property]: ../../icons/pubproperty.gif "Public property"
[Public method]: ../../icons/pubmethod.gif "Public method"
[Code example]: ../../icons/CodeExample.png "Code example"