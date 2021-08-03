AutomationMLContainer.GetRelatedParts Method (PackagePart, AutomationMLContainer.RelationshipType)
==================================================================================================
AutomationML 2.1 APIReturns an enumeration of the related parts for the specified part and relationship type.

  **Namespace:**  [Aml.Engine.AmlObjects][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public IEnumerable<PackagePart> GetRelatedParts(
	PackagePart part,
	AutomationMLContainer.RelationshipType relationShipType
)
```

#### Parameters

##### *part*
Type: [System.IO.Packaging.PackagePart][2]  
 The part.

##### *relationShipType*
Type: [Aml.Engine.AmlObjects.AutomationMLContainer.RelationshipType][3]  
 The relationship type.

#### Return Value
Type: [IEnumerable][4]&lt;[PackagePart][2]>  
 IEnumerable&lt;PackagePart>. 

See Also
--------

#### Reference
[AutomationMLContainer Class][5]  
[Aml.Engine.AmlObjects Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.io.packaging.packagepart
[3]: ../AutomationMLContainer_RelationshipType/README.md
[4]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png