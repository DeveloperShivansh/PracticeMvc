using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PracticeMvc.Models
{
    public class SimpleProjectViewModel
    {
        public string Name { get; set; }
        public List<IFormFile> Files { get; set; }
    }
}