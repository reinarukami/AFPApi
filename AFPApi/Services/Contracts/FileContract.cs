using AFPApi.Helpers.Nethereum;
using ApiLogger;
using Nethereum.Contracts;
using Nethereum.Hex.HexTypes;
using Nethereum.RPC.Eth.DTOs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AFPApi.Function.Contracts
{
    public static class FileContract
    {
        private static Contract Contract;

        static FileContract()
        {
		    //Get address and privatekey through session or cookie
            Contract = DefaultContract.InitContract(DefaultConfiguration.GetContractConfig().GetSection("DefaultAccount").Value, DefaultConfiguration.GetContractConfig().GetSection("DefaultPassword").Value, DefaultConfiguration.GetContractConfig().GetSection("ContractAbi").Value, DefaultConfiguration.GetContractConfig().GetSection("ContractAddress").Value);
        }

		public static void Test()
		{
			//Get the user cookies 
			var test1 = DefaultConfiguration.GetContractConfig().GetSection("DefaultAccount").Value;
			var test2 = DefaultConfiguration.GetContractConfig().GetSection("DefaultPassword").Value;
		}

		public static void 

    }
}
