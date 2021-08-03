# XmlSchemaManager.AttributeValueRestrictions Method 
AutomationML 2.1 API 

Gets the List of Attribute value restrictions for the attribute with the defined name. The Attribute should be an attribute of a child defined by the given name, which exists in the defined parent child relation defined by the parent name.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Schema">Aml.Engine.Schema</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public IEnumerable<Object> AttributeValueRestrictions(
	XName parentName,
	XName childName,
	string attributeName
)
```

**VB**<br />
``` VB
Public Function AttributeValueRestrictions ( 
	parentName As XName,
	childName As XName,
	attributeName As String
) As IEnumerable(Of Object)
```

**C++**<br />
``` C++
public:
IEnumerable<Object^>^ AttributeValueRestrictions(
	XName^ parentName, 
	XName^ childName, 
	String^ attributeName
)
```


#### Parameters
&nbsp;<dl><dt>parentName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xname" target="_parent" rel="noopener noreferrer">System.Xml.Linq.XName</a><br />The name of the child's parent</dd><dt>childName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xname" target="_parent" rel="noopener noreferrer">System.Xml.Linq.XName</a><br />the name of the child (owner of the attribute)</dd><dt>attributeName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />Name of the attribute.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_parent" rel="noopener noreferrer">Object</a>)<br />list of restrictions for an attribute value - object type has to be interpreted by the caller

## See Also


#### Reference
<a href="T_Aml_Engine_Schema_XmlSchemaManager">XmlSchemaManager Class</a><br /><a href="N_Aml_Engine_Schema">Aml.Engine.Schema Namespace</a><br />