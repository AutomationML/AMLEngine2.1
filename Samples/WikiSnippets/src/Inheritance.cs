// Copyright (c) 2021 Josef Prinz. All rights reserved.
// Licensed under the MIT License, see License.txt in the project root for license information.

using Aml.Engine.CAEX;
using Aml.Engine.CAEX.Extensions;
using Aml.Engine.Services;
using System.Diagnostics;
using System.Linq;

namespace Aml.Engine.Wiki.Snippets
{
    /// <summary>
    /// Inheritance samples: <see href="https://github.com/AutomationML/AMLEngine2.1/wiki/Inheritance
    /// </summary>
    internal static class Inheritance
    {
        /// <summary>
        /// <see href="https://github.com/AutomationML/AMLEngine2.1/wiki/Inheritance#Inheritance-of-SystemUnitClasses"/>
        /// </summary>
        /// <param name="document"></param>
        internal static void CreateSystemUnitClassInheritance(CAEXDocument document)
        {
            // adding a Class library and some classes
            var systemUnitClassLib = document.CAEXFile.SystemUnitClassLib.Append("Slib");
            var suc1 = systemUnitClassLib.SystemUnitClass.Append("s1");
            var suc2 = systemUnitClassLib.SystemUnitClass.Append("s2");
            var suc3 = systemUnitClassLib.SystemUnitClass.Append("s3");

            // suc2 becomes a sub class from suc1
            suc2.BaseClass = suc1;

            // suc3 becomes a sub class from suc2
            suc3.BaseClass = suc2;

            // get the inheritance hierarchy from suc3 (the base classes)
            var inheritanceHierarchy = suc3.GetReferenceHierarchy().ToArray();

            Debug.Assert(inheritanceHierarchy[0] == suc3);
            Debug.Assert(inheritanceHierarchy[1] == suc2);
            Debug.Assert(inheritanceHierarchy[2] == suc1);

            // gets the sub classes from suc1 (this also includes the sub-sub classes and further)
            var s = ServiceLocator.QueryService.AllClassReferencesDeep(suc1);

            Debug.Assert(s.Count() == 2);
        }

        /// <summary>
        /// <see href="https://github.com/AutomationML/AMLEngine2.1/wiki/Inheritance#Overriding-inherited-elements"/>
        /// </summary>
        /// <param name="document"></param>
        internal static void CreateOverridenAttributes(CAEXDocument document)
        {
            // adding a Class library and some classes
            var systemUnitClassLib = document.CAEXFile.SystemUnitClassLib.Append("Slib2");
            var suc1 = systemUnitClassLib.SystemUnitClass.Append("s1");
            var suc2 = systemUnitClassLib.SystemUnitClass.Append("s2");
            var suc3 = systemUnitClassLib.SystemUnitClass.Append("s3");
            var suc4 = systemUnitClassLib.SystemUnitClass.Append("s4");

            // suc1 is defined a base class of all other classes
            suc2.BaseClass = suc3.BaseClass = suc4.BaseClass = suc1;

            // adds an attribute to the base class
            var baseAtt = suc1.Attribute.Append("att1");

            // the added attribute is visible in all sub classes
            Debug.Assert(suc2.GetInheritedAttributes().Count() == 1);
            Debug.Assert(suc2.GetInheritedAttributes().First() == baseAtt);

            // this overrides the base class attribute 'att1'
            var overridenAtt = suc3.Attribute.Append("att1");

            // there is still only one attribute in the inheriance tree
            Debug.Assert(suc3.GetInheritedAttributes().Count() == 1);
            Debug.Assert(suc3.GetInheritedAttributes().First() == overridenAtt);

            // this deletes the inherited attribute from s4
            suc4.DeleteInheritedElement("att1", baseAtt.GetType());
            Debug.Assert(suc4.GetInheritedAttributes().Count() == 0);
        }

        /// <summary>
        /// <see href="https://github.com/AutomationML/AMLEngine2.1/wiki/Inheritance#Inheritance-relations-in-role-references"/>
        /// </summary>
        /// <param name="document"></param>
        internal static void CheckRoleReference(CAEXDocument document)
        {
            // adding a SystemUnitClass library and one class
            var systemUnitClassLib = document.CAEXFile.SystemUnitClassLib.Append("Slib3");
            var suc1 = systemUnitClassLib.SystemUnitClass.Append("s1");

            // adding a RoleClass library and some classes with inheritance relations
            var roleClassLib = document.CAEXFile.RoleClassLib.Append("Rlib");
            var role1 = roleClassLib.RoleClass.Append("r1");
            var role2 = roleClassLib.RoleClass.Append("r2");
            var role3 = roleClassLib.RoleClass.Append("r3");

            // role2 is sub-class of role1
            role2.BaseClass = role1;

            // role3 is sub-class of role2
            role3.BaseClass = role2;

            // assign role2 to the SystemUnitClass suc1, the role is added as a SupportedRoleClass
            suc1.AddRoleClassReference(role2);

            // according to the inheritance relation between role1 and role2 the SystemUnitClass owns
            // a derived relation to role1 as well
            var hasSupportedRole = suc1.HasRoleClassReference(role1, regardInheritanceOfRoleClasses: true);
            Debug.Assert(hasSupportedRole);

            // according to the inheritance relation between role2 and role3 the SystemUnitClass can be checked
            // for support of a generic role of role3, when no direct support of role3 exists.
            var supportsGenericRole = suc1.HasGenericRoleClassReference(role3);
            Debug.Assert(supportsGenericRole);
        }
    }
}