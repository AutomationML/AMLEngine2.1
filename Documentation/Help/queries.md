# Query Examples
This topic contains the following sections:
&nbsp;<ul><li><a href="#basic-queries">Basic queries</a></li>&nbsp;
<li><a href="#query-class-to-class-relations">Query class to class relations</a></li>&nbsp;
<li><a href="#query-class-to-instance-relations">Query class to instance relations</a></li>&nbsp;
<li><a href="#query-instance-to-instance-relations">Query instance to instance relations</a></li>&nbsp;
<li><a href="#see-also">See Also</a></li></ul>&nbsp;
Queries are often applied to get specific information from an AML document which cannot be supplied by a class member or a property. The Aml.Engine supports queries with the provision of a query service interface. The Aml.Engine contains two implementation of the query service interface <a href="T_Aml_Engine_Services_Interfaces_IQuery">IQuery</a>. The main purpose of the Query service is it, to find related objects (Class to Class, Instance to Class and Instance to Instance relations).


The implementation <a href="T_Aml_Engine_Services_QueryService">QueryService</a> is the registered default query service. The implementation is based on System.Xml.Linq integrated Query language. The second implementation <a href="T_Aml_Engine_Services_LookupService">LookupService</a> uses lookup tables and indexed based access to query objects. This service performs faster in most queries but needs additional memory space and an initialization phase to build the lookup tables. The tables are automatically updated when the AML document is modified.


To use the default System.Xml.Linq based Query service no programing is required. To access this service, the property <a href="P_Aml_Engine_Services_ServiceLocator_QueryService">QueryService</a> can be used. To use the table based LookupService, the registration method of the LookupService shall be called. 
**C#**<br />
``` C#
var service = LookupService.Register();

// after registration, the service locator has changed the query service property
Assert.AreEqual (service, Aml.Engine.Services.ServiceLocator.QueryService);
```
 After registration, all queries including those which are called by the Aml.Engine will be performed by the LookupService. To switch back to the default System.Xml.Linq based Query service, the LookupService shall be unregistered. 
**C#**<br />
``` C#
LookupService.UnRegister();

// after unregistration, the service locator has changed the query service property again
Assert.IsTrue (Aml.Engine.Services.ServiceLocator.QueryService is Aml.Engine.Services.QueryService);
```
 After unregistration, all queries including those which are called by the Aml.Engine will be performed by the default System.Xml.Linq base Query service again. Please note, that the Service locator will always allow only a single service registered for a service interface type. If the LookupService should be your preferred query service, leave it registered as long as it is used. This service needs to create tables to locate objects. If the service is unregistered the service and its tables are disposed. If it is registered again, all tables have to be rebuild.



## Basic queries

The most common queries are querying a CAEX object by an ID or a Path.



## Example

**FindByID example**<br />
``` C#
using Aml.Engine.Services;
using Aml.Engine.CAEX.Extensions;

CAEXObject FindByID (CAEXDocument document, InternalElementType internalElement)
{
    // this is a document extension method
    var caexObj_1 = document.FindByID (internalElement.ID);
    // this is the equivalent method
    var caexObj_2 = ServiceLocator.QueryService.FindByID (document, internalElement.ID);

    Assert.AreEqual (caexObj_1, caexObj_2);
    Assert.AreEqual (caexObj_1, internalElement);
    return caexObj_1;
}
```

**FindByPath example**<br />
``` C#
using Aml.Engine.Services;
using Aml.Engine.CAEX.Extensions;


// Try to find the referenced SystemUnitClass of an InternalElement.             
CAEXObject FindByPath (CAEXDocument document, InternalElementType internalElement)
{
    // this is a document extension method
    var caexObj_1 = document.FindByPath (internalElement.RefBaseSystemUnitPath);
    // this is the equivalent method
    var caexObj_2 = ServiceLocator.QueryService.FindByPath (document, internalElement.RefBaseSystemUnitPath);

    Assert.AreEqual (caexObj_1, caexObj_2);

    // The InternalElementType contains a property which can be used to get and set the SystemUnitClass
    Assert.AreEqual (caexObj_1, internalElement.SystemUnitClass);
    return caexObj_1;
}
```

<a href="#query-examples">Back to the Top</a>



## Query class to class relations

Class to Class relations are inheritance relations.



## Example

