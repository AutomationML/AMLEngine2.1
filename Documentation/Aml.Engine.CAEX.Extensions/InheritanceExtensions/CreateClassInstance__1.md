InheritanceExtensions.CreateClassInstance&lt;T> Method
======================================================
Creates a class instance of the CAEX class and assigns the name to the instance.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static CAEXBasicObject CreateClassInstance<T>(
	this IInstantiable<T> caexClass,
	string name
)
where T : CAEXObject

```

#### Parameters

##### *caexClass*
Type: [Aml.Engine.CAEX.IInstantiable][2]&lt;**T**>  
The instantiated CAEX class.

##### *name*
Type: [System.String][3]  
The new name.

#### Type Parameters

##### *T*

[Missing &lt;typeparam name="T"/> documentation for "M:Aml.Engine.CAEX.Extensions.InheritanceExtensions.CreateClassInstance``1(Aml.Engine.CAEX.IInstantiable{``0},System.String)"]


#### Return Value
Type: [CAEXBasicObject][4]  

[Missing &lt;returns> documentation for "M:Aml.Engine.CAEX.Extensions.InheritanceExtensions.CreateClassInstance``1(Aml.Engine.CAEX.IInstantiable{``0},System.String)"]

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [IInstantiable][2]&lt;**T**>. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][5] or [Extension Methods (C# Programming Guide)][6].

See Also
--------

#### Reference
[InheritanceExtensions Class][7]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/IInstantiable_1/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: ../../Aml.Engine.CAEX/CAEXBasicObject/README.md
[5]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[6]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png