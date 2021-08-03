CAEXDocument.LoadFromFile Method
================================
AutomationML 2.1 APICreate a CAEX document with content, loaded from a file. The schema version of the CAEX document is set accordingly to the SchemaVersion-Attribute of the CAEXFile object.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static CAEXDocument LoadFromFile(
	string filePath
)
```

#### Parameters

##### *filePath*
Type: [System.String][2]  
The file path.

#### Return Value
Type: [CAEXDocument][3]  
 The created CAEX document. 

Exceptions
----------

Exception                  | Condition 
-------------------------- | --------- 
[FileNotFoundException][4] | filePath  


See Also
--------

#### Reference
[CAEXDocument Class][3]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.string
[3]: README.md
[4]: https://docs.microsoft.com/dotnet/api/system.io.filenotfoundexception
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png