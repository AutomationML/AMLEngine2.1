XmlSchemaManager.MaxOccurence Method
====================================
Returned the maximal occurrence for child nodes with the specified name under a parent node with the specified name. For unbounded occurrences, the returned value is [MaxValue][1]. If the occurrence is `0`, the existence of a child with that name under a parent with that name is not allowed.

  **Namespace:**  [Aml.Engine.Schema][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public decimal MaxOccurence(
	string parentName,
	string childName
)
```

#### Parameters

##### *parentName*
Type: [System.String][3]  
Name of the child's parent

##### *childName*
Type: [System.String][3]  
Name of the child

#### Return Value
Type: [Decimal][4]  
The maximal occurrence of children with the defined name.

See Also
--------

#### Reference
[XmlSchemaManager Class][5]  
[Aml.Engine.Schema Namespace][2]  

[1]: https://docs.microsoft.com/dotnet/api/system.decimal.maxvalue
[2]: ../README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: https://docs.microsoft.com/dotnet/api/system.decimal
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png