# AttributeTypeType.Value Property 
AutomationML 2.1 API 

Gets and sets the Value for this Attribute object. The correct XML-String representation for the defined <a href="P_Aml_Engine_CAEX_AttributeTypeType_AttributeDataType">AttributeDataType</a> has to be ensured by the caller.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public string Value { get; set; }
```

**VB**<br />
``` VB
Public Property Value As String
	Get
	Set
```

**C++**<br />
``` C++
public:
property String^ Value {
	String^ get ();
	void set (String^ value);
}
```


#### Property Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a>

## Remarks
It is possible to use the Indexer <a href="P_Aml_Engine_CAEX_AttributeTypeType_Item">Item(String)</a> to set a type based value which is correctly encoded/decoded according to the specified <a href="P_Aml_Engine_CAEX_AttributeTypeType_AttributeDataType">AttributeDataType</a> or use the property <a href="P_Aml_Engine_CAEX_AttributeTypeType_AttributeValue">AttributeValue</a>, which provides the same value access.

## Examples
This sample shows how to use this property: 
```
 // setting a  value if the AttributeDataType is defined as 'xs:Duration'.
 TimeSpan processingTime = new TimeSpan(days: 0, hours: 0, minutes: 0, seconds: 5);

 AttributeType at = ReadMyAttribute ();
 at["Value"] = processingTime;
 at["DefaultValue"] = new TimeSpan(0);

// checking the appropriate type setting:
if (at.ValueAttributes[0].TypeCodeOfAttribute == System.Xml.Schema.XmlTypeCode.Duration)
{
}
```


## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_AttributeTypeType">AttributeTypeType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />