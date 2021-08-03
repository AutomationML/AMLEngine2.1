ICAEXSequence.Append Method
===========================
AutomationML 2.1 APICreates a new CAEX object and appends it to already existing elements in this sequence.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
ICAEXWrapper Append()
```

#### Return Value
Type: [ICAEXWrapper][2]  
the created CAEX object

Exceptions
----------

Exception                       | Condition                                                         
------------------------------- | ----------------------------------------------------------------- 
[SchemaConformanceException][3] | raised, when this parent child relation violates the CAEX schema. 


See Also
--------

#### Reference
[ICAEXSequence Interface][4]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: ../ICAEXWrapper/README.md
[3]: ../SchemaConformanceException/README.md
[4]: README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png