CAEXSequence&lt;T>.Append Method
================================
AutomationML 2.1 APICreates a new CAEX object and appends it to already existing elements in this sequence.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public virtual T Append()
```

#### Return Value
Type: [T][2]  
the created CAEX object

Exceptions
----------

Exception                       | Condition                                                         
------------------------------- | ----------------------------------------------------------------- 
[SchemaConformanceException][3] | raised, when this parent child relation violates the CAEX schema. 


See Also
--------

#### Reference
[CAEXSequence&lt;T> Class][2]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: README.md
[3]: ../SchemaConformanceException/README.md
[4]: https://www.automationml.org
[5]: ../../icons/logoShade.png