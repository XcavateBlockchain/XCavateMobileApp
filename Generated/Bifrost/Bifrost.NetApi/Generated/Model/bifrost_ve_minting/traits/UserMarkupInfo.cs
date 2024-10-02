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


namespace Bifrost.NetApi.Generated.Model.bifrost_ve_minting.traits
{
    
    
    /// <summary>
    /// >> 890 - Composite[bifrost_ve_minting.traits.UserMarkupInfo]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class UserMarkupInfo : BaseType
    {
        
        /// <summary>
        /// >> old_markup_coefficient
        /// </summary>
        public Bifrost.NetApi.Generated.Model.sp_arithmetic.fixed_point.FixedU128 OldMarkupCoefficient { get; set; }
        /// <summary>
        /// >> markup_coefficient
        /// </summary>
        public Bifrost.NetApi.Generated.Model.sp_arithmetic.fixed_point.FixedU128 MarkupCoefficient { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "UserMarkupInfo";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(OldMarkupCoefficient.Encode());
            result.AddRange(MarkupCoefficient.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            OldMarkupCoefficient = new Bifrost.NetApi.Generated.Model.sp_arithmetic.fixed_point.FixedU128();
            OldMarkupCoefficient.Decode(byteArray, ref p);
            MarkupCoefficient = new Bifrost.NetApi.Generated.Model.sp_arithmetic.fixed_point.FixedU128();
            MarkupCoefficient.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}