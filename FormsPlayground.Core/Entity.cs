using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormsPlayground.Core.Extensions;

namespace FormsPlayground.Core
{
    public class Entity
    {
        public int ID { get; set; }

        public string ListPrimary { get; set; }

        public string ListSecondary { get; set; }

        public string Initials => this.ListPrimary?.GetInitials();

        public string ImageBase64 { get; set; }

        public string ImageName { get; set; }

        public bool HasInitials
        {
            get { return this.ImageName == "EntityDefaultImage.png"; }
        }
    }
}
