//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi;
using Substrate.NetApi.Model.Extrinsics;
using Substrate.NetApi.Model.Meta;
using Substrate.NetApi.Model.Types;
using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace Unique.NetApi.Generated.Storage
{
    
    
    /// <summary>
    /// >> SudoStorage
    /// </summary>
    public sealed class SudoStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        /// <summary>
        /// >> SudoStorage Constructor
        /// </summary>
        public SudoStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Sudo", "Key"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Unique.NetApi.Generated.Model.sp_core.crypto.AccountId32)));
        }
        
        /// <summary>
        /// >> KeyParams
        ///  The `AccountId` of the sudo key.
        /// </summary>
        public static string KeyParams()
        {
            return RequestGenerator.GetStorage("Sudo", "Key", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> KeyDefault
        /// Default value as hex string
        /// </summary>
        public static string KeyDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> Key
        ///  The `AccountId` of the sudo key.
        /// </summary>
        public async Task<Unique.NetApi.Generated.Model.sp_core.crypto.AccountId32> Key(string blockhash, CancellationToken token)
        {
            string parameters = SudoStorage.KeyParams();
            var result = await _client.GetStorageAsync<Unique.NetApi.Generated.Model.sp_core.crypto.AccountId32>(parameters, blockhash, token);
            return result;
        }
    }
    
    /// <summary>
    /// >> SudoCalls
    /// </summary>
    public sealed class SudoCalls
    {
        
        /// <summary>
        /// >> sudo
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method Sudo(Unique.NetApi.Generated.Model.unique_runtime.EnumRuntimeCall call)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(call.Encode());
            return new Method(35, "Sudo", 0, "sudo", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> sudo_unchecked_weight
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SudoUncheckedWeight(Unique.NetApi.Generated.Model.unique_runtime.EnumRuntimeCall call, Unique.NetApi.Generated.Model.sp_weights.weight_v2.Weight weight)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(call.Encode());
            byteArray.AddRange(weight.Encode());
            return new Method(35, "Sudo", 1, "sudo_unchecked_weight", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_key
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SetKey(Unique.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress @new)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@new.Encode());
            return new Method(35, "Sudo", 2, "set_key", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> sudo_as
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SudoAs(Unique.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress who, Unique.NetApi.Generated.Model.unique_runtime.EnumRuntimeCall call)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(who.Encode());
            byteArray.AddRange(call.Encode());
            return new Method(35, "Sudo", 3, "sudo_as", byteArray.ToArray());
        }
    }
    
    /// <summary>
    /// >> SudoConstants
    /// </summary>
    public sealed class SudoConstants
    {
    }
    
    /// <summary>
    /// >> SudoErrors
    /// </summary>
    public enum SudoErrors
    {
        
        /// <summary>
        /// >> RequireSudo
        /// Sender must be the Sudo account
        /// </summary>
        RequireSudo,
    }
}
