CAEXFileTypeExtensions.PreorderTraversal Method
===============================================
AutomationML 2.1 APITraversal method for a hierarchical tree, with identical childSelector for all tree nodes. The method uses a pre-order algorithm without recursion for the deep traversal of the complete tree.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static IEnumerable PreorderTraversal(
	this CAEXFileType caexFile,
	IEnumerator source,
	Func<Object, IEnumerator> childSelector
)
```

#### Parameters

##### *caexFile*
Type: [Aml.Engine.CAEX.CAEXFileType][2]  
 the CAEXFile

##### *source*
Type: [System.Collections.IEnumerator][3]  
 The source.

##### *childSelector*
Type: [System.Func][4]&lt;[Object][5], [IEnumerator][3]>  
The child selector.

#### Return Value
Type: [IEnumerable][6]  
IEnumerable.
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [CAEXFileType][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][7] or [Extension Methods (C# Programming Guide)][8].

See Also
--------

#### Reference
[CAEXFileTypeExtensions Class][9]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXFileType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.collections.ienumerator
[4]: https://docs.microsoft.com/dotnet/api/system.func-2
[5]: https://docs.microsoft.com/dotnet/api/system.object
[6]: https://docs.microsoft.com/dotnet/api/system.collections.ienumerable
[7]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[8]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[9]: README.md
[10]: https://www.automationml.org
[11]: ../../icons/logoShade.png