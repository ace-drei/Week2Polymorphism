# Week2Polymorphism

Exercise: 
You are required to design and implement a program in C# which stores information about simple shapes. The program will be made up of several classes: 
Vertex class
1.	Implement a Vertex class which stores the x and y coordinates of a vertex (e.g. the endpoint of a line, the origin of a circle) in 2-dimensional space. 
2.	Implement a constructor for Vertex which accepts the x and y coordinate (both are integers). 
3.	Implement appropriate properties for the class.
4.	Test the Vertex class. 
Shape class
1.	Implement a Shape class which stores the color (e.g. red, blue etc.) of a Shape. 
2.	Implement a constructor to set the color for the shape. 
3.	Implement appropriate properties for the class.
4.	Implement 2 methods in Shape, one to return details of the Shape (ToString() ) and one to allow a shape to be translated in 2D space (Translate(..)). The amount to be translated should be passed as a parameter to the translate method (as a reference to a Vertex object i.e. the amount the object is to be translated with respect to the X and Y axes). 
5.	Test the Shape class. 
Line class
1.	Implement a Line class as a subclass of Shape. A line is to represented by 2 vertices (the endpoints for the line). Implement a constructor for Line which take 5 parameters indicating the x and y coordinates of each vertex and the color of the line. 
2.	Implement appropriate properties for the class.
3.	Override the ToString() method to display information about the line. 
4.	Override the Translate() method to translate the line in 2D space. 
5.	Test the class. 
Circle class
1.	Implement a Circle class as a subclass of Shape. A circle is to represented by an origin vertex and a radius. Implement a constructor for Circle which take 4 parameters indicating the x and y coordinates of the origin, the radius, and the color of the circle. 
2.	Implement appropriate properties for the class.
3.	Override the ToString() method to display information about the circle. 
4.	 Override the Translate() method to translate the Circle in 2D space. 
5.	Define a method Area() which calculates and returns the area of the circle. 
6.	Test the class. 
Test class
1.	Implement a test class which will be used to test the above classes. 
2.	Create and populate a polymorphic collection of lines and circles. Call the ToString() polymorphic method for each shape in the collection. Translate each shapes by a vector amount and call ToString() again. 
