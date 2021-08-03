AMLEngineAdapter.GetParent Method
=================================


**Note: This API is now obsolete.**
This method returns the parent CAEXBasicObject of the current CAEXBasicObject.

  **Namespace:**  [Aml.Engine.Adapter][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
[ObsoleteAttribute("Use the CAEXParent Property, which is defined for all CAEX objects.")]
public static CAEXBasicObject GetParent(
	this CAEXFileType caexFile,
	CAEXBasicObject obj
)
```

#### Parameters

##### *caexFile*
Type: [Aml.Engine.CAEX.CAEXFileType][2]  
The CAEX file.

##### *obj*
Type: [Aml.Engine.CAEX.CAEXBasicObject][3]  
the CAEX Basic Object

#### Return Value
Type: [CAEXBasicObject][3]  
 the parent CAEXBasicObject 
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [CAEXFileType][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][4] or [Extension Methods (C# Programming Guide)][5].

See Also
--------

#### Reference
[AMLEngineAdapter Class][6]  
[Aml.Engine.Adapter Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXFileType/README.md
[3]: ../../Aml.Engine.CAEX/CAEXBasicObject/README.md
[4]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[5]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png