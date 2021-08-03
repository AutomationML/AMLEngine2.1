CAEXSequenceEnumerator&lt;T> Class
==================================
This class implements the CAEX sequence enumerator which creates a CAEXWrapper for each enumerated XML-Element.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  **Aml.Engine.CAEX.CAEXSequenceEnumerator&lt;T>**  

  **Namespace:**  [Aml.Engine.CAEX][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public class CAEXSequenceEnumerator<T> : IEnumerator<T>, 
	IDisposable, IEnumerator
where T : CAEXWrapper

```

#### Type Parameters

##### *T*


The **CAEXSequenceEnumerator&lt;T>** type exposes the following members.


Constructors
------------

                 | Name                              | Description                                                               
---------------- | --------------------------------- | ------------------------------------------------------------------------- 
![Public method] | [CAEXSequenceEnumerator&lt;T>][3] | Initializes a new instance of the **CAEXSequenceEnumerator&lt;T>** class. 


Properties
----------

                   | Name         | Description                                                                
------------------ | ------------ | -------------------------------------------------------------------------- 
![Public property] | [Current][4] | Gets the item in the collection at the current position of the enumerator. 


Methods
-------

                 | Name          | Description                                             
---------------- | ------------- | ------------------------------------------------------- 
![Public method] | [Dispose][5]  | Dispose this instance.                                  
![Public method] | [MoveNext][6] | Sets the enumerator to the next item in the collection. 
![Public method] | [Reset][7]    | Resets the enumerator.                                  


Explicit Interface Implementations
----------------------------------

                                                        | Name                     | Description                                                                
------------------------------------------------------- | ------------------------ | -------------------------------------------------------------------------- 
![Explicit interface implementation]![Private property] | [IEnumerator.Current][8] | Gets the item in the collection at the current position of the enumerator. 


See Also
--------

#### Reference
[Aml.Engine.CAEX Namespace][2]  
[System.Collections.Generic.IEnumerator&lt;T>][9]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../README.md
[3]: _ctor.md
[4]: Current.md
[5]: Dispose.md
[6]: MoveNext.md
[7]: Reset.md
[8]: System_Collections_IEnumerator_Current.md
[9]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerator-1
[10]: https://www.automationml.org
[11]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public property]: ../../icons/pubproperty.gif "Public property"
[Explicit interface implementation]: ../../icons/pubinterface.gif "Explicit interface implementation"
[Private property]: ../../icons/privproperty.gif "Private property"