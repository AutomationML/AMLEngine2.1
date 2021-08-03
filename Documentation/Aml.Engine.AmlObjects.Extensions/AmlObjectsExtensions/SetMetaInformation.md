AmlObjectsExtensions.SetMetaInformation Method (CAEXFileType, MetaInformation)
==============================================================================
AutomationML 2.1 APIThis method is a short version of the setMetaInformation. Meta data with identical WriterID is replaced.

  **Namespace:**  [Aml.Engine.AmlObjects.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static void SetMetaInformation(
	this CAEXFileType caexFile,
	MetaInformation metaInformation
)
```

#### Parameters

##### *caexFile*
Type: [Aml.Engine.CAEX.CAEXFileType][2]  
the CAEXFile

##### *metaInformation*
Type: [Aml.Engine.AmlObjects.MetaInformation][3]  
the structure MetaInformation

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [CAEXFileType][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][4] or [Extension Methods (C# Programming Guide)][5].

Exceptions
----------

Exception                  | Condition 
-------------------------- | --------- 
[ArgumentNullException][6] | caexFile  


Remarks
-------
 Extension Method originally designed for AutomationML Versions based on CAEX 2.15. If this method is applied to a CAEX 3.0 document, the information is transformed to a [SourceDocumentInformationType][7]. 

See Also
--------

#### Reference
[AmlObjectsExtensions Class][8]  
[Aml.Engine.AmlObjects.Extensions Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXFileType/README.md
[3]: ../../Aml.Engine.AmlObjects/MetaInformation/README.md
[4]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[5]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[6]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[7]: ../../Aml.Engine.CAEX/SourceDocumentInformationType/README.md
[8]: README.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png