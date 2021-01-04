██████╗ ██████╗     ███████╗██╗  ██╗ █████╗ ██████╗ ███████╗███████╗    ██╗███╗   ██╗ ██████╗
╚════██╗██╔══██╗    ██╔════╝██║  ██║██╔══██╗██╔══██╗██╔════╝██╔════╝    ██║████╗  ██║██╔════╝
 █████╔╝██║  ██║    ███████╗███████║███████║██████╔╝█████╗  ███████╗    ██║██╔██╗ ██║██║     
 ╚═══██╗██║  ██║    ╚════██║██╔══██║██╔══██║██╔═══╝ ██╔══╝  ╚════██║    ██║██║╚██╗██║██║     
██████╔╝██████╔╝    ███████║██║  ██║██║  ██║██║     ███████╗███████║    ██║██║ ╚████║╚██████╗
╚═════╝ ╚═════╝     ╚══════╝╚═╝  ╚═╝╚═╝  ╚═╝╚═╝     ╚══════╝╚══════╝    ╚═╝╚═╝  ╚═══╝ ╚═════╝

DESCRIPTION
*********************************************************************************************
You have been hired by the 3D printing company 3D Shapes Inc. to write a program to determine
the costs of printing various 3D shapes (cubes, spheres, and pyramids).


INPUT SPECIFICATION
*********************************************************************************************
The file "input.txt" contains data pertaining to the shapes. The first line is the cost per
cubic centimetre of plastic.  Each subsequent line contains information on each shape to be
printed.

For cubes, the side length is specified.
For spheres, the radius is specified.
For pyramids, the side length of the base and the height are specified.


OUTPUT SPECIFICATION
*********************************************************************************************
Output a file named "output.txt", which exactly matches the "sample-output.txt" file. The
dollar amounts are pre-tax amounts.


FORMULAS
*********************************************************************************************
Refer to the following formulas...

Volume of a cube		V = s^3					s = side length
Volume of a sphere		V = 4/3 * pi * r^3		r = radius
Volume of a pyramid		V = s^2 * h / 3		    s = side length of base, h = height


PERMITTED .NET CLASSES
*********************************************************************************************
System.IO.StreamReader
System.IO.StreamWriter      