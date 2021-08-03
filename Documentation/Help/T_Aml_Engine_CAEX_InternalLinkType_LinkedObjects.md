# InternalLinkType.LinkedObjects Class
AutomationML 2.1 API 

This class allows accessing the related objects of an InternalLink without recalculation which improves the performance for consecutive access of the related objects.


## Inheritance Hierarchy
<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_parent" rel="noopener noreferrer">System.Object</a><br />&nbsp;&nbsp;Aml.Engine.CAEX.InternalLinkType.LinkedObjects<br />
**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public class LinkedObjects
```

**VB**<br />
``` VB
Public Class LinkedObjects
```

**C++**<br />
``` C++
public ref class LinkedObjects
```

The InternalLinkType.LinkedObjects type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_InternalLinkType_LinkedObjects__ctor">InternalLinkType.LinkedObjects</a></td><td>
Initializes a new instance of the InternalLinkType.LinkedObjects class</td></tr></table>&nbsp;
<a href="#internallinktype.linkedobjects-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_InternalLinkType_LinkedObjects_AInterface">AInterface</a></td><td>
Gets the A-Interface of the InternalLink by interpretation of the <a href="P_Aml_Engine_CAEX_InternalLinkType_RefPartnerSideA">RefPartnerSideA</a> Attribute on first access. Consecutive reads will return the at first calculated value. A Reinterpretation is performed, when the respective InternalLink property <a href="P_Aml_Engine_CAEX_InternalLinkType_AInterface">AInterface</a> is read or set.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_InternalLinkType_LinkedObjects_ASystemUnitClass">ASystemUnitClass</a></td><td>
Gets the A-SystemUnitClass using the preserved value <a href="P_Aml_Engine_CAEX_InternalLinkType_LinkedObjects_AInterface">AInterface</a>. If this value has not been calculated, a recalculation is performed.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_InternalLinkType_LinkedObjects_BInterface">BInterface</a></td><td>
Gets the B-Interface of the InternalLink by interpretation of the <a href="P_Aml_Engine_CAEX_InternalLinkType_RefPartnerSideB">RefPartnerSideB</a> Attribute on first access. Consecutive reads will return the at first calculated value. A Reinterpretation is performed, when the respective InternalLink property <a href="P_Aml_Engine_CAEX_InternalLinkType_BInterface">BInterface</a> is read or set.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_InternalLinkType_LinkedObjects_BSystemUnitClass">BSystemUnitClass</a></td><td>
Gets the B-SystemUnitClass using the preserved value <a href="P_Aml_Engine_CAEX_InternalLinkType_LinkedObjects_BInterface">BInterface</a>. If this value has not been calculated, a recalculation is performed.</td></tr></table>&nbsp;
<a href="#internallinktype.linkedobjects-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />