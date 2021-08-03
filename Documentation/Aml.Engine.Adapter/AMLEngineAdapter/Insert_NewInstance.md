AMLEngineAdapter.Insert_NewInstance Method
==========================================
AutomationML 2.1 API

**Note: This API is now obsolete.**
Inserting a new class instance to this object. This method can be overridden in derived classes. The Instance is inserted as the first instance of any other element with the same type if nothing else is explicit defined.

  **Namespace:**  [Aml.Engine.Adapter][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
[ObsoleteAttribute("Use Insert Method instead", false)]
public static bool Insert_NewInstance(
	this CAEXBasicObject caexObject,
	CAEXWrapper newInstanceObject,
	bool asFirst = true
)
```

#### Parameters

##### *caexObject*
Type: [Aml.Engine.CAEX.CAEXBasicObject][2]  
The CAEX object.

##### *newInstanceObject*
Type: [Aml.Engine.CAEX.CAEXWrapper][3]  
The instance of a class to be inserted at this object. The instance can be of type

##### *asFirst* (Optional)
Type: [System.Boolean][4]  
if `true`, inserted as first (default), otherwise at last

#### Return Value
Type: [Boolean][4]  
 True if insertion was successful, else false. 
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [CAEXBasicObject][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][5] or [Extension Methods (C# Programming Guide)][6].

See Also
--------

#### Reference
[AMLEngineAdapter Class][7]  
[Aml.Engine.Adapter Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXBasicObject/README.md
[3]: ../../Aml.Engine.CAEX/CAEXWrapper/README.md
[4]: https://docs.microsoft.com/dotnet/api/system.boolean
[5]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[6]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png