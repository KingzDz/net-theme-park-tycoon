using System;

namespace ThemeParkTycoonGame.Core
{
    public class Desire
    {
        public IDesirable Object;
        public string Reason;

        // For stalls or to specify intensity for a ride (if applicable, like front-seat or back-seat)
        public ObjectSpecific Specific;

        public DateTime GainedAt;

        public Desire()
        {
            GainedAt = DateTime.Now;
        }
    }
}