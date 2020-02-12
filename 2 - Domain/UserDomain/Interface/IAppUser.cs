using System.ComponentModel.DataAnnotations.Schema;

namespace LojaZero.UserDomain.Interface
{
    public interface IAppUser
    {
        [NotMapped]
        bool Wholesale { get; }
    }
}