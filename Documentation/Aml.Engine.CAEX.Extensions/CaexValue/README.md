CaexValue Class
===============
This class can be used for a type based access to the value attributes of a CAEX element. It is required, that the [AttributeDataType][1] is set according to the XSD Schema types. If the AttributeDataType is not defined, the type `xs:string` is assumed and the value is not encoded/decoded. CAEX Elements, which use this feature are [OrdinalScaledTypeType][2], [NominalScaledTypeType][3] and [AttributeTypeType][4] and their derivations. The interface [IAttributeValueType][5] is implemented by these classes. The type based conversion is implemented, using XML specific decoding and encoding methods, defined in the .NET class [XmlConvert][6]. The decoded/encoded value for an attribute can be accessed via the [Value][7] property.


Inheritance Hierarchy
---------------------
[System.Object][8]  
  **Aml.Engine.CAEX.Extensions.CaexValue**  

  **Namespace:**  [Aml.Engine.CAEX.Extensions][9]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public sealed class CaexValue : IComparable
```

The **CaexValue** type exposes the following members.


Properties
----------

                   | Name                      | Description                                                                                                                                                                                                                                                                                          
------------------ | ------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public property] | [DefaultValue][10]        | Gets a default decoded value according to the defined AttributeDataType                                                                                                                                                                                                                              
![Public property] | [FriendlyValueString][11] | Gets a friendly string of the Attribute value. This string is not in any case equal to the attribute value string, which is always an encoded string, according to the AttributeDataType. The conversion format used to convert the value to its string representation is fix and cannot be changed. 
![Public property] | [TypeAttribute][12]       | Gets the Attribute, which defines the AttributeDataType.                                                                                                                                                                                                                                             
![Public property] | [TypeCodeOfAttribute][13] | Gets the .NET Type code which is converted from the XSD Schema attribute defined in the [TypeAttribute][12].                                                                                                                                                                                         
![Public property] | [Value][7]                | Gets and sets the value attribute using the type specific XML conversion method. If no AttributeDataType is defined, the value is encoded / decoded as it is.                                                                                                                                        
![Public property] | [ValueElement][14]        | Gets the Element, which contains the Attribute value.                                                                                                                                                                                                                                                


Methods
-------

                                 | Name                          | Description                                                                                                                                                                                                                                                                                                                                                                                                                 
-------------------------------- | ----------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method]                 | [CompareTo][15]               | Type based comparison of attribute values.                                                                                                                                                                                                                                                                                                                                                                                  
![Public method]                 | [Equals][16]                  | Determines whether the specified [Object][8], is equal to this instance. (Overrides [Object.Equals(Object)][17].)                                                                                                                                                                                                                                                                                                           
![Public method]                 | [GetHashCode][18]             | Returns a hash code for this instance. (Overrides [Object.GetHashCode()][19].)                                                                                                                                                                                                                                                                                                                                              
![Public method]                 | [IsBinaryValue][20]           | Determines if the type code derived from the Attribute datatype is a binary type.                                                                                                                                                                                                                                                                                                                                           
![Public method]                 | [IsDateTimeType][21]          | Determines if the type code derived from the Attribute datatype is a date time type. The following type codes are recognized as date time types: [Time][22][Date][22][DateTime][22][GYearMonth][22][GMonthDay][22]                                                                                                                                                                                                          
![Public method]                 | [IsNumericOrBooleanValue][23] | Determines if the type code derived from the Attribute datatype is a numeric or boolean type. For a lit of numeric types .                                                                                                                                                                                                                                                                                                  
![Public method]                 | [IsNumericValue][24]          | Determines if the type code derived from the Attribute datatype is a numeric type. The following type codes are recognized as numeric types: [Double][22][Float][22][Long][22][UnsignedShort][22][UnsignedLong][22][UnsignedInt][22][UnsignedByte][22][Int][22][UnsignedShort][22][Short][22][NegativeInteger][22][PositiveInteger][22][Decimal][22][NonPositiveInteger][22][NonNegativeInteger][22][Byte][22][Integer][22] 
![Public method]                 | [IsPartOfDateValue][25]       | Determines if the type code derived from the Attribute datatype defined a part of a date. The datatype `ushort` is used for a date part. The following type codes are recognized as date parts: [GMonth][22][GDay][22][GYear][22]                                                                                                                                                                                           
![Public method]                 | [IsStringValue][26]           | Determines if the type code derived from the Attribute datatype is a string type. The following type codes are recognized as string types: [NmToken][22][AnyAtomicType][22][NormalizedString][22][Language][22][String][22][Token][22][NCName][22][QName][22][Name][22][Text][22]                                                                                                                                           
![Public method]                 | [IsValidStringValue][27]      | Checks for all string data types, if the provided string is valid according to the defined data type [TypeCodeOfAttribute][13]. The supported types are : [NmToken][22][Name][22][NormalizedString][22][NCName][22][QName][22][Token][22]                                                                                                                                                                                   
![Public method]![Static member] | [TypeCode][28]                | Translates an XSd schema type to an XmlTypeCode.                                                                                                                                                                                                                                                                                                                                                                            


See Also
--------

#### Reference
[Aml.Engine.CAEX.Extensions Namespace][9]  

[1]: ../../Aml.Engine.CAEX/AttributeTypeType/AttributeDataType.md
[2]: ../../Aml.Engine.CAEX/OrdinalScaledTypeType/README.md
[3]: ../../Aml.Engine.CAEX/NominalScaledTypeType/README.md
[4]: ../../Aml.Engine.CAEX/AttributeTypeType/README.md
[5]: ../../Aml.Engine.CAEX/IAttributeValueType/README.md
[6]: https://docs.microsoft.com/dotnet/api/system.xml.xmlconvert
[7]: Value.md
[8]: https://docs.microsoft.com/dotnet/api/system.object
[9]: ../README.md
[10]: DefaultValue.md
[11]: FriendlyValueString.md
[12]: TypeAttribute.md
[13]: TypeCodeOfAttribute.md
[14]: ValueElement.md
[15]: CompareTo.md
[16]: Equals.md
[17]: https://docs.microsoft.com/dotnet/api/system.object.equals#System_Object_Equals_System_Object_
[18]: GetHashCode.md
[19]: https://docs.microsoft.com/dotnet/api/system.object.gethashcode#System_Object_GetHashCode
[20]: IsBinaryValue.md
[21]: IsDateTimeType.md
[22]: https://docs.microsoft.com/dotnet/api/system.xml.schema.xmltypecode
[23]: IsNumericOrBooleanValue.md
[24]: IsNumericValue.md
[25]: IsPartOfDateValue.md
[26]: IsStringValue.md
[27]: IsValidStringValue.md
[28]: TypeCode.md
[29]: https://www.automationml.org
[30]: ../../icons/logoShade.png
[Public property]: ../../icons/pubproperty.gif "Public property"
[Public method]: ../../icons/pubmethod.gif "Public method"
[Static member]: ../../icons/static.gif "Static member"