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


namespace Unique.NetApi.Generated.Model.cumulus_pallet_dmp_queue.pallet
{
    
    
    /// <summary>
    /// >> Event
    /// The `Event` enum of this pallet
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> InvalidFormat
        /// Downward message is invalid XCM.
        /// </summary>
        InvalidFormat = 0,
        
        /// <summary>
        /// >> UnsupportedVersion
        /// Downward message is unsupported version of XCM.
        /// </summary>
        UnsupportedVersion = 1,
        
        /// <summary>
        /// >> ExecutedDownward
        /// Downward message executed with the given outcome.
        /// </summary>
        ExecutedDownward = 2,
        
        /// <summary>
        /// >> WeightExhausted
        /// The weight limit for handling downward messages was reached.
        /// </summary>
        WeightExhausted = 3,
        
        /// <summary>
        /// >> OverweightEnqueued
        /// Downward message is overweight and was placed in the overweight queue.
        /// </summary>
        OverweightEnqueued = 4,
        
        /// <summary>
        /// >> OverweightServiced
        /// Downward message from the overweight queue was executed.
        /// </summary>
        OverweightServiced = 5,
        
        /// <summary>
        /// >> MaxMessagesExhausted
        /// The maximum number of downward messages was reached.
        /// </summary>
        MaxMessagesExhausted = 6,
    }
    
    /// <summary>
    /// >> 359 - Variant[cumulus_pallet_dmp_queue.pallet.Event]
    /// The `Event` enum of this pallet
    /// </summary>
    public sealed class EnumEvent : BaseEnumRust<Event>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumEvent()
        {
				AddTypeDecoder<Unique.NetApi.Generated.Types.Base.Arr32U8>(Event.InvalidFormat);
				AddTypeDecoder<Unique.NetApi.Generated.Types.Base.Arr32U8>(Event.UnsupportedVersion);
				AddTypeDecoder<BaseTuple<Unique.NetApi.Generated.Types.Base.Arr32U8, Unique.NetApi.Generated.Types.Base.Arr32U8, Unique.NetApi.Generated.Model.xcm.v3.traits.EnumOutcome>>(Event.ExecutedDownward);
				AddTypeDecoder<BaseTuple<Unique.NetApi.Generated.Types.Base.Arr32U8, Unique.NetApi.Generated.Types.Base.Arr32U8, Unique.NetApi.Generated.Model.sp_weights.weight_v2.Weight, Unique.NetApi.Generated.Model.sp_weights.weight_v2.Weight>>(Event.WeightExhausted);
				AddTypeDecoder<BaseTuple<Unique.NetApi.Generated.Types.Base.Arr32U8, Unique.NetApi.Generated.Types.Base.Arr32U8, Substrate.NetApi.Model.Types.Primitive.U64, Unique.NetApi.Generated.Model.sp_weights.weight_v2.Weight>>(Event.OverweightEnqueued);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U64, Unique.NetApi.Generated.Model.sp_weights.weight_v2.Weight>>(Event.OverweightServiced);
				AddTypeDecoder<Unique.NetApi.Generated.Types.Base.Arr32U8>(Event.MaxMessagesExhausted);
        }
    }
}
