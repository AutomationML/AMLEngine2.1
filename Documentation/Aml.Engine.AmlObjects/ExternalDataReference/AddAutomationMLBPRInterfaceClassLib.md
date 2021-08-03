ExternalDataReference.AddAutomationMLBPRInterfaceClassLib Method
================================================================
Adds the AutomationMLBPRInterfaceClassLib containing all interface classes used to model external document references to the AMLDocument.

  **Namespace:**  [Aml.Engine.AmlObjects][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static void AddAutomationMLBPRInterfaceClassLib(
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
------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------- 
[SchemaConformanceException][5] | Different CAEX Versions used; register the SchemaTransform service to import the AutomationMLBPRInterfaceClassLib in your current document. 


See Also
--------

#### Reference
[ExternalDataReference Class][6]  
[Aml.Engine.AmlObjects Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXFileType/README.md
[3]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[4]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[5]: ../../Aml.Engine.CAEX/SchemaConformanceException/README.md
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png