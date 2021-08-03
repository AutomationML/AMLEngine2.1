LookupService.AddDocument Method
================================
AutomationML 2.1 APIAdds the document to the query service. All tables for the document will be created.

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine.Services (in AML.Engine.Services.dll)

Syntax
------

```csharp
public void AddDocument(
	CAEXDocument doc
)
```

#### Parameters

##### *doc*
Type: [Aml.Engine.CAEX.CAEXDocument][2]  
The document.


Exceptions
----------

Exception                  | Condition 
-------------------------- | --------- 
[ArgumentNullException][3] | doc       


See Also
--------

#### Reference
[LookupService Class][4]  
[Aml.Engine.Services Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXDocument/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[4]: README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png