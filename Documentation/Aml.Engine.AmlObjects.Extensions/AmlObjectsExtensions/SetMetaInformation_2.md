AmlObjectsExtensions.SetMetaInformation Method (SourceDocumentInformationType, MetaInformation)
===============================================================================================
AutomationML 2.1 APISets the properties for the specified SourceDocumentInformation object using the provided MetaInformation

  **Namespace:**  [Aml.Engine.AmlObjects.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static void SetMetaInformation(
	this SourceDocumentInformationType sourceDocumentInformation,
	MetaInformation metaInformation
)
```

#### Parameters

##### *sourceDocumentInformation*
Type: [Aml.Engine.CAEX.SourceDocumentInformationType][2]  
The source document information.

##### *metaInformation*
Type: [Aml.Engine.AmlObjects.MetaInformation][3]  
The meta information.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [SourceDocumentInformationType][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][4] or [Extension Methods (C# Programming Guide)][5].

Exceptions
----------

Exception                  | Condition                                    
-------------------------- | -------------------------------------------- 
[ArgumentNullException][6] | sourceDocumentInformation or metaInformation 


See Also
--------

#### Reference
[AmlObjectsExtensions Class][7]  
[Aml.Engine.AmlObjects.Extensions Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/SourceDocumentInformationType/README.md
[3]: ../../Aml.Engine.AmlObjects/MetaInformation/README.md
[4]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[5]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[6]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png