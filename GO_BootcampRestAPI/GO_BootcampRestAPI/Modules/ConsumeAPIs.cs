using System;
using System.Net;
using System.IO;

namespace GO_BootcampRestAPI.Modules
{
    public class ConsumeAPIs 
    {
        /// <summary>
        /// Class to consume a REST API get method without key.
        /// </summary>
        /// <param name="url">REST API url</param>
        /// <returns></returns>
        public static Respuesta getItem(string url)
        {
            Respuesta nvaRespuesta = new();
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            try {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        bool blnContinue = true;
                        if (strReader == null)
                        {
                            blnContinue = false;
                            nvaRespuesta.BlnError = true;
                            nvaRespuesta.ErrorMessage = "Elemento nulo";
                            nvaRespuesta.NormalResponse = "";
                        }

                        if (blnContinue)
                        {
                            using (StreamReader objReader = new StreamReader(strReader))
                            {
                                string responseBody = objReader.ReadToEnd();

                                nvaRespuesta.BlnError = false;
                                nvaRespuesta.ErrorMessage = "";
                                nvaRespuesta.NormalResponse = responseBody;
                            }
                        }
                    }
                }
            }
            catch (WebException ex) {
                nvaRespuesta.BlnError = true;
                nvaRespuesta.ErrorMessage = ex.Message;
                nvaRespuesta.NormalResponse = "";
            }
            catch (Exception ex2) {
                nvaRespuesta.BlnError = true;
                nvaRespuesta.ErrorMessage = ex2.Message;
                nvaRespuesta.NormalResponse = "";
            }

            return nvaRespuesta;
        }
    }
    
}
