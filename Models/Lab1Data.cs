using System;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
namespace Lab1.Models
{
    public class Lab1Data
    {public Guid Id { get; set; } = Guid.Empty;
     public string Cake { get; set; }
       public int Cost_price { get; set; } 
       public int Price { get; set; }

        public string Cook { get; set; }
    public BaseModelValidationResult Validate()
        {
            var validationResult = new BaseModelValidationResult();
// Метод  IsNullOrWhiteSpace -true,  если строка - null
            if (string.IsNullOrWhiteSpace(Cake)) validationResult.Append($"Cake cannot be empty");
            if (string.IsNullOrWhiteSpace(Cook)) validationResult.Append($"Cook cannot be empty");
            if ((0 > Price )) validationResult.Append($"Price {Price} is more than 0");
          

            if (!string.IsNullOrEmpty(Cake) && !char.IsUpper(Cake.FirstOrDefault())) validationResult.Append($"Name {Cake} should start from capital letter");
            if (!string.IsNullOrEmpty(Cook) && !char.IsUpper(Cook.FirstOrDefault())) validationResult.Append($"Surname {Cook} should start from capital letter");

            return validationResult;
        }

        public override string ToString()
        {
            return $"{Cook} {Cake} from  {Price}";
        }
    }}

  