Programming Assessment (C#)

Guidelines

The goal of this assessment is to validate your ability to create a high quality, production ready application that meets the stated requirements. Please consider programming best practices as you design your solution, including good Object Oriented principles and proper coding grammar.

You will be graded not only on whether your application produces the correct output, but also to what degree your solution is extensible and maintainable.

1. It is expected that the completed project can be copied to a development machine with Visual Studio installed and compiled/run without modification.

2. If additional steps are required to compile and run the solution, instructions must be provided. A console application is sufficient.

3. No user input should be required to produce the transaction output.

Problem Statement

Basic sales tax is applicable at a rate of 10% on all goods, except books, food, and medical products that are exempt. Import duty is an additional sales tax applicable on all imported goods at a rate of 5%, with no exemptions. When I purchase items I receive a receipt which lists the name of all the items and their price (including tax), finishing with the total cost of the items, and the total amounts of sales taxes paid. The rounding rules for sales tax are that for a tax rate of n%, a shelf price of p contains (np/100 rounded up to the nearest 0.05) amount of sales tax. Write an application that prints out the receipt details for these shopping baskets.

Input

Shopping Basket 1:

1 book at 12.49

1 music CD at 14.99

1 chocolate bar at 0.85

Shopping Basket 2:

1 imported box of chocolates at 10.00

1 imported bottle of perfume at 47.50

Shopping Basket 3:

1 imported bottle of perfume at 27.99

1 bottle of perfume at 18.99

1 packet of headache pills at 9.75

1 imported box of chocolates at 11.25

Output

Output 1:

1 book: 12.49

1 music CD: 16.49

1 chocolate bar: 0.85

Sales Taxes: 1.50

Total: 29.83

Output 2:

1 imported box of chocolates: 10.50

1 imported bottle of perfume: 54.65

Sales Taxes: 7.65

Total: 65.15

Output 3:

1 imported bottle of perfume: 32.19

1 bottle of perfume: 20.89

1 packet of headache pills: 9.75

1 imported box of chocolates: 11.85

Sales Taxes: 6.70

Total: 74.68
