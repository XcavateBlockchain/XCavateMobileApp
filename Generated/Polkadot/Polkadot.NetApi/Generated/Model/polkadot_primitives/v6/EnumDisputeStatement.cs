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


namespace Polkadot.NetApi.Generated.Model.polkadot_primitives.v6
{
    
    
    /// <summary>
    /// >> DisputeStatement
    /// </summary>
    public enum DisputeStatement
    {
        
        /// <summary>
        /// >> Valid
        /// </summary>
        Valid = 0,
        
        /// <summary>
        /// >> Invalid
        /// </summary>
        Invalid = 1,
    }
    
    /// <summary>
    /// >> 361 - Variant[polkadot_primitives.v6.DisputeStatement]
    /// </summary>
    public sealed class EnumDisputeStatement : BaseEnumRust<DisputeStatement>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumDisputeStatement()
        {
				AddTypeDecoder<Polkadot.NetApi.Generated.Model.polkadot_primitives.v6.EnumValidDisputeStatementKind>(DisputeStatement.Valid);
				AddTypeDecoder<Polkadot.NetApi.Generated.Model.polkadot_primitives.v6.EnumInvalidDisputeStatementKind>(DisputeStatement.Invalid);
        }
    }
}