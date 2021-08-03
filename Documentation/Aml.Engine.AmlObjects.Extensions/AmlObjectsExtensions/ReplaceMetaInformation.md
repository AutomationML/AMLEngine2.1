AmlObjectsExtensions.ReplaceMetaInformation Method
==================================================
AutomationML 2.1 APIThis function replaces any existing meta information corresponding to the identical oldWriterID with the new meta information defined in the newMetainformation

  **Namespace:**  [Aml.Engine.AmlObjects.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static bool ReplaceMetaInformation(
	this CAEXFileType caexFile,
	string oldWriterID,
	MetaInformation newMetainformation
)
```

#### Parameters

##### *caexFile*
Type: [Aml.Engine.CAEX.CAEXFileType][2]  
My CAEX file.

##### *oldWriterID*
Type: [System.String][3]  
writerID of the old meta information

##### *newMetainformation*
Type: [Aml.Engine.AmlObjects.MetaInformation][4]  
substitute for the old version of meta information

#### Return Value
Type: [Boolean][5]  
 true if succeeded, false if meta information about the oldWriterID is not found 
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [CAEXFileType][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][6] or [Extension Methods (C# Programming Guide)][7].

Exceptions
----------

Exception                  | Condition 
-------------------------- | --------- 
[ArgumentNullException][8] | caexFile  


Remarks
-------
 Extension Method originally designed for AutomationML Versions based on CAEX 2.15. If this method is applied to a CAEX 3.0 document, the information is transformed to a [SourceDocumentInformationType][9]. 

See Also
--------

#### Reference
[AmlObjectsExtensions Class][10]  
[Aml.Engine.AmlObjects.Extensions Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXFileType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: ../../Aml.Engine.AmlObjects/MetaInformation/README.md
[5]: https://docs.microsoft.com/dotnet/api/system.boolean
[6]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[7]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[8]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[9]: ../../Aml.Engine.CAEX/SourceDocumentInformationType/README.md
[10]: README.md
[11]: https://www.automationml.org
[12]: ../../icons/logoShade.png