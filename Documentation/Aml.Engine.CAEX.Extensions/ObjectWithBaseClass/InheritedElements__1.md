ObjectWithBaseClass.InheritedElements&lt;TInheritedElement> Method
==================================================================
Gets a collection of objects of the defined InheritedElement-Type that are inherited from base classes.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static IEnumerable<TInheritedElement> InheritedElements<TInheritedElement>(
	this IClassWithBaseClassReference classWithBaseClass,
	bool includeSelf = true
)
where TInheritedElement : CAEXBasicObject

```

#### Parameters

##### *classWithBaseClass*
Type: [Aml.Engine.CAEX.IClassWithBaseClassReference][2]  
the base class containing the element

##### *includeSelf* (Optional)
Type: [System.Boolean][3]  
if set to `true` the own elements are included.

#### Type Parameters

##### *TInheritedElement*
The type of the inherited element.

#### Return Value
Type: [IEnumerable][4]&lt;**TInheritedElement**>  
An enumeration of all inherited elements.
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [IClassWithBaseClassReference][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][5] or [Extension Methods (C# Programming Guide)][6].

See Also
--------

#### Reference
[ObjectWithBaseClass Class][7]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/IClassWithBaseClassReference/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[5]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[6]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png