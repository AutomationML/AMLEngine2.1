AutomationMLContainer Constructor (String, FileMode, FileAccess, FileShare)
===========================================================================
AutomationML 2.1 APIInitializes a new instance of the [AutomationMLContainer][1] class using the specified container file to load or save the package.

  **Namespace:**  [Aml.Engine.AmlObjects][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public AutomationMLContainer(
	string containerFilePath,
	FileMode packageMode,
	FileAccess packageAccess,
	FileShare packageShare
)
```

#### Parameters

##### *containerFilePath*
Type: [System.String][3]  
 The file path of the container file.

##### *packageMode*
Type: [System.IO.FileMode][4]  
 The file mode for the package file.

##### *packageAccess*
Type: [System.IO.FileAccess][5]  
 The file access mode for the package file.

##### *packageShare*
Type: [System.IO.FileShare][6]  
 The file share access mode for the package file, which controls access of other file streams to the same file.


See Also
--------

#### Reference
[AutomationMLContainer Class][1]  
[Aml.Engine.AmlObjects Namespace][2]  

[1]: README.md
[2]: ../README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: https://docs.microsoft.com/dotnet/api/system.io.filemode
[5]: https://docs.microsoft.com/dotnet/api/system.io.fileaccess
[6]: https://docs.microsoft.com/dotnet/api/system.io.fileshare
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png