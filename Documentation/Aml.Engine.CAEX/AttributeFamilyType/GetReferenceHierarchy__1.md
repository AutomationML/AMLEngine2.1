AttributeFamilyType.GetReferenceHierarchy&lt;T> Method
======================================================
AutomationML 2.1 API

**Note: This API is now obsolete.**
Gets the reference (inheritance) hierarchy. The reference hierarchy includes this instance and the reference hierarchy of an associated [BaseClass][1] defining a class to class relation.

  **Namespace:**  [Aml.Engine.CAEX][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
[ObsoleteAttribute("Use the GetReferenceHierarchy returning IEnumerable instead.")]
public Queue<T> GetReferenceHierarchy<T>()
where T : IClassWithBaseClassReference

```

#### Type Parameters

##### *T*
Type of the CAEX class.

#### Return Value
Type: [Queue][3]&lt;**T**>  
 Queue, containing this instance at the first element, followed by the reference hierarchy of a base class. 
#### Implements
[IClassWithBaseClassReference.GetReferenceHierarchy&lt;T>()][4]  


See Also
--------

#### Reference
[AttributeFamilyType Class][5]  
[Aml.Engine.CAEX Namespace][2]  

[1]: BaseClass.md
[2]: ../README.md
[3]: https://docs.microsoft.com/dotnet/api/system.collections.generic.queue-1
[4]: ../IClassWithBaseClassReference/GetReferenceHierarchy__1.md
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png