
using Week1_Homework_Oliver.Enums;
using Week1_Homework_Oliver.Model;


PaintSpecification spec1 = new PaintSpecification("red", 5);
PaintProduct paintProduct1 = new PaintProduct("pp1", PaintType.BaseCoat, spec1, 29.99m);

PaintSpecification spec2 = new PaintSpecification("green", 60);
PaintProduct paintProduct2 = new PaintProduct("pp2", PaintType.Glossy, spec2, 99.99m);

PaintSpecification spec3 = new PaintSpecification("Dark Blue", 20);
PaintProduct paintProduct3 = new PaintProduct("pp3", PaintType.Matte, spec3, 59.99m);


paintProduct1.DisplayInfo();
paintProduct2.DisplayInfo();
paintProduct3.DisplayInfo();


Order order1 = new Order(paintProduct1, 5);
Order order2 = new Order(paintProduct2, 8);
Order order3 = new Order(paintProduct3, 7);

order1.DisplayOrder();
order2.DisplayOrder();
order3.DisplayOrder();