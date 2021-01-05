using System.ComponentModel.DataAnnotations;

namespace SemestriProject.Facade.Common
{
    public abstract class UniqueEntityView : PeriodView
    {
        [Required]
        public string Id { get; set; }
    }
}