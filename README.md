# Mini_Challenges1
---
## Document
Description: Save a text document to disk based on a name and content provided by the user.

Purpose: This application provides experience with user input and interaction in the Console, writing files to disk, working with exceptions, and writing programs in C#/.NET.

Requirements:

Project Name: Document
Target Platform: Console
Programming Language: C#

This project is to be managed in a public GitHub repository. For this mini-challenge assignment, submit the Clone with HTTPS URL for the repository that contains it. If this mini-challenge is part of a collection of mini-challenges to be completed for an assignment, place them in one repo.

Documentation:

Types and variables (Microsoft)
Console.ReadLine Method () (Microsoft)
Strings (C# Programming Guide) (Microsoft)
How to read from and write to a text file by using Visual C# (Microsoft)
StreamWriter Class (Microsoft)
Exceptions and Exception Handling (C# Programming Guide) (Microsoft)
This program is to display the name of the app "Document" followed by a blank line, prompt the user for the name and content for a document, save the document to the current directory, and display a message if it was successful or unsuccessful based on a specification provided. The filename of the document is the name provided by the user with ".txt" appended to it.

When the program runs:

Display "Document" followed by a blank line.
Prompt the user for the name of the document.
Prompt the user for the content that is to be in the document.
Append .txt to the name and use it as the file name.
Save the content to a file in the current directory.
If an exception occurs, output the exception message and exit.
If an exception does not occur, output "[filename] was successfully saved. The document contains [count] characters." and exit. [filename] and [count] are placeholders for the filename of the document and the number of characters it contains.
Note that the requirements say the file is to be saved in the current directory. This means you can use just the file name as the path for the file. If you do that, the file will be saved in the current directory for the application. When I created the project and called it Document, a directory called Document was created that contains Document.sln and another directory called Document. The Document directory inside of the project is the current directory when the application runs and is where you will find the files that are saved.

Optional Requirements:

The following requirements are not required, but you should try to implement them if you can.

If the name provided by the user already ends in ".txt", do not append ".txt" to the name to create the filename. If it already has ".txt" on the end, use it as-is.

Close the stream that is opened in the finally block of a try-catch-finally. Caution: test the variable holding the reference to the stream to make sure it is not null before calling the Close method on it. Calling a method on a null reference will crash the application.

After the document is saved or fails to save, prompt the user if they want to save another document. If they do, prompt them again for input. If not, exit the program.

---
## Dogs
Description: Create a Dog class that contains specified properties and methods. Create an instance of Dog and use its methods.

Purpose: This application provides experience with creating classes and instances of objects in C#.

Requirements:

Project Name: Dog
Target Platform: Console
Programming Language: C#

This project is to be managed in a public GitHub repository. For this mini-challenge assignment, submit the Clone with HTTPS URL for the repository that contains it. If this mini-challenge is part of a collection of mini-challenges to be completed for an assignment, place them in one repo.

Documentation:

Types and variables (Microsoft)
Classes and objects (Microsoft)
Enums (Microsoft)
Create a class called Dog.

Dog is to have the following public properties:

name (of type string)
owner (of type string)
age (of type int)
gender (of type Gender)
Gender is a enum type you need to create that contains Male and Female.

Create a constructor in the class to initialize all of the properties when creating an instance.

Create a method (function in the class) called bark that takes one parameter that is the number of times to bark and prints "Woof!" that many times to the Console.

Create a method called getTag that takes no parameters and returns a string. The method returns "If lost, call [owner]. ['Her'|'His'] name is [name] and ['she'|'he'] is [age]  ['year'|'years'] old."

[owner] means replace with the name of the owner.

['Her'|'His'] means choose to display "Her" or "His" based on the gender of the Dog.

[name] means replace with the name of the Dog.

['she'|'he'] means choose to display "she" or "he" based on the gender of the Dog.

['year'|'years'] means to choose to display "year" or "years" depending on the age of the Dog. If age is 1, use "year". If any other age, use "years".

In the Main function of the application, test that instances of Dog can be created and that the methods work. In the following, "Orion" is the name of the Dog, "Shawn" is the name of the owner, 1 is the age, and Gender.Male is the gender.

Dog puppy = Dog("Orion", "Shawn", 1, Gender.Male);  // create object instance
puppy.bark(3); // output: Woof!Woof!Woof!
Console.WriteLine(puppy.getTag()); // output: If lost, call Shawn. His name is Orion and he is 1 year old.

Dog myDog = Dog("Lileu", "Dale", 4, Gender.Female);  // create object instance
myDog.bark(1); // output: Woof!
Console.WriteLine(myDog.getTag()); // output: If lost, call Dale. Her name is Lileu and she is 4 years old.
