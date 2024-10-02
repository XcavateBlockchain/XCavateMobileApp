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


namespace InvArch.NetApi.Generated.Model.pallet_sudo.pallet
{
    
    
    /// <summary>
    /// >> Event
    /// 
    ///			The [event](https://docs.substrate.io/main-docs/build/events-errors/) emitted
    ///			by this pallet.
    ///			
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> Sudid
        /// A sudo just took place. \[result\]
        /// </summary>
        Sudid = 0,
        
        /// <summary>
        /// >> KeyChanged
        /// The \[sudoer\] just switched identity; the old key is supplied if one existed.
        /// </summary>
        KeyChanged = 1,
        
        /// <summary>
        /// >> SudoAsDone
        /// A sudo just took place. \[result\]
        /// </summary>
        SudoAsDone = 2,
    }
    
    /// <summary>
    /// >> 32 - Variant[pallet_sudo.pallet.Event]
    /// 
    ///			The [event](https://docs.substrate.io/main-docs/build/events-errors/) emitted
    ///			by this pallet.
    ///			
    /// </summary>
    public sealed class EnumEvent : BaseEnumRust<Event>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumEvent()
        {
				AddTypeDecoder<InvArch.NetApi.Generated.Types.Base.EnumResult>(Event.Sudid);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Base.BaseOpt<InvArch.NetApi.Generated.Model.sp_core.crypto.AccountId32>>(Event.KeyChanged);
				AddTypeDecoder<InvArch.NetApi.Generated.Types.Base.EnumResult>(Event.SudoAsDone);
        }
    }
}