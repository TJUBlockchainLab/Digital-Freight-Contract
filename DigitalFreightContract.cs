using System;
using System.Collections.Generic;
using System.Diagnostics;
using AElf.Sdk.CSharp.State;
using AElf.Types;
using Google.Protobuf.WellKnownTypes;


namespace Tank.DataStoreContract
{
    /// <summary>
    /// The C# implementation of the contract defined in data_store_contract.proto that is located in the "protobuf"
    /// folder.
    /// Notice that it inherits from the protobuf generated code. 
    /// </summary>
    public class DataStoreContract : DataStoreContractContainer.DataStoreContractBase
    {
        public override Empty Initialize(InitializeInput input)
        {
            if (State.User == null)
            {
                State.User.Value = new Address();
            }
            State.User.Value = Context.Sender;
            return new Empty();
        }

        public override Empty InitiationHashStore(HashStoreInput input)
        {
            Assert(State.User.Value == Context.Sender, "No Permissions");
            
            if (State.InitiationHashStoreInputList.Value == null || State.InitiationHashStoreInputList.Value.List.Capacity == 500)
            {
                State.InitiationHashStoreInputList.Value = new HashStoreInputs();
            }
            
            State.InitiationHashStoreInputList.Value.List.Add(input);
            return new Empty();
        }

        public override Empty DigitalFreightHashStore(HashStoreInput input)
        {
            Assert(State.User.Value == Context.Sender, "No Permissions");
            if (State.DigitalFreightHashStoreInputList.Value == null || State.DigitalFreightHashStoreInputList.Value.List.Capacity == 500)
            {
                State.DigitalFreightHashStoreInputList.Value = new HashStoreInputs();
            }
            
            State.DigitalFreightHashStoreInputList.Value.List.Add(input);
            return new Empty();
        }

        public override Empty ResultHashStore(HashStoreInput input)
        {
            Assert(State.User.Value == Context.Sender, "No Permissions");
            if (State.ResultHashStoreInputList.Value == null || State.ResultHashStoreInputList.Value.List.Capacity == 500)
            {
                State.ResultHashStoreInputList.Value = new HashStoreInputs();
            }
            
            State.ResultHashStoreInputList.Value.List.Add(input);
 
            return new Empty();
        }
    }
}