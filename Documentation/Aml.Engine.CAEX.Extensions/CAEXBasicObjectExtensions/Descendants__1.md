CAEXBasicObjectExtensions.Descendants&lt;T> Method (CAEXWrapper)
================================================================
AutomationML 2.1 APIFinds the descendants of the provided CAEX object which are of the given type.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static IEnumerable<T> Descendants<T>(
	this CAEXWrapper caexObject
)
where T : CAEXWrapper

```

#### Parameters

##### *caexObject*
Type: [Aml.Engine.CAEX.CAEXWrapper][2]  
The CAEX object.

#### Type Parameters

##### *T*
CAEX element type of the descendants.

#### Return Value
Type: [IEnumerable][3]&lt;**T**>  
 The descendants of the CAEX object which are of the given type. 
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [CAEXWrapper][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][4] or [Extension Methods (C# Programming Guide)][5].

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
[2]: ../../Aml.Engine.CAEX/CAEXWrapper/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[4]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[5]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[6]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png