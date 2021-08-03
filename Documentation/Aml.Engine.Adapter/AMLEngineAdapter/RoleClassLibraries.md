AMLEngineAdapter.RoleClassLibraries Method
==========================================
AutomationML 2.1 API

**Note: This API is now obsolete.**
Enumeration Method for all RoleClass Libraries of the CAEXFile.

  **Namespace:**  [Aml.Engine.Adapter][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
[ObsoleteAttribute("Use RoleClassLib Property instead.")]
public static IEnumerable<RoleClassLibType> RoleClassLibraries(
	this CAEXFileType caexFile
)
```

#### Parameters

##### *caexFile*
Type: [Aml.Engine.CAEX.CAEXFileType][2]  

[Missing &lt;param name="caexFile"/> documentation for "M:Aml.Engine.Adapter.AMLEngineAdapter.RoleClassLibraries(Aml.Engine.CAEX.CAEXFileType)"]


#### Return Value
Type: [IEnumerable][3]&lt;[RoleClassLibType][4]>  
IEnumerable&lt;RoleClassLibType>.
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [CAEXFileType][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][5] or [Extension Methods (C# Programming Guide)][6].

See Also
--------

#### Reference
[AMLEngineAdapter Class][7]  
[Aml.Engine.Adapter Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXFileType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[4]: ../../Aml.Engine.CAEX/RoleClassLibType/README.md
[5]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[6]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png