// Copyright (c) 2021 Josef Prinz. All rights reserved.
// Licensed under the MIT License, see License.txt in the project root for license information.

using Aml.Engine.CAEX;

namespace Samples
{
    /// <summary>
    /// This class provides sample methods to add child objects to aml objects
    /// </summary>
    internal static class AMLObjectChildren
    {
        /// <summary>
        /// Adds internal element children to the provided container.
        /// InternalElement containers are InternalElements and InstanceHierarchies.
        /// </summary>
        /// <param name="container">The container.</param>
        internal static void AddElementChildren(IInternalElementContainer container, ref int levels)
        {
            // add a single child
            var newElement = AMLObject.AddObjectWithoutClassReference(container, "Child_1");
            if (levels > 0)
            {
                // add some grand childs, if last level not reached
                levels--;
                AddElementChildren(newElement, ref levels);
            }

            // add a child using an alternative method
            AMLObject.AddObjectWithClassReference(container, "Child_2");
        }
    }
}