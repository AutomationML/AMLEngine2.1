# ListAttribute.CreateListAttribute Method 
AutomationML 2.1 API 

Creates a new list attribute for an element which can have attributes.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static AttributeType CreateListAttribute(
	this IObjectWithAttributes element,
	string attributeName,
	int itemsCount,
	string itemType,
	string itemName = "item",
	bool isOrderedList = false
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function CreateListAttribute ( 
	element As IObjectWithAttributes,
	attributeName As String,
	itemsCount As Integer,
	itemType As String,
	Optional itemName As String = "item",
	Optional isOrderedList As Boolean = false
) As AttributeType
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static AttributeType^ CreateListAttribute(
	IObjectWithAttributes^ element, 
	String^ attributeName, 
	int itemsCount, 
	String^ itemType, 
	String^ itemName = L"item", 
	bool isOrderedList = false
)
```


#### Parameters
&nbsp;<dl><dt>element</dt><dd>Type: <a href="T_Aml_Engine_CAEX_IObjectWithAttributes">Aml.Engine.CAEX.IObjectWithAttributes</a><br />The element.</dd><dt>attributeName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />Name of the new list attribute.</dd><dt>itemsCount</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.int32" target="_parent" rel="noopener noreferrer">System.Int32</a><br />The items count for initialization of the containing attribute items.</dd><dt>itemType</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />Type of the item (unique for all items).</dd><dt>itemName (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />Name of the item (ignored if an ordered list is created). When an item attribute is created, the item Name gets the item index added to this name.</dd><dt>isOrderedList (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />if set to `true` the list is an ordered list.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_AttributeType">AttributeType</a><br />The list AttributeType.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_IObjectWithAttributes">IObjectWithAttributes</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_ListAttribute">ListAttribute Class</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />