CAEXDocument.SaveToFile Method
==============================
Saves the CAEX document to the specified file path.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public override void SaveToFile(
	string filename,
	bool prettyPrint
)
```

#### Parameters

##### *filename*
Type: [System.String][2]  
The file path to save the document to.

##### *prettyPrint*
Type: [System.Boolean][3]  
Set to true, if pretty printing is desired.


Exceptions
----------

Exception                  | Condition 
-------------------------- | --------- 
[ArgumentNullException][4] | filename  


See Also
--------

#### Reference
[CAEXDocument Class][5]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.string
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png