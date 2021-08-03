# XDocumentWrapper.Unload Method 
AutomationML 2.1 API 

Unloads this document instance.

**Namespace:**&nbsp;<a href="N_Aml_Engine_XML">Aml.Engine.XML</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public void Unload()
```

**VB**<br />
``` VB
Public Sub Unload
```

**C++**<br />
``` C++
public:
void Unload()
```


## Remarks
This method can be used to unload this instance of the CAEXDocument and remove it from all current tables of all registered services. The AMLEngine manages weak references to each created CAEXDocument instance, so explicit unload is normally not required.

## See Also


#### Reference
<a href="T_Aml_Engine_XML_XDocumentWrapper">XDocumentWrapper Class</a><br /><a href="N_Aml_Engine_XML">Aml.Engine.XML Namespace</a><br />