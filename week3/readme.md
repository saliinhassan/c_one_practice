## Chapter Topics

1. Decision structures and the if statement
2. The if-else statement
3. Nested decision structures
4. Logical operators
5. bool variables and flags
6. Comparing strings
7. Preventing data conversion exceptions with the TryParse method
8. Input validation
9. Radio buttons and check boxes
10. The switch statement
11. Introduction to List Boxes

## 4.1 Decision Structures and the if Statement

A **control structure** is a logical design that controls the order in which statements execute.

A **sequence structure** is a set of statements that execute in the order in which they appear.

A **decision structure** executes statements only under certain circumstances. A specific action is performed only if a certain condition exists. A decision structure is also known as a **selection structure**.

A **single-alternative decision structure** provides only one alternative path of execution.

The expression tested by an if statement is a **Boolean expression**, which can be evaluated as either true or false.

### Relational Operators

A **relational operator** determines whether a specific relationship exists between two values.



## 4.2 The if-else Statement

An **if-else statement** executes one block of statements if its Boolean expression is true, or another block if its Boolean expression is false.

It has two parts: an **if clause** and an **else clause**.

## 4.3 Nested Decision Structures

A **nested decision structure** is used to test more than one condition. The word **nested** means “one inside another.” A decision structure can be placed inside another decision structure.

### The if-else-if Statement

The **if-else-if statement** evaluates multiple conditions to make a final decision. It provides a way to test several conditions in sequence, with an else section for the situation in which the preceding conditions are not true.

## 4.4 Logical Operators

The logical AND operator and the logical OR operator allow multiple Boolean expressions to be connected to create a compound expression.

The logical NOT operator reverses the truth of a Boolean expression.


## 4.5 bool Variables and Flags

A **bool variable** can store either true or false. Bool variables are commonly used as **flags**.

A **flag** is a variable that signals when some condition exists in a program.

- **false** indicates that the condition does not exist.
- **true** indicates that the condition exists.

## 4.6 Comparing Strings

Strings can be compared using certain relational operators and methods.

The slides explain that the equality operator can compare two strings, and string variables can also be compared with string literals. The `String.Compare` method can also be used to compare two strings.

## 4.7 Preventing Data Conversion Exceptions with the TryParse Method

Exceptions should be prevented when possible.

The **TryParse methods** can prevent exceptions caused by users entering invalid data. The methods named in the slides are:

- `int.TryParse`
- `double.TryParse`
- `decimal.TryParse`

The general syntax requires an input string and an output target variable. The **out** keyword is required; it specifies that the target variable is an output variable.

## 4.8 Input Validation

**Input validation** is the process of inspecting data entered into a program to make sure it is valid before it is used.

The slides explain that TryParse checks whether the entered data can be parsed, but it does not check the integrity of the data.

Data integrity concerns whether the data is reasonable and trustworthy for the program's purpose. Therefore, data can be successfully parsed and still be outside an acceptable range.

## 4.9 Radio Buttons and Check Boxes

**Radio buttons** allow users to select one choice from several possible choices.

When a radio button is clicked, the program automatically deselects the other radio buttons in the same group. This is known as **mutually exclusive selection**, meaning only one choice can be selected at a time.

**Check boxes** allow users to select multiple options.

### RadioButton Control

.NET provides the **RadioButton control** to create a group of radio buttons.

Common properties include:

- **Text:** holds the text displayed next to the radio button.
- **Checked:** a Boolean property that determines whether the control is selected or deselected.

A decision structure can be used to determine whether a RadioButton is selected. The slides note that it is not necessary to compare the Checked property explicitly with true.

### CheckBox Control

The .NET Framework provides the **CheckBox control** to give the user an option, such as true/false or yes/no.

Common properties include:

- **Text:** holds the text displayed next to the check box.
- **Checked:** a Boolean property that determines whether the control is selected or deselected.

### The CheckedChanged Event

Whenever the Checked property of a radio button or check box changes, a **CheckedChanged event** is raised.

A CheckedChanged event handler can be created to write code that responds to the event. The slides explain that double-clicking the control in the Designer creates an empty CheckedChanged event handler.

## 4.10 The switch Statement

The **switch statement** lets the value of a variable or expression determine which path of execution the program will take.

It is a **multiple-alternative decision structure**.

It can be used as an alternative to an if-else-if statement that tests the same variable or expression for several different values.

The **test expression** is a variable or expression that gives an int, string, or bool value.

Each **case** is an individual subsection containing one or more statements, followed by a break statement.

The **default** section is optional. It is designed for a situation in which the test expression does not match any of the cases.

## 4.11 Introduction to List Boxes

A **ListBox control** displays a list of items and allows the user to select an item from the list.

### Common ListBox Properties

- **Text:** contains the text of the currently selected item in the ListBox.
- **Items:** contains the items of the ListBox.
- **Items.Count:** contains the number of items in the ListBox.
- **SelectedItem:** gets or sets the currently selected item. When the user selects an item, it is stored in this property.
- **SelectedIndex:** gets or sets the zero-based index of the currently selected item.

### Adding Items

The **Items.Add method** allows an item to be added to a ListBox.

### SelectedItem and SelectedIndex

An exception occurs if the SelectedItem property is accessed when no item is selected.

Items in a ListBox have an index starting at zero. The first item has index zero, and the nth item has index n minus one.

The **SelectedIndex** property stores the index of the selected item. If no item is selected, SelectedIndex has a value of minus one.

### Difference Between Text and SelectedItem

The slides compare these properties as follows:

| Feature | Text | SelectedItem |
|---|---|---|
| Type | string | object |
| Use case | Quick access to selected text | Full access to the selected item |
| Flexibility | Less flexible | More flexible; can be cast to an object |
| Null-safe? | Might return an empty string if nothing is selected | Might be null if nothing is selected |
| Best for | Simple cases with text-only lists | Complex or data-bound lists |

The slides also explain that SelectedItem is useful when working with real data objects, such as Student or Book, while Text is useful when only the displayed text is needed.

### Removing Items

The **Items.Remove method** removes a specific item from a ListBox.

The **Items.RemoveAt method** removes an item at a specific index.

The specified index must be valid. It cannot be less than zero, or greater than or equal to the number of items in the ListBox. If the index is invalid, RemoveAt throws an exception.

The **Items.Clear method** erases all items from the ListBox.

---




