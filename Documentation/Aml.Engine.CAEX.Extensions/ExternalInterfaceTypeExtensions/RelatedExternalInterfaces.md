ExternalInterfaceTypeExtensions.RelatedExternalInterfaces Method
================================================================
Gets the related external interfaces of the specified ExternalInterface connected with InternalLinks. Either the [AInterface][1] or the [BInterface][2] of the InternalLink is equal to the specified ExternalInterface.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][3]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static IEnumerable<ExternalInterfaceType> RelatedExternalInterfaces(
	this ExternalInterfaceType externalInterface
)
```

#### Parameters

##### *externalInterface*
Type: [Aml.Engine.CAEX.ExternalInterfaceType][4]  
The ExternalInterface CAEX element.

#### Return Value
Type: [IEnumerable][5]&lt;[ExternalInterfaceType][4]>  
An enumeration of related ExternalInterface elements
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [ExternalInterfaceType][4]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][6] or [Extension Methods (C# Programming Guide)][7].

See Also
--------

#### Reference
[ExternalInterfaceTypeExtensions Class][8]  
[Aml.Engine.CAEX.Extensions Namespace][3]  

[1]: ../../Aml.Engine.CAEX/InternalLinkType/AInterface.md
[2]: ../../Aml.Engine.CAEX/InternalLinkType/BInterface.md
[3]: ../README.md
[4]: ../../Aml.Engine.CAEX/ExternalInterfaceType/README.md
[5]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[6]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[7]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[8]: README.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png