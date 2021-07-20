using Aml.Engine.CAEX;
using Aml.Engine.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples
{
    /// <summary>
    /// This class provides sample methods to create and query aml object relations with InternalLinks
    /// </summary>
    internal static class AMLObjectRelations
    {
        /// <summary>
        /// Creates the aml object relation between the provided partners if they are not aready linked
        /// </summary>
        /// <param name="aPartner">a partner.</param>
        /// <param name="bPartner">The b partner.</param>
        /// <returns></returns>
        internal static bool CreateAMLObjectRelationIfUnrelated (ExternalInterfaceType aPartner, ExternalInterfaceType bPartner)
        {
            // we don't want to link interfaces of the same aml object
            if (aPartner.AssociatedObject.Equals(bPartner.AssociatedObject))
            {
                return false;
            }

            // we don`t want to create more than one link from an already linked object
            if (aPartner.InternalLinksToInterface().Count() > 0)
            {
                return false;
            }

            // we don`t want to create more than one link from an already linked object
            if (bPartner.InternalLinksToInterface().Count() > 0)
            {
                return false;
            }

            return InternalLinkType.New_InternalLink(aPartner, bPartner, "AmlRelation").Exists;
        }
    }
}
