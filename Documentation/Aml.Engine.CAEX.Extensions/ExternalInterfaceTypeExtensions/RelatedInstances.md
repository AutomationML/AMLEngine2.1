ExternalInterfaceTypeExtensions.RelatedInstances Method
=======================================================
Gets the related instances (SystemUnitClass or InternalElement) of the specified ExternalInterface connected with InternalLinks. Either the [AInterface][1] or the [BInterface][2] of the InternalLink is equal to the specified ExternalInterface.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][3]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static IEnumerable<SystemUnitClassType> RelatedInstances(
	this ExternalInterfaceType externalInterface
)
```

#### Parameters

##### *externalInterface*
Type: [Aml.Engine.CAEX.ExternalInterfaceType][4]  
The ExternalInterface CAEX element.

#### Return Value
Type: [IEnumerable][5]&lt;[SystemUnitClassType][6]>  
An enumeration of related Instances
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [ExternalInterfaceType][4]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][7] or [Extension Methods (C# Programming Guide)][8].

See Also
--------

#### Reference
[ExternalInterfaceTypeExtensions Class][9]  
[Aml.Engine.CAEX.Extensions Namespace][3]  

[1]: ../../Aml.Engine.CAEX/InternalLinkType/AInterface.md
[2]: ../../Aml.Engine.CAEX/InternalLinkType/BInterface.md
[3]: ../README.md
[4]: ../../Aml.Engine.CAEX/ExternalInterfaceType/README.md
[5]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[6]: ../../Aml.Engine.CAEX/SystemUnitClassType/README.md
[7]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[8]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[9]: README.md
[10]: https://www.automationml.org
[11]: ../../icons/logoShade.png