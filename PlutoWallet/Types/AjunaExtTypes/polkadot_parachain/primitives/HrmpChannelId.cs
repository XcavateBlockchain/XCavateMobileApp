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


namespace PlutoWallet.NetApiExt.Generated.Model.polkadot_parachain.primitives
{
    
    
    /// <summary>
    /// >> 112 - Composite[polkadot_parachain.primitives.HrmpChannelId]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class HrmpChannelId : BaseType
    {
        
        /// <summary>
        /// >> sender
        /// </summary>
        private PlutoWallet.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id _sender;
        
        /// <summary>
        /// >> recipient
        /// </summary>
        private PlutoWallet.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id _recipient;
        
        public PlutoWallet.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id Sender
        {
            get
            {
                return this._sender;
            }
            set
            {
                this._sender = value;
            }
        }
        
        public PlutoWallet.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id Recipient
        {
            get
            {
                return this._recipient;
            }
            set
            {
                this._recipient = value;
            }
        }
        
        public override string TypeName()
        {
            return "HrmpChannelId";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Sender.Encode());
            result.AddRange(Recipient.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Sender = new PlutoWallet.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id();
            Sender.Decode(byteArray, ref p);
            Recipient = new PlutoWallet.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id();
            Recipient.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
