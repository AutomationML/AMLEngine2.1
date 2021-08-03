NamedElementSequence&lt;T> Class
================================
AutomationML 2.1 APIA Sequence of XML elements related to a specific element name. An XML element may contain different NamedElementSequences with different names.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  **Aml.Engine.CAEX.NamedElementSequence&lt;T>**  
    [Aml.Engine.CAEX.CAEXSequence&lt;T>][2]  
    [Aml.Engine.CAEX.ValueSequence&lt;TDataType>][3]  

  **Namespace:**  [Aml.Engine.CAEX][4]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public abstract class NamedElementSequence<T> : IEnumerable<T>, 
	IEnumerable

```

#### Type Parameters

##### *T*

[Missing &lt;typeparam name="T"/> documentation for "T:Aml.Engine.CAEX.NamedElementSequence`1"]


The **NamedElementSequence&lt;T>** type exposes the following members.


Properties
----------

                   | Name             | Description                                                         
------------------ | ---------------- | ------------------------------------------------------------------- 
![Public property] | [CAEXOwner][5]   | Gets the CAEX owner of this sequence                                
![Public property] | [Count][6]       | Gets the number of elements in this sequence                        
![Public property] | [ElementName][7] | Gets the name of the elements in this sequence                      
![Public property] | [Elements][8]    | Gets a list of unwrapped CAEX elements (XElements) of this sequence 
![Public property] | [Exists][9]      | Determines, if the sequence contains any element                    
![Public property] | [Item][10]       | Gets or sets the value at the specified index.                      
![Public property] | [Owner][11]      | Gets the owner of this sequence                                     


Methods
-------

                 | Name                | Description                                                 
---------------- | ------------------- | ----------------------------------------------------------- 
![Public method] | [GetEnumerator][12] | Returns an enumerator that iterates through the collection. 
![Public method] | [Remove][13]        | Removes all CAEX objects from this sequence.                
![Public method] | [RemoveAt][14]      | Removes the element at the given index.                     


Explicit Interface Implementations
----------------------------------

                                                      | Name                            | Description 
----------------------------------------------------- | ------------------------------- | ----------- 
![Explicit interface implementation]![Private method] | [IEnumerable.GetEnumerator][15] |             


See Also
--------

#### Reference
[Aml.Engine.CAEX Namespace][4]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../CAEXSequence_1/README.md
[3]: ../ValueSequence_1/README.md
[4]: ../README.md
[5]: CAEXOwner.md
[6]: Count.md
[7]: ElementName.md
[8]: Elements.md
[9]: Exists.md
[10]: Item.md
[11]: Owner.md
[12]: GetEnumerator.md
[13]: Remove.md
[14]: RemoveAt.md
[15]: System_Collections_IEnumerable_GetEnumerator.md
[16]: https://www.automationml.org
[17]: ../../icons/logoShade.png
[Public property]: ../../icons/pubproperty.gif "Public property"
[Public method]: ../../icons/pubmethod.gif "Public method"
[Explicit interface implementation]: ../../icons/pubinterface.gif "Explicit interface implementation"
[Private method]: ../../icons/privmethod.gif "Private method"