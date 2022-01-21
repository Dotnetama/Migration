using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Single.Data
{
    /// <summary>
    /// 블로그 글을 관리하는 DB Table
    /// </summary>
    public class BlogMaster
    {
        /// <summary>
        /// 블로그아이디 Column
        /// </summary>
        [Key, StringLength(50), Column(TypeName = "varchar(50)")]
        public string BlogId { get; set; }

        [Key, StringLength(50), Column(TypeName = "varchar(50)")]
        public string PostId { get; set; }

        [Required, StringLength(1000), Column(TypeName = "nvarchar(1000)")]
        public string Title { get; set; }

        [Required, StringLength(4000), Column(TypeName = "nvarchar(4000)")]
        public string Content { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime ModifiedDate { get; set; } = DateTime.UtcNow;
    }
}
