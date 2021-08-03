AMLEngineAdapter.Insert_TypeBaseElement Method
==============================================
AutomationML 2.1 API

**Note: This API is now obsolete.**
[Insert(CAEXWrapper, Boolean)][1]

  **Namespace:**  [Aml.Engine.Adapter][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
[ObsoleteAttribute("Use Insert")]
public static bool Insert_TypeBaseElement(
	this CAEXBasicObject caexObject,
	CAEXWrapper elementToInsert,
	bool asFirst = true
)
```

#### Parameters

##### *caexObject*
Type: [Aml.Engine.CAEX.CAEXBasicObject][3]  
The CAEX object.

##### *elementToInsert*
Type: [Aml.Engine.CAEX.CAEXWrapper][4]  
an object to be inserted

##### *asFirst* (Optional)
Type: [System.Boolean][5]  
if `true`, the element is inserted as the first of it's type, otherwise as the last.

#### Return Value
Type: [Boolean][5]  
`true` if successfully inserted, `false` otherwise. 
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [CAEXBasicObject][3]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][6] or [Extension Methods (C# Programming Guide)][7].

See Also
--------

#### Reference
[AMLEngineAdapter Class][8]  
[Aml.Engine.Adapter Namespace][2]  

[1]: ../../Aml.Engine.CAEX/CAEXBasicObject/Insert.md
[2]: ../README.md
[3]: ../../Aml.Engine.CAEX/CAEXBasicObject/README.md
[4]: ../../Aml.Engine.CAEX/CAEXWrapper/README.md
[5]: https://docs.microsoft.com/dotnet/api/system.boolean
[6]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[7]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[8]: README.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png