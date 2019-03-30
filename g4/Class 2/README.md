# Exercise
Create a user class that has:
* Username
* Role - Guest, Moderator, Poster
* Comments - list of strings 
* PostComment ( method ) - accepts a comment and adds it to the Comments list
* PrintUser ( abstract method ) - prints all details of a user

 Note : You can't create a user object

 
Create a class Poster that has:
* Points 
* IsPosterOfTheWeek
* CheckStats ( method ) - prints a message how many points and comments this user has
* Has default Role of Poster


Create a Guest class that has:
* Id 
* ReadComment ( method ) - accepts string and writes in the console: The Guest with Id: Id read this comment: Comment
* If guest tries to post, it should show a message: Guests cannot post
* Has default Role of Guest

Create Moderator class that has:
* Users - list of users
* BanUser ( Method ) - accepts a user and a string REASON and writes in the console: The user Username is banned for REASON
* Has default Role of Moderator

