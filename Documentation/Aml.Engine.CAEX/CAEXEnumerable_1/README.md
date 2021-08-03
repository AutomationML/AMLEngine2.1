CAEXEnumerable&lt;T> Class
==========================
AutomationML 2.1 APIThis class implements a specific enumeration type which wraps an XElement with a CAEXWrapper during enumeration. The enumerator for this class is [CAEXSequenceEnumerator&lt;T>][1]


Inheritance Hierarchy
---------------------
[System.Object][2]  
  **Aml.Engine.CAEX.CAEXEnumerable&lt;T>**  

  **Namespace:**  [Aml.Engine.CAEX][3]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public class CAEXEnumerable<T> : IEnumerable<T>, 
	IEnumerable
where T : CAEXWrapper

```

#### Type Parameters

##### *T*
Type of the CAEX wrapper

The **CAEXEnumerable&lt;T>** type exposes the following members.


Constructors
------------

                 | Name                                                                    | Description                                                                        
---------------- | ----------------------------------------------------------------------- | ---------------------------------------------------------------------------------- 
![Public method] | [CAEXEnumerable&lt;T>(IEnumerable&lt;XElement>)][4]                     | Creates a new instance for the CAEX enumerable without an associated CAEXSequence. 
![Public method] | [CAEXEnumerable&lt;T>(CAEXSequence&lt;T>, IEnumerable&lt;XElement>)][5] | Creates a new instance for a CAEXEnumerable with an associated CAEXSequence.       


Methods
-------

                 | Name               | Description                     
---------------- | ------------------ | ------------------------------- 
![Public method] | [GetEnumerator][6] | Gets the CAEXSequenceEnumerator 


Explicit Interface Implementations
----------------------------------

                                                      | Name                           | Description                                               
----------------------------------------------------- | ------------------------------ | --------------------------------------------------------- 
![Explicit interface implementation]![Private method] | [IEnumerable.GetEnumerator][7] | Returns an enumerator that iterates through a collection. 


See Also
--------

#### Reference
[Aml.Engine.CAEX Namespace][3]  
[System.Collections.Generic.IEnumerable&lt;T>][8]  

[1]: ../CAEXSequenceEnumerator_1/README.md
[2]: https://docs.microsoft.com/dotnet/api/system.object
[3]: ../README.md
[4]: _ctor_1.md
[5]: _ctor.md
[6]: GetEnumerator.md
[7]: System_Collections_IEnumerable_GetEnumerator.md
[8]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Explicit interface implementation]: ../../icons/pubinterface.gif "Explicit interface implementation"
[Private method]: ../../icons/privmethod.gif "Private method"