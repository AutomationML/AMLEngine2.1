ValueSequence&lt;TDataType>.Append Method
=========================================
Creates a new CAEX object and appends it to the value sequence. The value of the appended object is set to the provided value.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public XElement Append(
	TDataType value
)
```

#### Parameters

##### *value*
Type: [TDataType][2]  
The value.

#### Return Value
Type: [XElement][3]  
The created XML node.

Exceptions
----------

Exception                       | Condition                          
------------------------------- | ---------------------------------- 
[SchemaConformanceException][4] | The element could not be appended. 


See Also
--------

#### Reference
[ValueSequence&lt;TDataType> Class][2]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: README.md
[3]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement
[4]: ../SchemaConformanceException/README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png