using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JenkinsPush.Models
{
    public class HomeViewModel
    {
        public HomeViewModel(string header, string body)
        {
            this._header = header;
            this._body = body;
        }
        public string _header { get; set; }
        public string _body { get; set; }
    }
}