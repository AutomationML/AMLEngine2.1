# AutomationML API Reference Guide

The **AMLEngine2.1** allows you to process AutomationML documents with a provided Application Programming Interface, based on the .NET <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.linq?view=net-5.0/" rel="noopener noreferrer" title="System.Xml.Linq">System.Xml.Linq</a> Namespace. Using the API you interact with CAEX-Elements and AutomationML-Objects. This AMLEngine is an advanced development of the AMLEngine Version 3.x which only supports AutomationML Edition 1 and the CAEX Version 2.15. This new development also supports **AutomationML Version 2.10** also known as AutomationML Edition 2, which is based on **CAEX Version 3.0**.


This AMLEngine is not based on code generation from the Altova tool package as all prior versions and has no dependencies to Altova DLLs. Instead all XML processing is based on the .NET <a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.linq?view=net-5.0/" rel="noopener noreferrer" title="System.Xml.Linq">LINQ to XML integrated query framework</a> . To ease adaption of legacy code to this advanced version of the AMLEngine a special adapter package is provided. Not all features from the former AMLEngine based on Altova code generation are adaptable, especially the data types and classes which were defined by Altova are not supported. There also exist many methods which are marked as obsolete, because they are either redundant or replaced by methods, implementing simpler access patterns. The main differences between CAEX Version 2.15 and version 3.0 are summarized here <a href="changes">CAEX Changes</a>. A short guide explaining the migration of legacy code to the AMLEngine2.1 is available here <a href="adaption">Adaption</a>. This documentation is a full API-reference guide.



## Fundamental changes

The **AMLEngine2.1** has changed its namespace naming in the move from v3.x.x.
&nbsp;<ul><li>
The namespace CAEXClassModel is now divided into <a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a> and <a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a></li><li>
The name spaces AMLEngineExtensions and AML are replaced with <a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a> and <a href="N_Aml_Engine_AmlObjects_Extensions">Aml.Engine.AmlObjects.Extensions</a>.</li><li>
Some extensions formerly contained in the CAEXClassModel and AMLEngineExtensions name spaces have been moved to the <a href="N_Aml_Engine_Services">Aml.Engine.Services</a> package. This package implements services. It is optional and may be excluded.


Special features like split and merge, schema transformation and others are implemented using services. The AMLEngine implements the service locater pattern to recognize a registered service and use its services. One consequence of the service locater pattern is, that there are no different query methods for fast and XPath based queries anymore. A query is performed by the currently located query service.</li></ul>&nbsp;
The AMLEngine has changed its .NET XML processing model from System.Xml to System.Xml.Linq, which is based on the integrated query framework LINQ.
&nbsp;<ul><li><a href="T_Aml_Engine_CAEX_CAEXDocument">CAEXDocument</a> is a wrapper for the <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xdocument" target="_parent" rel="noopener noreferrer">XDocument</a> and not <a href="https://docs.microsoft.com/dotnet/api/system.xml.xmldocument" target="_parent" rel="noopener noreferrer">XmlDocument</a> as before.</li><li><a href="T_Aml_Engine_CAEX_CAEXBasicObject">CAEXBasicObject</a> and derivations are wrappers for the <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement" target="_parent" rel="noopener noreferrer">XElement</a> and not <a href="https://docs.microsoft.com/dotnet/api/system.xml.xmlnode" target="_parent" rel="noopener noreferrer">XmlNode</a> as before.</li><li>
The introduction of a namespace into CAEX 3.0 has consequences on query expressions. The <a href="T_Aml_Engine_CAEX_CAEX_CLASSModel_TagNames">CAEX_CLASSModel_TagNames</a> has to be transformed to an <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xname" target="_parent" rel="noopener noreferrer">XName</a>, which is a combination of the element's name (called LocalName) and the <a href="P_Aml_Engine_Schema_AMLSchemaManager3_0_CAEXNamespace">CAEXNamespace</a>. For processing of CAEX 2.15 document's the elements name is still sufficient and the XName is build by an implicit conversion operator.</li></ul>

## Getting Started

To get started, add references to the AMLEngine DLLs to the project (a Visual Studio solution or project). The DLLs can be obtained as a single NuGet package via the NuGet extension in Visual Studio or loaded from the AutomationML web page. The package name for the new AMLEngine is AMLEngine2.1. The Identifier is Aml.Engine. The following DLLs are included in the package:
&nbsp;<ul><li>
AML.Engine.dll - contains the methods for CAEX document processing and AutoamtionML specific object processing.</li><li>
AML.Engine.Services.dll - contains services for advanced processing of AutomationML documents.</li></ul>&nbsp;
See the **AMLEngine Programming Guide** for some basic introductions to the API.
&nbsp;<ul><li>
Basic examples: <a href="basic">Basic code examples</a></li><li>
Using services: <a href="service">Advanced document processing using services</a></li><li>
Performance of queries: <a href="queries">Query Examples</a></li><li>
Document Validation: <a href="validation">Document Validation</a></li><li>
Adaption of legacy code: <a href="adaption">Adaption</a></li></ul>

## Getting the source code

The source code of the **AMLEngine2.1** is available for AutomationML members only. The current release can be obtained from the <a href="https://wiki.automationml.org/wiki/index.php/Special:Fileman?dir=%2F90%20Software%2F12AutomationMLEngineDotNet%2FPublicReleases/" rel="noopener noreferrer" title="AutomationML WIKI.">AutomationML WIKI.</a>



## Getting the binaries

The **AMLEngine2.1** is licensed under MIT License. The binaries are available for download from the <a href="https://www.automationml.org/o.red.c/dateien.html?cat=1" rel="noopener noreferrer">AutomationML download page</a> and from <a href="https://www.nuget.org/packages/Aml.Engine/" rel="noopener noreferrer">NuGet</a> as a direct download or with the usage of a NuGet client.



## See Also


#### Other Resources
<a href="basic">Basic code examples</a><br />