using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialReader
{
    internal class TelegramHandler
    {
        private Queue<Telegram> _telegramQueue = new();

        /*
         * Loads telegrams from a CSV file.
         * Each line should contain a command and an expected response, separated by a comma.
         */
        public void LoadFromCsv(string filepath)
        {
            var lines = File.ReadAllLines(filepath);

            foreach (var line in lines)
            {
                var parts = line.Split(',');
                if (parts.Length >= 2)
                {
                    _telegramQueue.Enqueue(new Telegram { Command = parts[0], ExpectedResponse = parts[1] });
                }
            }
        }
   
        public Telegram? GetNextTelegram()
        {
            return _telegramQueue.Count > 0 ? _telegramQueue.Dequeue() : null;
        }

        public bool HasTelegram => _telegramQueue.Count > 0;

    }

}
