# ObjectWithAttributes.CopyAttributesFrom Method 
AutomationML 2.1 API 

Copies all attribute of the source object with attributes to the target object including children

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static void CopyAttributesFrom(
	this IObjectWithAttributes targetObject,
	IObjectWithAttributes sourceObject,
	bool includingValues
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Sub CopyAttributesFrom ( 
	targetObject As IObjectWithAttributes,
	sourceObject As IObjectWithAttributes,
	includingValues As Boolean
)
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static void CopyAttributesFrom(
	IObjectWithAttributes^ targetObject, 
	IObjectWithAttributes^ sourceObject, 
	bool includingValues
)
```


#### Parameters
&nbsp;<dl><dt>targetObject</dt><dd>Type: <a href="T_Aml_Engine_CAEX_IObjectWithAttributes">Aml.Engine.CAEX.IObjectWithAttributes</a><br />the target object</dd><dt>sourceObject</dt><dd>Type: <a href="T_Aml_Engine_CAEX_IObjectWithAttributes">Aml.Engine.CAEX.IObjectWithAttributes</a><br />the source object</dd><dt>includingValues</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />true if the copy process should include the attribute values, not recommended for classes</dd></dl>

#### Return Value
Type: <br />nothing

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_IObjectWithAttributes">IObjectWithAttributes</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_ObjectWithAttributes">ObjectWithAttributes Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />