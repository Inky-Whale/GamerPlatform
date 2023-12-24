using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MernisServiceReference;

namespace GamerPlatform
{
    public class UserValidationManager:IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            MernisServiceReference.KPSPublicSoapClient client =
                new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var result =
                client.TCKimlikNoDogrulaAsync(gamer.IdNumber, gamer.FirstName, gamer.LastName, gamer.BirthYear);
            return result.Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
