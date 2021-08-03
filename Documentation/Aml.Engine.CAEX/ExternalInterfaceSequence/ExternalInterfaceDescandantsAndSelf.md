ExternalInterfaceSequence.ExternalInterfaceDescandantsAndSelf Method
====================================================================
AutomationML 2.1 APIGets all external interfaces and the external interface descendants (The external interface tree).

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public IEnumerable<ExternalInterfaceType> ExternalInterfaceDescandantsAndSelf()
```

#### Return Value
Type: [IEnumerable][2]&lt;[ExternalInterfaceType][3]>  
 an enumeration of all ExternalInterface object of this instance and their nested ExternalInterface objects. 

Remarks
-------
available since CAEX Version 3.0.

See Also
--------

#### Reference
[ExternalInterfaceSequence Class][4]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[3]: ../ExternalInterfaceType/README.md
[4]: README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png