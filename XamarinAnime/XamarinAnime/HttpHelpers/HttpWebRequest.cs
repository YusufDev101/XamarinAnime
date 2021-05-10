using Flurl.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using XamarinAnime.Models;

namespace XamarinAnime.HttpHelpers
{
    public class HttpWebRequest
    {
        public HttpWebRequest()
        {

        }

        internal async Task<AnimeListObject> GetPopularAnime()
        {
            try
            {
                // Get Pokemon.
                var buildString = HttpHelpers.PopularAnimeUrl;

                // Web request.
                var animeString = await buildString.GetStringAsync();

                // return De-serialized class object.
                var data =  JsonConvert.DeserializeObject<AnimeListObject>(animeString);
                return data;
            }
            catch (FlurlHttpTimeoutException ex)
            {
                // handle timeout
                throw ex;
            }
            catch (FlurlHttpException ex)
            {
                // handle error response
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
