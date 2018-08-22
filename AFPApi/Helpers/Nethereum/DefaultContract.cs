using Nethereum.Contracts;
using Nethereum.Web3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AFPApi.Helpers.Nethereum
{
    public static class DefaultContract
    {
        static Web3 web3;

        public static Contract InitContract(string _address, string _password, string _abi, string _contractaddress)
        {
            web3 = DefaultWeb3.InitializeWeb3(_address, _password);

            var FileContract = web3.Eth.GetContract(_abi, _contractaddress);

            web3.Eth.TransactionManager.DefaultGas = 999999;

            return FileContract;
        }
    }
}
