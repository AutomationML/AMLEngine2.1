ValidationResults.NameReferenceValidationResults Method
=======================================================
AutomationML 2.1 APIGets the Name reference validation results from the validation result list.

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine.Services (in AML.Engine.Services.dll)

Syntax
------

```csharp
public static IEnumerable<ValidationElement> NameReferenceValidationResults(
	this IEnumerable<ValidationElement> validationResult
)
```

#### Parameters

##### *validationResult*
Type: [System.Collections.Generic.IEnumerable][2]&lt;[ValidationElement][3]>  
The validation result.

#### Return Value
Type: [IEnumerable][2]&lt;[ValidationElement][3]>  
 All validation results, which are related to CAEX objects which use a Name to reference other CAEX objects. 
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [IEnumerable][2]&lt;[ValidationElement][3]>. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][4] or [Extension Methods (C# Programming Guide)][5].

Remarks
-------
 Currently only name references from mapping objects are validated 

See Also
--------

#### Reference
[ValidationResults Class][6]  
[Aml.Engine.Services Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[3]: ../ValidationElement/README.md
[4]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[5]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png