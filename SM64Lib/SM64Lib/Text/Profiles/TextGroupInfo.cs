using System.Linq;
using global::Newtonsoft.Json;

namespace SM64Lib.Text.Profiles
{
    public abstract class TextGroupInfo
    {
        public const string ENCODING_STRING_M64 = "m64";
        public const string ENCODING_STRING_ASCII = "ascii";
        [JsonProperty("Encoding")]
        private string myTextEncoding;

        public string Name { get; set; }

        [JsonIgnore]
        public System.Text.Encoding Encoding
        {
            get
            {
                var switchExpr = myTextEncoding;
                switch (switchExpr)
                {
                    case ENCODING_STRING_ASCII:
                        {
                            return System.Text.Encoding.ASCII;
                        }

                    case ENCODING_STRING_M64:
                        {
                            return M64TextEncoding.M64Text;
                        }

                    default:
                        {
                            return null;
                        }
                }
            }
        }

        [JsonIgnore]
        public string EncodingString
        {
            get
            {
                return myTextEncoding;
            }

            set
            {
                if (new[] { ENCODING_STRING_M64, ENCODING_STRING_ASCII }.Contains(value))
                {
                    myTextEncoding = value;
                }
            }
        }
    }
}