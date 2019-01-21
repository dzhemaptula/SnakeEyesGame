using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnakeEyesGame.Models {
    [JsonObject(MemberSerialization.OptIn)]
    public class SnakeEyes {
        private Dice _eye1;
        private Dice _eye2;
        [JsonProperty]
        public int Total { get; private set; }
        [JsonProperty]
        public int Eye1 { get { return _eye1.Pins; } }
        [JsonProperty]
        public int Eye2 { get { return _eye2.Pins; } }

        public SnakeEyes() {
            _eye2 = new Dice();
            _eye1 = new Dice();
            Total = 0;
        }

        public void Play() {
            _eye1.Roll();
            _eye2.Roll();
            if (Eye1 == 1 && Eye2 == 1) {
                Total = 0;
            }
            else {
                Total += Eye1 + Eye2;
            }
        }



    }
}
