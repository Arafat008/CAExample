using CAExample.Domain.Common;

namespace CAExample.Domain.Entities
{
    public class City : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
    }
}
