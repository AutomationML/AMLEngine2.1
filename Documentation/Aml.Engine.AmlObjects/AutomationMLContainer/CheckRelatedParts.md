AutomationMLContainer.CheckRelatedParts Method
==============================================
Returns an enumeration of the related parts for the specified part and relationship type.

  **Namespace:**  [Aml.Engine.AmlObjects][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public IEnumerable<(Uri PartUri, Uri RelatedPartUri, bool Exists)> CheckRelatedParts(
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
Type: [IEnumerable][4]&lt;[ValueTuple][5]&lt;[Uri][6], [Uri][6], [Boolean][7]>>  
 IEnumerable&lt;PackagePart>. 

See Also
--------

#### Reference
[AutomationMLContainer Class][8]  
[Aml.Engine.AmlObjects Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.io.packaging.packagepart
[3]: ../AutomationMLContainer_RelationshipType/README.md
[4]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[5]: https://docs.microsoft.com/dotnet/api/system.valuetuple-3
[6]: https://docs.microsoft.com/dotnet/api/system.uri
[7]: https://docs.microsoft.com/dotnet/api/system.boolean
[8]: README.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png