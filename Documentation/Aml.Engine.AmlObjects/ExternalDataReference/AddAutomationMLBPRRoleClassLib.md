ExternalDataReference.AddAutomationMLBPRRoleClassLib Method
===========================================================
Adds the AutomationMLBPRRoleClassLib containing all role classes used to model external document references to the AMLDocument.

  **Namespace:**  [Aml.Engine.AmlObjects][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static void AddAutomationMLBPRRoleClassLib(
	this CAEXFileType caexFile
)
```

#### Parameters

##### *caexFile*
Type: [Aml.Engine.CAEX.CAEXFileType][2]  
The CAEX file of the AMLDocument.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [CAEXFileType][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][3] or [Extension Methods (C# Programming Guide)][4].

Exceptions
----------

Exception                       | Condition                                                                                                                             
------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------- 
[ArgumentNullException][5]      | caexFile                                                                                                                              
[SchemaConformanceException][6] | Different CAEX Version used; register the SchemaTransform service to import the AutomationMLBPRRoleClassLib in your current document. 


See Also
--------

#### Reference
[ExternalDataReference Class][7]  
[Aml.Engine.AmlObjects Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXFileType/README.md
[3]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[4]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[5]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[6]: ../../Aml.Engine.CAEX/SchemaConformanceException/README.md
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png