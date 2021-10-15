AMLEngineAdapter.AssignNewGUIDs Method
======================================


**Note: This API is now obsolete.**
Assigns new GUIDs to this InternalElement and all of its child InternalElements

  **Namespace:**  [Aml.Engine.Adapter][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
[ObsoleteAttribute("It is not recommended to use this method anymore, because ID references are not updated, which can led to an invalid document.", 
	false)]
public static void AssignNewGUIDs(
	this InternalElementType element
)
```

#### Parameters

##### *element*
Type: [Aml.Engine.CAEX.InternalElementType][2]  

[Missing &lt;param name="element"/> documentation for "M:Aml.Engine.Adapter.AMLEngineAdapter.AssignNewGUIDs(Aml.Engine.CAEX.InternalElementType)"]


#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [InternalElementType][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][3] or [Extension Methods (C# Programming Guide)][4].

See Also
--------

#### Reference
[AMLEngineAdapter Class][5]  
[Aml.Engine.Adapter Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/InternalElementType/README.md
[3]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[4]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png