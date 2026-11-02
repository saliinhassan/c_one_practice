## Topics
- 5.1 The while Loop
- 5.2 The ++ and -- Operators
- 5.3 The for Loop
- 5.4 The do-while Loop
- 5.5 Using Files for Data Storage
- 5.6 The OpenFileDialog and SaveFileDialog Controls
- 5.7 Random Numbers
- 5.8 The Load Event
## The while Loop
The while loop causes a statement or set of statements to repeat as long as a Boolean expression is true.
The simple logic is: While a Boolean expression is true, do some task.

## A while loop has two parts:
- A Boolean expression that is tested for a true or false value.
- A statement or set of statements that is repeated as long as the Boolean expression is true.

## Structure of a while Loop
The first line is called the while clause.

Statements inside the curly braces are the body of the loop.
When a while loop executes, the Boolean expression is tested. If true, the statements are executed.
Each time the loop executes its statement or statements, we say the loop is iterating, or performing an iteration.
Counter variables — variables used to track how many times a loop runs.
The while Loop is a Pretest Loop
A while loop is a pretest loop, which means it tests its condition before performing an iteration.
This usually means steps must be taken prior to the loop to ensure it executes at least once.
If a while loop's condition is false to start with, the loop will not iterate.
Infinite Loops
An infinite loop is a loop that will repeat until the program is interrupted.
There are few conditions that cause a while loop to be an infinite loop. A typical scenario is that the programmer forgets to write code that makes the test condition false.

## The Increment and Decrement Operators
To increment a variable means to increase its value and to decrement a variable means to decrease its value.
C# provides the ++ and -- operators to increment and decrement variables.
Postfix Mode versus Prefix Mode
Postfix mode means to place the operators after their operands.
Prefix mode means to place the operators before their operands.
- Postfix: use old value, then change it.
- Prefix: change value first, then use it.

## The for Loop
The for loop is specially designed for situations requiring a counter variable to control the number of times that a loop iterates.
You must specify three actions:
- Initialization: A one-time expression that defines the initial value of the counter.
- Test: A Boolean expression to be tested. If true, the loop iterates.
- Update: Increase or decrease the value of the counter.
The for loop is a pretest loop.
Other Forms of Update Expression
In the update expression, the counter variable is typically incremented by 1. But this is not a requirement.

You can decrement the counter variable to make it count backward.
## The do-while Loop
The do-while loop is a posttest loop, which means it performs an iteration before testing its Boolean expression.

In the flowchart, one or more statements are executed before a Boolean expression is tested.
## Using Files for Data Storage
When a program needs to save data for later use, it writes the data in a file.

There are always three steps:
1. Open the file: Create a connection between the file and the program.
2. Process the file: Either write to or read from the file.
3. Close the file: Disconnect the file and the program.
In general, there are two types of files:
- Text file: Contains data that has been encoded as text using a scheme such as Unicode.
- Binary file: Contains data that has not been converted to text. You cannot view the contents of binary files with a text editor.
This chapter only works with text files.
File Accessing
A file object is an object that is associated with a specific file and provides a way for the program to work with that file.

.NET provides two classes to work with file objects:
- StreamWriter: For writing data to a text file.
- StreamReader: For reading data from a text file.
Writing Data to a File
- Start with creating a StreamWriter object.
- Use one of the File methods to open the file to which you will be writing data.
- Use the Write or WriteLine method to write items of data to the file.
- Close the connection.
Sample File methods:
- File.CreateText
- File.AppendText
CreateText versus AppendText
The File.CreateText method:
- Creates a text file with the name specified by the argument. If the file already exists, its contents are erased.
- Creates a StreamWriter object in memory, associated with the file.
- Returns a reference to the StreamWriter object.
When there is a need not to erase the contents of an existing file, use the AppendText method.
Specifying the Location of an Output File
If you want to open a file in a different location, you can specify a path as well as filename in the argument.

Be sure to prefix the string with the @ character.
Reading Data from a File
- Start with creating a StreamReader object.
- Use the File.OpenText method to open the file.
- Use the Read or ReadLine method to read items of data from the file.
- Close the connection.
StreamReader.ReadLine: Reads a line of characters from the current stream and returns the data as a string.

StreamReader.Read: Reads the next character or next set of characters from the input stream.

StreamReader.ReadToEnd

File.ReadAllText
Reading a File with a Loop
StreamReader objects have a Boolean property named EndOfStream that signals whether or not the end of file has been reached.

You can write a loop to detect the end of the file.
## The OpenFileDialog and SaveFileDialog Controls
The OpenFileDialog and SaveDialog controls allow your application to display standard Windows dialog boxes for opening and saving files.

Unlike Label, Button, and TextBox, they are invisible controls.
- The OpenFileDialog control displays a standard Windows Open dialog box.
- The SaveDialog control displays a standard Windows Save As dialog box.
Displaying an Open Box
When adding an OpenFileDialog control to the form, it does not appear on the form but in an area at the bottom of the Designer called the component tray.

In code, you can display an Open dialog box by calling the ShowDialog method.
Detecting the User’s Selection
The ShowDialog method returns a DialogResult value that indicates which button the user clicks to dismiss the dialog box.
- If the user clicked the Open button, the value DialogResult.OK is returned.
- If the user clicked the Cancel button, the value DialogResult.Cancel is returned.
The Filename and InitialDirectory Property
When the user selects a file with the Open dialog box, the file’s path and filename are stored in the control’s Filename property.

You can specify a directory to be initially displayed with the InitialDirectory property.
Displaying a Save As Dialog Box
- Use the following to call the SaveFileDialog control’s ShowDialog method.
- Use the following to detect the user’s choice.
- Use the following to open the selected file.
## Random Numbers
.NET provides the Random class to generate random numbers.

Two commonly used methods to generate random numbers are:
- Next: Randomly create an integer.
- NextDouble: Randomly create a floating-point number from 0.0 to 1.0.
Syntax of the Random.Next Method
Random.Next generates a random number whose value ranges from 0 to 2,147,483,647.

It also allows you to generate a random number whose value ranges from zero to some other positive number.
## The Load Event
When running an application, the application’s form is loaded into memory and an event known as Load takes place.

To create a Load event handler, simply double click the form in the Designer.

Any code you write inside the Load event will execute when the form is launched.