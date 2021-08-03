# AMLEngine2.1 Version 1.3

Version 1.3 of AMLEngine2.1 was released on 26.07.2019. The actual service release is Version 1.3.3.



## New in Version 1.3
&nbsp;<ul><li>
New class <a href="T_Aml_Engine_CAEX_Extensions_CaexValue">CaexValue</a> has been added. The class supports encoding and decoding of value elements according to a defined AttributeDataType.


Example: Get and set a Timespan value.


**C#**<br />
``` C#
using Aml.Engine.CAEX;
using Aml.Engine.Resources;

var document = CAEXDocument.LoadFromFile ("myFile.aml");
var iH = document.CaexFile.InstanceHierarchy.Append("myIH");
var iE = iH.InternalElement.Append ("myIE");
var at = iE.Attribute.Append ("myAT");
at.AttributeDataType = XsdDataTypes.DurationType;
at["Value"] = new TimeSpan (hours:0, minutes:0, seconds:29);
TimeSpan duration = at["Value"];
```</li><li>
Access to the XSD Datatype Resourcestrings are made public now: XsdDataTypes</li><li>The Inteface classes and their inheritance relations have been harmonized. The Type <a href="T_Aml_Engine_CAEX_CAEXBasicObject">CAEXBasicObject</a> implements the new defined Interface class <a href="T_Aml_Engine_CAEX_ICAEXBasicObject">ICAEXBasicObject</a>. The already existing Interface class <a href="T_Aml_Engine_CAEX_ICAEXObject">ICAEXObject</a> is derived from this interface.</li></ul>

## See Also


#### Other Resources
<a href="Version history">Version History</a><br />