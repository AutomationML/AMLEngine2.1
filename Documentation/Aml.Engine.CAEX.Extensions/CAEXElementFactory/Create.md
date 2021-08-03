CAEXElementFactory.Create Method (CAEXDocument, String)
=======================================================
AutomationML 2.1 APIFactory method to create a new CAEX object in the provided CAEX document. The CAEX element is derived from the specified CAEX object Type. To insert the new CAEX object into the document an appropriate insertion method has to be used.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static CAEXWrapper Create(
	this CAEXDocument document,
	string caexTagName
)
```

#### Parameters

##### *document*
Type: [Aml.Engine.CAEX.CAEXDocument][2]  
The CAEX document.

##### *caexTagName*
Type: [System.String][3]  
Name of the CAEX tag.

#### Return Value
Type: [CAEXWrapper][4]  
 The created CAEX object. 
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [CAEXDocument][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][5] or [Extension Methods (C# Programming Guide)][6].

Exceptions
----------

Exception                  | Condition 
-------------------------- | --------- 
[NotSupportedException][7] |           
[ArgumentNullException][8] | document  


See Also
--------

#### Reference
[CAEXElementFactory Class][9]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXDocument/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: ../../Aml.Engine.CAEX/CAEXWrapper/README.md
[5]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[6]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[7]: https://docs.microsoft.com/dotnet/api/system.notsupportedexception
[8]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[9]: README.md
[10]: https://www.automationml.org
[11]: ../../icons/logoShade.png