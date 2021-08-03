AMLEngineAdapter.GetExternalInterfaces Method
=============================================


**Note: This API is now obsolete.**
Gets the external interfaces.

  **Namespace:**  [Aml.Engine.Adapter][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
[ObsoleteAttribute("Direct enumeration of the ExternalInterface property is supported", 
	false)]
public static IEnumerable<InterfaceClassType> GetExternalInterfaces(
	this IObjectWithExternalInterface systemUnitClass,
	string interfaceName
)
```

#### Parameters

##### *systemUnitClass*
Type: [Aml.Engine.CAEX.IObjectWithExternalInterface][2]  

[Missing &lt;param name="systemUnitClass"/> documentation for "M:Aml.Engine.Adapter.AMLEngineAdapter.GetExternalInterfaces(Aml.Engine.CAEX.IObjectWithExternalInterface,System.String)"]


##### *interfaceName*
Type: [System.String][3]  

[Missing &lt;param name="interfaceName"/> documentation for "M:Aml.Engine.Adapter.AMLEngineAdapter.GetExternalInterfaces(Aml.Engine.CAEX.IObjectWithExternalInterface,System.String)"]


#### Return Value
Type: [IEnumerable][4]&lt;[InterfaceClassType][5]>  
IEnumerable&lt;InterfaceClassType>.
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [IObjectWithExternalInterface][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][6] or [Extension Methods (C# Programming Guide)][7].

See Also
--------

#### Reference
[AMLEngineAdapter Class][8]  
[Aml.Engine.Adapter Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/IObjectWithExternalInterface/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[5]: ../../Aml.Engine.CAEX/InterfaceClassType/README.md
[6]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[7]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[8]: README.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png