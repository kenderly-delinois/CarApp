using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace CarApp.Models
{
    public class Car
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)] // will not generate the car ID Number automatically
        public int CarId { get; set; }
        public string CarVin {  get; set; }

        public string CarMake { get; set; }

        public string CarModel { get; set; }
        public int CarYear { get; set; }
        public double CarPrice { get; set; }

        public virtual ObservableCollectionListSource<Car> Cars { get; set; }

    }
}
