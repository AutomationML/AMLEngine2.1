CAEXBasicObjectExtensions.FindCaexObjectFromId&lt;T> Method
===========================================================
Finds the CAEX object with the specified id and the specified Type.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static T FindCaexObjectFromId<T>(
	this ICAEXWrapper caexObject,
	string id
)
where T : CAEXBasicObject

```

#### Parameters

##### *caexObject*
Type: [Aml.Engine.CAEX.ICAEXWrapper][2]  
CAEX object, used to identify the document for the search.

##### *id*
Type: [System.String][3]  
Id of the CAEX object.

#### Type Parameters

##### *T*
CAEX element type of the searched CAEX object.

#### Return Value
Type: **T**  
 CAEX object with the given id or `null`, if not found. 
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [ICAEXWrapper][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][4] or [Extension Methods (C# Programming Guide)][5].

Exceptions
----------

Exception                  | Condition  
-------------------------- | ---------- 
[ArgumentNullException][6] | caexObject 


See Also
--------

#### Reference
[CAEXBasicObjectExtensions Class][7]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/ICAEXWrapper/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[5]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[6]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png