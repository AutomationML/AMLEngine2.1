SystemUnitClassTypeExtensions.Insert_InternalElement Method
===========================================================


**Note: This API is now obsolete.**
Inserting an InternalElement to the InternalElement-Collection of the *objectWithInternalElements*.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
[ObsoleteAttribute("Use systemUnitClass.InternalElement.Insert() or systemUnitClass.Insert() instead")]
public static void Insert_InternalElement(
	this IInternalElementContainer objectWithInternalElements,
	InternalElementType internalElement,
	bool asFirst = true
)
```

#### Parameters

##### *objectWithInternalElements*
Type: [Aml.Engine.CAEX.IInternalElementContainer][2]  
Any object with an InternalElement collection.

##### *internalElement*
Type: [Aml.Engine.CAEX.InternalElementType][3]  
The InternalElement to insert.

##### *asFirst* (Optional)
Type: [System.Boolean][4]  
Insert as first if set to true (default), otherwise append as last

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [IInternalElementContainer][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][5] or [Extension Methods (C# Programming Guide)][6].

Remarks
-------


See Also
--------

#### Reference
[SystemUnitClassTypeExtensions Class][7]  
[Aml.Engine.CAEX.Extensions Namespace][1]  
[CAEXSequence&lt;T>.Insert(T, Boolean)][8]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/IInternalElementContainer/README.md
[3]: ../../Aml.Engine.CAEX/InternalElementType/README.md
[4]: https://docs.microsoft.com/dotnet/api/system.boolean
[5]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[6]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[7]: README.md
[8]: ../../Aml.Engine.CAEX/CAEXSequence_1/Insert.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png