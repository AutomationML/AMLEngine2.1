ExternalDataReference.DocumentElements Method
=============================================
Gets all Internal Element Children from the specified internal element which are document elements.

  **Namespace:**  [Aml.Engine.AmlObjects][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static IEnumerable<InternalElementType> DocumentElements(
	this SystemUnitClassType internalElement
)
```

#### Parameters

##### *internalElement*
Type: [Aml.Engine.CAEX.SystemUnitClassType][2]  
The internal element.

#### Return Value
Type: [IEnumerable][3]&lt;[InternalElementType][4]>  
 Enumeration of InternalElement objects, which are document elements. 
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [SystemUnitClassType][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][5] or [Extension Methods (C# Programming Guide)][6].

Exceptions
----------

Exception                  | Condition       
-------------------------- | --------------- 
[ArgumentNullException][7] | internalElement 


See Also
--------

#### Reference
[ExternalDataReference Class][8]  
[Aml.Engine.AmlObjects Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/SystemUnitClassType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[4]: ../../Aml.Engine.CAEX/InternalElementType/README.md
[5]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[6]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[7]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[8]: README.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png