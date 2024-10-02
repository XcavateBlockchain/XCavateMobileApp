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


namespace PolkadotAssetHub.NetApi.Generated.Model.pallet_nfts.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> create
        /// See [`Pallet::create`].
        /// </summary>
        create = 0,
        
        /// <summary>
        /// >> force_create
        /// See [`Pallet::force_create`].
        /// </summary>
        force_create = 1,
        
        /// <summary>
        /// >> destroy
        /// See [`Pallet::destroy`].
        /// </summary>
        destroy = 2,
        
        /// <summary>
        /// >> mint
        /// See [`Pallet::mint`].
        /// </summary>
        mint = 3,
        
        /// <summary>
        /// >> force_mint
        /// See [`Pallet::force_mint`].
        /// </summary>
        force_mint = 4,
        
        /// <summary>
        /// >> burn
        /// See [`Pallet::burn`].
        /// </summary>
        burn = 5,
        
        /// <summary>
        /// >> transfer
        /// See [`Pallet::transfer`].
        /// </summary>
        transfer = 6,
        
        /// <summary>
        /// >> redeposit
        /// See [`Pallet::redeposit`].
        /// </summary>
        redeposit = 7,
        
        /// <summary>
        /// >> lock_item_transfer
        /// See [`Pallet::lock_item_transfer`].
        /// </summary>
        lock_item_transfer = 8,
        
        /// <summary>
        /// >> unlock_item_transfer
        /// See [`Pallet::unlock_item_transfer`].
        /// </summary>
        unlock_item_transfer = 9,
        
        /// <summary>
        /// >> lock_collection
        /// See [`Pallet::lock_collection`].
        /// </summary>
        lock_collection = 10,
        
        /// <summary>
        /// >> transfer_ownership
        /// See [`Pallet::transfer_ownership`].
        /// </summary>
        transfer_ownership = 11,
        
        /// <summary>
        /// >> set_team
        /// See [`Pallet::set_team`].
        /// </summary>
        set_team = 12,
        
        /// <summary>
        /// >> force_collection_owner
        /// See [`Pallet::force_collection_owner`].
        /// </summary>
        force_collection_owner = 13,
        
        /// <summary>
        /// >> force_collection_config
        /// See [`Pallet::force_collection_config`].
        /// </summary>
        force_collection_config = 14,
        
        /// <summary>
        /// >> approve_transfer
        /// See [`Pallet::approve_transfer`].
        /// </summary>
        approve_transfer = 15,
        
        /// <summary>
        /// >> cancel_approval
        /// See [`Pallet::cancel_approval`].
        /// </summary>
        cancel_approval = 16,
        
        /// <summary>
        /// >> clear_all_transfer_approvals
        /// See [`Pallet::clear_all_transfer_approvals`].
        /// </summary>
        clear_all_transfer_approvals = 17,
        
        /// <summary>
        /// >> lock_item_properties
        /// See [`Pallet::lock_item_properties`].
        /// </summary>
        lock_item_properties = 18,
        
        /// <summary>
        /// >> set_attribute
        /// See [`Pallet::set_attribute`].
        /// </summary>
        set_attribute = 19,
        
        /// <summary>
        /// >> force_set_attribute
        /// See [`Pallet::force_set_attribute`].
        /// </summary>
        force_set_attribute = 20,
        
        /// <summary>
        /// >> clear_attribute
        /// See [`Pallet::clear_attribute`].
        /// </summary>
        clear_attribute = 21,
        
        /// <summary>
        /// >> approve_item_attributes
        /// See [`Pallet::approve_item_attributes`].
        /// </summary>
        approve_item_attributes = 22,
        
        /// <summary>
        /// >> cancel_item_attributes_approval
        /// See [`Pallet::cancel_item_attributes_approval`].
        /// </summary>
        cancel_item_attributes_approval = 23,
        
        /// <summary>
        /// >> set_metadata
        /// See [`Pallet::set_metadata`].
        /// </summary>
        set_metadata = 24,
        
        /// <summary>
        /// >> clear_metadata
        /// See [`Pallet::clear_metadata`].
        /// </summary>
        clear_metadata = 25,
        
        /// <summary>
        /// >> set_collection_metadata
        /// See [`Pallet::set_collection_metadata`].
        /// </summary>
        set_collection_metadata = 26,
        
        /// <summary>
        /// >> clear_collection_metadata
        /// See [`Pallet::clear_collection_metadata`].
        /// </summary>
        clear_collection_metadata = 27,
        
        /// <summary>
        /// >> set_accept_ownership
        /// See [`Pallet::set_accept_ownership`].
        /// </summary>
        set_accept_ownership = 28,
        
        /// <summary>
        /// >> set_collection_max_supply
        /// See [`Pallet::set_collection_max_supply`].
        /// </summary>
        set_collection_max_supply = 29,
        
        /// <summary>
        /// >> update_mint_settings
        /// See [`Pallet::update_mint_settings`].
        /// </summary>
        update_mint_settings = 30,
        
        /// <summary>
        /// >> set_price
        /// See [`Pallet::set_price`].
        /// </summary>
        set_price = 31,
        
        /// <summary>
        /// >> buy_item
        /// See [`Pallet::buy_item`].
        /// </summary>
        buy_item = 32,
        
        /// <summary>
        /// >> pay_tips
        /// See [`Pallet::pay_tips`].
        /// </summary>
        pay_tips = 33,
        
        /// <summary>
        /// >> create_swap
        /// See [`Pallet::create_swap`].
        /// </summary>
        create_swap = 34,
        
        /// <summary>
        /// >> cancel_swap
        /// See [`Pallet::cancel_swap`].
        /// </summary>
        cancel_swap = 35,
        
        /// <summary>
        /// >> claim_swap
        /// See [`Pallet::claim_swap`].
        /// </summary>
        claim_swap = 36,
        
        /// <summary>
        /// >> mint_pre_signed
        /// See [`Pallet::mint_pre_signed`].
        /// </summary>
        mint_pre_signed = 37,
        
        /// <summary>
        /// >> set_attributes_pre_signed
        /// See [`Pallet::set_attributes_pre_signed`].
        /// </summary>
        set_attributes_pre_signed = 38,
    }
    
    /// <summary>
    /// >> 356 - Variant[pallet_nfts.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumRust<Call>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumCall()
        {
				AddTypeDecoder<BaseTuple<PolkadotAssetHub.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, PolkadotAssetHub.NetApi.Generated.Model.pallet_nfts.types.CollectionConfig>>(Call.create);
				AddTypeDecoder<BaseTuple<PolkadotAssetHub.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, PolkadotAssetHub.NetApi.Generated.Model.pallet_nfts.types.CollectionConfig>>(Call.force_create);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, PolkadotAssetHub.NetApi.Generated.Model.pallet_nfts.types.DestroyWitness>>(Call.destroy);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, PolkadotAssetHub.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.NetApi.Model.Types.Base.BaseOpt<PolkadotAssetHub.NetApi.Generated.Model.pallet_nfts.types.MintWitness>>>(Call.mint);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, PolkadotAssetHub.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, PolkadotAssetHub.NetApi.Generated.Model.pallet_nfts.types.ItemConfig>>(Call.force_mint);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>>(Call.burn);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, PolkadotAssetHub.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress>>(Call.transfer);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U32>>>(Call.redeposit);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>>(Call.lock_item_transfer);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>>(Call.unlock_item_transfer);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, PolkadotAssetHub.NetApi.Generated.Model.pallet_nfts.types.BitFlagsT1>>(Call.lock_collection);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, PolkadotAssetHub.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress>>(Call.transfer_ownership);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseOpt<PolkadotAssetHub.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress>, Substrate.NetApi.Model.Types.Base.BaseOpt<PolkadotAssetHub.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress>, Substrate.NetApi.Model.Types.Base.BaseOpt<PolkadotAssetHub.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress>>>(Call.set_team);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, PolkadotAssetHub.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress>>(Call.force_collection_owner);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, PolkadotAssetHub.NetApi.Generated.Model.pallet_nfts.types.CollectionConfig>>(Call.force_collection_config);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, PolkadotAssetHub.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32>>>(Call.approve_transfer);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, PolkadotAssetHub.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress>>(Call.cancel_approval);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>>(Call.clear_all_transfer_approvals);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.Bool, Substrate.NetApi.Model.Types.Primitive.Bool>>(Call.lock_item_properties);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32>, PolkadotAssetHub.NetApi.Generated.Model.pallet_nfts.types.EnumAttributeNamespace, PolkadotAssetHub.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT6, PolkadotAssetHub.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT7>>(Call.set_attribute);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Base.BaseOpt<PolkadotAssetHub.NetApi.Generated.Model.sp_core.crypto.AccountId32>, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32>, PolkadotAssetHub.NetApi.Generated.Model.pallet_nfts.types.EnumAttributeNamespace, PolkadotAssetHub.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT6, PolkadotAssetHub.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT7>>(Call.force_set_attribute);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32>, PolkadotAssetHub.NetApi.Generated.Model.pallet_nfts.types.EnumAttributeNamespace, PolkadotAssetHub.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT6>>(Call.clear_attribute);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, PolkadotAssetHub.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress>>(Call.approve_item_attributes);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, PolkadotAssetHub.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, PolkadotAssetHub.NetApi.Generated.Model.pallet_nfts.types.CancelAttributesApprovalWitness>>(Call.cancel_item_attributes_approval);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, PolkadotAssetHub.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT7>>(Call.set_metadata);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>>(Call.clear_metadata);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, PolkadotAssetHub.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT7>>(Call.set_collection_metadata);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U32>(Call.clear_collection_metadata);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32>>(Call.set_accept_ownership);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>>(Call.set_collection_max_supply);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, PolkadotAssetHub.NetApi.Generated.Model.pallet_nfts.types.MintSettings>>(Call.update_mint_settings);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.NetApi.Model.Types.Base.BaseOpt<PolkadotAssetHub.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress>>>(Call.set_price);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U128>>(Call.buy_item);
				AddTypeDecoder<PolkadotAssetHub.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT21>(Call.pay_tips);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseOpt<PolkadotAssetHub.NetApi.Generated.Model.pallet_nfts.types.PriceWithDirection>, Substrate.NetApi.Model.Types.Primitive.U32>>(Call.create_swap);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>>(Call.cancel_swap);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseOpt<PolkadotAssetHub.NetApi.Generated.Model.pallet_nfts.types.PriceWithDirection>>>(Call.claim_swap);
				AddTypeDecoder<BaseTuple<PolkadotAssetHub.NetApi.Generated.Model.pallet_nfts.types.PreSignedMint, PolkadotAssetHub.NetApi.Generated.Model.sp_runtime.EnumMultiSignature, PolkadotAssetHub.NetApi.Generated.Model.sp_core.crypto.AccountId32>>(Call.mint_pre_signed);
				AddTypeDecoder<BaseTuple<PolkadotAssetHub.NetApi.Generated.Model.pallet_nfts.types.PreSignedAttributes, PolkadotAssetHub.NetApi.Generated.Model.sp_runtime.EnumMultiSignature, PolkadotAssetHub.NetApi.Generated.Model.sp_core.crypto.AccountId32>>(Call.set_attributes_pre_signed);
        }
    }
}