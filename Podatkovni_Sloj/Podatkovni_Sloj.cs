using RestSharp;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Podatkovni_Sloj.Models;
using Newtonsoft.Json;

namespace Podatkovni_Sloj
{
    public class Podatkovni_Sloj
    {
        private const string HR = "hr";
        private const string EN = "en";
        private const char DEL = ',';


        public static List<string> LoadDataFromTxt(string file)
        {
            List<string> info = new List<string>();
            using (StreamReader reader = new StreamReader(file))
            {
                while (!reader.EndOfStream)
                {
                    info.Add(reader.ReadLine());
                }

            }

            return info;
        }


        public static void SaveDataToTxt(List<string> info, string file)
        {
            using (StreamWriter writer = new StreamWriter(file))
            {
                for (int i = 0; i < info.Count; i++)
                {
                    writer.WriteLine(info[i]);
                }
            }

        }

        public static void SetKultura(string culture)
        {
            if (culture == "Hrvatski" || culture == "Croatian")
            {
                var kultura = new CultureInfo(HR);
                Thread.CurrentThread.CurrentUICulture = kultura;
                Thread.CurrentThread.CurrentCulture = kultura;
            }
            else
            {
                var kultura = new CultureInfo(EN);
                Thread.CurrentThread.CurrentUICulture = kultura;
                Thread.CurrentThread.CurrentCulture = kultura;
            }


        }

        public static Task<RestResponse<Prvenstvo>> GetPrvenstvo(string prvenstvo)
        {
            string APIPath = (prvenstvo == "Žensko" || prvenstvo == "Female" ? "http://worldcup.sfg.io/teams/results" : "https://world-cup-json-2018.herokuapp.com/teams/results");

            RestClient apiKlijent = new RestClient(APIPath);

            return apiKlijent.ExecuteAsync<Prvenstvo>(new RestRequest());

        }

        public static List<Prvenstvo> DeserijalizirajPodatke(RestResponse<Prvenstvo> restResponse)
        {
            return JsonConvert.DeserializeObject<List<Prvenstvo>>(restResponse.Content);
        }

        public static Task<RestResponse<Utakmica>> GetUtakmica(string drzava, string prvenstvo)
        {

            string APIPath = (prvenstvo == "Žensko" || prvenstvo == "Female" ? $"http://worldcup.sfg.io/matches/country?fifa_code={drzava}" : $"https://world-cup-json-2018.herokuapp.com/matches/country?fifa_code={drzava}");

            RestClient apiKlijent = new RestClient(APIPath);

            return apiKlijent.ExecuteAsync<Utakmica>(new RestRequest());

        }

        public static List<Utakmica> DeserijalizirajPodatkeIgraca(RestResponse<Utakmica> restResponse)
        {
            return JsonConvert.DeserializeObject<List<Utakmica>>(restResponse.Content);
        }

        public static string ParsePlayerForFile(Player player)
        {
            return $"{player.Name}{DEL}{player.ShirtNumber}{DEL}{player.Position}{DEL}{player.Captain}";
        }

        public static Player ParsePlayerFromFile(string line)
        {
            string[] details = line.Split(DEL);
            return new Player
            {
                Name = details[0],
                ShirtNumber = details[1],
                Position = (Converters.Position)Enum.Parse(typeof(Converters.Position), details[2]),
                Captain = Boolean.Parse(details[3])
            };
        }
    }
}
