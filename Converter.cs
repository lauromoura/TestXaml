using System;
using OmniXaml;
using Tizen.NUI.Binding;

namespace Nui.Vsix.Xaml
{
    public class Converter : IStringSourceValueConverter
    {
        private readonly TypeConverter converter;

        public Converter(TypeConverter conv)
        {
            converter = conv;
        }

        public (bool, object) Convert(string value, Type desiredTargetType, ConvertContext context = null)
        {
            if (!converter.CanConvertFrom(typeof(string)))
            {
                return (false, null);
            }

            try
            {
                return (true, converter.ConvertFromInvariantString(value));
            }
            catch (Exception)
            {
                return (false, null);
            }
        }
    }
}