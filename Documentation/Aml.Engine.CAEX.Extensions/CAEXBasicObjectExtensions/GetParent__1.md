CAEXBasicObjectExtensions.GetParent&lt;T> Method
================================================
AutomationML 2.1 APITries to get a CAEX parent with the specified Type of the provided caexObject. If the parent is not assignable to the provided type, the result is `null`.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static T GetParent<T>(
	this ICAEXWrapper caexObject
)
where T : class, ICAEXWrapper

```

#### Parameters

##### *caexObject*
Type: [Aml.Engine.CAEX.ICAEXWrapper][2]  
The CAEX object.

#### Type Parameters

##### *T*
The expected type of the parent.

#### Return Value
Type: **T**  
 The parent with the specified Type or `null`. 
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [ICAEXWrapper][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][3] or [Extension Methods (C# Programming Guide)][4].

Exceptions
----------

Exception                  | Condition  
-------------------------- | ---------- 
[ArgumentNullException][5] | caexObject 


See Also
--------

#### Reference
[CAEXBasicObjectExtensions Class][6]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/ICAEXWrapper/README.md
[3]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[4]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[5]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png