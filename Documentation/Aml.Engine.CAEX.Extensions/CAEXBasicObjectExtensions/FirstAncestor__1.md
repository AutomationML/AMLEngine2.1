CAEXBasicObjectExtensions.FirstAncestor&lt;T> Method (ICAEXWrapper)
===================================================================
AutomationML 2.1 APIFinds the first ancestor of the specified CAEX object in the given Type.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static T FirstAncestor<T>(
	this ICAEXWrapper caexObject
)
where T : CAEXWrapper

```

#### Parameters

##### *caexObject*
Type: [Aml.Engine.CAEX.ICAEXWrapper][2]  
The CAEX object.

#### Type Parameters

##### *T*
CAEX element type of the ancestor.

#### Return Value
Type: **T**  
 First ancestor of the specified CAEX object or `null`, if no ancestor with this Type exists. 
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