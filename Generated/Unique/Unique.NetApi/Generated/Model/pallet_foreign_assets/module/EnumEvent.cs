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


namespace Unique.NetApi.Generated.Model.pallet_foreign_assets.module
{
    
    
    /// <summary>
    /// >> Event
    /// The `Event` enum of this pallet
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> ForeignAssetRegistered
        /// The foreign asset registered.
        /// </summary>
        ForeignAssetRegistered = 0,
    }
    
    /// <summary>
    /// >> 364 - Variant[pallet_foreign_assets.module.Event]
    /// The `Event` enum of this pallet
    /// </summary>
    public sealed class EnumEvent : BaseEnumRust<Event>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumEvent()
        {
				AddTypeDecoder<BaseTuple<Unique.NetApi.Generated.Model.up_data_structs.CollectionId, Unique.NetApi.Generated.Model.xcm.EnumVersionedAssetId>>(Event.ForeignAssetRegistered);
        }
    }
}
