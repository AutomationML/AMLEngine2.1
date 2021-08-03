# ObjectWithAttributes.SetAttributeValue Method (IObjectWithAttributes, String, Double, Double, String, String)
AutomationML 2.1 API 

Modifies the attribute with the specified name from the attribute collection of the CAEX object, using the provided values. If no attribute with that name exists, it is created. Sets the AttributeDataType to xs:double

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static AttributeType SetAttributeValue(
	this IObjectWithAttributes objWithAttr,
	string attName,
	double attValue,
	double defaultValue,
	string description,
	string attUnit
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function SetAttributeValue ( 
	objWithAttr As IObjectWithAttributes,
	attName As String,
	attValue As Double,
	defaultValue As Double,
	description As String,
	attUnit As String
) As AttributeType
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static AttributeType^ SetAttributeValue(
	IObjectWithAttributes^ objWithAttr, 
	String^ attName, 
	double attValue, 
	double defaultValue, 
	String^ description, 
	String^ attUnit
)
```


#### Parameters
&nbsp;<dl><dt>objWithAttr</dt><dd>Type: <a href="T_Aml_Engine_CAEX_IObjectWithAttributes">Aml.Engine.CAEX.IObjectWithAttributes</a><br />parent object</dd><dt>attName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />attribute name</dd><dt>attValue</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.double" target="_parent" rel="noopener noreferrer">System.Double</a><br />attribute value of type double</dd><dt>defaultValue</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.double" target="_parent" rel="noopener noreferrer">System.Double</a><br />attribute defaultValue</dd><dt>description</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />attribute description</dd><dt>attUnit</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />attribute unit</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_AttributeType">AttributeType</a><br />The modified attribute

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_IObjectWithAttributes">IObjectWithAttributes</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_ObjectWithAttributes">ObjectWithAttributes Class</a><br /><a href="Overload_Aml_Engine_CAEX_Extensions_ObjectWithAttributes_SetAttributeValue">SetAttributeValue Overload</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />