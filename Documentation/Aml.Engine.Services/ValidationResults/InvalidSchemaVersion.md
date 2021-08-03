ValidationResults.InvalidSchemaVersion Method
=============================================
Gets the validation results for all MetaData which are related to the CAEX Schema Version

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine.Services (in AML.Engine.Services.dll)

Syntax
------

```csharp
public static IEnumerable<ValidationElement> InvalidSchemaVersion(
	this IEnumerable<ValidationElement> validationResult
)
```

#### Parameters

##### *validationResult*
Type: [System.Collections.Generic.IEnumerable][2]&lt;[ValidationElement][3]>  
 The validation result. Use the [MetaDataValidationResults(IEnumerable&lt;ValidationElement>)][4] as a parameter for this method.

#### Return Value
Type: [IEnumerable][2]&lt;[ValidationElement][3]>  
All validation results, which are related to MetaData which are related to the CAEX Schema Version.
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [IEnumerable][2]&lt;[ValidationElement][3]>. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][5] or [Extension Methods (C# Programming Guide)][6].

See Also
--------

#### Reference
[ValidationResults Class][7]  
[Aml.Engine.Services Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[3]: ../ValidationElement/README.md
[4]: MetaDataValidationResults.md
[5]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[6]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png