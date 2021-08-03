# ObjectWithAMLAttributes.New_RefUriAttribute Method 
AutomationML 2.1 API 

Creates a new RefURI attribute for the <a href="P_Aml_Engine_AmlObjects_ObjectWithAMLAttributes_CAEXBase">CAEXBase</a> object if none exists. The RefURI attribute value is set to the provided Uri.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public RefURIAttributeType New_RefUriAttribute(
	string uri
)
```

**VB**<br />
``` VB
Public Function New_RefUriAttribute ( 
	uri As String
) As RefURIAttributeType
```

**C++**<br />
``` C++
public:
RefURIAttributeType^ New_RefUriAttribute(
	String^ uri
)
```


#### Parameters
&nbsp;<dl><dt>uri</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The Uri string.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_AmlObjects_RefURIAttributeType">RefURIAttributeType</a><br />the RefURIAttributeType.

## Remarks
AutomationML defines, that only one RefUri attribute can be assigned to an object. If a RefUri attribute exists, the provided Uri is set to the existing attribute.

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_ObjectWithAMLAttributes">ObjectWithAMLAttributes Class</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />