SystemUnitClassTypeExtensions.New_InternalElement Method
========================================================
AutomationML 2.1 APIAdding a new InternalElement instance to the InternalElement-Collection of the *elementWithInternalElements*. The New InternalElement is inserted as the first InternalElement of any existing InternalElement objects if nothing else is explicit defined.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static InternalElementType New_InternalElement(
	this IInternalElementContainer elementWithInternalElements,
	string elementName,
	bool asFirst = true
)
```

#### Parameters

##### *elementWithInternalElements*
Type: [Aml.Engine.CAEX.IInternalElementContainer][2]  
Any object with an InternalElement collection.

##### *elementName*
Type: [System.String][3]  
Name of the InternalElement

##### *asFirst* (Optional)
Type: [System.Boolean][4]  
If set to true, the InternalElement is insert at first, otherwise at last.

#### Return Value
Type: [InternalElementType][5]  
The new InternalElement
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [IInternalElementContainer][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][6] or [Extension Methods (C# Programming Guide)][7].

See Also
--------

#### Reference
[SystemUnitClassTypeExtensions Class][8]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/IInternalElementContainer/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: https://docs.microsoft.com/dotnet/api/system.boolean
[5]: ../../Aml.Engine.CAEX/InternalElementType/README.md
[6]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[7]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[8]: README.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png