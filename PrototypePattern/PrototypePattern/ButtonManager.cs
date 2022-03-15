using System;
using System.Collections.Generic;

namespace PrototypePattern
{
    public class ButtonManager
    {
        private Dictionary<string, ButtonPrototype> colors =
            new Dictionary<string, ButtonPrototype>();

        public ButtonPrototype this[string key]
        {
            get { return colors[key]; }
            set { colors.Add(key, value); }
        }

    }
}
