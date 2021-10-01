// Copyright (c) 2021 Josef Prinz. All rights reserved.
// Licensed under the MIT License, see License.txt in the project root for license information.

using Aml.Engine.CAEX;
using Aml.Engine.CAEX.Extensions;
using Aml.Engine.Services;

namespace Aml.Engine.Wiki.Snippets
{
    /// <summary>
    /// Basic samples: <see href="https://github.com/AutomationML/AMLEngine2.1/wiki/Basic
    /// </summary>
    internal static class Basic
    {
        /// <summary>
        /// <see href="https://github.com/AutomationML/AMLEngine2.1/wiki/Basic#Removal-of-Elements"/>
        /// </summary>
        /// <param name="document"></param>
        internal static void RemoveElements(CAEXDocument document)
        {
            // adding a Class library and some classes organized in a class tree
            var systemUnitClassLib = document.CAEXFile.SystemUnitClassLib.Append("modified original");
            var suc1 = systemUnitClassLib.SystemUnitClass.Append("s1");
            var suc2 = systemUnitClassLib.SystemUnitClass.Append("s2");
            var suc3 = systemUnitClassLib.SystemUnitClass.Append("s3");
            var suc4 = systemUnitClassLib.SystemUnitClass.Append("s4");

            // suc2 becomes a sub class from suc1
            suc2.BaseClass = suc1;
            // suc3 becomes a sub class from suc2
            suc3.BaseClass = suc2;
            // suc4 becomes a sub class from suc3
            suc4.BaseClass = suc3;

            // copy everything to another class library (as a backup)
            var backup = systemUnitClassLib.CopyAndChangeReferences(document.CAEXFile, "copied original");

            // this will remove the class suc2 and the base class relation in suc3
            suc2.Remove(removeRelations: true);

            // copy the remaining to another class library (to see the result)
            var remaining = systemUnitClassLib.CopyAndChangeReferences(document.CAEXFile, "remove suc2 with relation");

            // this will remove the class suc3 but not the base class relation in suc4
            suc3.Remove(removeRelations: false);
        }

        private static CAEXObject Copy (this CAEXObject source, string name)
        {
            var copy = source.Copy() as CAEXObject;
            copy.Name = name;
            return copy;
        }

        /// <summary>
        /// <see href="https://github.com/AutomationML/AMLEngine2.1/wiki/Basic#Insertion-of-Elements"/>
        /// </summary>
        /// <param name="document"></param>
        internal static void InsertElements(CAEXDocument document)
        {
            // adding a Class library and a class with element and attribute
            var systemUnitClassLib = document.CAEXFile.SystemUnitClassLib.Append("Slib");
            var suc1 = systemUnitClassLib.SystemUnitClass.Append("s1");
            var element = suc1.InternalElement.Append("element1");
            var attribute = suc1.Attribute.Append("attribute1");

            // insert an element copy to the class; the element is automatically
            // appended to the InternalElement collection of the class.
            suc1.Insert(element.Copy("afterElement1"), asFirst: false);

            // inserts a copy of the element before the element.
            element.InsertBefore((InternalElementType)element.Copy("beforeElement1"));

            // inserts a copy of the element at position 1 of the InternalElement collection
            // (it becomes the 2nd. element in the collection)
            suc1.InternalElement.InsertAt(1, (InternalElementType)element.Copy("atPosition1"));

            // inserts an attribute copy at the first position
            suc1.Insert(attribute.Copy("firstAttribute"), asFirst: true);
        }

        private static void ChangeNameAndReferences<T>(this IClassWithBaseClassReference<T> source, string name) where T : CAEXObject
        {
            var references = source.CAEXDocument().ElementsWithCAEXPathReference(source.CAEXPath());
            source.Name = name;
            var path = source.CAEXPath();
            foreach (var reference in references)
            {
                reference.CaexObject.SetXAttributeValue(reference.ReferenceAttributeName, path);
            }
        }


        /// <summary>
        /// <see href="https://github.com/AutomationML/AMLEngine2.1/wiki/Basic#Copying-Elements"/>
        /// </summary>
        /// <param name="document"></param>
        internal static void CopyElements(CAEXDocument document)
        {
            // adding a Class library and some classes organized in a class tree
            var systemUnitClassLib = document.CAEXFile.SystemUnitClassLib.Append("SLib");
            var suc1 = systemUnitClassLib.SystemUnitClass.Append("s1");
            var suc2 = suc1.SystemUnitClass.Append("s2");
            suc2.SystemUnitClass.Append("s3").BaseClass = suc2;

            // adding some elements to the class
            suc1.InternalElement.Append("ie1");

            // copies the full class tree including the elements
            var suc1Tree = suc1.Copy(deepCopy: true, assignNewIDs: true, includeSubClasses: true);
            ((CAEXObject)suc1Tree).Name = "s1_TreeCopy";
            systemUnitClassLib.Insert(suc1Tree, false);

            // copies the full class tree including the elements and redirect class reference
            _ = suc1.CopyTreeAndChangeReferences (systemUnitClassLib, "s1_TreeCopyWithRedirectedRelations");

            // change the name of suc2 and update the references
            suc2.ChangeNameAndReferences("s2_source");
            
            // copies only suc1, omitting the nested classes
            var suc1Class = suc1.Copy(deepCopy: true, true, false);
            ((CAEXObject)suc1Class).Name = "s1_ClassCopy";
            systemUnitClassLib.Insert(suc1Class, false);

            // copies only suc1, omitting the nested classes and elements
            var suc1ClassWithoutElements = suc1.Copy(deepCopy: false, true, false);
            ((CAEXObject)suc1ClassWithoutElements).Name = "s1_ClassOnlyCopy";
            systemUnitClassLib.Insert(suc1ClassWithoutElements, false);
        }
    }
}