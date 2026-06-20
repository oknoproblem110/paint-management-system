
using System.Collections.Generic;
using Week1_Homework_Oliver.Enums;
using Week1_Homework_Oliver.Model;


PaintSpecification spec1 = new PaintSpecification("red", 5);
Brand brand1 = new Brand("Aus1");
PaintProduct paintProduct1 = new PaintProduct(100, "pp1", PaintType.BaseCoat, spec1, 29.99m, brand1);

PaintSpecification spec2 = new PaintSpecification("green", 60);
Brand brand2 = new Brand("Aus2");
PaintProduct paintProduct2 = new PaintProduct(200,"pp2", PaintType.Glossy, spec2, 99.99m, brand2);

PaintSpecification spec3 = new PaintSpecification("Dark Blue", 20);
Brand brand3 = new Brand("Aus3");
PaintProduct paintProduct3 = new PaintProduct(300, "pp3", PaintType.Matte, spec3, 59.99m, brand3);


paintProduct1.DisplayInfo();
paintProduct2.DisplayInfo();
paintProduct3.DisplayInfo();



Order order1 = new Order(paintProduct1, 5);
Order order2 = new Order(paintProduct2, 8);
Order order3 = new Order(paintProduct3, 7);

Order order4 = new Order(new List<PaintProduct>{paintProduct1, paintProduct2, paintProduct3});
Order order5 = new Order(new List<PaintProduct> { paintProduct2, paintProduct3 });
Order order6 = new Order(new List<PaintProduct> { paintProduct1, paintProduct3 });



order1.DisplayOrder();
order2.DisplayOrder();
order3.DisplayOrder();
order4.DisplayOrder();
order5.DisplayOrder();
order6.DisplayOrder();

