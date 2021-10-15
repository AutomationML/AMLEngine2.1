InheritanceExtensions.ChangeNameAndReferences&lt;T> Method
==========================================================
Changes the name of the CAEX class and all the references to the class in the whole CAEX document.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static void ChangeNameAndReferences<T>(
	this IClassWithBaseClassReference<T> caexClass,
	string name
)
where T : CAEXObject

```

#### Parameters

##### *caexClass*
Type: [Aml.Engine.CAEX.IClassWithBaseClassReference][2]&lt;**T**>  
The CAEX class which name is changed.

##### *name*
Type: [System.String][3]  
The new name.

#### Type Parameters

##### *T*

[Missing &lt;typeparam name="T"/> documentation for "M:Aml.Engine.CAEX.Extensions.InheritanceExtensions.ChangeNameAndReferences``1(Aml.Engine.CAEX.IClassWithBaseClassReference{``0},System.String)"]


#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [IClassWithBaseClassReference][2]&lt;**T**>. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][4] or [Extension Methods (C# Programming Guide)][5].

See Also
--------

#### Reference
[InheritanceExtensions Class][6]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/IClassWithBaseClassReference_1/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[5]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png