using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_DifferentSkills.ORM
{
    //downloadUrl--https://github.com/ademilter/AMA/archive/master.zip
    [Table("GithubRepository")]
    public class GithubRepository
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(250),Required]
        public string FullName { get; set; }
        [StringLength(25),Required]
        public string CreatedAt { get; set; }
        [StringLength(250)]
        public string DownloadUrl { get; set; }
        public GithubUser User { get; set; }
    }
}
