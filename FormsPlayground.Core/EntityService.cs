using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsPlayground.Core
{
    public class EntityService
    {
        private string[] randomFirst = new string[] { "John", "Jim", "Bob", "Greg", "Marcel", "Harrold" };
        private string[] randomLast = new string[] { "Doe", "Lie", "Arinovith", "Durant", "Dupont", "Carrez" };
        private string[] randomCompany = new string[] { "Google", "Microsoft", "Facebook", "Amazon", "Twitter", "Total" };

        public ObservableCollection<Entity> GetSampleEntities()
        {
            var random = new Random();

            var items = new List<Entity>();
            for (int i = 0; i < 1000; i++)
            {
                var entity = new Entity()
                {
                    ID = i,
                    ListPrimary = $"{randomFirst[random.Next(0, 5)]} {randomLast[random.Next(0, 5)]}",
                    ListSecondary = $"{randomCompany[random.Next(0, 5)]}",
                };

                var iRandomImage = random.Next(0, 17);

                entity.ImageName = iRandomImage == 0 ? "EntityDefaultImage.png" : $"img{iRandomImage}";

                items.Add(entity);
            }

            return new ObservableCollection<Entity>(items);
        }
    }
}
