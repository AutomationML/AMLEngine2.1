ExternalDataReference.AddLanguage Method
========================================
AutomationML 2.1 APIAdds a language attribute to the internal element. If this is the first language attribute, a simple attribute is added. If this is not the first, a language attribute list is used. A former created simple attribute is transferred to a list item.

  **Namespace:**  [Aml.Engine.AmlObjects][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static void AddLanguage(
	this InternalElementType internalElement,
	string language
)
```

#### Parameters

##### *internalElement*
Type: [Aml.Engine.CAEX.InternalElementType][2]  
The internal element.

##### *language*
Type: [System.String][3]  
The language specification.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [InternalElementType][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][4] or [Extension Methods (C# Programming Guide)][5].

Exceptions
----------

Exception                  | Condition       
-------------------------- | --------------- 
[ArgumentNullException][6] | internalElement 


See Also
--------

#### Reference
[ExternalDataReference Class][7]  
[Aml.Engine.AmlObjects Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/InternalElementType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[5]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[6]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png