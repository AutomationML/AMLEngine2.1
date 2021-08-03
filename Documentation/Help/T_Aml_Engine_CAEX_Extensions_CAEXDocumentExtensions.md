# CAEXDocumentExtensions Class
AutomationML 2.1 API 

This class defines extension methods for the <a href="T_Aml_Engine_CAEX_CAEXDocument">CAEXDocument</a> class.


## Inheritance Hierarchy
<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_parent" rel="noopener noreferrer">System.Object</a><br />&nbsp;&nbsp;Aml.Engine.CAEX.Extensions.CAEXDocumentExtensions<br />
**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static class CAEXDocumentExtensions
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public NotInheritable Class CAEXDocumentExtensions
```

**C++**<br />
``` C++
[ExtensionAttribute]
public ref class CAEXDocumentExtensions abstract sealed
```

The CAEXDocumentExtensions type exposes the following members.


## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXDocumentExtensions_FindByID">FindByID</a></td><td>
Tries to locate a CAEX object from the specified ID. If the ID uses an alias reference and an <a href="T_Aml_Engine_Services_Interfaces_IExternalReferenceResolver">IExternalReferenceResolver</a> can be located, it is tried to resolve the external reference and to get the object from the external source.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXDocumentExtensions_FindByPath">FindByPath</a></td><td>
Tries to locates a CAEX object from the specified CAEX path. If the path uses an alias reference and an <a href="T_Aml_Engine_Services_Interfaces_IExternalReferenceResolver">IExternalReferenceResolver</a> can be located, it is tried to resolve the external reference and to get the object from the external source.</td></tr></table>&nbsp;
<a href="#caexdocumentextensions-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />