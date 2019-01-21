using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnakeEyesGame.Models {
    [JsonObject(MemberSerialization.OptIn)]
    public class Dice {
        private Random _dice;

        public Dice() {
            _dice = new Random();
            Pins = 6;
        }

        [JsonProperty]
        public int Pins { get; set; }

        public void Roll() {
            Pins = _dice.Next(1, 7);
        }
    }
}
