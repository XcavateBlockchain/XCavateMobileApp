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


namespace PolkadotAssetHub.NetApi.Generated.Model.frame_support.dispatch
{
    
    
    /// <summary>
    /// >> RawOrigin
    /// </summary>
    public enum RawOrigin
    {
        
        /// <summary>
        /// >> Root
        /// </summary>
        Root = 0,
        
        /// <summary>
        /// >> Signed
        /// </summary>
        Signed = 1,
        
        /// <summary>
        /// >> None
        /// </summary>
        None = 2,
    }
    
    /// <summary>
    /// >> 385 - Variant[frame_support.dispatch.RawOrigin]
    /// </summary>
    public sealed class EnumRawOrigin : BaseEnumRust<RawOrigin>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumRawOrigin()
        {
				AddTypeDecoder<BaseVoid>(RawOrigin.Root);
				AddTypeDecoder<PolkadotAssetHub.NetApi.Generated.Model.sp_core.crypto.AccountId32>(RawOrigin.Signed);
				AddTypeDecoder<BaseVoid>(RawOrigin.None);
        }
    }
}