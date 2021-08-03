# InheritanceExtensions.DerivedClassDictionary Class
AutomationML 2.1 API 

This class can be used to improve the performance of the <a href="M_Aml_Engine_CAEX_Extensions_InheritanceExtensions_ClassIsDerivedFrom__1">ClassIsDerivedFrom(T)(CAEXDocument, String, String)</a> method. If your class library in the AML document is stable, it is possible to add the base classes, which are of interest, into the dictionary. After a class is registered, all derived classes of this class are fast accessible. If not longer needed or if the class library needs an update, the dictionary entries should be updated or removed.


## Inheritance Hierarchy
<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_parent" rel="noopener noreferrer">System.Object</a><br />&nbsp;&nbsp;<a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.dictionary-2" target="_parent" rel="noopener noreferrer">System.Collections.Generic.Dictionary</a>(<a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a>, <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.hashset-1" target="_parent" rel="noopener noreferrer">HashSet</a>(<a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a>))<br />&nbsp;&nbsp;&nbsp;&nbsp;Aml.Engine.CAEX.Extensions.InheritanceExtensions.DerivedClassDictionary<br />
**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public class DerivedClassDictionary : Dictionary<string, HashSet<string>>
```

**VB**<br />
``` VB
Public Class DerivedClassDictionary
	Inherits Dictionary(Of String, HashSet(Of String))
```

**C++**<br />
``` C++
public ref class DerivedClassDictionary : public Dictionary<String^, HashSet<String^>^>
```

The InheritanceExtensions.DerivedClassDictionary type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_InheritanceExtensions_DerivedClassDictionary__ctor">InheritanceExtensions.DerivedClassDictionary</a></td><td>
Initializes a new instance of the InheritanceExtensions.DerivedClassDictionary class</td></tr></table>&nbsp;
<a href="#inheritanceextensions.derivedclassdictionary-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_Extensions_InheritanceExtensions_DerivedClassDictionary_AddClassDerivations">AddClassDerivations</a></td><td>
Adds the class derivations for the specified class path to the dictionary.</td></tr></table>&nbsp;
<a href="#inheritanceextensions.derivedclassdictionary-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />