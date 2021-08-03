# AMLEngineAdapter.getReferencedClass Method 
AutomationML 2.1 API 

**Note: This API is now obsolete.**

Getting the XML Node for a class path.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Adapter">Aml.Engine.Adapter</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
[ObsoleteAttribute("Use the FindByPath method from the CAEXDocument or the Services.ServiceLocator.QueryService.FindByPath method instead", 
	false)]
public static XElement getReferencedClass(
	this CAEXBasicObject caexObject,
	string referencedClassPath
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
<ObsoleteAttribute("Use the FindByPath method from the CAEXDocument or the Services.ServiceLocator.QueryService.FindByPath method instead", 
	false)>
Public Shared Function getReferencedClass ( 
	caexObject As CAEXBasicObject,
	referencedClassPath As String
) As XElement
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
[ObsoleteAttribute(L"Use the FindByPath method from the CAEXDocument or the Services.ServiceLocator.QueryService.FindByPath method instead", 
	false)]
static XElement^ getReferencedClass(
	CAEXBasicObject^ caexObject, 
	String^ referencedClassPath
)
```


#### Parameters
&nbsp;<dl><dt>caexObject</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXBasicObject">Aml.Engine.CAEX.CAEXBasicObject</a><br />The CAEX object.</dd><dt>referencedClassPath</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The full path to the referenced class. Hierarchies are separated via slash "/"</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement" target="_parent" rel="noopener noreferrer">XElement</a><br />The XML Node of the desired class, or null if none found. Use FindFastByID for speed optimizations.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_CAEXBasicObject">CAEXBasicObject</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter Class</a><br /><a href="N_Aml_Engine_Adapter">Aml.Engine.Adapter Namespace</a><br />