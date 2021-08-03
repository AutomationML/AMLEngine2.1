AMLEngineAdapter.ConsistencyCheck_ClassReference Method
=======================================================
AutomationML 2.1 API

**Note: This API is now obsolete.**
Check if the given classPath is a valid path to an existent class in the AML file.

  **Namespace:**  [Aml.Engine.Adapter][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
[ObsoleteAttribute("Use FindByPath and check if not null")]
public static bool ConsistencyCheck_ClassReference(
	this CAEXBasicObject caexObject,
	string classPath
)
```

#### Parameters

##### *caexObject*
Type: [Aml.Engine.CAEX.CAEXBasicObject][2]  
The CAEX object.

##### *classPath*
Type: [System.String][3]  
The class path to check for validity.

#### Return Value
Type: [Boolean][4]  
 True if a class at the given path exists, else false. 
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [CAEXBasicObject][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][5] or [Extension Methods (C# Programming Guide)][6].

See Also
--------

#### Reference
[AMLEngineAdapter Class][7]  
[Aml.Engine.Adapter Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXBasicObject/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: https://docs.microsoft.com/dotnet/api/system.boolean
[5]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[6]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png