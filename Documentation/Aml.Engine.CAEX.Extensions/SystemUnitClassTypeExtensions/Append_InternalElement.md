SystemUnitClassTypeExtensions.Append_InternalElement Method
===========================================================


**Note: This API is now obsolete.**
Inserts the InternalElement object after the defined Predecessor in the InternalElement collection of the SystemUnitClass. If the Predecessor is null, the InternalElement object is inserted at the first position of the InternalElement collection.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
[ObsoleteAttribute("Use internalElementPredecessor.InsertAfter()")]
public static void Append_InternalElement(
	this SystemUnitClassType systemUnitClass,
	InternalElementType internalElement,
	InternalElementType internalElementPredecessor
)
```

#### Parameters

##### *systemUnitClass*
Type: [Aml.Engine.CAEX.SystemUnitClassType][2]  
The SystemUnitClass object

##### *internalElement*
Type: [Aml.Engine.CAEX.InternalElementType][3]  
The internal element.

##### *internalElementPredecessor*
Type: [Aml.Engine.CAEX.InternalElementType][3]  
The internal element predecessor.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [SystemUnitClassType][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][4] or [Extension Methods (C# Programming Guide)][5].

See Also
--------

#### Reference
[SystemUnitClassTypeExtensions Class][6]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/SystemUnitClassType/README.md
[3]: ../../Aml.Engine.CAEX/InternalElementType/README.md
[4]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[5]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png