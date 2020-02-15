using LojaZero.CrossCutting.Extensions;

namespace LojaZero.CrossCutting.Util.Validator
{
    public static class ValidateCpf
    {
        public static bool IsCpf(this string cpf)
        {
            cpf = cpf.OnlyNumbers();
            if (cpf.Length != 11)
                return false;
            var multiplier1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            var multiplier2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            var temp = cpf.Substring(0, 9);
            var soma = 0;

            for (var i = 0; i < 9; i++)
                soma += int.Parse(temp[i].ToString()) * multiplier1[i];
            var resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            var digit = resto.ToString();
            temp += digit;
            soma = 0;
            for (var i = 0; i < 10; i++)
                soma += int.Parse(temp[i].ToString()) * multiplier2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digit += resto.ToString();
            return cpf.EndsWith(digit);
        }

    }
}
