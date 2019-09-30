using Newtonsoft.Json;

namespace BTCPayServer.Altcoins.Monero.RPC.Models
{
    public partial class CreateAddressResponse
    {
        [JsonProperty("address")] public string Address { get; set; }
        [JsonProperty("address_index")] public long AddressIndex { get; set; }
    }
}