# Homework

## Task 1 - Breaking News

### Description
Whenever there are breaking news, mediums like: CNN, A1, Kanal 5... want to send a message to their followers, so that they are informed when something interesting is happening in the world. These follower are really eager to know everything. 
But first the followers need to subscribe to the mediums they want to, to receive that kind of special message. <br />
They made a huge mistake by sending all of their programmers on a vacation, luckily they already started on something(*the code in Program class*). We don't need to start from zero, we only need to figure out what the programmers where up to before they went on a vacation, **so let's help them out!** <br />
Note: Programmers's code is in ***BreakingNews*** folder.

### By looking at the code in Program class, we can see that we need to do the following:
* We need to create classes for *Mediums* and *Followers*
* *Mediums* should be **publishers**, *Followers* should be **subscribers**
* *Mediums* should have a method **SendBreakingNews** which should send breaking news to all of their followers
* *Followers* should have **Subscribe** method which subscribes to some Medium
* *Followers*? should print the breaking news in the Console when some *Medium* sends some to them(we can't guess this last point just by looking at the code in Program, we'll just add it so that we look more cool when the programmers are back!)

## Task 2 - Custom Generic List
* Create a **generic** class for your custom List
* The class should have one **Type** parameter<br /> 
* Properties: <br />
  ***private*** Array: **Type** <br />
  Count: **int** <br />
* Methods: <br />
  Add(**Type** element): void
  Remove(**int** index): **Type**
  GetElementByIndex(**int** index): **Type**

### Bonus:
Use an indexer instead of the method GetElementByIndex