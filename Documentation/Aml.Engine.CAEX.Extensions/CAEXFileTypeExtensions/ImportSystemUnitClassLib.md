CAEXFileTypeExtensions.ImportSystemUnitClassLib Method
======================================================
Imports the provided library into the SystemUnitClassLib collection of this CAEX file.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static SystemUnitClassLibType ImportSystemUnitClassLib(
	this CAEXFileType caexFile,
	SystemUnitClassLibType systemUnitClassLib
)
```

#### Parameters

##### *caexFile*
Type: [Aml.Engine.CAEX.CAEXFileType][2]  
 the CAEX file

##### *systemUnitClassLib*
Type: [Aml.Engine.CAEX.SystemUnitClassLibType][3]  
The source SystemUnitClassLib.

#### Return Value
Type: [SystemUnitClassLibType][3]  
The imported SystemUnitClassLib.
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [CAEXFileType][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][4] or [Extension Methods (C# Programming Guide)][5].

See Also
--------

#### Reference
[CAEXFileTypeExtensions Class][6]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXFileType/README.md
[3]: ../../Aml.Engine.CAEX/SystemUnitClassLibType/README.md
[4]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[5]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png