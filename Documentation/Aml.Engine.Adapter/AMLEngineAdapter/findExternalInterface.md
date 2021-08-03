AMLEngineAdapter.findExternalInterface Method
=============================================


**Note: This API is now obsolete.**
Searches for an ExternalInterface in this InternalElement

  **Namespace:**  [Aml.Engine.Adapter][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
[ObsoleteAttribute("Use the Indexer of the ExternalInterface sequence ExternalInterface[interfaceName]", 
	false)]
public static ExternalInterfaceType findExternalInterface(
	this IObjectWithExternalInterface systemUnitClass,
	string interfaceName
)
```

#### Parameters

##### *systemUnitClass*
Type: [Aml.Engine.CAEX.IObjectWithExternalInterface][2]  
The system unit class.

##### *interfaceName*
Type: [System.String][3]  
Name of the ExternalInterface to search for

#### Return Value
Type: [ExternalInterfaceType][4]  
 An ExternalInterface of the given element with name attribute equal to interfaceName 
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [IObjectWithExternalInterface][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][5] or [Extension Methods (C# Programming Guide)][6].

See Also
--------

#### Reference
[AMLEngineAdapter Class][7]  
[Aml.Engine.Adapter Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/IObjectWithExternalInterface/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: ../../Aml.Engine.CAEX/ExternalInterfaceType/README.md
[5]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[6]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png