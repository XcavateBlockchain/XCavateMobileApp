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


namespace Hydration.NetApi.Generated.Model.pallet_lbp.pallet
{
    
    
    /// <summary>
    /// >> Event
    /// The `Event` enum of this pallet
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> PoolCreated
        /// Pool was created by the `CreatePool` origin.
        /// </summary>
        PoolCreated = 0,
        
        /// <summary>
        /// >> PoolUpdated
        /// Pool data were updated.
        /// </summary>
        PoolUpdated = 1,
        
        /// <summary>
        /// >> LiquidityAdded
        /// New liquidity was provided to the pool.
        /// </summary>
        LiquidityAdded = 2,
        
        /// <summary>
        /// >> LiquidityRemoved
        /// Liquidity was removed from the pool and the pool was destroyed.
        /// </summary>
        LiquidityRemoved = 3,
        
        /// <summary>
        /// >> SellExecuted
        /// Sale executed.
        /// </summary>
        SellExecuted = 4,
        
        /// <summary>
        /// >> BuyExecuted
        /// Purchase executed.
        /// </summary>
        BuyExecuted = 5,
    }
    
    /// <summary>
    /// >> 113 - Variant[pallet_lbp.pallet.Event]
    /// The `Event` enum of this pallet
    /// </summary>
    public sealed class EnumEvent : BaseEnumRust<Event>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumEvent()
        {
				AddTypeDecoder<BaseTuple<Hydration.NetApi.Generated.Model.sp_core.crypto.AccountId32, Hydration.NetApi.Generated.Model.pallet_lbp.Pool>>(Event.PoolCreated);
				AddTypeDecoder<BaseTuple<Hydration.NetApi.Generated.Model.sp_core.crypto.AccountId32, Hydration.NetApi.Generated.Model.pallet_lbp.Pool>>(Event.PoolUpdated);
				AddTypeDecoder<BaseTuple<Hydration.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128>>(Event.LiquidityAdded);
				AddTypeDecoder<BaseTuple<Hydration.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128>>(Event.LiquidityRemoved);
				AddTypeDecoder<BaseTuple<Hydration.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U128>>(Event.SellExecuted);
				AddTypeDecoder<BaseTuple<Hydration.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U128>>(Event.BuyExecuted);
        }
    }
}