InheritanceExtensions.ClassIsDerivedFrom&lt;T> Method (IClassWithBaseClassReference&lt;T>, IClassWithBaseClassReference&lt;T>)
==============================================================================================================================
AutomationML 2.1 APIDetermines, if the specified class is directly or indirectly (across multiple generations) a descendant of the specified base class or identical to it. This method can be used, if the classes are distributed over different CAEX documents, the documents should be referenced by external references and alias references.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static bool? ClassIsDerivedFrom<T>(
	this IClassWithBaseClassReference<T> classWithReference,
	IClassWithBaseClassReference<T> baseClass
)
where T : CAEXObject

```

#### Parameters

##### *classWithReference*
Type: [Aml.Engine.CAEX.IClassWithBaseClassReference][2]&lt;**T**>  
The class with reference.

##### *baseClass*
Type: [Aml.Engine.CAEX.IClassWithBaseClassReference][2]&lt;**T**>  
The base class.

#### Type Parameters

##### *T*
The type of the CAEX class.

#### Return Value
Type: [Nullable][3]&lt;[Boolean][4]>  
`true` if the class is derived, `false` if it is not. If no value is returned, some references could not be resolved to get the answer. 
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [IClassWithBaseClassReference][2]&lt;**T**>. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][5] or [Extension Methods (C# Programming Guide)][6].

See Also
--------

#### Reference
[InheritanceExtensions Class][7]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/IClassWithBaseClassReference_1/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.nullable-1
[4]: https://docs.microsoft.com/dotnet/api/system.boolean
[5]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[6]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png