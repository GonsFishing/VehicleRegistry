using Vehicle_DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace CarRegister.Controllers
{
    public class AccountController : Controller
    {
        private readonly string gettoken = "https://localhost:44381/token";
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        public string GetToken(string userName, string password)
        {
            using (var _httpClient = new HttpClient())
            {
                var userDict = new Dictionary<string, string>
                        {
                            {"userName", userName },
                            {"password", password },
                            {"grant_type", "password" }
                        };
                var content = new FormUrlEncodedContent(userDict);
                var response = _httpClient.PostAsync(gettoken, content).Result;
                var jsonstring = response.Content.ReadAsStringAsync().Result;
                var tokenstring = JsonConvert.DeserializeObject<TokenDTO>(jsonstring);

                return tokenstring.Access_token;
            }
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginModelDTO login)
        {
            var token = GetToken(login.Username, login.Password);
            if(string.IsNullOrEmpty(token))
            {
                return RedirectToAction("Login", "Account");     
            }

            Session["tokenkey"] = token;
            return RedirectToAction("Index", "Home");
        }
    }
}