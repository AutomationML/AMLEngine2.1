MappingElementType&lt;T>.RoleClassMappingElements Method
========================================================
Gets the collection of all possible elements and their mapping identifiers of the mapped RoleClass and its ancestors in the inheritance tree for this mapping element. The mapping identifier uniquely identifies the mapped CAEX object. The syntax of the identifier is defined by the derived mapping element types and is build from the CAEX path of the object.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public abstract IEnumerable<(T , string MappingIdentifier)> RoleClassMappingElements(
	bool includeDuplicates = false
)
```

#### Parameters

##### *includeDuplicates* (Optional)
Type: [System.Boolean][2]  

[Missing &lt;param name="includeDuplicates"/> documentation for "M:Aml.Engine.CAEX.MappingElementType`1.RoleClassMappingElements(System.Boolean)"]


#### Field Value
Type: [IEnumerable][3]&lt;[ValueTuple][4]&lt;[T][5], [String][6]>>  
 The possible mapping elements and their identifiers of the mapped RoleClass. 
#### Return Value
Type: [IEnumerable][3]&lt;[ValueTuple][4]&lt;[T][5], [String][6]>>  

[Missing &lt;returns> documentation for "M:Aml.Engine.CAEX.MappingElementType`1.RoleClassMappingElements(System.Boolean)"]


See Also
--------

#### Reference
[MappingElementType&lt;T> Class][5]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.boolean
[3]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[4]: https://docs.microsoft.com/dotnet/api/system.valuetuple-2
[5]: README.md
[6]: https://docs.microsoft.com/dotnet/api/system.string
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png