CAEXBasicObjectExtensions.Ancestors&lt;T> Method
================================================
Finds the ancestors of the provided CAEX object which have the given type.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static IEnumerable<T> Ancestors<T>(
	this ICAEXWrapper caexObject,
	bool includeSelf = false
)
where T : CAEXWrapper

```

#### Parameters

##### *caexObject*
Type: [Aml.Engine.CAEX.ICAEXWrapper][2]  
The CAEX object.

##### *includeSelf* (Optional)
Type: [System.Boolean][3]  

[Missing &lt;param name="includeSelf"/> documentation for "M:Aml.Engine.CAEX.Extensions.CAEXBasicObjectExtensions.Ancestors``1(Aml.Engine.CAEX.ICAEXWrapper,System.Boolean)"]


#### Type Parameters

##### *T*
CAEX element type of the ancestors.

#### Return Value
Type: [IEnumerable][4]&lt;**T**>  
 The ancestors of the CAEX object which are of the given type. 
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [ICAEXWrapper][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][5] or [Extension Methods (C# Programming Guide)][6].

Exceptions
----------

Exception                  | Condition  
-------------------------- | ---------- 
[ArgumentNullException][7] | caexObject 


See Also
--------

#### Reference
[CAEXBasicObjectExtensions Class][8]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/ICAEXWrapper/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[5]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[6]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[7]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[8]: README.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png