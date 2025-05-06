using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialReader
{
    internal class Telegram
    {
        public string Command { get; set; }
        public string ExpectedResponse { get; set; }

        public bool ValidateResponse(string response)
        {
            return response.Trim() == ExpectedResponse.Trim();
        }
    }
}
