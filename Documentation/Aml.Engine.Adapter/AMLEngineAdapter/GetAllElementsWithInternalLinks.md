AMLEngineAdapter.GetAllElementsWithInternalLinks Method
=======================================================
AutomationML 2.1 API

**Note: This API is now obsolete.**
Getting a List of all Elements with InternalLinks of all InstanceHierarchies and SystemUnitClassLibraries in the CAEXFile. The List may contain InternalElements and SystemUnitClass elements.

  **Namespace:**  [Aml.Engine.Adapter][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
[ObsoleteAttribute("Use the Services.ServiceLocator.QueryService for any query.")]
public static List<SystemUnitClassType> GetAllElementsWithInternalLinks(
	this CAEXFileType caexFile
)
```

#### Parameters

##### *caexFile*
Type: [Aml.Engine.CAEX.CAEXFileType][2]  

[Missing &lt;param name="caexFile"/> documentation for "M:Aml.Engine.Adapter.AMLEngineAdapter.GetAllElementsWithInternalLinks(Aml.Engine.CAEX.CAEXFileType)"]


#### Return Value
Type: [List][3]&lt;[SystemUnitClassType][4]>  
A List with InternalElements is returned.
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [CAEXFileType][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][5] or [Extension Methods (C# Programming Guide)][6].

See Also
--------

#### Reference
[AMLEngineAdapter Class][7]  
[Aml.Engine.Adapter Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXFileType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.collections.generic.list-1
[4]: ../../Aml.Engine.CAEX/SystemUnitClassType/README.md
[5]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[6]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png