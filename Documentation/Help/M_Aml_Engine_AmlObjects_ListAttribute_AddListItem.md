# ListAttribute.AddListItem Method 
AutomationML 2.1 API 

Adds an additional list item attribute to the list attribute. If the List attribute already contains some items, the new item will have the same item type as the already existing items. If this is the first item, the specified itemType is used as the attribute data type. If no itemType is defined, the default data type for the list item is "xs:string". The Item name is automatically set to the Index if the List attribute is an ordered list, otherwise the defined itemName is used.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static AttributeType AddListItem(
	this AttributeType attribute,
	string itemType = "",
	string itemName = "item"
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function AddListItem ( 
	attribute As AttributeType,
	Optional itemType As String = "",
	Optional itemName As String = "item"
) As AttributeType
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static AttributeType^ AddListItem(
	AttributeType^ attribute, 
	String^ itemType = L"", 
	String^ itemName = L"item"
)
```


#### Parameters
&nbsp;<dl><dt>attribute</dt><dd>Type: <a href="T_Aml_Engine_CAEX_AttributeType">Aml.Engine.CAEX.AttributeType</a><br />The List attribute.</dd><dt>itemType (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />Type of the new item (ignored for a list attribute containing items)</dd><dt>itemName (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />Name of the item (ignored for an ordered list attribute).</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_AttributeType">AttributeType</a><br />the added list item Attribute.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_AttributeType">AttributeType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_ListAttribute">ListAttribute Class</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />