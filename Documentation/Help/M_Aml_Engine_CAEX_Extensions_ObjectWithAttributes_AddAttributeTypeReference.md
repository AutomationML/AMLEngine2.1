# ObjectWithAttributes.AddAttributeTypeReference Method (IObjectWithAttributes, AttributeFamilyType, Boolean, Boolean, String)
AutomationML 2.1 API 

Adds an AttributeType reference to this ObjectWithAttribute using the provided AttributeType object. The AttributeType reference is added as a <a href="T_Aml_Engine_CAEX_AttributeType">AttributeType</a> object.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static AttributeType AddAttributeTypeReference(
	this IObjectWithAttributes ObjectWithAttribute,
	AttributeFamilyType attributeClass,
	bool addUnique = true,
	bool addInstance = false,
	string name = ""
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function AddAttributeTypeReference ( 
	ObjectWithAttribute As IObjectWithAttributes,
	attributeClass As AttributeFamilyType,
	Optional addUnique As Boolean = true,
	Optional addInstance As Boolean = false,
	Optional name As String = ""
) As AttributeType
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static AttributeType^ AddAttributeTypeReference(
	IObjectWithAttributes^ ObjectWithAttribute, 
	AttributeFamilyType^ attributeClass, 
	bool addUnique = true, 
	bool addInstance = false, 
	String^ name = L""
)
```


#### Parameters
&nbsp;<dl><dt>ObjectWithAttribute</dt><dd>Type: <a href="T_Aml_Engine_CAEX_IObjectWithAttributes">Aml.Engine.CAEX.IObjectWithAttributes</a><br /></dd><dt>attributeClass</dt><dd>Type: <a href="T_Aml_Engine_CAEX_AttributeFamilyType">Aml.Engine.CAEX.AttributeFamilyType</a><br />The AttributeType to be assigned to the ObjectWithAttribute.</dd><dt>addUnique (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />if set to `true`, the AttributeType reference is not added, if a reference to the provided AttributeType already exists.</dd><dt>addInstance (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />if set to `true`, the reference is created as am instance of the AttributeType, containig all Attributes and Attributes of the AttributeType.</dd><dt>name (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />Provides the name for the new external attribute. If no name is given, the name is taken from the referenced class.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_AttributeType">AttributeType</a><br />The new added AttributeType reference.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_IObjectWithAttributes">IObjectWithAttributes</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td>attributeClass</td></tr></table>

## Remarks
The default behaviour is, that only a reference to the attribute class is added and no instance of the class containing all Attributes and Attribute objects. If an instance is required, set the optional parameter 'addInstance' to true or use the <a href="M_Aml_Engine_CAEX_InterfaceFamilyType_CreateClassInstance">CreateClassInstance()</a> and the CAEXSequenceOfCAEXObjects Insert(CAEXWrapper, bool) methods.

## Examples
This sample shows how to call the AddAttributeTypeReference(IObjectWithAttributes, AttributeFamilyType, Boolean, Boolean, String) method using a standard base AttributeType from the <a href="M_Aml_Engine_AmlObjects_AutomationMLBaseAttributeTypeLibType_AttributeTypeLib">AttributeTypeLib(CAEXDocument)</a>
```
var amlAttributeTypeLib = AutomationMLBaseAttributeTypeLibType.AttributeTypeLib (myDocument);
var myIH = myDocument.CAEXFile.InstanceHierarchy.Append ("myIH");
var myIE = myIH.InternalElement.Append("myIH");
myIE.AddAttributeTypeReference (amlAttributeTypeLib.Direction);
```


## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_ObjectWithAttributes">ObjectWithAttributes Class</a><br /><a href="Overload_Aml_Engine_CAEX_Extensions_ObjectWithAttributes_AddAttributeTypeReference">AddAttributeTypeReference Overload</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />