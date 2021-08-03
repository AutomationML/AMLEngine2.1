AmlObjectsExtensions.ClearMetaInformation Method
================================================
AutomationML 2.1 APIRemoves all "Writer Header" specific meta information out of this CAEX file.

  **Namespace:**  [Aml.Engine.AmlObjects.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static void ClearMetaInformation(
	this CAEXFileType caexFile
)
```

#### Parameters

##### *caexFile*
Type: [Aml.Engine.CAEX.CAEXFileType][2]  
the CAEXFile

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [CAEXFileType][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][3] or [Extension Methods (C# Programming Guide)][4].

Exceptions
----------

Exception                  | Condition 
-------------------------- | --------- 
[ArgumentNullException][5] | caexFile  


Remarks
-------
 Extension Method originally designed for AutomationML Versions based on CAEX 2.15. If this method is applied to a CAEX 3.0 document, the information is transformed to a [SourceDocumentInformationType][6]. 

See Also
--------

#### Reference
[AmlObjectsExtensions Class][7]  
[Aml.Engine.AmlObjects.Extensions Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXFileType/README.md
[3]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[4]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[5]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[6]: ../../Aml.Engine.CAEX/SourceDocumentInformationType/README.md
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png