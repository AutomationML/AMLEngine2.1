AttributeTypeType.ClrToXmlType Method
=====================================
AutomationML 2.1 APIGets the xmlType type for the specified CLR type. The Mapping is done according to [Mapping XML Data Types to CLR Types.][1] This reverse mapping is not unambiguous. If more than one mapping is possible, the most common used description is generated. If No mapping is defined the 'xs:string' is used.

  **Namespace:**  [Aml.Engine.CAEX][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static string ClrToXmlType(
	Type clrType
)
```

#### Parameters

##### *clrType*
Type: [System.Type][3]  
.Net data Type.

#### Return Value
Type: [String][4]  
 the name of the XML type 

Exceptions
----------

Exception                  | Condition 
-------------------------- | --------- 
[ArgumentNullException][5] | clrType   


Remarks
-------
 You can use the encoding and decoding methods of the [CaexValue][6] object, to receive a type conform result for the attribute value elements. 

See Also
--------

#### Reference
[AttributeTypeType Class][7]  
[Aml.Engine.CAEX Namespace][2]  

[1]: https://msdn.microsoft.com/en-us/library/xa669bew(v=vs.110).aspx
[2]: ../README.md
[3]: https://docs.microsoft.com/dotnet/api/system.type
[4]: https://docs.microsoft.com/dotnet/api/system.string
[5]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[6]: ../../Aml.Engine.CAEX.Extensions/CaexValue/README.md
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png