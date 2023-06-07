using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Player : ProtoPlayer
    {
        public string Name { get; set; }
        public string Team { get; set; }
        public byte KitNumber { get; set; }
        public bool IsCaptain { get; set; }
        public Position Position { get; set; }

        public Player(string name, string team, byte kitNumber, bool isCaptain, Position position)
        {
            Name = name;
            Team = team;
            KitNumber = kitNumber;
            IsCaptain = isCaptain;
            Position = position;
        }

        public override ProtoPlayer Clone()
        {
            return this.MemberwiseClone() as ProtoPlayer;
        }
    }

    public enum Position
    {
        GoalKeeper,
        Defender,
        Midfielder,
        Forward
    }

}
