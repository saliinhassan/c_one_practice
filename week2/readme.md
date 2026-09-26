## TOPICS
3.1 Reading Input with TextBox Controls
3.2 A First Look at Variables
3.3 Numeric Data Type and Variables
3.4 Performing Calculations
3.5 Inputting and Outputting Numeric Values
3.6 Formatting Numbers with the ToString Method
3.7 Simple Exception Handling
3.8 Using Named Constants
3.9 Declaring Variables as Fields
3.10 Using the Math Class
3.11 More G U I Details
3.12 Using the Debugger to Locate Logic Errors


## Reading Input with TextBox Control
TextBox control
a rectangular area
can accept keyboard input from the user
located in the Common Control group of the Toolbox
double click to add it to the form
default name is textBoxn

## The Text Property
A TextBox control’s Text property stores the user inputs
Text property accepts only string values, e.g.
textBox1.Text = "Hello";
To clear the content of a TextBox control, assign an empty string("")
textBox1.Text = "";
textBox1.Text = string.Empty;
textBox1.Clear();

## A First Look at Variables
A variable is a storage location in memory
A variable name represents the memory location
you must declare a variable in a program before
using it to store data
The syntax to declare variables is

## Data Types
  A c# variable must be declared with a proper data type
The data type specifies the type of data a variable can hold
in c# many data types are known as primitive data types
they store fundamental types of data (means essential or core
such as strings and integers
“Primitive” means basic / simple / built-in.
In C#, primitive data types are already defined by the language, not created by you.


## Variable Names
A variable name identifies a variable
Always choose a meaningful name for variables
Basic naming conventions are:
the first character must be a letter (upper or lowercase) or an underscore (_)
the name cannot contain spaces

do not use c# keywords or reserved words

## String Variables
A string is a combination of characters 
A variable of the string data type can hold any combination of characters, such as names, phone numbers, and social security numbers
The value of a string variable is assigned on the right of the = operator surrounded by a pair of double quotes
productDescription = "Jamhuuriya University";
The following assigns the productDescription string to a Label control named productLabel:
productLabel = productDescription
## String Concatenation
Concatenation is the appending of one string to the end of another string
Concatenation can happen between a string and another data type
int and string
double and string

## Local Variables and Scope
A local variable belongs to the method in which it was declared
Only statements inside that method can access the variable
Scope describes the part of a program in which a variable may be accessed
Lifetime of a variable is the time period during which the variable exists in memory while the program is executing
A local variable is created in memory when the method in which it is declared starts executing. When the method ends, all the method’s local variables are destroyed.

## Duplicate Variable Names
You cannot declare two variables with the same name in the same scope. 
For example, if you declare a variable named productDescription in an event handler, you cannot declare another variable with that name in the same event handler. 
You can, however, have variables of the same name declared in different methods

## Declaring Multiple Variables with One Statement
You can declare multiple variables of the same data type with one declaration statement. Here is an example:
string lastName, firstName, middleName
Remember, you can break up a long statement, so it spreads across two or more lines. Sometimes you will see long variable declarations written across multiple lines, like this:
string lastName = "Khalaf",
       firstName = "Mohamed",
       middleName = "Abdullahi
## Numeric Data Types and Variables
 If you need to store a number in a variable and use the number in a mathematical operation, the variable must be of a numeric data type
       
double: real numbers including numbers with fractional parts
decimal: real numbers, stored with greater precision than doubles. Typically used in financial applications.
## Numeric Literals
A numeric literal is a number that is written into a program’s code.
Examples of variables initialized with numeric literals:
Numeric literals with a decimal point, such as 87.6, 3.14, and 1.0, are treated as a double.
To create a decimal literal, append the letter M or m to a numeric literal. Example:

## Assignment Compatibility for int Variables
You can assign int values to int variables, but you cannot assign double or decimal values to int variables. For example,
int hoursWorked = 40;    // This works
int unitsSold = 650m;    // ERROR!
int score = −25.5;       // ERROR!

## Explicit Conversion with Cast Operators
 c# allows you to explicitly convert among types, which is
known as type casting
You can use the cast operator which is simply the name of the type enclosed in parentheses
int wholeNumber;
decimal moneyNumber = 4500m;
wholeNumber = (int)moneyNumber

## Integer Division
int x = 7, y = 3;
MessageBox.Show((x / y).ToString());

## Inputting and Outputting Numeric Values
Input collected from the keyboard are considered combinations of characters (or string literals) even if they look like a number to you
A TextBox control reads keyboard input, such as 25.65. However, the TextBox treats it as a string, not a number.
If the user has entered a numeric value into a TextBox control and you want to assign that value to a numeric variable, you have to convert the control’s Text property to the desired numeric data type. Unfortunately, you cannot use a cast operator to convert a string to a numeric type. 


## Displaying Numeric Values
The Text property of a control only accepts string literals
To display a number in a TextBox or Label control requires you to convert a numeric data to string type

decimal grossPay = 1550.0m;
grossPayLabel.Text = grossPay.ToString();
int myNumber = 123;
MessageBox.Show(myNumber.ToString());









