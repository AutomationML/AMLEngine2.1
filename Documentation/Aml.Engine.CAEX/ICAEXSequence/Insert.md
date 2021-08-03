ICAEXSequence.Insert Method
===========================
AutomationML 2.1 APIInserts the specified CAEX object into this sequence. If no position is specified the element is appended. If 'asFirst' is set to `true`, the element is prepended to already existing ones.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
void Insert(
	ICAEXWrapper caexObject,
	bool asFirst = true
)
```

#### Parameters

##### *caexObject*
Type: [Aml.Engine.CAEX.ICAEXWrapper][2]  
the CAEX object

##### *asFirst* (Optional)
Type: [System.Boolean][3]  
 optional parameter, if set to `true (default)` the object is prepended to already existing ones, otherwise it is appended.


See Also
--------

#### Reference
[ICAEXSequence Interface][4]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: ../ICAEXWrapper/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png