# AttributeTypeTypeExtensions.New_RefSemantic Method 
AutomationML 2.1 API 

Appends a new RefSemantic object with the defined semantics to the specified CAEX object.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static RefSemanticType New_RefSemantic(
	this AttributeTypeType caexObject,
	string semantic
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function New_RefSemantic ( 
	caexObject As AttributeTypeType,
	semantic As String
) As RefSemanticType
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static RefSemanticType^ New_RefSemantic(
	AttributeTypeType^ caexObject, 
	String^ semantic
)
```


#### Parameters
&nbsp;<dl><dt>caexObject</dt><dd>Type: <a href="T_Aml_Engine_CAEX_AttributeTypeType">Aml.Engine.CAEX.AttributeTypeType</a><br />The CAEX object</dd><dt>semantic</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />A string, defining some external defined semantic source.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_RefSemanticType">RefSemanticType</a><br />The new RefSemantic object

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_AttributeTypeType">AttributeTypeType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_AttributeTypeTypeExtensions">AttributeTypeTypeExtensions Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />