using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;

namespace EXItoinfWallace.Modelos
{
    public interface IEtiquetaApiService
    {

        [Get("/sro/{chaveIntegracao}/{codigoEtiqueta}/U")]
        Task<IEnumerable<EtiquetaResponse>> GetAddressAsync(string chaveIntegracao, string codigoEtiqueta);
    }
}
