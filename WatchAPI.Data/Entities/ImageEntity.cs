using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using WatchAPI.Data.Interfaces;

namespace WatchAPI.Data.Entities
{
    public class ImageEntity : IEntity<string>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }     

        public DateTime PublishingTime { get; set; }
    }
}
