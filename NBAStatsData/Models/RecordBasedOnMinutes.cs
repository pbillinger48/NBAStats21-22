using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBAStatsData.Models
{
    public class RecordBasedOnMinutes
    {
        public string PlayerName;
        public string TeamName;
        public int WinsWhenThresholdMet;
        public int LossesWhenThresholdMet;
        public int WinsWhenThresholdNotMet;
        public int LossesWhenThresholdNotMet;

        public RecordBasedOnMinutes(string pN, string tN, int wMet, int lMet, int wNotMet, int lNotMet)
        {
            PlayerName = pN;
            TeamName = tN;
            WinsWhenThresholdMet = wMet;
            LossesWhenThresholdMet = lMet;
            WinsWhenThresholdNotMet = wNotMet;
            LossesWhenThresholdNotMet = lNotMet;
        }
    }
}
