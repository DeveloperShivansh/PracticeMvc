using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PracticeMvc.Models
{
    public class SimpleProject
    {
        public string Name { get; set; }
        public List<string> Files { get; set; }
    }
}
