// See https://aka.ms/new-console-template for more information
using Shape;

Rectangle rectangle = new Rectangle(10, 5);
Circle circle = new Circle(100);
Square square = new Square(5);
_2DShape rct = new Rectangle();
ShapeList shapeList = new ShapeList();
shapeList.Add(square); shapeList.Add(rct);
shapeList.Add(circle);
shapeList.Add(rectangle);
shapeList.GetShapeAtIndex(3);
shapeList.GetShapeAtIndex(4);
Thread.Sleep(1000);
shapeList.RemoveShapeAtIndex(0);
shapeList.RemoveShapeAtIndex(3);
int[] arr = {1,2,3,4};
