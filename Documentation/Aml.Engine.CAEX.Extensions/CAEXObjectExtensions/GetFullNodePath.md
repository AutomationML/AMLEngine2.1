CAEXObjectExtensions.GetFullNodePath Method
===========================================
Gets the full node path of the provided CAEX object, which includes the object names of all ancestor hierarchy levels and the name of the object itself.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static string GetFullNodePath(
	this ICAEXObject caexObject
)
```

#### Parameters

##### *caexObject*
Type: [Aml.Engine.CAEX.ICAEXObject][2]  
The CAEX object.

#### Return Value
Type: [String][3]  
The path to the XML node.
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [ICAEXObject][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][4] or [Extension Methods (C# Programming Guide)][5].

Remarks
-------
 Please note that this method returns a different result than the [CAEXPath()][6] method, which returns the CAEX path used for referencing objects. 

See Also
--------

#### Reference
[CAEXObjectExtensions Class][7]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/ICAEXObject/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[5]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[6]: ../../Aml.Engine.CAEX/CAEXObject/CAEXPath.md
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png