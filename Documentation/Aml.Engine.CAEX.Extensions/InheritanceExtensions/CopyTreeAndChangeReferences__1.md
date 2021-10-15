InheritanceExtensions.CopyTreeAndChangeReferences&lt;T> Method
==============================================================
Creates a copy of the source class and all its child classes and assigns the provided name to the copy. Including references to objects in the original class tree are redirected to objects in the copied tree. The copy is inserted into the provided parent object.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static T CopyTreeAndChangeReferences<T>(
	this IClassWithBaseClassReference<T> source,
	CAEXObject parent,
	string name
)
where T : CAEXObject

```

#### Parameters

##### *source*
Type: [Aml.Engine.CAEX.IClassWithBaseClassReference][2]&lt;**T**>  
The source class to be copied

##### *parent*
Type: [Aml.Engine.CAEX.CAEXObject][3]  
The parent where the copy is appended

##### *name*
Type: [System.String][4]  
The new name.

#### Type Parameters

##### *T*

[Missing &lt;typeparam name="T"/> documentation for "M:Aml.Engine.CAEX.Extensions.InheritanceExtensions.CopyTreeAndChangeReferences``1(Aml.Engine.CAEX.IClassWithBaseClassReference{``0},Aml.Engine.CAEX.CAEXObject,System.String)"]


#### Return Value
Type: **T**  
If the copy could be appended to the appropriate element collection of the parent, the copied class with all child classes and redirected references; otherwise `null`.
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [IClassWithBaseClassReference][2]&lt;**T**>. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][5] or [Extension Methods (C# Programming Guide)][6].

See Also
--------

#### Reference
[InheritanceExtensions Class][7]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/IClassWithBaseClassReference_1/README.md
[3]: ../../Aml.Engine.CAEX/CAEXObject/README.md
[4]: https://docs.microsoft.com/dotnet/api/system.string
[5]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[6]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png