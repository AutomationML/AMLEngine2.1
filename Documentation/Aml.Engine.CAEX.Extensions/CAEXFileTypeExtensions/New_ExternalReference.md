CAEXFileTypeExtensions.New_ExternalReference Method
===================================================
AutomationML 2.1 APIA new ExternalReference node is added to the CAEX file.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static ExternalReferenceType New_ExternalReference(
	this CAEXFileType caexFile,
	string path,
	string alias
)
```

#### Parameters

##### *caexFile*
Type: [Aml.Engine.CAEX.CAEXFileType][2]  
 the CAEX file.

##### *path*
Type: [System.String][3]  
 The path value of this external reference.

##### *alias*
Type: [System.String][3]  
The alias value of this external reference.

#### Return Value
Type: [ExternalReferenceType][4]  
A new ExternalReference
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [CAEXFileType][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][5] or [Extension Methods (C# Programming Guide)][6].

See Also
--------

#### Reference
[CAEXFileTypeExtensions Class][7]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXFileType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: ../../Aml.Engine.CAEX/ExternalReferenceType/README.md
[5]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[6]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png