using System;

namespace SimkapSmartLibrary.simkap.smart.library.entitas
{
    [Serializable]
    public class EntRemoteTransactionClient
    {
        private string text;

        public string Text
        {
            get
            {
                return text;
            }

            set
            {
                text = value;
            }
        }
    }
}
