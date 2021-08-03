AmlObjectsExtensions.GetMetaInformation Method (CAEXFileType, String)
=====================================================================
AutomationML 2.1 APIThis function returns the MetaInformation corresponding to the writerID, otherwise null.

  **Namespace:**  [Aml.Engine.AmlObjects.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static MetaInformation GetMetaInformation(
	this CAEXFileType caexFile,
	string writerID
)
```

#### Parameters

##### *caexFile*
Type: [Aml.Engine.CAEX.CAEXFileType][2]  
this CAEX file

##### *writerID*
Type: [System.String][3]  
the writerID

#### Return Value
Type: [MetaInformation][4]  
 This function returns the MetaInformation corresponding to the writerID, otherwise null. 
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [CAEXFileType][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][5] or [Extension Methods (C# Programming Guide)][6].

Exceptions
----------

Exception                  | Condition 
-------------------------- | --------- 
[ArgumentNullException][7] | caexFile  


Remarks
-------
 Extension Method originally designed for AutomationML Versions based on CAEX 2.15. If this method is applied to a CAEX 3.0 document, the information is transformed from a [SourceDocumentInformationType][8]. 

See Also
--------

#### Reference
[AmlObjectsExtensions Class][9]  
[Aml.Engine.AmlObjects.Extensions Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXFileType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: ../../Aml.Engine.AmlObjects/MetaInformation/README.md
[5]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[6]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[7]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[8]: ../../Aml.Engine.CAEX/SourceDocumentInformationType/README.md
[9]: README.md
[10]: https://www.automationml.org
[11]: ../../icons/logoShade.png