using System.ComponentModel.DataAnnotations.Schema;

namespace YouTubeTutorial.Data.context
{
    public class Users
    {
        public int id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Password { get; set; }
        [NotMapped]
        public string? Search { get; set; }
        [NotMapped]
        public string? SortBy { get; set; }
        [NotMapped]
        public string? SortOrder { get; set; }
        [NotMapped]
        public int PageIndex { get; set; }
        [NotMapped]
        public int PageSize { get; set; }
    }
}