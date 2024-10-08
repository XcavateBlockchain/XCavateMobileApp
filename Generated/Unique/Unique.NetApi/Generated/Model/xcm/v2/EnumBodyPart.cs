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


namespace Unique.NetApi.Generated.Model.xcm.v2
{
    
    
    /// <summary>
    /// >> BodyPart
    /// </summary>
    public enum BodyPart
    {
        
        /// <summary>
        /// >> Voice
        /// </summary>
        Voice = 0,
        
        /// <summary>
        /// >> Members
        /// </summary>
        Members = 1,
        
        /// <summary>
        /// >> Fraction
        /// </summary>
        Fraction = 2,
        
        /// <summary>
        /// >> AtLeastProportion
        /// </summary>
        AtLeastProportion = 3,
        
        /// <summary>
        /// >> MoreThanProportion
        /// </summary>
        MoreThanProportion = 4,
    }
    
    /// <summary>
    /// >> 127 - Variant[xcm.v2.BodyPart]
    /// </summary>
    public sealed class EnumBodyPart : BaseEnumRust<BodyPart>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumBodyPart()
        {
				AddTypeDecoder<BaseVoid>(BodyPart.Voice);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>>(BodyPart.Members);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>>>(BodyPart.Fraction);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>>>(BodyPart.AtLeastProportion);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>>>(BodyPart.MoreThanProportion);
        }
    }
}
