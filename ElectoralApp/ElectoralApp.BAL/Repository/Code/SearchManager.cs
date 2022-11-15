using ElectoralApp.BAL.Repository.Interfaces;
using ElectoralApp.BAL.Repository.Model;
using ElectoralApp.DAL;
using ElectoralApp.DAL.Repository.Code;
using ElectoralApp.DAL.Repository.Interfaces;
using ElectoralApp.DAL.Repository.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Configuration;

namespace ElectoralApp.BAL.Repository.Code
{
   public class SearchManager :ISearchManager
    {
        private readonly ElectoralDBEntities _context;

        private readonly ISearchRepository _searchRepository;

        
        public SearchManager(ElectoralDBEntities context)
        {
            _searchRepository = new SearchRepository(context);
        }

        public SearchManager(ElectoralDBEntities context, ISearchRepository searchRepository)
        {
            _searchRepository = searchRepository;
            _context = context;
        }

        public SearchInfo SearchVoterListNew(ElectoralAPI.SearchFiltersInfoReq sFilterReq)
        {
            try
            {
                string serviceUrl = ConfigurationManager.AppSettings["ServiceUrl"];
                string inputJson = JsonConvert.SerializeObject(sFilterReq);
                HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create(new Uri(serviceUrl + "/SearchVoter"));
                httpRequest.Accept = "application/json";
                httpRequest.ContentType = "application/json";
                httpRequest.Method = "POST";

                byte[] bytes = Encoding.UTF8.GetBytes(inputJson);

                using (Stream stream = httpRequest.GetRequestStream())
                {
                    stream.Write(bytes, 0, bytes.Length);
                    stream.Close();
                }
                string result = string.Empty;
                using (HttpWebResponse httpResponse = (HttpWebResponse)httpRequest.GetResponse())
                {
                    using (Stream stream = httpResponse.GetResponseStream())
                    {
                        result = (new StreamReader(stream)).ReadToEnd();
                    }
                }

                SearchInfo foos = JsonConvert.DeserializeObject<SearchInfo>(result);

                return foos;
            }
            catch (Exception ex)
            {
                throw ex;            
            }
            
        }

        public VoterInfo GetVoterDetails(long VoterId, int userId, string hashValue)
        {

            try
            {
                string serviceUrl = ConfigurationManager.AppSettings["ServiceUrl"];
                HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create(new Uri(serviceUrl + "/GetVoterInfo?userId=" + userId + "&voterId=" + VoterId + "&hashValue=" + hashValue + ""));
                httpRequest.Method = "GET";
                string result = string.Empty;
                using (HttpWebResponse httpResponse = (HttpWebResponse)httpRequest.GetResponse())
                {
                    using (Stream stream = httpResponse.GetResponseStream())
                    {
                        result = (new StreamReader(stream)).ReadToEnd();
                    }
                }
                var foos = JsonConvert.DeserializeObject<VoterInfo>(result);

                return foos;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
