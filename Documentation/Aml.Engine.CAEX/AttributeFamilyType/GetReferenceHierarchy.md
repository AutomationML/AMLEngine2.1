AttributeFamilyType.GetReferenceHierarchy Method
================================================
Gets the reference (inheritance) hierarchy. The reference hierarchy includes this instance and the reference hierarchy of an associated [BaseClass][1] defining a class to class relation.

  **Namespace:**  [Aml.Engine.CAEX][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public IEnumerable<AttributeFamilyType> GetReferenceHierarchy()
```

#### Return Value
Type: [IEnumerable][3]&lt;[AttributeFamilyType][4]>  
Collection, containing this instance and the reference hierarchy of a base class.
#### Implements
[IClassWithBaseClassReference&lt;T>.GetReferenceHierarchy()][5]  


See Also
--------

#### Reference
[AttributeFamilyType Class][4]  
[Aml.Engine.CAEX Namespace][2]  

[1]: BaseClass.md
[2]: ../README.md
[3]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[4]: README.md
[5]: ../IClassWithBaseClassReference_1/GetReferenceHierarchy.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png