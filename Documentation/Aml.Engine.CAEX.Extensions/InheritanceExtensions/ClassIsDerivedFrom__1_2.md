InheritanceExtensions.ClassIsDerivedFrom&lt;T> Method (IClassWithBaseClassReference&lt;T>, String)
==================================================================================================
Determines, if the specified class is directly or indirectly (across multiple generations) a descendant of the class or identical to it, which is uniquely identified with the specified baseClass path. The base class path or the referenced class path may contain alias identifiers. If alias identifiers are present, the method tries to load the external referenced document.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static bool? ClassIsDerivedFrom<T>(
	this IClassWithBaseClassReference<T> classWithReference,
	string baseClassPath
)
where T : CAEXObject

```

#### Parameters

##### *classWithReference*
Type: [Aml.Engine.CAEX.IClassWithBaseClassReference][2]&lt;**T**>  
The class with reference.

##### *baseClassPath*
Type: [System.String][3]  
The base class path.

#### Type Parameters

##### *T*
The type of the CAEX class.

#### Return Value
Type: [Nullable][4]&lt;[Boolean][5]>  
`true` if the class is derived, `false` if it is not. If no value is returned, some references could not be resolved to get the answer. 
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [IClassWithBaseClassReference][2]&lt;**T**>. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][6] or [Extension Methods (C# Programming Guide)][7].

See Also
--------

#### Reference
[InheritanceExtensions Class][8]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/IClassWithBaseClassReference_1/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: https://docs.microsoft.com/dotnet/api/system.nullable-1
[5]: https://docs.microsoft.com/dotnet/api/system.boolean
[6]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[7]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[8]: README.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png