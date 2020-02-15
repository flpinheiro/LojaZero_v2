using System;
using System.Linq;
using System.Text;

namespace LojaZero.CrossCutting.Extensions
{
    public static class ExtensionClass
    {
        /// <summary>
        /// Recebe uma string e retorna apenas os número da string, sem letras ou caracteres especiais ou espaços. 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string OnlyNumbers(this string str)
        {
            if (string.IsNullOrEmpty(str)) return string.Empty;
            str = str.Trim();
            var sb = new StringBuilder();
            foreach (var c in str.Where(c => c >= '0' && c <= '9'))
                sb.Append(c);
            return sb.ToString();
        }

        public static string ToCpfFormat(this string cpf)
        {
            try
            {
                return Convert.ToUInt64(cpf.OnlyNumbers()).ToString(@"000\.000\.000\-00");
            }
            catch (Exception)
            {
                return cpf;
            }
        }
        public static string ToCnpjFormat(this string cnpj)
        {
            try
            {
                return Convert.ToUInt64(cnpj.OnlyNumbers()).ToString(@"00.000.000/0000-00");
            }
            catch (Exception)
            {
                return cnpj;
            }
        }
        public static string ToCepFormat(this string cep)
        {
            try
            {
                return Convert.ToUInt64(cep.OnlyNumbers()).ToString(@"00.000-000");
            }
            catch (Exception)
            {
                return cep;
            }
        }

    }
}