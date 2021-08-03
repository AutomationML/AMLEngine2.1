IClassWithBaseClassReference.GetReferenceHierarchy&lt;T> Method
===============================================================
Gets the reference (inheritance relations) hierarchy including the actual class as a queue.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
Queue<T> GetReferenceHierarchy<T>()
where T : IClassWithBaseClassReference

```

#### Type Parameters

##### *T*
The type of the CAEX class.

#### Return Value
Type: [Queue][2]&lt;**T**>  
A Queue of the base classes including the actual class.

See Also
--------

#### Reference
[IClassWithBaseClassReference Interface][3]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.collections.generic.queue-1
[3]: README.md
[4]: https://www.automationml.org
[5]: ../../icons/logoShade.png