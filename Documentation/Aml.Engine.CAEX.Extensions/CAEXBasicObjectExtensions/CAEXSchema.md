CAEXBasicObjectExtensions.CAEXSchema Method
===========================================
AutomationML 2.1 APIGets the associated CAEX schema of the CAEX object.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static CAEXDocument.CAEXSchema CAEXSchema(
	this ICAEXWrapper caexObject
)
```

#### Parameters

##### *caexObject*
Type: [Aml.Engine.CAEX.ICAEXWrapper][2]  
The CAEX object.

#### Return Value
Type: [CAEXDocument.CAEXSchema][3]  
 The Schema associated to the CAEX object. 
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
[3]: ../../Aml.Engine.CAEX/CAEXDocument_CAEXSchema/README.md
[4]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[5]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[6]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png