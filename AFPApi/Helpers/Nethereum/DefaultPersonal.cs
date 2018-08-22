namespace AFPApi.Helpers.Nethereum
{
    public static class DefaultPersonal
    {

        public static string CreateAccount(string password)
        {
            var taskCreateAccount =  DefaultWeb3.InitializeWeb3().Personal.NewAccount.SendRequestAsync(password);
            taskCreateAccount.Wait();

            return taskCreateAccount.Result;
        }

        //public static bool UnlockAccount(string address, string password)
        //{
        //    var taskUnlockAccount = DefaultWeb3.InitializeWeb3().Personal.UnlockAccount.SendRequestAsync(address, password, new int?(60));
        //    return taskUnlockAccount.Result;
        //}
    }
}
