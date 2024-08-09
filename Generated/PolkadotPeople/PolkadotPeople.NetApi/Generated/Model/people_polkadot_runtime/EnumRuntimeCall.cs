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


namespace PolkadotPeople.NetApi.Generated.Model.people_polkadot_runtime
{
    
    
    /// <summary>
    /// >> RuntimeCall
    /// </summary>
    public enum RuntimeCall
    {
        
        /// <summary>
        /// >> System
        /// </summary>
        System = 0,
        
        /// <summary>
        /// >> ParachainSystem
        /// </summary>
        ParachainSystem = 1,
        
        /// <summary>
        /// >> Timestamp
        /// </summary>
        Timestamp = 2,
        
        /// <summary>
        /// >> ParachainInfo
        /// </summary>
        ParachainInfo = 3,
        
        /// <summary>
        /// >> Balances
        /// </summary>
        Balances = 10,
        
        /// <summary>
        /// >> CollatorSelection
        /// </summary>
        CollatorSelection = 21,
        
        /// <summary>
        /// >> Session
        /// </summary>
        Session = 22,
        
        /// <summary>
        /// >> XcmpQueue
        /// </summary>
        XcmpQueue = 30,
        
        /// <summary>
        /// >> PolkadotXcm
        /// </summary>
        PolkadotXcm = 31,
        
        /// <summary>
        /// >> CumulusXcm
        /// </summary>
        CumulusXcm = 32,
        
        /// <summary>
        /// >> MessageQueue
        /// </summary>
        MessageQueue = 34,
        
        /// <summary>
        /// >> Utility
        /// </summary>
        Utility = 40,
        
        /// <summary>
        /// >> Multisig
        /// </summary>
        Multisig = 41,
        
        /// <summary>
        /// >> Proxy
        /// </summary>
        Proxy = 42,
        
        /// <summary>
        /// >> Identity
        /// </summary>
        Identity = 50,
        
        /// <summary>
        /// >> IdentityMigrator
        /// </summary>
        IdentityMigrator = 248,
    }
    
    /// <summary>
    /// >> 319 - Variant[people_polkadot_runtime.RuntimeCall]
    /// </summary>
    public sealed class EnumRuntimeCall : BaseEnumExt<RuntimeCall, PolkadotPeople.NetApi.Generated.Model.frame_system.pallet.EnumCall, PolkadotPeople.NetApi.Generated.Model.cumulus_pallet_parachain_system.pallet.EnumCall, PolkadotPeople.NetApi.Generated.Model.pallet_timestamp.pallet.EnumCall, PolkadotPeople.NetApi.Generated.Model.staging_parachain_info.pallet.EnumCall, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, PolkadotPeople.NetApi.Generated.Model.pallet_balances.pallet.EnumCall, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, PolkadotPeople.NetApi.Generated.Model.pallet_collator_selection.pallet.EnumCall, PolkadotPeople.NetApi.Generated.Model.pallet_session.pallet.EnumCall, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, PolkadotPeople.NetApi.Generated.Model.cumulus_pallet_xcmp_queue.pallet.EnumCall, PolkadotPeople.NetApi.Generated.Model.pallet_xcm.pallet.EnumCall, PolkadotPeople.NetApi.Generated.Model.cumulus_pallet_xcm.pallet.EnumCall, BaseVoid, PolkadotPeople.NetApi.Generated.Model.pallet_message_queue.pallet.EnumCall, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, PolkadotPeople.NetApi.Generated.Model.pallet_utility.pallet.EnumCall, PolkadotPeople.NetApi.Generated.Model.pallet_multisig.pallet.EnumCall, PolkadotPeople.NetApi.Generated.Model.pallet_proxy.pallet.EnumCall, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, PolkadotPeople.NetApi.Generated.Model.pallet_identity.pallet.EnumCall, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, PolkadotPeople.NetApi.Generated.Model.polkadot_runtime_common.identity_migrator.pallet.EnumCall>
    {
    }
}
