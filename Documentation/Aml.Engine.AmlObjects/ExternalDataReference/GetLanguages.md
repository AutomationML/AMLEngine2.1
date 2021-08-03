ExternalDataReference.GetLanguages Method
=========================================
AutomationML 2.1 APIGets the languages, defined for the document element. If the given internal element is not a document element, the collection is empty.

  **Namespace:**  [Aml.Engine.AmlObjects][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static IEnumerable<string> GetLanguages(
	this InternalElementType documentElement
)
```

#### Parameters

##### *documentElement*
Type: [Aml.Engine.CAEX.InternalElementType][2]  
The document element.

#### Return Value
Type: [IEnumerable][3]&lt;[String][4]>  
 IEnumerable&lt;System.String>. 
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [InternalElementType][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][5] or [Extension Methods (C# Programming Guide)][6].

Exceptions
----------

Exception                  | Condition       
-------------------------- | --------------- 
[ArgumentNullException][7] | documentElement 


See Also
--------

#### Reference
[ExternalDataReference Class][8]  
[Aml.Engine.AmlObjects Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/InternalElementType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[4]: https://docs.microsoft.com/dotnet/api/system.string
[5]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[6]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[7]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[8]: README.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png