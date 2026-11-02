
## 1. IF Statement

An `if` statement is a decision structure that allows a program to make a decision based on a condition.

- First, the program evaluates the condition.
- If the condition is `true`, the statements inside the `if` section are executed.
- If the condition is `false`, the `if` section is skipped and the program continues with the statements that follow.

In this section, the sales amount is compared with a specified threshold. If sales are above that threshold, a bonus is awarded. If sales do not exceed the threshold, that bonus is not awarded.


## 2. IF-ELSE Statement

An `if-else` statement is a decision structure with two different paths.

- If the `if` condition is `true`, the `if` section runs.
- If the condition is `false`, the `else` section runs.
- Both sections do not run at the same time; only one is selected based on the condition's result.

In this section, the program determines whether a person has reached adulthood. The result will be one of the two possible outcomes.


## 3. NESTED IF

A nested IF is a decision structure placed inside another decision structure. It is used when a second decision depends on the first condition being satisfied.

1. The outer condition is checked first.
2. If the outer condition is true, the inner condition is checked.
3. If the outer condition is false, the inner section is not reached.
4. The final result depends on both conditions.

In this section, the program first checks whether the salary meets the loan requirement. If it does, the program then checks how long the person has been employed. Both conditions are important for loan eligibility.


## 4. IF – ELSE IF – ELSE

This structure is used when a decision involves several different possible situations.

- Conditions are checked in order, from top to bottom.
- When a condition is true, its associated section is executed.
- The remaining conditions are not checked after a true condition is found.
- If all `if` and `else if` conditions are false, the `else` section runs.

In this section, student grade levels are determined based on the student's score. The result depends on the first condition that is satisfied.



## 5. LOGICAL OPERATORS: AND, OR, NOT

Logical operators are used to combine or reverse the results of Boolean conditions.

### AND (`&&`)

AND is `true` only when both conditions are true. If either condition is false, the overall result is `false`.

### OR (`||`)

OR is `true` when at least one condition is true. The result is `false` only when both conditions are false.

### NOT (`!`)

NOT reverses the result of a condition:
- `true` becomes `false`.
- `false` becomes `true`.

In this section, the three operators are used to check temperature and time conditions. Each operator evaluates conditions in its own way.



## 6. BOOL VARIABLE AND FLAG

`bool` is a data type that can hold only two values: `true` or `false`.

A flag is a variable used to indicate whether a particular condition or state exists. A program can read the current state from the flag and then decide what action to take next.

In this section, a Boolean variable represents the user's login status:
- If the login status is true, the program displays a welcome message.
- If it is not true, the program indicates that the user needs to log in.


## 7. COMPARING STRINGS

A string is text data. Sometimes a program needs to determine whether two pieces of text are the same or different.

The comparison methods covered in this section are:

- Equality comparison checks whether two strings are the same.
- Inequality comparison checks whether two strings are different.
- `String.Compare` compares two strings; a result of zero indicates that the strings are equal.

In this section, two names are compared with each other, and a name is also compared with another fixed text value.

## 8. TRYPARSE

`TryParse` is a method used to test whether text can be converted into a numeric data type. It allows a program to handle invalid input without relying on a conversion exception.

