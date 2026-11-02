## C# CHAPTER 4 
## WHILE LOOP

 Initializes an integer variable called count with the value 5
 Checks whether the count is less than 5
 If the condition is true, it displays a message box containing "Hello"
 Increases the count by 1 after each iteration.
 The loop does not execute because the initial value is already 5


## FOR LOOP

 Starts the counter at 0
 Checks whether the counter is less than 5
 Increases the counter by 1 after each iteration
 Displays "Hello" every time the loop executes
 Stops when the counter reaches 5


## CREATING A TEXT FILE – File.CreateText

 Creates a StreamWriter object to write data into a file
 Creates a text file named courses.txt
 Writes three course names into the file
 Each course name is written on a separate line
 Closes the file after writing


 ## APPENDTEXT – USING FILE PATH

 Creates a StreamWriter object
 Opens the file named Names.txt inside the Data folder
 Uses the full file path to identify the file location
 Adds the name "Ahmed" to the file.
 Closes the file after writing


## APPENDTEXT – ADDING MORE NAMES

 Creates a StreamWriter object.
 Opens the existing file named Names.txt
 Adds three names: Lynn, Jamal, and Alex
 Each name is written on a separate line
 Closes the file after writing


## SAVEFILEDIALOG – SAVING A FILE

 Displays the Save As dialog box.
 Allows the user to choose where to save the file
 Checks whether the user clicks the Save button
 Creates a new file in the selected location
 Writes "Welcome to C#" into the file
 Closes the file after saving


## READING DATA FROM A FILE – StreamReader

 Creates a StreamReader object to read data from a file
 Opens the file named students.txt
 Reads the first line from the file
 Stores the read information in a string variable
 Displays the information using a message box
Closes the file after reading
