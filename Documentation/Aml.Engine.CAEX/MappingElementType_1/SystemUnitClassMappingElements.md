MappingElementType&lt;T>.SystemUnitClassMappingElements Property
================================================================
Gets the collection of all possible elements and their mapping identifiers of the mapped SystemUnitClass and its ancestors in the inheritance tree for this mapping element. The mapping identifier uniquely identifies the mapped CAEX object. The syntax of the identifier is defined by the derived mapping element types and is build from the CAEX path of the object.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public abstract IEnumerable<(T , string MappingIdentifier)> SystemUnitClassMappingElements { get; }
```

#### Property Value
Type: [IEnumerable][2]&lt;[ValueTuple][3]&lt;[T][4], [String][5]>>  
 The possible mapping elements and their identifiers of the mapped SystemUnitClass. 

See Also
--------

#### Reference
[MappingElementType&lt;T> Class][4]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[3]: https://docs.microsoft.com/dotnet/api/system.valuetuple-2
[4]: README.md
[5]: https://docs.microsoft.com/dotnet/api/system.string
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png