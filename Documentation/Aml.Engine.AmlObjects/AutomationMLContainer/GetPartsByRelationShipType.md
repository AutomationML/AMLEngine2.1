AutomationMLContainer.GetPartsByRelationShipType Method
=======================================================
AutomationML 2.1 APIReturns an enumeration of all parts with the given relationship type from the package.

  **Namespace:**  [Aml.Engine.AmlObjects][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public IEnumerable<PackagePart> GetPartsByRelationShipType(
	AutomationMLContainer.RelationshipType relationShipType
)
```

#### Parameters

##### *relationShipType*
Type: [Aml.Engine.AmlObjects.AutomationMLContainer.RelationshipType][2]  
 The relationship type.

#### Return Value
Type: [IEnumerable][3]&lt;[PackagePart][4]>  
 IEnumerable&lt;PackagePart>. 

See Also
--------

#### Reference
[AutomationMLContainer Class][5]  
[Aml.Engine.AmlObjects Namespace][1]  

[1]: ../README.md
[2]: ../AutomationMLContainer_RelationshipType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[4]: https://docs.microsoft.com/dotnet/api/system.io.packaging.packagepart
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png