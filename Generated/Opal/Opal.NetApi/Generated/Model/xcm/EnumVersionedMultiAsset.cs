//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace Opal.NetApi.Generated.Model.xcm
{
    
    
    /// <summary>
    /// >> VersionedMultiAsset
    /// </summary>
    public enum VersionedMultiAsset
    {
        
        /// <summary>
        /// >> V2
        /// </summary>
        V2 = 1,
        
        /// <summary>
        /// >> V3
        /// </summary>
        V3 = 3,
    }
    
    /// <summary>
    /// >> 136 - Variant[xcm.VersionedMultiAsset]
    /// </summary>
    public sealed class EnumVersionedMultiAsset : BaseEnumRust<VersionedMultiAsset>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumVersionedMultiAsset()
        {
				AddTypeDecoder<Opal.NetApi.Generated.Model.xcm.v2.multiasset.MultiAsset>(VersionedMultiAsset.V2);
				AddTypeDecoder<Opal.NetApi.Generated.Model.xcm.v3.multiasset.MultiAsset>(VersionedMultiAsset.V3);
        }
    }
}