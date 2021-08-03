InterfaceFamilyType.GetReferenceHierarchy&lt;T> Method
======================================================
AutomationML 2.1 API

**Note: This API is now obsolete.**
Gets the reference (Inheritance) hierarchy including this instance in an ordered sequence of ancestors.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
[ObsoleteAttribute("Use the more specific method")]
public Queue<T> GetReferenceHierarchy<T>()
where T : IClassWithBaseClassReference

```

#### Type Parameters

##### *T*
Type of the CAEX class in the hierarchy.

#### Return Value
Type: [Queue][2]&lt;**T**>  
a queue of ancestors. this instance is first in the queue
#### Implements
[IClassWithBaseClassReference.GetReferenceHierarchy&lt;T>()][3]  


See Also
--------

#### Reference
[InterfaceFamilyType Class][4]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.collections.generic.queue-1
[3]: ../IClassWithBaseClassReference/GetReferenceHierarchy__1.md
[4]: README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png