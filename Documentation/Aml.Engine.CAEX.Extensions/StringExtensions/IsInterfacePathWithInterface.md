StringExtensions.IsInterfacePathWithInterface Method
====================================================
Determines whether the specified path is an interface path with this interface name.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static bool IsInterfacePathWithInterface(
	this string path,
	string interfaceName,
	CAEXDocument.CAEXSchema schema
)
```

#### Parameters

##### *path*
Type: [System.String][2]  
The path.

##### *interfaceName*
Type: [System.String][2]  
Name of the interface.

##### *schema*
Type: [Aml.Engine.CAEX.CAEXDocument.CAEXSchema][3]  
A CAEX schema version.

#### Return Value
Type: [Boolean][4]  
`true` if the specified path is an interface path with this interface name; otherwise, `false`. 
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [String][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][5] or [Extension Methods (C# Programming Guide)][6].

Remarks
-------
 Since CAEX Version 3.0 Names cannot be part of an interface path anymore. 

See Also
--------

#### Reference
[StringExtensions Class][7]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.string
[3]: ../../Aml.Engine.CAEX/CAEXDocument_CAEXSchema/README.md
[4]: https://docs.microsoft.com/dotnet/api/system.boolean
[5]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[6]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png