AttributeTypeType.XmlTypeToClrType Method
=========================================
Gets the CLR type for the specified xmlType. The Mapping is done according to [Mapping XML Data Types to CLR Types.][1]

  **Namespace:**  [Aml.Engine.CAEX][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static Type XmlTypeToClrType(
	string xmlType
)
```

#### Parameters

##### *xmlType*
Type: [System.String][3]  
The name of the XML type

#### Return Value
Type: [Type][4]  
 a .NET data Type 

Exceptions
----------

Exception                  | Condition 
-------------------------- | --------- 
[ArgumentNullException][5] | xmlType   


See Also
--------

#### Reference
[AttributeTypeType Class][6]  
[Aml.Engine.CAEX Namespace][2]  

[1]: https://msdn.microsoft.com/en-us/library/xa669bew(v=vs.110).aspx
[2]: ../README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: https://docs.microsoft.com/dotnet/api/system.type
[5]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png