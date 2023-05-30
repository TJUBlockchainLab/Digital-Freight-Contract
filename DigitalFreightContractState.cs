using AElf.Sdk.CSharp.State;
using AElf.Types;


namespace Tank.DataStoreContract
{
    /// <summary>
    /// The state class of the contract, it inherits from the AElf.Sdk.CSharp.State.ContractState type. 
    /// </summary>
    public class   DataStoreContractState : ContractState
    {
        
        
        // state definitions go here.
        public SingletonState<HashStoreInputs> InitiationHashStoreInputList { get;  set; }
        public SingletonState<HashStoreInputs> DigitalFreightHashStoreInputList { get;  set; }
        public SingletonState<HashStoreInputs> ResultHashStoreInputList { get;  set; }
        public MappedState<Address, BoolState> AddressAccessMap { get; set; }
        public SingletonState<Address> User { get; set; }
        
    }
}