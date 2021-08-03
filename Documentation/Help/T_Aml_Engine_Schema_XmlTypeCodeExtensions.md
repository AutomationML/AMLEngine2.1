# XmlTypeCodeExtensions Class
AutomationML 2.1 API 

This static class provides extension methods for the interpretation of <a href="https://docs.microsoft.com/dotnet/api/system.xml.schema.xmltypecode" target="_parent" rel="noopener noreferrer">XmlTypeCode</a>.


## Inheritance Hierarchy
<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_parent" rel="noopener noreferrer">System.Object</a><br />&nbsp;&nbsp;Aml.Engine.Schema.XmlTypeCodeExtensions<br />
**Namespace:**&nbsp;<a href="N_Aml_Engine_Schema">Aml.Engine.Schema</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static class XmlTypeCodeExtensions
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public NotInheritable Class XmlTypeCodeExtensions
```

**C++**<br />
``` C++
[ExtensionAttribute]
public ref class XmlTypeCodeExtensions abstract sealed
```

The XmlTypeCodeExtensions type exposes the following members.


## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Schema_XmlTypeCodeExtensions_AttributeType">AttributeType</a></td><td>
Gets the CLR-Type for the provided typeCode</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Schema_XmlTypeCodeExtensions_Default">Default</a></td><td> **Obsolete. **
Returns the default value for XmlTypeCode</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Schema_XmlTypeCodeExtensions_DefaultDecodedValue">DefaultDecodedValue</a></td><td>
Returns the default value for an XmlTypeCode. The data type of the returned object is the associated CLR type of the provided type code. The CLR type is available with the <a href="M_Aml_Engine_Schema_XmlTypeCodeExtensions_AttributeType">AttributeType(XmlTypeCode)</a> method.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Schema_XmlTypeCodeExtensions_DefaultEncodedValue">DefaultEncodedValue</a></td><td>
Converts the default value for the specified typeCode to a valid XML value string</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Schema_XmlTypeCodeExtensions_XmlTypeCodeFromSchemaType">XmlTypeCodeFromSchemaType</a></td><td>
Gets the <a href="https://docs.microsoft.com/dotnet/api/system.xml.schema.xmltypecode" target="_parent" rel="noopener noreferrer">XmlTypeCode</a> from the W3C XSD schema type string.</td></tr></table>&nbsp;
<a href="#xmltypecodeextensions-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Aml_Engine_Schema">Aml.Engine.Schema Namespace</a><br />