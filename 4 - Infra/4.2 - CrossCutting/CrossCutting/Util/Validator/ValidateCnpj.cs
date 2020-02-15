using LojaZero.CrossCutting.Extensions;

namespace LojaZero.CrossCutting.Util.Validator
{
    public static class ValidateCnpj
    {
        public static bool IsCnpj(this string cnpj)
        {
            cnpj = cnpj.OnlyNumbers();
            if (cnpj.Length != 14)
                return false;
            var multiplier1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            var multiplier2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            var tempCnpj = cnpj.Substring(0, 12);
            var soma = 0;
            for (var i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplier1[i];
            var resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            var digit = resto.ToString();
            tempCnpj += digit;
            soma = 0;
            for (var i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplier2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digit += resto.ToString();
            return cnpj.EndsWith(digit);
        }
    }
}