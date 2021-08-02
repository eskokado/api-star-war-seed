using System;
using System.ComponentModel.DataAnnotations;

namespace APIStarWar.Models
{
    public abstract class StarWarBase
    {
        [Key]
        public Guid Id { get; set; }
        private DateTime? _created;
        public DateTime? Created
        {
            get { return _created; }
            set { _created = (value == null ? DateTime.UtcNow : value); }
        }
        public DateTime? Edited { get; set; }
        public string Url { get; set; }
    }
}
