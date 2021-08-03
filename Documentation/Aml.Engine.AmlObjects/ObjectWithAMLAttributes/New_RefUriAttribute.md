ObjectWithAMLAttributes.New_RefUriAttribute Method
==================================================
Creates a new RefURI attribute for the [CAEXBase][1] object if none exists. The RefURI attribute value is set to the provided Uri.

  **Namespace:**  [Aml.Engine.AmlObjects][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public RefURIAttributeType New_RefUriAttribute(
	string uri
)
```

#### Parameters

##### *uri*
Type: [System.String][3]  
The Uri string.

#### Return Value
Type: [RefURIAttributeType][4]  
the RefURIAttributeType.

Remarks
-------
 AutomationML defines, that only one RefUri attribute can be assigned to an object. If a RefUri attribute exists, the provided Uri is set to the existing attribute. 

See Also
--------

#### Reference
[ObjectWithAMLAttributes Class][5]  
[Aml.Engine.AmlObjects Namespace][2]  

[1]: CAEXBase.md
[2]: ../README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: ../RefURIAttributeType/README.md
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png