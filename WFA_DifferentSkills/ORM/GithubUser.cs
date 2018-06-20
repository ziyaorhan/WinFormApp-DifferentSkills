using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_DifferentSkills.ORM
{
    [Table("GithubUser")]// veritabanında tablo adı için
   public class GithubUser
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]//id'yi identity yapmak için
        public int Id { get; set; }
        [StringLength(50),Required]
        public string Login { get; set; }
        [StringLength(250)]
        public string AvatarUrl { get; set; }
        [StringLength(250), Required]
        public string HtmlUrl { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(10)]
        public string Followers { get; set; }
        [StringLength(10)]
        public string Following { get; set; }
        public List<GithubRepository> Repository { get; set; }
    }
}
