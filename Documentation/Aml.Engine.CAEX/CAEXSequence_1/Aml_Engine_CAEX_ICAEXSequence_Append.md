CAEXSequence&lt;T>.ICAEXSequence.Append Method
==============================================
Creates a new CAEX object and appends it to already existing elements in this sequence.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
ICAEXWrapper ICAEXSequence.Append()
```

#### Return Value
Type: [ICAEXWrapper][2]  
the created CAEX object
#### Implements
[ICAEXSequence.Append()][3]  


Exceptions
----------

Exception                       | Condition                                                         
------------------------------- | ----------------------------------------------------------------- 
[SchemaConformanceException][4] | raised, when this parent child relation violates the CAEX schema. 


See Also
--------

#### Reference
[CAEXSequence&lt;T> Class][5]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: ../ICAEXWrapper/README.md
[3]: ../ICAEXSequence/Append.md
[4]: ../SchemaConformanceException/README.md
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png