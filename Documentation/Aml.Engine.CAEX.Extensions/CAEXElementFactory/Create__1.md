CAEXElementFactory.Create&lt;T> Method (CAEXDocument)
=====================================================
AutomationML 2.1 APIFactory method to create a new CAEX object in the provided CAEX document. The CAEX element is derived from the specified CAEX object Type. To insert the new CAEX object into the document an appropriate insertion method has to be used.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static T Create<T>(
	this CAEXDocument document
)
where T : CAEXWrapper

```

#### Parameters

##### *document*
Type: [Aml.Engine.CAEX.CAEXDocument][2]  
The CAEX document.

#### Type Parameters

##### *T*
The CAEX object Type.

#### Return Value
Type: **T**  
The created CAEX object.
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [CAEXDocument][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][3] or [Extension Methods (C# Programming Guide)][4].

Exceptions
----------

Exception                  | Condition 
-------------------------- | --------- 
[NotSupportedException][5] |           
[ArgumentNullException][6] | document  


See Also
--------

#### Reference
[CAEXElementFactory Class][7]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXDocument/README.md
[3]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[4]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[5]: https://docs.microsoft.com/dotnet/api/system.notsupportedexception
[6]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png