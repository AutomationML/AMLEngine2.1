# CAEX Changes


Differences between CAEX 2.15 and CAEX 3.0.   
Edited by Prof. Dr.-Ing. Rainer Drath, Hochschule Pforzheim   





This topic contains the following sections:
&nbsp;<ul><li><a href="#mandatory-attribute-refbaseroleclasspath">Mandatory Attribute RefBaseRoleClassPath</a></li>&nbsp;
<li><a href="#native-support-of-multiple-role-references">Native	Support	of multiple role references</a></li>&nbsp;
<li><a href="#attributelibrary-and-attributefamiliytype-with-reference">AttributeLibrary and AttributeFamiliyType with reference</a></li>&nbsp;
<li><a href="#xs:anytype-removed-and-replaced">xs:anyType removed and replaced</a></li>&nbsp;
<li><a href="#native-support-of-nested-interfaces">Native	support of nested interfaces</a></li>&nbsp;
<li><a href="#superiorstandardversion">SuperiorStandardVersion</a></li>&nbsp;
<li><a href="#sourcedocumentinformation">SourceDocumentInformation</a></li>&nbsp;
<li><a href="#sourceobjectinformation">SourceObjectInformation</a></li>&nbsp;
<li><a href="#namespace-definition">Namespace definition</a></li>&nbsp;
<li><a href="#mirror-objects">Mirror objects</a></li>&nbsp;
<li><a href="#internallink">InternalLink</a></li>&nbsp;
<li><a href="#interface-mappings">Interface Mappings</a></li></ul>&nbsp;
AmlEngine2.1 supports AutomationML documents based on CAEX 2.15 as well as documents, based on CAEX 3.0. The main differences between these versions are listed below. A document transformation service can be used, to transform CAEX 2.15 documents to CAEX 3.0 documents and back.



## Mandatory Attribute RefBaseRoleClassPath

The Attribute _RefBaseRoleClassPath_ defined for _RoleRequirements_ is mandatory in CAEX 3.0

<br /><img alt="c 1" src="media/c1.png" /><br /><a href="#">Back</a>



## Native Support of multiple role references

In CAEX 3.0, the CAEX Element _InternalElementType_ can have multiple _RoleRequirements_ assigned.


The _MappingObject_ is moved below the _RoleRequirements_ to define their context.

<br /><img alt="c 2" src="media/c2.png" /><br /><a href="#">Back</a>



## AttributeLibrary and AttributeFamiliyType with reference

The _AttributeTypeLib_ is a new library type in CAEX 3.0. It contains _AttributeFamilyTypes_ which can be referenced in Attributes with the _RefAttributeType_ to define the Attribute Type.

<br /><img alt="c 3" src="media/c3.png" /><br /><br />**Example**<br /><img alt="c 4" src="media/c4.png" /><br /><a href="#">Back</a>



## xs:anyType removed and replaced

The _xs:anyType_ has been replaced with _xs:string_ as value type.

<br /><img alt="c 5" src="media/c5.png" /><br /><a href="#">Back</a>



## Native support of nested interfaces

The _InterfaceClassType_ can contain child _ExternalInterfaceType_ elements.

<br /><img alt="c 6" src="media/c6.png" /><br /><a href="#">Back</a>



## SuperiorStandardVersion

The new attribute _SuperiorStandardVersion_ allows defining the superior version number of the used AutomationML standard.

<br /><img alt="c 7" src="media/c7.png" /><br /><a href="#">Back</a>



## SourceDocumentInformation

In CAEX 3.0, the _SourceDocumentInformation_ shall be used to define information about the data source.

<br /><img alt="c 8" src="media/c8.png" /><br /><a href="#">Back</a>



## SourceObjectInformation

The new element _SourceObjectInformation_ can be used to store the original object-ID of the belonging document source and object source.

<br /><img alt="c 9" src="media/c9.png" /><br /><a href="#">Back</a>



## Namespace definition

In CAEX 3.0 a namespace definition for the CAEX schema is added.

<br /><img alt="c 10" src="media/c10.png" /><br /><a href="#">Back</a>



## Mirror objects

In CAEX 3.0 the Mirror concept is extended to attributes and interfaces but forbids that mirror objects hold individual children or attributes.

<br /><img alt="c 11" src="media/c11.png" /><br /><a href="#">Back</a>



## InternalLink

The modeling of _InternalLinks_ has been refined. The _RefPartnerSideA_ and _RefPartnerSideB_ are mandatory, open links are reflected by an empty string.

<br /><img alt="c 12" src="media/c12.png" /><br /><a href="#">Back</a>



## Interface Mappings

The _InterfaceNameMapping_ has been replaced by the _InterfaceIdMapping_. Interface mapping bases on the CAEXObject IDs instead of the CAEXObject names.

<br /><img alt="c 13" src="media/c13.png" /><br /><a href="#">Back</a>