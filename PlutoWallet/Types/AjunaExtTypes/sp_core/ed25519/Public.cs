//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Attributes;
using Ajuna.NetApi.Model.Types.Base;
using Ajuna.NetApi.Model.Types.Metadata.V14;
using System.Collections.Generic;


namespace PlutoWallet.NetApiExt.Generated.Model.sp_core.ed25519
{
    
    
    /// <summary>
    /// >> 51 - Composite[sp_core.ed25519.Public]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class Public : BaseType
    {
        
        /// <summary>
        /// >> value
        /// </summary>
        private PlutoWallet.NetApiExt.Generated.Types.Base.Arr32U8 _value;
        
        public PlutoWallet.NetApiExt.Generated.Types.Base.Arr32U8 Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
        
        public override string TypeName()
        {
            return "Public";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Value.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Value = new PlutoWallet.NetApiExt.Generated.Types.Base.Arr32U8();
            Value.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
