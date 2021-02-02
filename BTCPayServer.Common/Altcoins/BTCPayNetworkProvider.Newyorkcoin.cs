using NBitcoin;
using NBXplorer;

namespace BTCPayServer
{
    public partial class BTCPayNetworkProvider
    {
        public void InitNewyorkcoin()
        {
            var nbxplorerNetwork = NBXplorerNetworkProvider.GetFromCryptoCode("NYC");
            Add(new BTCPayNetwork()
            {
                CryptoCode = nbxplorerNetwork.CryptoCode,
                DisplayName = "Newyorkcoin",
                BlockExplorerLink = NetworkType == ChainName.Mainnet ? "https://chainz.cryptoid.info/nyc/tx.dws?{0}.htm" : "https://chainz.cryptoid.info/nyc/tx.dws?{0}htm",
                NBXplorerNetwork = nbxplorerNetwork,
                UriScheme = "newyorkcoin",
                DefaultRateRules = new[]
                {
                                "NYC_X = NYC_BTC * BTC_X",
                                "NYC_BTC = southxchange(NYC_BTC)"
                },
                CryptoImagePath = "imlegacy/newyorkcoin.png",
                DefaultSettings = BTCPayDefaultSettings.GetDefaultSettings(NetworkType),
                CoinType = NetworkType == ChainName.Mainnet ? new KeyPath("3'") : new KeyPath("1'")
            });
        }
    }
}
