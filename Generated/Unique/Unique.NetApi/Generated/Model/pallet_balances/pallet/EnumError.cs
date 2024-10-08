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


namespace Unique.NetApi.Generated.Model.pallet_balances.pallet
{
    
    
    /// <summary>
    /// >> Error
    /// The `Error` enum of this pallet.
    /// </summary>
    public enum Error
    {
        
        /// <summary>
        /// >> VestingBalance
        /// Vesting balance too high to send value.
        /// </summary>
        VestingBalance = 0,
        
        /// <summary>
        /// >> LiquidityRestrictions
        /// Account liquidity restrictions prevent withdrawal.
        /// </summary>
        LiquidityRestrictions = 1,
        
        /// <summary>
        /// >> InsufficientBalance
        /// Balance too low to send value.
        /// </summary>
        InsufficientBalance = 2,
        
        /// <summary>
        /// >> ExistentialDeposit
        /// Value too low to create account due to existential deposit.
        /// </summary>
        ExistentialDeposit = 3,
        
        /// <summary>
        /// >> Expendability
        /// Transfer/payment would kill account.
        /// </summary>
        Expendability = 4,
        
        /// <summary>
        /// >> ExistingVestingSchedule
        /// A vesting schedule already exists for this account.
        /// </summary>
        ExistingVestingSchedule = 5,
        
        /// <summary>
        /// >> DeadAccount
        /// Beneficiary account must pre-exist.
        /// </summary>
        DeadAccount = 6,
        
        /// <summary>
        /// >> TooManyReserves
        /// Number of named reserves exceed `MaxReserves`.
        /// </summary>
        TooManyReserves = 7,
        
        /// <summary>
        /// >> TooManyHolds
        /// Number of holds exceed `MaxHolds`.
        /// </summary>
        TooManyHolds = 8,
        
        /// <summary>
        /// >> TooManyFreezes
        /// Number of freezes exceed `MaxFreezes`.
        /// </summary>
        TooManyFreezes = 9,
    }
    
    /// <summary>
    /// >> 444 - Variant[pallet_balances.pallet.Error]
    /// The `Error` enum of this pallet.
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
