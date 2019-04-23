# Exercise
1) Create a class called Writer that has:
	* Name
	* Age
	* HasWrittenBook
	* NumberOfBooks
	* CurrentBookText
	* CreateBookText( method ) - A method that accepts any number of strings as parameters and creates one string text. Then it adds that string text in to CurrentBookText and changes the HasWrittenBook property to true and NumberOfBooks to +1
2) Create a custom exception called CheckAge that will be thrown if Age is a negative number and will edit the message with reason as well as writing in the console: Please enter a valid name! ( reason: the number is negative )
3) Create a custom exception called CheckName that will be thrown if Name is shorter than 1 character and will edit the message with reason as well as writing in the console: Please enter a valid name! ( reason: Too little characters )
4) Create a constructor that sets only Name and Age and throw your custom exceptions when they are not correct