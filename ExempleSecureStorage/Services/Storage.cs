using System;
using System.Collections.Generic;
using System.Text;

namespace ExempleSecureStorage.Services
{
    public static class Storage
    {
        public static async void StockerValeur(string paramKey, string paramValue)
        {
            try
            {
                await SecureStorage.SetAsync(paramKey, paramValue);
            }
            catch (Exception ex)
            {
               
            }
        }
        public static async Task<string>  RecupererValeur(string paramKey)
        {
            return await SecureStorage.GetAsync(paramKey);

        }
    }
}
