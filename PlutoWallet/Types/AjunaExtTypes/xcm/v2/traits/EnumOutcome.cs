//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace PlutoWallet.NetApiExt.Generated.Model.xcm.v2.traits
{
    
    
    public enum Outcome
    {
        
        Complete = 0,
        
        Incomplete = 1,
        
        Error = 2,
    }
    
    /// <summary>
    /// >> 109 - Variant[xcm.v2.traits.Outcome]
    /// </summary>
    public sealed class EnumOutcome : BaseEnumExt<Outcome, Ajuna.NetApi.Model.Types.Primitive.U64, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U64, PlutoWallet.NetApiExt.Generated.Model.xcm.v2.traits.EnumError>, PlutoWallet.NetApiExt.Generated.Model.xcm.v2.traits.EnumError>
    {
    }
}
