using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Media.Imaging;

namespace TCC_Hidracom
{
    /// <summary>
    /// Uma classe que guarda métodos que são usados como extensão
    /// </summary>
    public static class ExtensionsMethods
    {
        /// <summary>
        /// Verifica se o valor é um DBNULL
        /// </summary>
        /// <param name="data">Valor que irá ser verificado</param>
        /// <returns></returns>
        public static bool IsNotDBNull<T>(this object data, out T value)
        {
            if (Convert.IsDBNull(data))
            {
                value = default(T);
                return false;
            }

            value = (T)Convert.ChangeType(data, typeof(T));
            return true;

        }

        /// <summary>
        /// Converte Int para Bool
        /// </summary>
        /// <param name="value">Valor a ser convertido</param>
        /// <returns></returns>
        public static bool ToBoolean(this int value)
        {
            return Convert.ToBoolean(value);
        }

        /// <summary>
        /// Converte uma <see cref="BitmapImage"/> para bytes[]
        /// </summary>
        /// <param name="imageSource">Image que irá ser convertida</param>
        /// <returns></returns>
        public static byte[] ImageToByte(this BitmapImage imageSource)
        {
            var stream = imageSource.StreamSource;
            byte[] imagebyte = null;
            if (stream != null && stream.Length > 0)
            {
                using (var br = new BinaryReader(stream))
                {
                    imagebyte = br.ReadBytes((int)stream.Length);
                }
            }

            return imagebyte;
        }

        /// <summary>
        /// Converte byte[] para <see cref="BitmapImage"/>
        /// </summary>
        /// <param name="bytes">Bytes da imagem</param>
        /// <returns></returns>
        public static BitmapImage ImageFromBuffer(this byte[] bytes)
        {
            var stream = new MemoryStream(bytes);
            var image = new BitmapImage();
            image.BeginInit();
            image.StreamSource = stream;
            image.EndInit();
            return image;
        }

        /// <summary>
        /// Retorna a data em formato para ser inserida no banco de dados
        /// </summary>
        /// <returns></returns>
        public static string GetDateTimeDBString(this DateTime data)
        {
            return new StringBuilder().AppendFormat("{0}-{1}-{2} {3}", data.ToShortDateString().Split('/')[2], data.ToShortDateString().Split('/')[1], data.ToShortDateString().Split('/')[0], data.Hour + ":" + data.Minute).ToString();
        }

        /// <summary>
        /// Retorna o valor formatado do double sem ','
        /// </summary>
        /// <param name="value">Valor a ser formatado</param>
        /// <returns></returns>
        public static string GetDoubleDBString(this double value)
        {
            return value.ToString("###0.00", CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Retorna o valor se ele for do tipo especifico
        /// </summary>
        /// <typeparam name="T">Tipo genérico</typeparam>
        /// <param name="value">Valor a ser testado</param>
        /// <param name="value2">Valor a ser retornado</param>
        /// <returns></returns>
        public static bool GetValueIfIs<T>(this object value, out T value2)
        {
            if(value is T)
            {
                value2 = (T)value;
                return true;
            }

            value2 = default(T);
            return false;
        }
    }
}
