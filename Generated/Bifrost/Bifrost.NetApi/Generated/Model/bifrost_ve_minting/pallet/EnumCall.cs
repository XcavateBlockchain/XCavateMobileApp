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


namespace Bifrost.NetApi.Generated.Model.bifrost_ve_minting.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> set_config
        /// </summary>
        set_config = 0,
        
        /// <summary>
        /// >> create_lock
        /// </summary>
        create_lock = 1,
        
        /// <summary>
        /// >> increase_amount
        /// </summary>
        increase_amount = 2,
        
        /// <summary>
        /// >> increase_unlock_time
        /// </summary>
        increase_unlock_time = 3,
        
        /// <summary>
        /// >> withdraw
        /// </summary>
        withdraw = 4,
        
        /// <summary>
        /// >> notify_rewards
        /// </summary>
        notify_rewards = 5,
        
        /// <summary>
        /// >> get_rewards
        /// </summary>
        get_rewards = 6,
        
        /// <summary>
        /// >> redeem_unlock
        /// </summary>
        redeem_unlock = 7,
        
        /// <summary>
        /// >> set_markup_coefficient
        /// </summary>
        set_markup_coefficient = 8,
        
        /// <summary>
        /// >> deposit_markup
        /// </summary>
        deposit_markup = 9,
        
        /// <summary>
        /// >> withdraw_markup
        /// </summary>
        withdraw_markup = 10,
        
        /// <summary>
        /// >> refresh
        /// </summary>
        refresh = 11,
    }
    
    /// <summary>
    /// >> 418 - Variant[bifrost_ve_minting.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumRust<Call>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumCall()
        {
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32>>>(Call.set_config);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U32>>(Call.create_lock);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128>>(Call.increase_amount);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U32>>(Call.increase_unlock_time);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U128>(Call.withdraw);
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Primitive.U128>>>>(Call.notify_rewards);
				AddTypeDecoder<BaseVoid>(Call.get_rewards);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U128>(Call.redeem_unlock);
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.sp_arithmetic.fixed_point.FixedU128, Bifrost.NetApi.Generated.Model.sp_arithmetic.fixed_point.FixedU128>>(Call.set_markup_coefficient);
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Primitive.U128>>(Call.deposit_markup);
				AddTypeDecoder<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId>(Call.withdraw_markup);
				AddTypeDecoder<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId>(Call.refresh);
        }
    }
}