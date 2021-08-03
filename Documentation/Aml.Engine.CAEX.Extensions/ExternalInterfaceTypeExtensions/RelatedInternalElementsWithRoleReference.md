ExternalInterfaceTypeExtensions.RelatedInternalElementsWithRoleReference Method
===============================================================================
AutomationML 2.1 APIGets the related InternalElements of the specified ExternalInterface connected with InternalLinks, which have a role reference to the provided *roleClassPath*. Inheritance is considered here. Either the [AInterface][1] or the [BInterface][2] of the InternalLink is equal to the specified ExternalInterface.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][3]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static IEnumerable<InternalElementType> RelatedInternalElementsWithRoleReference(
	this ExternalInterfaceType externalInterface,
	string roleClassPath
)
```

#### Parameters

##### *externalInterface*
Type: [Aml.Engine.CAEX.ExternalInterfaceType][4]  
The ExternalInterface CAEX element.

##### *roleClassPath*
Type: [System.String][5]  
The role class path.

#### Return Value
Type: [IEnumerable][6]&lt;[InternalElementType][7]>  
 An enumeration of selected related InternalElements. 
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [ExternalInterfaceType][4]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][8] or [Extension Methods (C# Programming Guide)][9].

See Also
--------

#### Reference
[ExternalInterfaceTypeExtensions Class][10]  
[Aml.Engine.CAEX.Extensions Namespace][3]  

[1]: ../../Aml.Engine.CAEX/InternalLinkType/AInterface.md
[2]: ../../Aml.Engine.CAEX/InternalLinkType/BInterface.md
[3]: ../README.md
[4]: ../../Aml.Engine.CAEX/ExternalInterfaceType/README.md
[5]: https://docs.microsoft.com/dotnet/api/system.string
[6]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[7]: ../../Aml.Engine.CAEX/InternalElementType/README.md
[8]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[9]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[10]: README.md
[11]: https://www.automationml.org
[12]: ../../icons/logoShade.png