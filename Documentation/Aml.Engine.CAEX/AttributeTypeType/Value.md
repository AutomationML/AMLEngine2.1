AttributeTypeType.Value Property
================================
AutomationML 2.1 APIGets and sets the Value for this Attribute object. The correct XML-String representation for the defined [AttributeDataType][1] has to be ensured by the caller.

  **Namespace:**  [Aml.Engine.CAEX][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public string Value { get; set; }
```

#### Property Value
Type: [String][3]

Remarks
-------
 It is possible to use the Indexer [Item[String]][4] to set a type based value which is correctly encoded/decoded according to the specified [AttributeDataType][1] or use the property [AttributeValue][5], which provides the same value access. 

Examples
--------
 This sample shows how to use this property: 
```csharp
 // setting a TimeSpan value if the AttributeDataType is defined as 'xs:Duration'.
 TimeSpan processingTime = new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 5);

 AttributeType at = ReadMyAttribute ();
 at["Value"] = processingTime;
 at["DefaultValue"] = new TimeSpan(0);

// checking the appropriate type setting:
if (at.ValueAttributes[0].TypeCodeOfAttribute == System.Xml.Schema.XmlTypeCode.Duration)
{
}
```


See Also
--------

#### Reference
[AttributeTypeType Class][7]  
[Aml.Engine.CAEX Namespace][2]  

[1]: AttributeDataType.md
[2]: ../README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: Item.md
[5]: AttributeValue.md
[6]: https://docs.microsoft.com/dotnet/api/system.timespan
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png