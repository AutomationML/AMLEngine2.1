CAEXDocument.New_CAEXDocument Method (CAEXDocument.CAEXSchema)
==============================================================
Creates a new empty CAEX document containing only the CAEXFile element as the root element. The CAEX document is created using the specified schema version. The specified schema version defines the applicable editing methods.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static CAEXDocument New_CAEXDocument(
	CAEXDocument.CAEXSchema schema
)
```

#### Parameters

##### *schema*
Type: [Aml.Engine.CAEX.CAEXDocument.CAEXSchema][2]  
The schema version which defines the CAEX document.

#### Return Value
Type: [CAEXDocument][3]  
 The created CAEX document containing the CAEXFile root element. 

See Also
--------

#### Reference
[CAEXDocument Class][3]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: ../CAEXDocument_CAEXSchema/README.md
[3]: README.md
[4]: https://www.automationml.org
[5]: ../../icons/logoShade.png