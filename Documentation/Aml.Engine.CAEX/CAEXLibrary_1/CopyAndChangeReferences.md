CAEXLibrary&lt;TLibItem>.CopyAndChangeReferences Method
=======================================================
Creates a copy of the library and assigns the provided name to the copy. Including references to objects in the original library are redirected to objects in the copied library.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public CAEXLibrary<TLibItem> CopyAndChangeReferences(
	CAEXFileType caexFile,
	string name
)
```

#### Parameters

##### *caexFile*
Type: [Aml.Engine.CAEX.CAEXFileType][2]  
The CAEX file object, to which the copied library is appended.

##### *name*
Type: [System.String][3]  
The new name.

#### Return Value
Type: [CAEXLibrary][4]&lt;[TLibItem][4]>  
The copied object, if it could be appended to the CAEX file; otherwise `null`.

See Also
--------

#### Reference
[CAEXLibrary&lt;TLibItem> Class][4]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: ../CAEXFileType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png