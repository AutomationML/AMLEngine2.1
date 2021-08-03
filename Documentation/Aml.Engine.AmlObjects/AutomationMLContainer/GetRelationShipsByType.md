AutomationMLContainer.GetRelationShipsByType Method
===================================================
AutomationML 2.1 APIReturns an enumeration of all relationships with the given relationship type.

  **Namespace:**  [Aml.Engine.AmlObjects][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public IEnumerable<PackageRelationship> GetRelationShipsByType(
	AutomationMLContainer.RelationshipType relationType
)
```

#### Parameters

##### *relationType*
Type: [Aml.Engine.AmlObjects.AutomationMLContainer.RelationshipType][2]  
 Type of the relation.

#### Return Value
Type: [IEnumerable][3]&lt;[PackageRelationship][4]>  
 IEnumerable&lt;PackageRelationship>. 

See Also
--------

#### Reference
[AutomationMLContainer Class][5]  
[Aml.Engine.AmlObjects Namespace][1]  

[1]: ../README.md
[2]: ../AutomationMLContainer_RelationshipType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[4]: https://docs.microsoft.com/dotnet/api/system.io.packaging.packagerelationship
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png