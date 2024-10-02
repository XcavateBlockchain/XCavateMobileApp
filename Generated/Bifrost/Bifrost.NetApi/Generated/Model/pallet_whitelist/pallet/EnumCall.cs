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


namespace Bifrost.NetApi.Generated.Model.pallet_whitelist.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> whitelist_call
        /// </summary>
        whitelist_call = 0,
        
        /// <summary>
        /// >> remove_whitelisted_call
        /// </summary>
        remove_whitelisted_call = 1,
        
        /// <summary>
        /// >> dispatch_whitelisted_call
        /// </summary>
        dispatch_whitelisted_call = 2,
        
        /// <summary>
        /// >> dispatch_whitelisted_call_with_preimage
        /// </summary>
        dispatch_whitelisted_call_with_preimage = 3,
    }
    
    /// <summary>
    /// >> 137 - Variant[pallet_whitelist.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumRust<Call>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumCall()
        {
				AddTypeDecoder<Bifrost.NetApi.Generated.Model.primitive_types.H256>(Call.whitelist_call);
				AddTypeDecoder<Bifrost.NetApi.Generated.Model.primitive_types.H256>(Call.remove_whitelisted_call);
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.primitive_types.H256, Substrate.NetApi.Model.Types.Primitive.U32, Bifrost.NetApi.Generated.Model.sp_weights.weight_v2.Weight>>(Call.dispatch_whitelisted_call);
				AddTypeDecoder<Bifrost.NetApi.Generated.Model.bifrost_polkadot_runtime.EnumRuntimeCall>(Call.dispatch_whitelisted_call_with_preimage);
        }
    }
}