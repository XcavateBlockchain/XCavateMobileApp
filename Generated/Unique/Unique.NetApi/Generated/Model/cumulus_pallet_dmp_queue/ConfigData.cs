//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Attributes;
using Substrate.NetApi.Model.Types.Base;
using Substrate.NetApi.Model.Types.Metadata.Base;
using System.Collections.Generic;


namespace Unique.NetApi.Generated.Model.cumulus_pallet_dmp_queue
{
    
    
    /// <summary>
    /// >> 563 - Composite[cumulus_pallet_dmp_queue.ConfigData]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class ConfigData : BaseType
    {
        
        /// <summary>
        /// >> max_individual
        /// </summary>
        public Unique.NetApi.Generated.Model.sp_weights.weight_v2.Weight MaxIndividual { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "ConfigData";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(MaxIndividual.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            MaxIndividual = new Unique.NetApi.Generated.Model.sp_weights.weight_v2.Weight();
            MaxIndividual.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
