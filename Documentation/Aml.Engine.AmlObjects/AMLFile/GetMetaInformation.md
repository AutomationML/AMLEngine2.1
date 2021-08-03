AMLFile.GetMetaInformation Method
=================================
This methods returns an Enumeration of all "WriterHeader" meta information out of an existing AutomationML file.

  **Namespace:**  [Aml.Engine.AmlObjects][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public IEnumerable<MetaInformation> GetMetaInformation()
```

#### Return Value
Type: [IEnumerable][2]&lt;[MetaInformation][3]>  
 Enumerable with element containing all meta information, or null if no meta information is existing 

Exceptions
----------

Exception                        | Condition 
-------------------------------- | --------- 
[ArgumentOutOfRangeException][4] |           


Remarks
-------
 Extension Method originally designed for AutomationML Versions based on CAEX 2.15. 

See Also
--------

#### Reference
[AMLFile Class][5]  
[Aml.Engine.AmlObjects Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[3]: ../MetaInformation/README.md
[4]: https://docs.microsoft.com/dotnet/api/system.argumentoutofrangeexception
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png