**First generation of derived classes**<br />
``` C#
using Aml.Engine.Services;

// get the first generation of derived role classes from the specified role class
void GetDerivedFirstGeneration (RoleFamilyType roleClass)
{
    var derivedClasses = ServiceLocator.QueryService.AllClassReferences (roleClass);
}
```

**All generations of derived classes**<br />
``` C#
using Aml.Engine.Services;

// get the first and all following generations of derived role classes from the specified role class
void GetDerivedFirstGeneration (RoleFamilyType roleClass)
{
    var derivedClasses = ServiceLocator.QueryService.AllClassReferencesDeep (roleClass);
}
```

<a href="#query-examples">Back to the Top</a>



## Query class to instance relations

A Class to Instance relations is always defined using a class path as a value in any Attribute of a CAEX object, which is not a class (InternalElement, ExternalInterface, Attribute, RoleRequirement, SupportedRoleClass). You have to either provide a full CAEX path or the CAEX class object itself as a parameter of a query.



## Example

**ExternalInterface Instances of an InterfaceClass**<br />
``` C#
using Aml.Engine.Services;
using Aml.Engine.AmlObjects;
using Aml.Engine.CAEX;

// Get all ExternalInterfaces, which are ExternalDataConnectors, including those ExternalInterfaces,
// which reference a derived class from an ExternalDataConnector.
// This method is appropriate, to get a collection of external sources.
void GetAllExternalDataConnectorInstances (CAEXDocument document)
{                  
    var externalInterfaces = ServiceLocator.QueryService.AllClassReferencesDeep(document, 
                   AutomationMLInterfaceClassLib.ExternalDataConnector, CAEX_CLASSModel_TagNames.EXTERNAL_INTERFACE);

    foreach (var externalInterface in externalInterfaces)
    {
         var refUriAttribute = ((ObjectWithAMLAttribute)externalInterface).RefURIAttribute;
         if (refUriAttribute != null)
         {
             Console.WriteLine (refUriAttribute.Value);
         }
    }
}
```

<a href="#query-examples">Back to the Top</a>



## Query instance to instance relations

An Instance to Instance relation is always defined using an InternalLink. The Query Interface contains special queries to explore Instance to Instance Relations.



## Example

**InternalLinks connected to an ExternalInterface**<br />
``` C#
using Aml.Engine.Services;
using Aml.Engine.AmlObjects;
using Aml.Engine.CAEX;

// Get all InternalLinks, which are attached to an ExternalInterface. 
// This method is appropriate, to get a collection of related ExternalInterfaces.

IEnumerable<ExternalInterfaceType> GetAllRelatedExternalInterfaces(ExternalInterfaceType externalInterface)
{
  var internalLinks = ServiceLocator.QueryService.InternalLinksToInterface(externalInterface);

  // or use the equivalent extension method externalInterface.InternalLinksToInterface();

  foreach (var internalLink in internalLinks)
  {
    if (internalLink.AInterface.Equals(externalInterface)
      yield return internalLink.BInterface;
    else
      yield return internalLink.AInterface;
  }
}
```

<a href="#query-examples">Back to the Top</a>



## See Also


#### Reference
<a href="M_Aml_Engine_Services_Interfaces_IQuery_FindByID">FindByID</a><br /><a href="M_Aml_Engine_CAEX_Extensions_CAEXDocumentExtensions_FindByID">FindByID</a><br /><a href="M_Aml_Engine_CAEX_Extensions_CAEXDocumentExtensions_FindByPath">FindByPath</a><br /><a href="M_Aml_Engine_Services_Interfaces_IQuery_FindByPath">FindByPath</a><br /><a href="Overload_Aml_Engine_Services_Interfaces_IQuery_AllClassReferences">AllClassReferences</a><br /><a href="Overload_Aml_Engine_Services_Interfaces_IQuery_AllClassReferencesDeep">AllClassReferencesDeep</a><br /><a href="F_Aml_Engine_AmlObjects_AutomationMLInterfaceClassLib_ExternalDataConnector">ExternalDataConnector</a><br /><a href="M_Aml_Engine_Services_QueryResult_InternalLinksToInterface">InternalLinksToInterface</a><br /><a href="M_Aml_Engine_Services_Interfaces_IQuery_InternalLinksToInterface">InternalLinksToInterface</a><br />