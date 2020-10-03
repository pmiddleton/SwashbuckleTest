using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace SwashbuckleTest.Model
{
 
   // [SwaggerDiscriminator("shapeType")]
   // [SwaggerSubType(typeof(Rectangle), DiscriminatorValue = "rectangle")]
   // [SwaggerSubType(typeof(Circle), DiscriminatorValue = "circle")]
      [SwaggerSubTypes(typeof(Rectangle), typeof(Circle), Discriminator = "discriminator")]
    public abstract class Shape 
    {
        public int Sides { get; set; }
    }

    public class Rectangle : Shape
    {
        public int Area { get; set; }
    }

    public class Circle : Shape
    {
        public int Radius { get; set; }
    }
}
