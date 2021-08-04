# Adaption of legacy code.


### Adaption of legacy code based on AMLEngine v3.x.x and ALTOVA DLLs
&nbsp;
<ol>
<li>
Select the appropriate migration strategy


First, the appropriate migration strategy must be determined. Which strategy is suitable depends on the complexity of the code to be migrated. If there are large dependencies on the underlying memory model of the Altova Engine, which is based on the .NET System.Xml namespace, it might be better to use the adaption features, provided by specific [Adaption Methods](Documentation/Aml.Engine.Adapter/README.md). If you mainly use the base classes of the CAEX_ClassModel namespace, direct migration can take place without using the special adapter methods, to avoid getting the obsolete warnings during building.

</li>

<li>
Direct Migration
&nbsp;
<ul>

<li>

Modification of using directives:
- Replace **CAEX_ClassModel** with [Aml.Engine.CAEX](Documentation/Aml.Engine.CAEX/README.md).
- Add [Aml.Engine.CAEX.Extensions](Documentation/Aml.Engine.CAEX.Extensions/README.md). 
- Replace **AMLEngineExtensions** with [Aml.Engine.AmlObjects](Documentation/Aml.Engine.AmlObjects/README.md).
- Add [Aml.Engine.AmlObjects.Extensions](Documentation/Aml.Engine.AmlObjects.Extensions/README.md).

To use special services like fast Access Methods, Split and Merge or Document validation the additional namespace [Aml.Engine.Services](Documentation/Aml.Engine.Services/README.md) has to be included. As an example, the Schema Transformation service, which can be used to transform AutomationML documents from version 2.0 to version 2.10 (based on CAEX3.0) is provided in the Aml.Engine.Services namespace.
</li>

<li>

- All Altova namespaces must be removed, because the AMLEngine2.1 is not generated using Altova software anymore. If Altova types are used in your code these types must be replaced manually. The formerly used base class for all CAEX objects was **Altova.Xml.TypeBase**. This class is replaced with the class [CAEXWrapper](Documentation/Aml.Engine.CAEX/CAEXWrapper/README.md). 
- Any usages of member element types like **MemberElement_InternalElement** in iterations or declarations can mostly be replaced by a variable declaration or the concrete element type like InternalElementType.
- The **CAEX_ClassModel.xs.anyType** has to be replaced with the string type or – in the accessors of AdditonalInformation elements with the object type. 

The underlying memory model in the Altova based classes depends on the <a href="https://docs.microsoft.com/dotnet/api/system.xml" target="_parent" rel="noopener noreferrer">System.Xml</a> namespace. The AMLEngine2.1 is based on the <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq" target="_parent" rel="noopener noreferrer">System.Xml.Linq</a> namespace. If there are dependencies in your application code to the System.Xml namespace replace and change these dependencies using the System.Xml.Linq namespace. In most cases, you can try to substitute the classes:
&nbsp;
<ul>
<li>
XmlNode => XElement
</li>
<li>
XmlAttribute => XAttribute
</li>
<li>
XmlDocument => XDocument
</li>
</ul>
</li>
<li>

The old engine always uses classes as wrappers to access XML attributes. In the new engine, attributes like the object [ID](Documentation/Aml.Engine.CAEX/ICAEXObject/ID.md) or the object [Name](Documentation/Aml.Engine.CAEX/ICAEXObject/Name.md) are directly accessible as value types. Also XML elements representing single values like [Description](Documentation/Aml.Engine.CAEX/CAEXBasicObject/Description.md) are accessible as value types. 
The consequence is, that there exist no member accessors for these CAEX attributes and elements. A formerly coded assignment like _element.Name.Value=”IE”_ has to be replaced by _element.Name=”IE”_. An existence test like 
_element.Name.Exists()_ has to be replaced by _string.IsNullOrEmpty(element.Name)_.
</li>

<li>
  
Access to specific AMLObjects and specific AMLAttributes has been modified. The new engine doesn't mix AMLAttributes with basic CAEX classes. As an example you cannot access a FrameAttribute using a defined property of an InternalElement. To access specific AML Attributes or AML Objects implicit or explicit type conversion methods are provided. The SystemUnitClass defines this
implicit [type conversion operator ObjectWithAMLAttribute](Documentation/Aml.Engine.CAEX/SystemUnitClassType/op_Implicit.md) to access the
[specific AutomationML Attributes of an object](Documentation/Aml.Engine.AmlObjects/ObjectWithAMLAttributes/README.md). To access an AutomationML Attribute
like for instance the [FrameAttribute](Documentation/Aml.Engine.AmlObjects/ObjectWithAMLAttributes/FrameAttribute.md) of an InternalElement, use a Type cast like: _((ObjectWithAMLAttributes)internalElment).FrameAttribute_.
  
</li>
  
</ul>
</li>
</ol>
&nbsp;
