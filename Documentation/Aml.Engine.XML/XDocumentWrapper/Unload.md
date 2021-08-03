XDocumentWrapper.Unload Method
==============================
Unloads this document instance.

  **Namespace:**  [Aml.Engine.XML][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public void Unload()
```


Remarks
-------
 This method can be used to unload this instance of the CAEXDocument and remove it from all current tables of all registered services. The AMLEngine manages weak references to each created CAEXDocument instance, so explicit unload is normally not required. 

See Also
--------

#### Reference
[XDocumentWrapper Class][2]  
[Aml.Engine.XML Namespace][1]  

[1]: ../README.md
[2]: README.md
[3]: https://www.automationml.org
[4]: ../../icons/logoShade.png