# Local Variable Practice

This program demonstrates how to use a local variable in C#.

## Description
The program creates a string variable called `Name`.
It gets the user's name from a TextBox and stores it in the variable.

## Code Explanation
- `string Name;` creates a string variable.
- `Name = txtname.Text;` gets the text from the TextBox.
- The value entered by the user is stored in `Name`.

## Topic
- Local Variables
- String
- TextBox


## Topic
- Integer
- int.Parse()
- Type Conversion
- MessageBox

# Int.Parse Practice

This program demonstrates how to convert text into an integer using `int.Parse()` in C#.

## Description
The program gets the number of hours worked from a TextBox.
It converts the text into an integer and displays the result.

## Code Explanation
- `int hoursWorked;` creates an integer variable.
- `int.Parse(txttext1.Text)` converts the TextBox text into an integer.
- `MessageBox.Show(hoursWorked.ToString());` displays the value.


# String Concatenation Practice

This program demonstrates how to combine two strings in C#.

## Description
The program gets a first name and last name from two TextBoxes.
It combines them to create a full name and displays it in a Label.

## Code Explanation
- `firstName` stores the first name.
- `lastName` stores the last name.
- `fullName` combines the first name and last name.
- `label1.Text = fullName;` displays the full name.

## Topic
- String Variables
- TextBox
- String Concatenation
- Label
