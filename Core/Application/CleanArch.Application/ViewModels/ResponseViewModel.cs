using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.ViewModels {
    public class ResponseViewModel {
        public HttpStatusCode StatusCode { get; set; }
        public string EnMessage { get; set; }
        public string FaMessage { get; set; }
        public bool IsSuccess { get; set; }
        public List<object> Data { get; set; }
    }
}